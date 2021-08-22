using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumTestWithCore.helpers;
using SeleniumTestWithCore.page;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SeleniumTestWithCore.test
{
    [TestFixture]
    public class LoginTest : Base
    {
        //[Test,Category("Smoke Testing")]
        //public void Login()
        //{
        //    Console.WriteLine(driver.Title);
        //    IWebElement element = driver.FindElement(By.XPath("//input[@name='q']"));
        //    element.SendKeys("Selenium WebDriver");
            

        //}
        //[Test, Category("Smoke Testing")]
        //public void Login2()
        //{
        //    Console.WriteLine(driver.Title);
        //    IWebElement element = driver.FindElement(By.XPath("//input[@name='q']"));
        //    element.SendKeys("Selenium WebDriver");


        //}
        [Test, Category("Regression Testing")]
        public void Login3()
        {
            LoginPage login = new LoginPage(driver);
            login.SearchText.SendKeys("Login Test by using POM");
            Console.WriteLine(driver.Title);

            //IWebElement element = driver.FindElement(By.XPath("//input[@name='q']"));
            //element.SendKeys("Selenium WebDriver");


        }
        //[Test, Category("Smoke Testing")]
        //public void Login4()
        //{
        //    Console.WriteLine(driver.Title);
        //    IWebElement element = driver.FindElement(By.XPath("//input[@name='q']"));
        //    element.SendKeys("Selenium WebDriver");


        //}
    }
}
