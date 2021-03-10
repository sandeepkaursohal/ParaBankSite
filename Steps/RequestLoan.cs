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
    public class RequestLoan
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
            //Service.driver.Close();

        }
        [Test]
        public static void Req_Loan()
        {
            LoginPage.CustomerLogin();
           
            Service.driver.FindElement(By.LinkText("Request Loan")).Click();
            Thread.Sleep(2000);

            Service.driver.FindElement(By.XPath("//input[@id='amount']")).SendKeys("200");
            Service.driver.FindElement(By.XPath("//input[@id='downPayment']")).SendKeys("100");
            Service.driver.FindElement(By.XPath("//input[@type='submit']")).Submit();

            //Verify text
            IWebElement Processed = Service.driver.FindElement(By.XPath("//*[@id='rightPanel']/div/div/h1"));
            //Loan Request Processed
            string LoanRP = Processed.Text;

            Console.WriteLine("Success Message after Request Loan: " + LoanRP);
           // Console.WriteLine(LoanRP);

        }

    }
}
