using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ParaBankSite.Common_Lib;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParaBankSite.Examples
{
    
    class Enabled_EX

    {
        IWebDriver driver;
        [Test]
       public void Test1()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("file:///C:/Users/Sandeep%20Sohal/source/repos/ParaBankSite/Frames_Html/Example.html");
            IWebElement ClickMe = driver.FindElement(By.XPath("/html/body/button"));

         // Enabled operation returns Boolean value , Same is shown in Output
            //Boolean clk = ClickMe.Enabled;
        

            //Console.WriteLine("Elelemt Enabled ? " +clk);
            try
            {
                IWebElement Inputtxt = driver.FindElement(By.XPath("/html/body/input"));
                bool inp = ClickMe.Displayed;
            }
            catch
            {
                Console.WriteLine("Element is Not Displayed");
            }


        }
    }
}
