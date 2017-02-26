using framework.Tests.PageObject;
using NUnit.Framework;
using static framework.Tests.DataProviders;

namespace framework.mustransme
{
    [TestFixture]
    //[Parallelizable(ParallelScope.Fixtures)]
    class LoginTests
    {
        [Test, TestCaseSource(typeof(TestCasesProvider), "NegativeLoginData")]
        public static void NegativeLoginTests(string login, string password, string expected)
        {
            LoginPage loginPage = new LoginPage();
                loginPage.LoginJournalNegative(login, password);
                Assert.AreEqual(expected, loginPage.FindError());
        }
        
        public static void PositiveLoginTests()
        {
            LoginPage loginPage = new LoginPage();
            NavigationPage navigationPage = new NavigationPage();
            navigationPage.Navigate(Data.Default.JournalName);
            Assert.AreEqual($"http://journals.lww.com/{Data.Default.JournalName}/pages/default.aspx", loginPage.LoginJournalPositive(Data.Default.login, Data.Default.passwd, Data.Default.JournalName));
        }

        [OneTimeTearDown]
        public static void Cleanup()
        {
            WebDriver.KillDriver();
        }
    }
}
