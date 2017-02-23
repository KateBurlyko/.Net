using NUnit.Framework;
using framework.Tests.PageObject;
using static framework.Tests.DataProviders;

namespace framework
{
    [TestFixture]
    [Parallelizable]//(ParallelScope.Fixtures)]
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

        [TestFixtureTearDown]
        public static void Cleanup()
        {
            WebDriver.KillDriver();
        }
    }

}