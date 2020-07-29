using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject1.TestBase
{
    public class Base
    {
        public IWebDriver driver;

       
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        
        public void Teardown()
        {
            driver.Quit();
        }

    }
}
