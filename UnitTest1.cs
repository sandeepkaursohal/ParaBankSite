using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using ParaBankSite.Common_Lib;
using System.Threading;

namespace ParaBankSite
{
    public class Tests
    {

        IWebDriver driver;
        [Test]
        public void Test1()

        {
            
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://dev-online.dev.tsretail.co.za/landing");
            driver.Manage().Window.Maximize();

            Thread.Sleep(10000);
           
            
            driver.FindElement(By.XPath("/html/body/app-root/div/div/top-navigation/div/div/div/div[1]/div[2]/button-with-notification[1]")).Click();
         
          
        }

    }
}