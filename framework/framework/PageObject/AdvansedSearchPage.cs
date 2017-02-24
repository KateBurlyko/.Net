using OpenQA.Selenium;

namespace framework.PageObject
{
    class AdvansedSearchPage
    {
        public IWebElement FindTextBox(string numberBox)
        {
           return WebDriver.Driver.FindElement(By.Id($"keywords_input_{numberBox}"));
        }

        public void Navigate()
        {
            WebDriver.Driver.Navigate().GoToUrl($"http://journals.lww.com/pages/advancedsearch.aspx");
        }

        public void InputKeywords(string numberBox, string query)
        {
            FindTextBox(numberBox).Clear();
            FindTextBox(numberBox).Click();
            FindTextBox(numberBox).SendKeys(query);
        }

        public void ChoseContentTypes(string checkbox)
        {
            WebDriver.Driver.FindElement(By.Id($"ctl00_ctl45_g_77cc2d0c_f9e9_4965_823b_6d21a4776877_ctl00_filterList{checkbox}")).Click();
        }

        public void ChosePublicationDate(int checkbox)
        {
            WebDriver.Driver.FindElement(By.Id($"ctl00_ctl45_g_77cc2d0c_f9e9_4965_823b_6d21a4776877_ctl00_searchDatesRadioButtonList_{checkbox}")).Click();
        }

        public void ChooseLimitToContent(string limit)
        {
            WebDriver.Driver.FindElement(By.Id($"ctl00_ctl45_g_77cc2d0c_f9e9_4965_823b_6d21a4776877_ctl00_filterList{limit}"));
        }

        public void StartSearch()
        {
            WebDriver.Driver.FindElement(By.XPath("id('ctl00_ctl45_g_77cc2d0c_f9e9_4965_823b_6d21a4776877_ctl00_searchAgain')")).Click();
        }
    }
}
