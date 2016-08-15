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
            _driver.Navigate().GoToUrl(siteUrl);
        }

        [Then(@"I am able to see '(.*)' url")]
        public void ThenIAmAbleToSeeEnUrl(string inputUrl)
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));
            wait.Until(driver => _driver.Url == inputUrl);
        }
    }
}
