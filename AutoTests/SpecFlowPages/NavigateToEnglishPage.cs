using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace SpecFlowPages
{
    public class NavigateToEnglishPage
    {
        public static void ClickEnButton()
        {
            var EnButton = Driver.Instance.FindElement(By.CssSelector("#header > div > div > a.flag.flag-us"));
            EnButton.Click();
        }

        public static object GetEnUrl()
        {
            return Driver.Instance.Url;
        }
    }
}
