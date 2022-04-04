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
/*
Puslapiui https://developers.whatismybrowser.com/useragents/parse/?analyse-my-user-agent=yes#parse-useragent parašyti testus, ar 
teisingai parodo jūsų naršyklę, jei paleidžiate testus su:
chrome,
firefox,
opera ar safari (optional).
*/

    class MyBrowserTest
    {
        private static IWebDriver driver;
        private static IWebDriver driver2;

        [OneTimeSetUp]
        public static void OneTimeSetUp()
        {
            driver = new FirefoxDriver();
            driver2 = new ChromeDriver();

            driver.Url = "https://developers.whatismybrowser.com/useragents/parse/?analyse-my-user-agent=yes#parse-useragent";
            driver2.Url = "https://developers.whatismybrowser.com/useragents/parse/?analyse-my-user-agent=yes#parse-useragent";
            driver.Manage().Window.Maximize();
            driver2.Manage().Window.Maximize();
        }

        [OneTimeTearDown]
        public static void OnetimeTearDown()
        {
            driver.Quit();
            driver2.Quit();
        }

        [Test] // AR GALIMA CIA PADARYTI SU TESTCASE? 
        public static void TestWithFirefox()
        {
            IWebElement result = driver.FindElement(By.CssSelector("#primary-detection > div"));
            Assert.AreEqual("Firefox 98 on Windows 10", result.Text, "Kazkas netaip");

            IWebElement result2 = driver2.FindElement(By.CssSelector("#primary-detection > div"));
            Assert.AreEqual("Chrome 100 on Windows 10", result2.Text, "Kazkas netaip");
        }


    }
}
