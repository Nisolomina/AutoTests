using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AutoTests
{
    [Binding]
    public class StepsBase
    {
        get( return ((IWebDriver)ScenarioContext.Current["Driver"]);
       
    }
}
