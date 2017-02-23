using System.Collections.Generic;
using System.Collections;
using NUnit.Framework;
using framework.JournalItem;
using framework.LoginData;
using framework.Parser;

namespace framework
{
    [TestFixture]
    class TestClassTests
    {
        /// <summary>
        /// for one journal
        /// </summary>
        /// <param name="menu"></param>
        [Test, TestCaseSource(typeof(TestCasesProvider), "TestCaseWithJournals")]
        public static void testNavigation(MenuElement menu)
        {
            NavigationPage navigationPage = new NavigationPage();

            navigationPage.Navigate(menu.JournalTitle);

            foreach (Colomn c in menu.Colomns)
            {
                Assert.True(navigationPage.FindMenu(c.MenuTitle), $"not found the element menu {menu.JournalTitle} in journal {menu.JournalTitle}");

                foreach (string e in c.coloms)
                {
                    Assert.True(navigationPage.FindMenu(e), $"not found the element submenu {e} in journal {menu.JournalTitle}");
                }
            }
        }

        [Test, TestCaseSource(typeof(TestCasesProvider), "TestCaseWithJournals")]
        public static void loginTest(MenuElement menu)
        {
            NavigationPage navigationPage = new NavigationPage();
            navigationPage.Navigate(menu.JournalTitle);
            Assert.AreEqual($"http://journals.lww.com/{menu.JournalTitle}/pages/default.aspx", navigationPage.LoginJournal(Data.Default.login, Data.Default.passwd));
        }

        [Test]
        public static void searchTest()
        {
            WebDriver.Driver.Navigate().GoToUrl("http://journals.lww.com/pages/results.aspx?txtkeywords=stomach+performed");
        }


        //to do
        // add function which find expected message instead of lg.Expected
        [Test]
        public static void login()
        {
            NavigationPage navigationPage = new NavigationPage();
            ParsingLoginPassword par = new ParsingLoginPassword();
            WebDriver.Driver.Navigate().GoToUrl("http://journals.lww.com/");
            List<LoginDatas> list = par.GetLogin();
            foreach (LoginDatas lg in list) {
                navigationPage.LoginJournal(lg.Login, lg.Password);
                Assert.True(navigationPage.FindError(lg.Expected));
               
            }
        }

        [TestFixtureTearDown]
        public static void Cleanup()
        {
            WebDriver.KillDriver();
        }
    }
    public class TestCasesProvider
    {
        public static IEnumerable TestCaseWithJournals()
        {
            Journal journa = new Journal();
            AllJournals all = new AllJournals();
            WorkingWithExcel work = new WorkingWithExcel();

            List<Journal> list = work.WorkWithExcel(all, Data.Default.pathBatch, journa);
            foreach (Journal jou in list)
            {
                foreach (MenuElement menu in jou.JournalInfo)
                {
                    yield return new TestCaseData(menu);
                }
            }
        }
    }
}
