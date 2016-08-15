using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AutoTests
{
    [Binding]
    public class ScenarioHooks
    {
        private string DriverKey = "Driver";

        [BeforeScenario]
        protected void Setup()        {
      
            DriverFactory driverFactory = new DriverFactory();
            ScenarioContext.Current["Driver"] = driverFactory.CreateChromeDriver();
        }

        [AfterScenario]
        public void TearDown()
        {
            ((IWebDriver)ScenarioContext.Current["Driver"]).Close();
        }
    }
}
