﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace SpecFlowPages
{
    public class NavigateToSpecFlowExcel
    {
        public static void ClickSpecFlowPlus()
        {
            var action = new Actions(Driver.Instance);
            var specFlowPlusButton = Driver.Instance.FindElement(By.XPath(".//*[@id='menu-item-701']/a"));
            action.MoveToElement(specFlowPlusButton).Perform();
        }

        public static void ClickSpecFlowPlusExcel()
        {
            var specFlowPlusExcelButton = Driver.Instance.FindElement(By.XPath(".//*[@id='menu-item-698']/a"));
            specFlowPlusExcelButton.Click();
        }

        public static string GetButtonGetStartedText()
        {
            return Driver.Instance.FindElement(By.XPath(".//*[@id='get-started-now']/a")).Text;
        }
    }
}
