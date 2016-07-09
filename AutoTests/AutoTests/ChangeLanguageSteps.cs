using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpecFlowPages;
using OpenQA.Selenium;

namespace AutoTests
{
    [Binding]
    public class ChangeLanguageSteps
    {

        private IWebDriver Driver { get; set; }

        [BeforeScenario]
        public void Setup()
        {
            DriverFactory driverFactory = new DriverFactory();
            Driver = driverFactory.CreateChromeDriver();
        }

        [AfterScenario]
        public void TearDown()
        {
            Driver.Close();
        }

        [Given(@"the russian main page")]
        public void GivenTheRussianMainPage()
        {
            Driver.Navigate().GoToUrl(ConstantsUtils.Url);
        }
        
        [When(@"I press EN")]
        public void WhenIPressEn()
        {
            var enButton = Driver.FindElement(By.CssSelector("#header > div > div > a.flag.flag-us"));
            enButton.Click();
        }
        
        [Then(@"I am able to see '(.*)' url")]
        public void ThenIAmAbleToSeeEnUrl(string p0)
        {
            Assert.AreEqual(ConstantsUtils.GetEnUrl,
                Driver.Url);
        }
    }
}