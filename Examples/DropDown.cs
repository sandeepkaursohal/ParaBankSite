using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parababnk.Dropdowns_Ex
{
    class Example1
    {

        IWebDriver driver;

         [Test]
        public void amzon()
        {
            driver = new ChromeDriver();
            /* driver.Navigate().GoToUrl("https://www.amazon.in/");
             System.Threading.Thread.Sleep(4000);
             IWebElement element = driver.FindElement(By.XPath("//*[@id='searchDropdownBox']"));

             SelectElement select_elem = new SelectElement(element);


             Thread.Sleep(4000);
             select_elem.SelectByIndex(5);

             System.Threading.Thread.Sleep(4000);
             select_elem.SelectByValue("search-alias=instant-video");

             System.Threading.Thread.Sleep(4000);
             select_elem.SelectByText("Shoes & Handbags");
            */
            driver.Navigate().GoToUrl("http://output.jsbin.com/osebed/2");

            IWebElement element = driver.FindElement(By.XPath("//*[@id='fruits']"));


            SelectElement ele = new SelectElement(element);
            ele.SelectByText("Banana");
            ele.SelectByIndex(2);
            ele.SelectByValue("apple");
            ele.DeselectByText("Banana");









        }
    }
}
