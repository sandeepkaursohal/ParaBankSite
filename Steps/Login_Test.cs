using NUnit.Framework;
using ParaBankSite.Common_Lib;
using ParaBankSite.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParaBankSite.Steps
{
    public class Login_Test
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
        public static void LoginCustomer()
        {
            LoginPage.CustomerLogin();
            String aText = AccountsOverviewPage.AccountStatus();
            String expText = "Accounts Overvieww";
            Verify.Text(expText, aText);

         
        }
    }

}
