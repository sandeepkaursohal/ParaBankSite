using OpenQA.Selenium;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Chrome;

namespace ParaBankSite.Examples
{
    public class AssinmentEnabledBtnandText
    {
        IWebDriver driver;
       
        [Test]
        public void logincheck()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://parabank.parasoft.com/parabank/index.htm");
            IWebElement Uname = driver.FindElement(By.XPath("//*[@id='loginPanel']/form/div[1]/input"));
            IWebElement Passwd = driver.FindElement(By.XPath("//*[@id='loginPanel']/form/div[2]/input"));
            IWebElement Login = driver.FindElement(By.XPath("//input[@value='Log In']"));
            string user_textvalue = driver.FindElement(By.XPath("//*[@id='loginPanel']/form/p[1]/b")).Text;
            string pass_textvalue = driver.FindElement(By.XPath("//*[@id='loginPanel']/form/p[2]/b")).Text;

            Boolean CheckUname = Uname.Displayed;
            Boolean CheckPasswd = Passwd.Displayed;
            Boolean LogInBtn = Login.Displayed;


            Console.WriteLine("Text Value in Username is : " + user_textvalue);
            Console.WriteLine("Username input field Displayed ?" + CheckUname);



            Console.WriteLine("Text Value in Password is : " + pass_textvalue);
            Console.WriteLine("Password input field Displayed ?" + CheckPasswd);

         
            
            Console.WriteLine("Login Button Displayed ?" + LogInBtn);


        }



    }
}
