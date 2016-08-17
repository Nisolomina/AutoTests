using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AutoTests
{
    [Binding]
    public class ScenarioHooks
    {
        private const string DriverKey = "Driver";

        [BeforeScenario]
        protected void Setup()        {
      
            DriverFactory driverFactory = new DriverFactory();
            ScenarioContext.Current[DriverKey] = driverFactory.CreateChromeDriver();
        }

        [AfterScenario]
        public void TearDown()
        {
            ((IWebDriver)ScenarioContext.Current[DriverKey]).Close();
        }
    }
}
