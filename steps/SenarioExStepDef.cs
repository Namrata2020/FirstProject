using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace NUnitTestProject1.steps
{
    [Binding]
    public sealed class SenarioExStepDef
    {
        [Given(@"open chrome browser")]
        public void GivenOpenChromeBrowser()
        {
            Console.WriteLine("chrome browser open");
        }

        [Given(@"enter given url")]
        public void GivenEnterGivenUrl(Table table)
        {
            /*Console.WriteLine(table.Rows);
            Console.WriteLine("url");
           */
            var details = table.CreateInstance<EmployeeDetails>();
            Console.WriteLine(details.URL);


        }

        [When(@"enter username and password")]
        public void WhenEnterUsernameAndPassword(Table table)
        {
            /*Console.WriteLine(table.Rows);
            Console.WriteLine("username and password");
            */

            var details = table.CreateInstance<EmployeeDetails>();
            Console.WriteLine(details.username);
            Console.WriteLine(details.password);

        }

        [Then(@"sign in page should be displayed")]
        public void ThenSignInPageShouldBeDisplayed()
        {
            Console.WriteLine("sign in page should be displayed");
        }


    }
}
