using System;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpecFlowPages;
using OpenQA;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutoTests
{
    [Binding]
    public class ChangeLanguageSteps
    {
        [BeforeScenario]
        public void Setup()
        {
            Driver.Initialize();
            Driver.Instance.Navigate().GoToUrl(Driver.BaseAddress);
        }

        [AfterScenario]
        public void TearDown()
        {
            Driver.Close();
        }

        [Given(@"the russian main page")]
        public void GivenTheRussianMainPage()
        {
            
        }
        
        [When(@"I press EN")]
        public void WhenIPressEN()
        {
            NavigateToEnglishPage.ClickEnButton();
        }
        
        [Then(@"I am able to see '(.*)' url")]
        public void ThenIAmAbleToSeeEnUrl(string p0)
        {
            Assert.AreEqual(ConstantsUtils.GetEnUrl,
                NavigateToEnglishPage.GetEnUrl());
        }
    }
}
