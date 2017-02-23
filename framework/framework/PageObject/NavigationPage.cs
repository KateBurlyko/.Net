using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace framework
{
    class NavigationPage
    {

        /// <summary>
        /// go to Journal URL
        /// </summary>
        /// <param name="jurnalName">Jurnal name</param>
        public void Navigate(string jurnalName)
        {
            WebDriver.Driver.Navigate().GoToUrl("http://journals.lww.com/" + jurnalName);
        }

        /// <summary>
        /// check menu item display
        /// </summary>
        /// <param name="menuID">item of menu which cheks</param>
        /// <returns>true if item is displayed</returns>
        public bool FindMenu(string menuID)
        {
            return WebDriver.Driver.FindElement(By.XPath($"//div[@id='zz1_TopNavigationMenu']//*[text()=\"{menuID}\"]")).Enabled;
        }
    }
}
