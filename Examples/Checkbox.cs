using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParaBankSite.Examples
{
    class Checkbox
    {
        IWebDriver driver;

        [Test]
        public void Check_box()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://mykidsbank.org/");
            // to get the height and width with a web element or the current browser window. the return type is of type struct sze
            
        
            Console.WriteLine(driver.Manage().Window.Size);


            IWebElement CheckBox = driver.FindElement(By.XPath("//*[@type='checkbox']"));
            Boolean CheckboxStatus1= CheckBox.Selected;
            Console.WriteLine("Checkbox is Selected: " +CheckboxStatus1);

            CheckBox.Click();

            Boolean Checkboxstatus2 = CheckBox.Selected;
            Console.WriteLine("Checkbox is Selected Now : " + Checkboxstatus2);

        }
    }
}