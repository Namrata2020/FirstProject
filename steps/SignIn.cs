using NUnitTestProject1.Pages;
using NUnitTestProject1.TestBase;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace NUnitTestProject1.steps
{
    [Binding]
    public sealed class SignIn : Base
    {
       
        SignInPage page;


       [Given(@"user open browser for POM")]
        public void GivenUserOpenBrowserForPOM()
        {
            Setup();
            page = new SignInPage(driver);
        }

        [Given(@"user open url")]
        public void GivenUserOpenUrl()
        {
            driver.Url = "https://www.google.com/";
        }


        [When(@"user enter ""(.*)""")]
        public void WhenUserEnter(string text)
        {
           page.SendTextInSearchField(text);
        }

        [Then(@"user navigate to another page")]
        public void ThenUserNavigateToAnotherPage()
        {
            Console.WriteLine(driver.Title);
            Teardown();
        }


    }
}
