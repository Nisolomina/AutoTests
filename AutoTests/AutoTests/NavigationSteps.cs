using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AutoTests
{
    [Binding]
    public class NavigationSteps : StepsBase
    {
        [Given(@"I open the site '(.*)'")]
        [When(@"I open the site '(.*)'")]
        public void GivenIOpenTheSite(string siteUrl)
        {
            Driver.Navigate().GoToUrl(siteUrl);
            System.Threading.Thread.Sleep(5000);
        }

        [Then(@"I am able to see '(.*)' url")]
        public void ThenIAmAbleToSeeEnUrl(string inputUrl)
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(20));
            wait.Until(driver => Driver.Url == inputUrl);
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
            var button = Driver.FindElement(
                By.CssSelector("#post-listing > ul.pager > li.next > a[ng-href='/en/posts/2']"));

        }

        [Then(@"I am able to see Newer button")]
        public void ThenIAmAbleToSeeNewerButton()
        {
            var button = Driver.FindElement(
                By.CssSelector("#post-listing > ul.pager > li.previous > a[ng-href='/en/posts/1']"));

        }
    }
}
