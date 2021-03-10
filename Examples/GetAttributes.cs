using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParaBankSite.Examples
{
    class GetAttributes
    {

        IWebDriver driver;
        [Test]
        public void Test1()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://parabank.parasoft.com/parabank/index.htm");
            IWebElement Attribute = driver.FindElement(By.XPath("//*[@id='loginPanel']/form/div[1]/input"));

            string atb = Attribute.GetAttribute("name");
            Console.WriteLine(atb);
            //some common atributes used are name, type, class,id
            //String titleValue = web_element.GetAttribute("class")
        }
    }
}
