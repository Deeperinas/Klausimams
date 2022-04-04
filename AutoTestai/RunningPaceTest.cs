using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTestai
{
    //nueiti į https://www.active.com/fitness/calculators/pace
    //patikrinti, ar nubėgus 13km per 1val 5min vieno kilometro greitis yra 5min/km

    class RunningPaceTest
    {
        [Test]
        public static void RunningTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.active.com/fitness/calculators/pace";
            driver.Manage().Window.Maximize();


            driver.FindElement(By.CssSelector("#calculator-pace > form > div:nth-child(2) > div > label:nth-child(1) > input[type=number]")).SendKeys("1");
            driver.FindElement(By.CssSelector("#calculator-pace > form > div:nth-child(2) > div > label:nth-child(2) > input[type=number]")).SendKeys("5");
            driver.FindElement(By.CssSelector("#calculator-pace > form > div:nth-child(3) > div > label > input[type=number]")).SendKeys("13");

            driver.FindElement(By.CssSelector("#calculator-pace > form > div:nth-child(3) > div > span > span")).Click(); //kaip paselectint is dropdowno? 









        }
    }
}
