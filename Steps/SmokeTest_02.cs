using NUnit.Framework;
using OpenQA.Selenium;
using ParaBankSite.Common_Lib;
using ParaBankSite.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParaBankSite.Steps
{
    public class SmokeTest_02
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
        public void  Smoketest_002()
        {

            LoginPage.CustomerLogin();
            Service.driver.FindElement(By.XPath("//a[contains(text(),'Accounts Overview')]")).Click();

        }

    }

}
