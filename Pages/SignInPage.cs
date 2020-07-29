using NUnitTestProject1.TestBase;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace NUnitTestProject1.Pages
{
    class SignInPage : Base
    {

        IWebDriver driver;
        

        public SignInPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        IWebElement element => driver.FindElement(By.XPath("//input[@type=\"text\"]"));

        public void SendTextInSearchField(String text)
        {
            Thread.Sleep(3000);
            element.SendKeys(text);
        }


    }
}
