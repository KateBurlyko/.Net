using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace framework
{
    class NavigationPage
    {
        //  private WebDriver driver;
      //  public IWebElement FindButton { get { return WebDriver.Driver.FindElement(By.PartialLinkText("Articles")); } }
        public IWebElement FindButton1 { get { return WebDriver.Driver.FindElement(By.PartialLinkText("Current")); } }

        //public NavigationPage(WebDriver driver)
        //{
        //    this.driver = driver;
        //}

        //public void setTitle()
        //{
        //    FindButton.Click();
        //}

        public void Navigate(string s)
        {
            WebDriver.Driver.Navigate().GoToUrl("http://journals.lww.com/" + s);
        }
        public void FindButton(string men)
        {
           WebDriver.Driver.FindElement(By.PartialLinkText(men));
        }
    }

}
