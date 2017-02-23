using framework.Login;
using framework.Parser;
using framework.Tests.PageObject;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static framework.Tests.DataProviders;

namespace framework.mustransme
{
    [TestFixture]
    //[Parallelizable]//(ParallelScope.Fixtures)]
    class LoginTests
    {
        [Test]
        public static void NegativeLoginTests()
        {
            LoginPage loginPage = new LoginPage();
            CSVParser par = new CSVParser();
            List<LoginData> list = par.GetLogin();
            foreach (LoginData lg in list)
            {
                loginPage.LoginJournalNegative(lg.Login, lg.Password);
                Assert.AreEqual(lg.Expected, loginPage.FindError());
            }
        }

        [Test, TestCaseSource(typeof(TestCasesProvider), "TestCaseWithJournals")]
        public static void PositiveLoginTests(MenuElement menu, string journalName)
        {
            LoginPage loginPage = new LoginPage();
            NavigationPage navigationPage = new NavigationPage();
            navigationPage.Navigate(menu.JournalTitle);
            Assert.AreEqual($"http://journals.lww.com/{menu.JournalTitle}/pages/default.aspx", loginPage.LoginJournalPositive(Data.Default.login, Data.Default.passwd, menu.JournalTitle));
        }

        [OneTimeTearDown]
        public static void Cleanup()
        {
            WebDriver.KillDriver();
        }
    }
}
