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
using NUnit;
using NUnit.Framework;

namespace AutoTests
{
    static class Wrapper
    {
        public static string _domain;
        public static string GetUrl()
        {
            _domain = "http://www.eugenesqr.com/";
            return _domain;
        }
    }
}
