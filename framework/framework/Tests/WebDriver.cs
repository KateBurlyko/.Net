using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Threading;
using System.Configuration;

namespace framework
{
    public class WebDriver
    {
        private WebDriver() { }

        private static IWebDriver driver;


        public static IWebDriver Driver
        {
            get
            {
                if (driver == null)
                {
                    driver = new ChromeDriver(Data.Default.pathDriver);
                    driver.Manage().Window.Maximize();
                }
                //switch (Data.Default.driver)
                //{
                //    case "chrome":
                //        if (driver == null)
                //        {
                //            driver = new ChromeDriver(Data.Default.pathDriver);
                //            driver.Manage().Window.Maximize();
                //        }
                //        break;
                //    case "firefox":
                //        if (driver != null)
                //        {
                //            driver = new FirefoxDriver();
                //            driver.Manage().Window.Maximize();
                //        }
                //        break;
                //    case "opera":
                //        if (driver == null)
                //        {

                //            driver.Manage().Window.Maximize();
                //        }
                //        break;
                //}
                return driver;                
            }
        }

        public static void KillDriver()
        {
            driver.Quit();
            driver = null;
        }
    }
}