using AutoTestai.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTestai.Test
{
    public class FirstInputTest
    {
        private static IWebDriver driver;

        [OneTimeSetUp]
        public static void OneTimeSetup()
        {
            driver = new FirefoxDriver();
            driver.Url = "http://demo.seleniumeasy.com/basic-first-form-demo.html";
            driver.Manage().Window.Maximize(); //maximizinam langa

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(tempDriver => tempDriver.FindElement(By.Id("at-cv-lightbox-close")).Displayed);
            driver.FindElement(By.Id("at-cv-lightbox-close")).Click();
        }
        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            driver.Quit();
        }

        [TestCase("2", "2", "4", TestName = "2 plus 2")]
        [TestCase("-5", "3", "-2", TestName = "-5 plus 3")]
        [TestCase("a", "b", "NaN", TestName = "a plus b")]
        public static void TestFromSeleniumWebPage(string firstParameter, string secondParameter, string sum)
        {
            FirstInputPage page = new FirstInputPage(driver);

            page.InsertFirstInput(firstParameter);
            page.InsertSecondInput(secondParameter);
            page.ClickCalculatebutton();
            page.VerifyResult(sum);
        }
    }
}
