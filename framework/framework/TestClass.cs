using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace framework
{
    [TestClass]
    class TestClass
    {
        [Test]
        public void test()
        {
           // IWebDriver driver = new IWebDriver();

            WebDriver.Driver.Navigate().GoToUrl("http://journals.lww.com/pages/default.aspx");
            Assert.AreSame(10, 5 + 6);
            //   driver.Quit();
        }
    }
}
