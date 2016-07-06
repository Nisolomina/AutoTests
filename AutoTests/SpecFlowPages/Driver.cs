using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace SpecFlowPages
{
    public class Driver
    {
        public static IWebDriver Instance { get; set; }

        public static string BaseAddress
        {
            get { return ConstantsUtils.Url; }
        }

        public static void Initialize()
        {
            Instance = new ChromeDriver("C:/Distrib/chromedriver_win32");
            TurnOnWait();
            Instance.Manage().Window.Maximize();
        }

        public static void Navigate()
        {
            Instance.Navigate().GoToUrl(BaseAddress);
        }

        public static void Close()
        {
            Instance.Close();
        }

        private static void TurnOnWait()
        {
            Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
        }
    }
}
