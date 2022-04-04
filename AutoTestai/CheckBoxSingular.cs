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
    class CheckBoxSingular
    {
        private static IWebDriver driver;

        [OneTimeSetUp]
        public static void OneTimeSetUp()
        {
            driver = new FirefoxDriver();
            driver.Url = "http://demo.seleniumeasy.com/basic-checkbox-demo.html";
            driver.Manage().Window.Maximize();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            driver.Quit();
        }

        [Test]
        public static void TestSingularCheckbox()
        {
            IWebElement firstCheckbox = driver.FindElement(By.Id("isAgeSelected"));
            firstCheckbox.Click();

            IWebElement success = driver.FindElement(By.CssSelector("#txtAge"));

            Assert.AreEqual("Success - Check box is checked", success.Text, "Kazkas ne taip");

            


        }


    }

}
