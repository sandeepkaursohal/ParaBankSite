using NUnit.Framework;
using OpenQA.Selenium;
using ParaBankSite.Common_Lib;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ParaBankSite.Pages
{
    public class RequestLoanPage
    {

        public static void ReqLoan()
        {

            LoginPage.CustomerLogin();
            Service.driver.FindElement(By.LinkText("Request Loan")).Click();
            //Thread.Sleep(2000);

            Service.driver.FindElement(By.XPath("//input[@id='amount']")).SendKeys("200");
            Service.driver.FindElement(By.XPath("//input[@id='downPayment']")).SendKeys("100");
            Service.driver.FindElement(By.XPath("//input[@type='submit']")).Submit();

       
            IWebElement Processed = Service.driver.FindElement(By.XPath("//*[@id='rightPanel']/div/div/h1"));
            //Print text should be - Loan Request Processed

            //string LoanRP = Processed.Text;
            string LoanRP = Processed.GetAttribute("text");

            // Console.WriteLine("Success Message after Request Loan: " + LoanRP);
            Console.WriteLine(LoanRP);


        }
    }
}
