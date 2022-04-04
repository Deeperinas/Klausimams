using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTestai.Page
{
    public class CheckboxPage
    {
        private static IWebDriver driver;
        
        private IWebElement firstCheckbox => driver.FindElement(By.Id("isAgeSelected"));
        private IWebElement success => driver.FindElement(By.CssSelector("#txtAge"));

        public CheckboxPage(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        public void ClickFirstCheckbox()
        {
            firstCheckbox.Click(); 
        }

        public void VerifyTextResult()
        {
            Assert.AreEqual("Success - Check box is checked", success.Text, "Kazkas ne taip");
        }
    }
}
