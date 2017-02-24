using framework.DeserealizationData;
using framework.DeserealizationData.LoginData;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace framework.Tests
{
    [TestFixture]
    class testConfig
    {
        [Test]
        public static void test()
        {
            string qwe = ConfigurationManager.AppSettings["chrome"];
        }

        [Test]
        public static void te()
        {
            WebDriver.Driver.Navigate().GoToUrl("http://journals.lww.com/pages/advancedsearch.aspx");
            WebDriver.Driver.FindElement(By.Id("keywords_input_3")).Click();
            WebDriver.Driver.FindElement(By.Id("keywords_input_3")).SendKeys("dgdgdghdhg");
            WebDriver.Driver.FindElement(By.XPath("id('ctl00_ctl45_g_77cc2d0c_f9e9_4965_823b_6d21a4776877_ctl00_searchAgain')")).Click();
        }
    }
}
