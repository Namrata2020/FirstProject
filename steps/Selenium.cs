using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;





namespace NUnitTestProject1.steps
{
    [Binding]
    public sealed class Selenium
    {

         IWebDriver driver;

        [Given(@"open browser")]
        public void GivenOpenBrowser()
        {
           driver = new ChromeDriver();
        }

        [Given(@"enter url")]
        public void GivenEnterUrl()
        {
            driver.Url = "https://www.google.com/webhp?authuser=1";
        }

        [Then(@"page should display")]
        public void ThenPageShouldDisplay()
        {
                                                                
           

        }

    }
}
