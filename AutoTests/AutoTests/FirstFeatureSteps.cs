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
    public class FirstFeatureSteps
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
        [Given(@"the specflow page")]
        public void GivenTheSpecflowPage()
        {
           
        }
        
        [When(@"I press SpecFlow\+")]
        public void WhenIPressSpecFlow()
        {
            NavigateToSpecFlowExcel.ClickSpecFlowPlus();
        }
        
        [When(@"Specflow\+-Excel")]
        public void WhenSpecflow_Excel()
        {
            NavigateToSpecFlowExcel.ClickSpecFlowPlusExcel();
        }
        
        [Then(@"I am able to see '(.*)' button")]
        public void ThenIAmAbleToSeeButton(string p0)
        {
            Assert.AreEqual(ConstantsUtils.GetStartedExcelButtonText,
                NavigateToSpecFlowExcel.GetButtonGetStartedText());
        }
    }
}
