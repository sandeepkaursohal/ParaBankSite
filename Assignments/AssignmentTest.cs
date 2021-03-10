using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ParaBankSite
{
   public  class AssignmentTest
    {
       
        [Test]
        public void Test()

        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://dev-online.dev.tsretail.co.za/landing");
            driver.Manage().Window.Maximize();

            Thread.Sleep(10000);
            driver.FindElement(By.XPath("/html/body/app-root/div/div/top-navigation/div/div/div/div[1]/div[2]/button-with-notification[1]")).Click();
            Thread.Sleep(10000);
            
        }


    }
}
