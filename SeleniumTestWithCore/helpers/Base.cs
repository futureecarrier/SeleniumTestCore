using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumTestWithCore.helpers
{
    [TestFixture]
    public class Base
    {
       public  IWebDriver driver;

        public Base()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
        }
        [OneTimeSetUp]
        public void Setup()
        {
           
           
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Url = "https://www.google.com/";
        }
        [OneTimeTearDown]
        public void Teardown()
        {
            Thread.Sleep(5000);
           // driver.Quit();
        }
        
    }
}
