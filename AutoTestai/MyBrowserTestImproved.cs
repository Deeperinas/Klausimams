using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTestai
{
    class MyBrowserTestImproved
    {
        private static IWebDriver _driver;

        [TestCase("Chrome", "Chrome 100 on Windows 10", TestName = "Testing Chrome")]
        [TestCase("Firefox", "Firefox 98 on Windows 10", TestName = "Testing Firefox")]

        public static void TestBrowsers(string browser, string text)
        {
            if ("Chrome".Equals(browser))
            {
                _driver = new ChromeDriver();
            }

            if ("Firefox".Equals(browser))
            {
                _driver = new FirefoxDriver();
            }

            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("https://developers.whatismybrowser.com/useragents/parse/?analyse-my-user-agent=yes#parse-useragent");
            IWebElement actualResult = _driver.FindElement(By.CssSelector("#primary-detection > div"));

            Assert.AreEqual(text, actualResult, $"Narsykle nera {browser}");
        }
    }
}
