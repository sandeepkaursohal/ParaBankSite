using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParaBankSite.Examples
{
    class GetCSSVAlue
    {
        IWebDriver driver;
        [Test]
        public void Test123()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://parabank.parasoft.com/parabank/index.htm");
            IWebElement CustomerloginCSSvalue = driver.FindElement(By.XPath("//*[@id='leftPanel']/h2"));

            string Cssvalue = CustomerloginCSSvalue.GetCssValue("background-color");
            Console.WriteLine(Cssvalue);
            // background-color, size, Font-size etc
        }

    }
}
