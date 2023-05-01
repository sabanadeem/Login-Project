using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Login_Project.Wrapper;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Login_Project.PageObjects.Login
{
    internal class LoginPage
    {
        private readonly IWebDriver _webDriver;
        private readonly WrappedWebDriver _wrappedWebDriver;

        
        public LoginPage(IWebDriver webDriver, WrappedWebDriver wrappedWebDriver)
        {
            _webDriver = webDriver;
            _wrappedWebDriver = wrappedWebDriver;
        }

        private static readonly By Email = By.CssSelector("#email");
        private static readonly By Password = By.CssSelector("#password");
        private static readonly By Submit = By.CssSelector("#logIn");

        public void GotoPage()
        {
            _webDriver.Navigate().GoToUrl("https://www.hudl.com/login");
           // _webDriver.Manage().Window.Maximize();
            
        }

        public void UserEnterDetails(string name)
        {

            var element = _wrappedWebDriver.Wait(d => d.FindElement(Email));
            element.Click();
            element.SendKeys(name);
        }

        public void UserEnterPasswordDetails(string PasswordCredential)
        {
            
            var password_element = _wrappedWebDriver.Wait(d => d.FindElement(Password));
            password_element.Click();
            password_element.SendKeys(PasswordCredential);

        }

        public void ClickSubmit()
        {
           var submit_element = _wrappedWebDriver.Wait(d => d.FindElement(Submit));
            submit_element.Click();
        }

        public void UserLoggedIn()
        {
            
            var element = _wrappedWebDriver.Wait(d => d.FindElement(By.CssSelector("#feed_w > div > div > div.content.js-explore-tabs-content > div > div > div > div")));
            Assert.That(element.Displayed,Is.True);


        }
    }
}

