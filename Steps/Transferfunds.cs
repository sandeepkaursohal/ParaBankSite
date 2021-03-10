using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ParaBankSite.Common_Lib;
using ParaBankSite.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParaBankSite.Steps
{
    public class Transferfunds
    {
        [SetUp]

        public void SetUp()
        {
            string Appurl = "https://parabank.parasoft.com/";
            Service.StartBrowser("Chrome", Appurl);
        }
        [TearDown]
        public void TearDown()
        {
            Service.CloseDriver();
        }
        [Test]
        public static void Transfunds()
        {
            LoginPage.CustomerLogin();

            Service.driver.FindElement(By.XPath("//*[@id='leftPanel']/ul/li[3]/a")).Click();
            IWebElement pagetitle = Service.driver.FindElement(By.XPath("//*[@id='rightPanel']/div/div/h1"));
            string p_title = pagetitle.Text;

            Console.WriteLine("Title of Page when clicked at Transfer funds: " + p_title);

        }
    }
}
