using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParaBankSite.Examples
{
    public class Disabled

    {
        IWebDriver driver;
        [Test]
        public void Test1()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("file:///C:/Users/Sandeep%20Sohal/source/repos/ParaBankSite/Frames_Html/Example.html");
            IWebElement ClickMe = driver.FindElement(By.XPath("/html/body/button"));


            Boolean Clk = ClickMe.Enabled;   // Enabled operation returns Boolean value , Same is shown in Output
            Console.WriteLine("Elelemt Disabled ? " + Clk);


        }
    }


}
