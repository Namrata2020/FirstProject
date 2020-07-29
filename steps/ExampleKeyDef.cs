using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace NUnitTestProject1.steps
{
    [Binding]
    public sealed class ExampleKeyDef
    {
        IWebDriver driver;

        [Given(@"user is on browser")]
        public void GivenUserIsOnBrowser()
        {
            driver = new ChromeDriver();
        }

        [Given(@"user hit the url")]
        public void GivenUserHitTheUrl()
        {
            driver.Url = "https://www.google.com/search?q=selenium+test+site&oq=selenium+test+site&aqs=chrome..69i57.8296j0j7&sourceid=chrome&ie=UTF-8";
        }

        


        [When(@"enter ""(.*)"" and ""(.*)""")]
        public void WhenEnterAnd(string mailid, string password)
        {
            Thread.Sleep(5000);
            IWebElement element = driver.FindElement(By.XPath("//a[@class=\"gb_4 gb_5 gb_re gb_6c\"]"));
            element.Click();

            Thread.Sleep(5000);
            element = driver.FindElement(By.XPath("//input[@autocomplete=\"username\"]"));
            element.SendKeys(mailid);


        }






        [Then(@"the result should be show")]
        public void ThenTheResultShouldBeShow()
        {
            Console.WriteLine(driver.Title);
        }

    }
}
