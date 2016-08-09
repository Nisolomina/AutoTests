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
            PressButtonToChangeLanguage("en");
        }
        [When(@"I press button to change language to Russian")]
        public void WhenIPressButtonToChangeLanguageToRussian()
        {
            PressButtonToChangeLanguage("ru");
        }

        [Then(@"I am able to see '(.*)' url")]
        public void ThenIAmAbleToSeeEnUrl(string inputUrl)
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));
            wait.Until(driver => _driver.Url == inputUrl);
        }

        private void PressButtonToChangeLanguage(string languageAbbreviation)
        {
            IWebElement button = _driver.FindElement(
                By.CssSelector(
                    string.Format(
                        "#header > div > div > a[ng-href='/{0}/posts/1']",
                        languageAbbreviation)));

            button.Click();
        }

        private void PressButtonToChangePage(string buttonName, string languageAbbreviation, int pageNumber)
        {
            IWebElement button = _driver.FindElement(
                By.CssSelector(
                    string.Format(
                            "#post-listing > ul.pager > li.{0} > a[ng-href='/{1}/posts/{2}']",
                            buttonName,
                            languageAbbreviation,
                            pageNumber
                )));

            button.Click();
        }
        [When(@"I press button to see earlier Russian posts")]
        public void WhenIPressButtonToSeeEarlierRussianPosts()
        {
            PressButtonToChangePage("next", "ru", 2);
        }

        [When(@"I press button to see newer Russian posts")]
        public void WhenIPressButtonToSeeNewerRussianPosts()
        {
            PressButtonToChangePage("previous","ru", 1);
        }
        [When(@"I press button to see earlier English posts")]
        public void WhenIPressButtonToSeeEarlierEnglishPosts()
        {
            PressButtonToChangePage("next", "en", 2);
        }

        [When(@"I press button to see newer English posts")]
        public void WhenIPressButtonToSeeNewerEnglishPosts()
        {
            PressButtonToChangePage("previous", "en", 1);
        }
    }
}