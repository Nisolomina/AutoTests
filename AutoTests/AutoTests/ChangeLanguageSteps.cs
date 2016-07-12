using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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

        [Given(@"I open the site '(.*)'")]
        public void GivenIOpenTheSite(string siteUrl)
        {
            Driver.Navigate().GoToUrl(siteUrl);
        }
        
        [When(@"I press EN")]
        public void WhenIPressEn()
        {
            var enButton = Driver.FindElement(By.CssSelector("#header > div > div > a.flag.flag-us"));
            enButton.Click();
        }
        [When(@"I press button '(.*)'")]
        public void WhenIPressButton(string buttonName)
        {
            string css = string.Empty;

            if ( buttonName == "RU" ) 
            {
                css = "#header > div > div > a.flag.flag-ru";                
            }

            if (buttonName == "EN")
            {
                css = "#header > div > div > a.flag.flag-us";
            }

            var button = Driver.FindElement(By.CssSelector(css));
            button.Click();
        }

        
        [Then(@"I am able to see '(.*)' url")]
        public void ThenIAmAbleToSeeEnUrl(string inputUrl)
        {
            Assert.AreEqual(inputUrl, Driver.Url);
        }

    }
}