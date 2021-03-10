using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParaBankSite.Examples
{
    class ElementDisplayed
    {

        IWebDriver driver;
        [Test]
        public void DisplayElement()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("file:///C:/Users/Sandeep%20Sohal/source/repos/ParaBankSite/Frames_Html/Example.html");
            IWebElement InputText = driver.FindElement(By.XPath("/html/body/input"));

            Boolean InTxt = InputText.Displayed;   // Enabled operation returns Boolean value , Same is shown in Output
            Console.WriteLine("Input Displayed ? " +InTxt);

           //To Display type this command in Example.html//  < input type = "text" Enabled ></ input >
        }
    }
}
