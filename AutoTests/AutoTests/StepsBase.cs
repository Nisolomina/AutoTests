using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AutoTests
{
    [Binding]
    class StepsBase
    {
        protected IWebDriver Driver;

        [BeforeScenario]
        protected void Setup() 
        {

            DriverFactory driverFactory = new DriverFactory();
            ScenarioContext.Current.ToString("Driver") = driverFactory.CreateChromeDriver();
        }

        [AfterScenario]
        public void TearDown()
        {
            ((IWebDriver)ScenarioContext.Current("Driver")).Close();
        }

        [AfterScenario]
        protected void TearDown()
        {
            Driver.Close();
        }
    }
}
