using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutoTestai
{
    class SeleniumTests
    {
   
      
          /*
          Užduotis:
          Puslapyje http://demo.seleniumeasy.com/basic-first-form-demo.html parašyti testus "Two Input Fields" formai.
          Patikrinti, ar teisingai suskaičiuotos sumos, jei įvesti tokie duomenys:
          2+2
          -5+3
          a + b
          */

   
        [Test]
        public static void TestSum4()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://demo.seleniumeasy.com/basic-first-form-demo.html";
            Thread.Sleep(5000);

            IWebElement popup = driver.FindElement(By.Id("at-cv-lightbox-close"));
            popup.Click(); // clicku istiesu nereikia

            IWebElement valueA = driver.FindElement(By.Id("sum1"));
            valueA.Click(); // clicku istiesu nereikia
            valueA.SendKeys("2");

            IWebElement valueB = driver.FindElement(By.Id("sum2"));
            valueB.Click(); // clicku istiesu nereikia
            valueB.SendKeys("2");

            IWebElement resultBtn = driver.FindElement(By.CssSelector("#gettotal > button"));
            resultBtn.Click(); // clicku istiesu nereikia

            IWebElement result = driver.FindElement(By.Id("displayvalue"));           
            Assert.AreEqual("4", result.Text, "Result is not 4");

            driver.Quit();
        }

        [Test]
        public static void TestSum5()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://demo.seleniumeasy.com/basic-first-form-demo.html";
            Thread.Sleep(5000);

            IWebElement popup = driver.FindElement(By.Id("at-cv-lightbox-close"));
            popup.Click();

            IWebElement valueA = driver.FindElement(By.Id("sum1"));
            valueA.SendKeys("-5");

            IWebElement valueB = driver.FindElement(By.Id("sum2"));
            valueB.SendKeys("3");

            IWebElement resultBtn = driver.FindElement(By.CssSelector("#gettotal > button"));
            resultBtn.Click();

            IWebElement result = driver.FindElement(By.Id("displayvalue"));
            Assert.AreEqual("-2", result.Text, "Result is not -2");

            driver.Quit();

        }
        [Test]
        public static void TestSum6()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://demo.seleniumeasy.com/basic-first-form-demo.html";
            Thread.Sleep(5000);

            IWebElement popup = driver.FindElement(By.Id("at-cv-lightbox-close"));
            popup.Click();

            IWebElement valueA = driver.FindElement(By.Id("sum1"));
            valueA.SendKeys("a");

            IWebElement valueB = driver.FindElement(By.Id("sum2"));
            valueB.SendKeys("b");

            IWebElement resultBtn = driver.FindElement(By.CssSelector("#gettotal > button"));
            resultBtn.Click();

            IWebElement result = driver.FindElement(By.Id("displayvalue"));
            Assert.AreEqual("NaN", result.Text, "???");

            driver.Quit();

        }

    }
}
