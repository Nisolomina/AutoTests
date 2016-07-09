﻿
using System;
using OpenQA.Selenium.Chrome;

namespace AutoTests
{
    public class DriverFactory
    {
        public ChromeDriver CreateChromeDriver()
        {
            ChromeDriver driver = new ChromeDriver();

            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
            driver.Manage().Window.Maximize();

            return driver;
        }
    }
}