using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using Login_Project.PageObjects.Login;
using NUnit.Framework;

namespace Login_Project.StepDefinitions;
[Binding]

internal class Login
{
    private readonly LoginPage _loginFeature;

    public Login(LoginPage loginFeature)
    {
        _loginFeature = loginFeature;
    }


   [Given(@"I am on Login Page")]

     public void WhenIamOnLoginPage()
     {
         _loginFeature.GotoPage();
     }

   [When(@"User enters login Details (.+)")]

     public void UserEnterDetails(string username)
     {
         _loginFeature.UserEnterDetails(username);
     }

     
   [When(@"User enters password details (.+)")]

     public void UserEnterPasswordDetails(string password) 
     {
         _loginFeature.UserEnterPasswordDetails(password);
     }

     [When(@"User click submit")]

     public void UsercClickSubmit()
     {
         _loginFeature.ClickSubmit();
     }

   [Then(@"User gets logged In")]

     public void UsergetsLoggedIn()
     {
         _loginFeature.UserLoggedIn();

     }




}

