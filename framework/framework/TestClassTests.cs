
using NUnit.Framework;
using framework.New;

namespace framework
{
    [TestFixture]
    class TestClassTests
    {

        NavigationPage navigationPage = new NavigationPage();
        // MenuElement menuItem;
        Journal journa = new Journal();

        [Test]
        public void test()
        {
            GettingJournalInfo getInfo = new GettingJournalInfo();
            getInfo.readFile(Data.Default.pathBatch, journa);
            foreach (MenuElement jou in journa.JournalInfo)
            {
                navigationPage.Navigate(jou.JournalTitle);
                foreach (Colomn c in jou.Colomns)
                {
                    navigationPage.FindButton(c.MenuItem);

                    foreach (string e in c.coloms)
                    {
                        navigationPage.FindButton(e);
                    }

                    navigationPage.FindButton1.Click();
                }
            }
        }


    }
}

