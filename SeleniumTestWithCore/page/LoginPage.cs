using OpenQA.Selenium;
//using OpenQA.Selenium.Support.PageObjects;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTestWithCore.page
{
    public class LoginPage
    {
        private IWebDriver driver;
        public LoginPage(  IWebDriver driver)
        {
            this.driver = driver;    
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//input[@name='q']")]
        public IWebElement SearchText { get; set; }
    }
}
