using NUnit.Framework;
using ParaBankSite.Common_Lib;
using ParaBankSite.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParaBankSite.Parallel_Tests
{
    public class ParallelLoginTestPositive
    {

        string Appurl = "https://parabank.parasoft.com/";

        [Test]
        [Parallelizable]


        public void Login_TC01()
        {
            String[] Browsers = { "Chrome" };

            foreach (String drivers in Browsers)
            {
                Service.StartBrowser(drivers, Appurl);
                LoginPage.CustomerLogin();
            }
        }

        [Test]
        [Parallelizable]
        public void Login_TC02()
        {
            String[] Browsers = { "Firefox" };
            foreach (String drivers in Browsers)
            {
                Service.StartBrowser(drivers, Appurl);
                LoginPage.CustomerLogin();
            }
        }

    }
}