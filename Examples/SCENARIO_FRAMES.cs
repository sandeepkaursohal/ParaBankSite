using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ParaBankSite.Examples
{
    class SCENARIO_FRAMES
    {
        IWebDriver driver;


        [Test]
        [Obsolete]
        public void TestFrames()
        {
            driver = new ChromeDriver();
            //driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("file:///C:/Users/Sandeep%20Sohal/source/repos/ParaBankSite/Frames_Html/Frames.html");

            driver.SwitchTo().Frame(0);
            driver.FindElement(By.XPath("//*[@id='navbarExample']/ul/li[2]/a")).Click();

            driver.SwitchTo().DefaultContent();
           driver.SwitchTo().Frame(2);
            
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));

            IWebElement Element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@name='search']")));

            driver.FindElement(By.XPath("//input[@name='search']")).SendKeys("Selenium");

           /*IWebElement blogname = driver.FindElement(By.XPath(""));
            blogname.Click();
            string Blog = blogname.Text;
            Console.WriteLine(Blog);
           */
           
            driver.SwitchTo().DefaultContent();
            driver.SwitchTo().Frame("Bing");
            driver.FindElement(By.XPath("//*[@id='sb_form_q']")).SendKeys("Sydney");
            Thread.Sleep(5000);

            driver.SwitchTo().DefaultContent();

            driver.SwitchTo().Frame(3);
            driver.FindElement(By.XPath("//*[@id='loginPanel']/p[2]/a")).Click();
            driver.FindElement(By.XPath("//input[@id='customer.firstName']")).SendKeys("Sandeep");
            Thread.Sleep(5000);

            driver.SwitchTo().DefaultContent();
            driver.FindElement(By.LinkText("Google.com")).Click();

           
        }
    }
}

