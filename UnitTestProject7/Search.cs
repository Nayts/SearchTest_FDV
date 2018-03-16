namespace Test_FDV
{
    using FDV.Behaviours;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;

    [TestClass]
    public class GoogleSearch
    {
        private IWebDriver _driver;

        [TestInitialize]
        public void Initialize()
        {
            // Creating a new instance of ChromeDriver
            _driver = new ChromeDriver();

            // Maximizing the browser
            _driver
                .Manage()
                .Window
                .Maximize();

            // Navigate too Google 
            _driver
                .Navigate()
                .GoToUrl("http://www.google.com");
        }

        [TestMethod]
        public void PerformGoogleSearch()
        {
            // Creates a new instance of GoogleBehaviours
            GoogleBehaviours google = new GoogleBehaviours(_driver);

            // Performs a search for 'SeleniumHQ' and then goes to the desired URL
            google
                .Search("SeleniumHQ")
                .GoToSeleniumHQWebSite();

            // Checks if we're actually in Selenium Website
            Assert.AreEqual(_driver.Title, "Selenium - Web Browser Automation");
        }

        [TestCleanup]
        public void TearDown()
        {
            // Closes the browser and task in task manager
            _driver.Quit();
        }
    }
}