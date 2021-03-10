using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ParaBankSite.Examples
{
    class Submit
    {

        IWebDriver driver;
        [Test]
        public void Test12()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://parabank.parasoft.com/parabank/index.htm");

            IWebElement customerName = driver.FindElement(By.XPath("//input[@name='username']"));
            customerName.Clear();
            customerName.SendKeys("SS1");

            IWebElement customerpassword = driver.FindElement(By.XPath("//input[@name='password']"));
            customerpassword.Clear();
            customerpassword.SendKeys("kk");

            IWebElement loginButton = driver.FindElement(By.XPath("//input[@value='Log In']"));
            loginButton.Submit();

            //use of Web Elements command text 
            //it doesnt work for buttons only for texts and links defined inside the link text

            IWebElement Errormessage = driver.FindElement(By.XPath("//*[@class='error']"));
            string Texts = Errormessage.Text;

            Console.WriteLine(Texts);

            Thread.Sleep(4000);
        }
    }
}
  