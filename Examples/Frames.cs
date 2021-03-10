using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParaBankSite.Examples
{
    class Frames
    {
        IWebDriver driver;
        
        [Test]
        public void Rediff()

        {
            driver = new ChromeDriver();
            //driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.rediff.com/");
            // driver.SwitchTo().Frame("moneyiframe");  //with id 

            driver.SwitchTo().Frame(0);// by Index// search above there is no frame available so its a first frame , hence index0
            // by web element

            string NSE = driver.FindElement(By.Id("nseindex")).Text;

            Console.WriteLine(NSE);
            driver.SwitchTo().DefaultContent(); // focussing on parent HTML Page
            driver.FindElement(By.LinkText("SPORTS")).Click();




        }
  
    }
}
