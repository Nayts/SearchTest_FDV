namespace FDV.Behaviours
{
    using FDV.Selectors;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.PageObjects;

    public class GoogleBehaviours
    {
        private IWebDriver _driver;
        private GoogleSelectors _selectors;

        public GoogleBehaviours(IWebDriver driver)
        {
            // Creates a local copy of the driver instance
            _driver = driver;

            // Creates a new object containing all the GoogleSelectors properties
            _selectors = new GoogleSelectors();

            // Initializes the GoogleSelectors pageobject under the '_selectors' object
            PageFactory.InitElements(_driver, _selectors);
        }

        public GoogleBehaviours Search(string TextToSearch)
        {
            // Uses the previously generated _selectors PageObject to search
            _selectors.SearchBar.SendKeys(TextToSearch + Keys.Enter);
            return this;
        }

        public GoogleBehaviours GoToSeleniumHQWebSite()
        {
            // Clicks the 'SeleniumHQ' result link in the grid
            _selectors.SeleniumHqSearchResult.Click();
            return this;
        }
    }
}