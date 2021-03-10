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
    public class BillPay
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
        public static void Bill_Pay()
        {
            LoginPage.CustomerLogin();
            Thread.Sleep(2000);

            Service.driver.FindElement(By.XPath("//*[@id='leftPanel']/ul/li[4]/a")).Click();
            IWebElement pagetitle = Service.driver.FindElement(By.XPath("//*[@id='rightPanel']/div/div[1]/h1"));
            
            string p_title = pagetitle.Text;

            Console.WriteLine("Title of Page when clicked at Bill Pay: " + p_title);
            IWebElement PayeeName = Service.driver.FindElement(By.XPath("//*[@id='rightPanel']/div/div[1]/form/table/tbody/tr[1]/td[2]/input"));
            PayeeName.SendKeys("John");

            IWebElement Address = Service.driver.FindElement(By.XPath("//*[@id='rightPanel']/div/div[1]/form/table/tbody/tr[2]/td[2]/input"));
            Address.SendKeys("Lock street");

            IWebElement City = Service.driver.FindElement(By.XPath("//*[@id='rightPanel']/div/div[1]/form/table/tbody/tr[3]/td[2]/input"));
            City.SendKeys("Sydney");

            IWebElement State = Service.driver.FindElement(By.XPath("//*[@id='rightPanel']/div/div[1]/form/table/tbody/tr[4]/td[2]/input"));
            State.SendKeys("QLD");

            IWebElement ZipCode = Service.driver.FindElement(By.XPath("//*[@id='rightPanel']/div/div[1]/form/table/tbody/tr[5]/td[2]/input"));
            ZipCode.SendKeys("4032");

            IWebElement Phone = Service.driver.FindElement(By.XPath("//*[@name='payee.phoneNumber']"));
            Phone.SendKeys("406492976");
            //Created new Account in Open New account - 13899
            Thread.Sleep(1000);
            IWebElement Account = Service.driver.FindElement(By.XPath("//input[@name='payee.accountNumber']"));
            Account.SendKeys("13899");
           
            IWebElement VerifyAccount = Service.driver.FindElement(By.XPath("//input[@name='verifyAccount']"));
            VerifyAccount.SendKeys("13899");

            IWebElement Amount = Service.driver.FindElement(By.XPath("//*[@name='amount']"));
            Amount.SendKeys("400");

            //Click Send Payment
            Service.driver.FindElement(By.XPath("//input[@value='Send Payment']")).Click();

            //Verify Bill Payment Complete 

            IWebElement BPComplete = Service.driver.FindElement(By.XPath("//*[@id='rightPanel']/div/div[2]/h1"));
            string BillPay = BPComplete.Text;

            //Console.WriteLine(BillPay);
            Console.WriteLine("Success Message after BillPay: " + BillPay);



        }
    }
}
