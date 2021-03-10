using OpenQA.Selenium;
using ParaBankSite.Common_Lib;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ParaBankSite.Pages
{
    public class UpdateContactInfo
    {
        public static void UpdateProfile()
        {

            Service.driver.FindElement(By.XPath("//a[contains(text(),'Update Contact Info')]")).Click();
            IWebElement custfirstName = Service.driver.FindElement(By.Name("customer.firstName"));
            IWebElement custlastName = Service.driver.FindElement(By.Name("customer.lastName"));
            IWebElement custAdd = Service.driver.FindElement(By.XPath("//input[@id='customer.address.street']"));
            IWebElement custCity= Service.driver.FindElement(By.XPath("//input[@id='customer.address.city']"));
            IWebElement custState = Service.driver.FindElement(By.XPath("//input[@id='customer.address.state']"));
            IWebElement custZipCode = Service.driver.FindElement(By.XPath("//input[@id='customer.address.zipCode']"));
            IWebElement custPhone = Service.driver.FindElement(By.XPath("//input[@id='customer.phoneNumber']"));
            IWebElement UpdateProfileButton = Service.driver.FindElement(By.XPath("//input[@value='Update Profile']"));


            custfirstName.Clear();
            custfirstName.SendKeys("Sandeep Kaur");

            custlastName.Clear();
            custlastName.SendKeys("Sohal");

            custAdd.Clear();
            custAdd.SendKeys("Glenwood");

            custCity.Clear();
            custCity.SendKeys("Sydney");

            custState.Clear();
            custState.Click();
            custState.SendKeys("NSW");

            custZipCode.Clear();
            custZipCode.SendKeys("2148");

            custPhone.Clear();
            //custPhone.Click();
            custPhone.SendKeys("0434191820");

            UpdateProfileButton.Click();


        }
    }
}
