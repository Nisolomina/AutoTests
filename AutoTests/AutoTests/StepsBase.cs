using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace AutoTests
{
    public class StepsBase
    {
        protected IWebDriver Driver
        {
            get { return (IWebDriver)ScenarioContext.Current["Driver"]; }
        }
    }
}
