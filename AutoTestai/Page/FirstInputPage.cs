using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTestai.Page
{
    public class FirstInputPage
    {
        private static IWebDriver driver;

        

        private IWebElement firstInputField => driver.FindElement(By.Id("sum1"));
        private IWebElement secondInputField => driver.FindElement(By.Id("sum2"));
        private IWebElement calculateButton => driver.FindElement(By.CssSelector("#gettotal > button"));
        private IWebElement resultFromPage => driver.FindElement(By.Id("displayvalue"));

        public FirstInputPage(IWebDriver webdriver)
        {
            driver = webdriver;
        }

        public void InsertFirstInput(string firstParameter)
        {
            firstInputField.Clear();
            firstInputField.SendKeys(firstParameter);
        }

        public void InsertSecondInput(string secondParameter)
        {
            secondInputField.Clear();
            secondInputField.SendKeys(secondParameter);
        }

        public void ClickCalculatebutton()
        {
            calculateButton.Click();
        }

        public void VerifyResult(string sum)
        {
            Assert.AreEqual(sum, resultFromPage.Text, "Actual result differs from expected");
        }
    }
}
