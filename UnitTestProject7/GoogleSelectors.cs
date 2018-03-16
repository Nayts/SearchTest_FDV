namespace FDV.Selectors
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.PageObjects;

    public class GoogleSelectors
    {
        private const string searchBar = "input[id='lst-ib']";
        private const string seleniumHqSearchResult = "div[class='g'] a[href='https://www.seleniumhq.org/']";

        // Creates new objects that will be filled once the use the PageFactory from Selenium
        [FindsBy(How = How.CssSelector, Using = searchBar)]
        public IWebElement SearchBar { get; set; }

        [FindsBy(How = How.CssSelector, Using = seleniumHqSearchResult)]
        public IWebElement SeleniumHqSearchResult { get; set; }
    }
}
