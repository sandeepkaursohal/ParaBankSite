using NUnit.Framework;
using OpenQA.Selenium;
using ParaBankSite.Common_Lib;
using ParaBankSite.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ParaBankSite.Steps
{
    public class UpdateProfileTest
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
            //Service.CloseDriver();
        }
        [Test]
        public static void Update()
        {
            LoginPage.CustomerLogin();
            Thread.Sleep(1000);
            UpdateContactInfo.UpdateProfile();
            // verify
            //IWebElement Profile_updated = Service.driver.FindElement(By.XPath("//*[@id='rightPanel']/div/div/h1"));

            IWebElement Profile_updated = Service.driver.FindElement(By.XPath("//*[@id='rightPanel']/div/div/h1"));
         
            string ProUpdated = Profile_updated.Text;
            Thread.Sleep(1000);

            Console.WriteLine(ProUpdated);



        }
    }

}
