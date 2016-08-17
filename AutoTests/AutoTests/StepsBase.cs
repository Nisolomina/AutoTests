using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AutoTests
{
    public class StepsBase
    {
        protected IWebDriver Driver
        {
            get { return ((IWebDriver)ScenarioContext.Current["Driver"]); }

        }
    }
}
