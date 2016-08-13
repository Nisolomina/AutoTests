﻿using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AutoTests
{
    [Binding]
    public class ChangeLanguageSteps : StepsBase
    {
        [When(@"I press button to change language to English")]
        public void WhenIPressButtonToChangeLanguageToEnglish()
        {
            PressButtonToChangeLanguage("us");
        }
        [When(@"I press button to change language to Russian")]
        public void WhenIPressButtonToChangeLanguageToRussian()
        {
            PressButtonToChangeLanguage("ru");
        }

        /*The working version of method PressButtonToChangeLanguage with link in CSS selector
            private void PressButtonToChangeLanguage(string languageAbbreviation)
            {
                IWebElement button = _driver.FindElement(
                    By.CssSelector(
                        string.Format(
                            "#header > div > div > a[ng-href='/{0}/posts/1']",
                            languageAbbreviation)));

                button.Click();
            }*/
        private void PressButtonToChangeLanguage(string languageAbbreviation)
        {
            IWebElement button = Driver.FindElement(
                By.CssSelector(
                    string.Format(
                    "#header > div > div > a.flag.flag-{0}",
                        languageAbbreviation)));

            button.Click();
        }
        private void PressButtonToChangePage(string buttonName, string languageAbbreviation, int pageNumber)
        {
            IWebElement button = Driver.FindElement(
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
            PressButtonToChangePage("previous", "ru", 1);
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

        private void ClickLinkOfPost(string languageAbbreviation, string postTag)
        {
            IWebElement link = Driver.FindElement(
                By.CssSelector(
                    string.Format(
                            "#post-listing > ul.separated-list > li > header > a[ng-href='/{0}/post/{1}']",
                            languageAbbreviation,
                            postTag
                )));

            link.Click();
        }

        [When(@"I click on link of Russian post '(.*)'")]
        public void WhenIClickOnLinkOfRussianPost(string postName)
        {
            ClickLinkOfPost("ru", postName);
        }

        [When(@"I click on link of English post '(.*)'")]
        public void WhenIClickOnLinkOfEnglishPost(string postName)
        {
            ClickLinkOfPost("en", postName);
        }

        [Then(@"I am able to see Older button")]
        public void ThenIAmAbleToSeeOlderButton()
        {
            Driver.FindElement(
                By.CssSelector("#post-listing > ul.pager > li.next > a[ng-href='/en/posts/2']"));

        }

        [Then(@"I am able to see Newer button")]
        public void ThenIAmAbleToSeeNewerButton()
        {
            Driver.FindElement(
                By.CssSelector("#post-listing > ul.pager > li.previous > a[ng-href='/en/posts/1']"));

        }

    }
}