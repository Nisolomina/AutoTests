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
    class TestClass1:SeleniumTestBase
    {
        [Test, Timeout(10000)]
        public void Test1()
        {
            Driver.Navigate().GoToUrl(Wrapper.GetUrl());
            Assert.IsTrue(Driver.Title == "Простой код, который работает");
        }
    }
}
