using NUnit.Framework;
using ParaBankSite.Common_Lib;
using ParaBankSite.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ParaBankSite.Steps
{
    public class Registration_Test
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
        public void Register()
        {
            //RG_TC01_POS();
            //RG_TC01_NEG();
            Thread.Sleep(3000);
            HomePage.RG_TC01_POS();
            //HomePage.RG_TC01_NEG();
            String aText = WelcomePage.AccountCreated();
            String expText = "Welcome Sandeep";

         

            Verify.Text(expText, aText);
           

        }
    }
}
