using OpenQA.Selenium;
using ParaBankSite.Common_Lib;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParaBankSite.Pages
{
    class AccountsOverviewPage
    {
        public static string AccountStatus()
        {
            var MyAccountWebElement = Service.driver.FindElement(By.XPath("//h1[contains(text(),'Accounts Overview')]"));
            string statusText = MyAccountWebElement.Text;
            return statusText;
        }
    }
}
