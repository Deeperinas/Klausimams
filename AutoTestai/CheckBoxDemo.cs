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
    class CheckBoxDemo
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
            driver.Quit();
        }

        [Test]
        public static void TestMultipleCheckBoxes()
        {
            IReadOnlyCollection<IWebElement> checkboxes = driver.FindElements(By.CssSelector(".cb-element"));

            foreach (IWebElement checkbox in checkboxes)
            {
                checkbox.Click();
            }


        }


    }

}
