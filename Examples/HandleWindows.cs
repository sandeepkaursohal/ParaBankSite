using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParaBankSite.Examples
{
    class HandleWindows
    {
        IWebDriver driver;
        [Test]
        public void Win()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.globalsqa.com/demo-site/frames-and-windows/#Open%20New%20Window");

            String mainwindow = driver.CurrentWindowHandle; //get parent(current) window name

        }
    }
}
