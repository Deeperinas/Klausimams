using AutoTestai.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTestai.Test
{
    public class CheckboxTest
    {
        public static IWebDriver driver;

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
        public static void TestFirstCheckbox()
        {
            CheckboxPage page = new CheckboxPage(driver);

            page.ClickFirstCheckbox();
            page.VerifyTextResult();
        }
    }
}
