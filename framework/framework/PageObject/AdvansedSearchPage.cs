using OpenQA.Selenium;

namespace framework.PageObject
{
    class AdvansedSearchPage
    {
        private string Xpath = "ctl00_ctl45_g_77cc2d0c_f9e9_4965_823b_6d21a4776877_ctl00_";
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
            WebDriver.Driver.FindElement(By.Id($"{Xpath}filterList{checkbox}")).Click();
        }

        public void ChosePublicationDate(string checkbox)
        {
            WebDriver.Driver.FindElement(By.Id($"{Xpath}searchDatesRadioButtonList_{checkbox}")).Click();
        }

        public void ChooseLimitToContent(string limit)
        {
            WebDriver.Driver.FindElement(By.Id($"{Xpath}filterList{limit}")).Click();
        }

        public void StartSearch()
        {
            WebDriver.Driver.FindElement(By.XPath($"id('{Xpath}searchAgain')")).Click();
        }

        public bool FindSearchResults()
        {
            return WebDriver.Driver.FindElement(By.XPath($"id('ej-featured-article-info')/header/h4/a")).Enabled;
        }
    }
}
