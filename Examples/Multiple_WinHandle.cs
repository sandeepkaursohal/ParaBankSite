using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ParaBankSite.Examples
{
    class Multiple_WinHandle
    {
        IWebDriver driver;
        [Test]
        public void Win()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.snapdeal.com/");
            //Click at Product and entered in new tab
            driver.FindElement(By.XPath("//*[@id='content_wrapper']/section/div[4]/section/div[2]/div[1]/div/div[5]/a/div[3]/div[1]")).Click();

            // Switching back to Parent tab
            driver.SwitchTo().Window(driver.WindowHandles[0]);

            //Clicking at "About us" in parent window
            driver.FindElement(By.XPath("//*[@id='sdFooter']/div[2]/div[1]/div/div[2]/ul/li[1]/a")).Click();
            Thread.Sleep(2000);

            //Swtch to child tab again and Click at Add to Cart
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            driver.FindElement(By.XPath("//*[@id='add-cart-button-id']")).Click();

        }
    }
}
