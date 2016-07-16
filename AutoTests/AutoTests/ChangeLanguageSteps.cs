using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AutoTests
{
    [Binding]
    public class ChangeLanguageSteps
    {
        private IWebDriver _driver;

        [BeforeScenario]
        public void Setup()
        {
            DriverFactory driverFactory = new DriverFactory();
            _driver = driverFactory.CreateChromeDriver();
        }

        [AfterScenario]
        public void TearDown()
        {
            _driver.Close();
        }

        [Given(@"I open the site '(.*)'")]
        [When(@"I open the site '(.*)'")]
        public void GivenIOpenTheSite(string siteUrl)
        {
            _driver.Navigate().GoToUrl(siteUrl);
        }
        
        [When(@"I press button to change language to English")]
        public void WhenIPressButtonToChangeLanguageToEnglish()
        {
            PressButton("en");
        }
        [When(@"I press button to change language to Russian")]
        public void WhenIPressButtonToChangeLanguageToRussian()
        {
            PressButton("ru");
        }

        [Then(@"I am able to see '(.*)' url")]
        public void ThenIAmAbleToSeeEnUrl(string inputUrl)
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait.Until(driver => _driver.Url == inputUrl);
        }

        private void PressButton(string languageAbbreviation)
        {
            IWebElement button = _driver.FindElement(
                By.CssSelector(
                    string.Format(
                        "#header > div > div > a[ng-href='/{0}/posts/1']",
                        languageAbbreviation)));

            button.Click();
        }
    }
}