using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace framework.Tests.PageObject
{
    class LoginPage
    {
        public IWebElement LoginInput { get { return WebDriver.Driver.FindElement(By.XPath("//*[contains(@id, 'txt_UserName')]")); } }
        public IWebElement PasswordInput { get { return WebDriver.Driver.FindElement(By.XPath("//*[contains(@id, 'txt_Password')]")); } }
        public IWebElement LoginButton { get { return WebDriver.Driver.FindElement(By.XPath("//*[contains(@id, 'LoginButton')]")); } }
        public IWebElement Login { get { return WebDriver.Driver.FindElement(By.LinkText("Login")); } }
        public IWebElement LogOutButton { get { return WebDriver.Driver.FindElement(By.LinkText("Log Out")); } }

        public string FindError()
        {
            return WebDriver.Driver.FindElement(By.XPath("//*[contains(@id, 'ctl00_ctl45_g_818e981e_cd12_4836_8e55_9fe5e199454d_ctl00_LoginControl_cvLoginSuccess')]")).Text;
        }

        /// <summary>
        /// go to Journal URL
        /// </summary>
        /// <param name="jurnalName">Jurnal name</param>
        private void Navigate()
        {
            WebDriver.Driver.Navigate().GoToUrl("http://journals.lww.com/");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="user">login</param>
        /// <param name="pasw">password</param>
        /// <returns>URL after login</returns>
        public string LoginJournalPositive(string user, string pasw)
        {
            Navigate();
            LoginInput.SendKeys(user);
            PasswordInput.SendKeys(pasw);
            LoginButton.Click();
            string resultURL = WebDriver.Driver.Url.ToString();
            LogOutButton.Click();
            return resultURL;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userLogin">login</param>
        /// <param name="pasw">password</param>
        public void LoginJournalNegative(string userLogin, string pasw)
        {
            Navigate();
            Login.Click();
            LoginInput.SendKeys(userLogin);
            PasswordInput.SendKeys(pasw);
            LoginButton.Click();
        }
    }
}
