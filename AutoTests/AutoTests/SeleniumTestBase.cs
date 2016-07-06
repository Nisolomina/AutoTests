using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Edge;
using NUnit;
using NUnit.Framework;



namespace AutoTests
{
    [TestFixture]
    public abstract class SeleniumTestBase
    {
        protected IWebDriver Driver;
        [TestFixtureSetUp]
        public void TestInitialize() {
            Driver = new ChromeDriver();
        }
        [TestFixtureTearDown]
        public void TestCleanup() {
            Driver.Quit();
        }
        [TearDown]
        public void OneTearDown()
        {
            Driver.Manage().Cookies.DeleteAllCookies();
        }
        [SetUp]
        public void OneSetUp()
        {
            Driver.Manage().Window.Maximize();
        }
    }
}
