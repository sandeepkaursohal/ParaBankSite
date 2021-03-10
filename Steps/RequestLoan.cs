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
          
            RequestLoanPage.ReqLoan();
            //Verify text
           

        }

    }
}
