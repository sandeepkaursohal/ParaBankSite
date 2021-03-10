using OpenQA.Selenium;
using ParaBankSite.Common_Lib;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParaBankSite.Pages
{
    class WelcomePage
    {
        public static string AccountCreated()
        {
            var MyWelcomeWebElement = Service.driver.FindElement(By.XPath("//h1[contains(text(),'Welcome Sandeep')]"));
            string WelcomeText = MyWelcomeWebElement.Text;

            return WelcomeText;
        }
    }
}
