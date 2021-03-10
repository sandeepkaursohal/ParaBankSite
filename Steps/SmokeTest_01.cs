using NUnit.Framework;
using OpenQA.Selenium;
using ParaBankSite.Common_Lib;
using ParaBankSite.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParaBankSite.Steps
{
    public class SmokeTest_01
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
        public void SmokeTest_001()
        {
            HomePage.RG_TC01_POS();
            Service.driver.FindElement(By.XPath("//a[contains(text(),'Log Out')]")).Click();
            LoginPage.CustomerLogin();

        }

    }
}
