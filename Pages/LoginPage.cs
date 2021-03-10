using OpenQA.Selenium;
using ParaBankSite.Common_Lib;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ParaBankSite.Pages
{
    public class LoginPage
    {
        public static void CustomerLogin()
        {
            IWebElement customerName = Service.driver.FindElement(By.Name("username"));
            customerName.Clear();
            customerName.SendKeys("SS");

            IWebElement customerpassword = Service.driver.FindElement(By.Name("password"));
            customerpassword.Clear();
            customerpassword.SendKeys("kk");

            IWebElement loginButton = Service.driver.FindElement(By.XPath("//input[@value='Log In']"));
            loginButton.Click();

            Thread.Sleep(4000);

        }
    }
}
