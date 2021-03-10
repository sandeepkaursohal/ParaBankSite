using OpenQA.Selenium;
using ParaBankSite.Common_Lib;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ParaBankSite.Pages
{
    public class HomePage
    {
        public static void RG_TC01_POS()
        {

            IWebElement registerLink = Service.driver.FindElement(By.XPath("//a[contains(text(),'Register')]"));
            registerLink.Click();
            Thread.Sleep(5000);

            IWebElement firstName = Service.driver.FindElement(By.XPath("//input[@id='customer.firstName' or @name='customer.firstName']"));
            IWebElement lastName = Service.driver.FindElement(By.XPath("//input[@id='customer.lastName']"));
            IWebElement address = Service.driver.FindElement(By.XPath("//input[@id='customer.address.street']"));
            IWebElement city = Service.driver.FindElement(By.XPath("//input[@id='customer.address.city']"));
            IWebElement state = Service.driver.FindElement(By.XPath("//input[@id='customer.address.state']"));
            IWebElement zipCode = Service.driver.FindElement(By.XPath("//input[@id='customer.address.zipCode']"));
            IWebElement phoneNumber = Service.driver.FindElement(By.XPath("//input[@id='customer.phoneNumber']"));
            IWebElement SSN = Service.driver.FindElement(By.XPath("//input[@id='customer.ssn']"));
            IWebElement userName = Service.driver.FindElement(By.XPath("//input[@id='customer.username']"));
            IWebElement password = Service.driver.FindElement(By.XPath("//input[@id='customer.password']"));
            IWebElement confirm = Service.driver.FindElement(By.XPath("//input[@id='repeatedPassword']"));
            IWebElement registerButton = Service.driver.FindElement(By.XPath("//input[@value='Register']"));

    

            firstName.SendKeys("Sandeep");
            lastName.SendKeys("Kaur");
            address.SendKeys("203, 1 Griffiths Street");
            city.SendKeys("Blacktown");
            state.SendKeys("NSW");
            zipCode.SendKeys("2148");
            phoneNumber.SendKeys("0434191820");
            SSN.SendKeys("123");
            userName.SendKeys("sandeepkk");
            password.SendKeys("12345");
            confirm.SendKeys("12345");
           registerButton.Click();

            Thread.Sleep(4000);

            /* String Title = Service.driver.Title;
            Console.WriteLine(Title);

            if (Title.Equals("ParaBank | Customer Created"))
            {
                Console.WriteLine("RG_TC_POS:- Test Passed");
            }
            else 
            {
                Console.WriteLine("RG_TC_POS:- Test Failed");
            }*/
        }

    
        public static void RG_TC01_NEG()
        {

            IWebElement registerLink = Service.driver.FindElement(By.XPath("//a[contains(text(),'Register')]"));
            registerLink.Click();
            Thread.Sleep(5000);

            IWebElement firstName = Service.driver.FindElement(By.XPath("//input[@id='customer.firstName']"));
            IWebElement lastName = Service.driver.FindElement(By.XPath("//input[@id='customer.lastName']"));
            IWebElement address = Service.driver.FindElement(By.XPath("//input[@id='customer.address.street']"));
            IWebElement city = Service.driver.FindElement(By.XPath("//input[@id='customer.address.city']"));
            IWebElement state = Service.driver.FindElement(By.XPath("//input[@id='customer.address.state']"));
            IWebElement zipCode = Service.driver.FindElement(By.XPath("//input[@id='customer.address.zipCode']"));
            IWebElement phoneNumber = Service.driver.FindElement(By.XPath("//input[@id='customer.phoneNumber']"));
            IWebElement SSN = Service.driver.FindElement(By.XPath("//input[@id='customer.ssn']"));
            IWebElement userName = Service.driver.FindElement(By.XPath("//input[@id='customer.username']"));
            IWebElement password = Service.driver.FindElement(By.XPath("//input[@id='customer.password']"));
            IWebElement confirm = Service.driver.FindElement(By.XPath("//input[@id='repeatedPassword']"));
            IWebElement registerButton = Service.driver.FindElement(By.XPath("//input[@value='Register']"));

        

            firstName.SendKeys("Sandeep");
            lastName.SendKeys("Kaur");
            address.SendKeys("203, 1 Griffiths Street");
            city.SendKeys("Blacktown");
            state.SendKeys("NSW");
            zipCode.SendKeys("2148");
            phoneNumber.SendKeys("0434191820");
            SSN.SendKeys("123");
            userName.SendKeys("sandeep");
            password.SendKeys("12345");
            confirm.SendKeys("123456");
            registerButton.Click();
            
            String Title = Service.driver.Title;
            Console.WriteLine(Title);

            if (Title.Equals("ParaBank | Register for Free Online Account Access"))
            {
                Console.WriteLine("RG_TC_NEG:- Test Passed");
            }
        }

        
    }
}

