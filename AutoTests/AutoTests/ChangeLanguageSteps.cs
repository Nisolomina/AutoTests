using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AutoTests
{
    [Binding]
    public class ChangeLanguageSteps : StepsBase
    {     
        [When(@"I press button to change language to English on First Page")]
        public void WhenIPressButtonToChangeLanguageToEnglishOnFirstPage()
        {
            PressButtonToChangeLanguage("en/posts/1");
        }

        [When(@"I press button to change language to Russian on First Page")]
        public void WhenIPressButtonToChangeLanguageToRussianOnFirstPage()
        {
            PressButtonToChangeLanguage("ru/posts/1");
        }

        [When(@"I press button to change language to English on post page")]
        public void WhenIPressButtonToChangeLanguageToEnglishOnPostPage()
        {
            PressButtonToChangeLanguage("en/post/second-iteration-completed");
        }

        [When(@"I press button to change language to Russian on post page")]
        public void WhenIPressButtonToChangeLanguageToRussianOnPostPage()
        {
            PressButtonToChangeLanguage("ru/post/second-iteration-completed");
        }

        private void PressButtonToChangeLanguage(string pageAddr)
        {
            IWebElement button = Driver.FindElement(
                By.CssSelector(
                string.Format(
                        "#header > div > div > a[ng-href='/{0}']",
                        pageAddr)));
            button.Click();
        }

        /*private void PressButtonToChangeLanguage(string languageAbbreviation)
        {
            IWebElement button = _driver.FindElement(
                By.CssSelector(
                    string.Format(
                        "#header > div > div > a[ng-href='/{0}/posts/1']",
                        languageAbbreviation)));

            button.Click();
        }*/

        [Then(@"I am able to see RU button")]
        public void ThenIAmAbleToSeeRUButton()
        {
            var button = Driver.FindElement(
                By.CssSelector("#header > div > div > a.flag.flag-ru"));

        }

        [Then(@"I am able to see EN button")]
        public void ThenIAmAbleToSeeENButton()
        {
            var button = Driver.FindElement(
                By.CssSelector("#header > div > div > a.flag.flag-us"));

        }
    }
}