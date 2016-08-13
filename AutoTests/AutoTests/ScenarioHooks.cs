using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace AutoTests
{
    [Binding]
    public class ScenarioHooks
    {
        private const string DriverKey = "Driver";

        [BeforeScenario]
        protected void Setup()
        {
            DriverFactory driverFactory = new DriverFactory();
            ScenarioContext.Current[DriverKey] = driverFactory.CreateChromeDriver();
        }

        [AfterScenario]
        protected void TearDown()
        {
            ((IWebDriver)ScenarioContext.Current[DriverKey]).Close();
        }
    }
}
