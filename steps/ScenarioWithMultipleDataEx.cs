using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace NUnitTestProject1.steps
{
    [Binding]
    public sealed class ScenarioWithMultipleDataEx
    {
        [Given(@"open ch browser")]
        public void GivenOpenChBrowser()
        {
            Console.WriteLine("open ch browser");
        }

        [Given(@"enter url in search bar")]
        public void GivenEnterUrlInSearchBar(Table table)
        {
             var data  = table.CreateInstance<AddMultipleData>();

            Console.WriteLine(data.URL);
          
        }

        [When(@"enter multiple data")]
        public void WhenEnterMultipleData(Table table)
        {
            var data = table.CreateSet<AddMultipleData>();

            foreach (AddMultipleData a in data)
            {
               
                Console.WriteLine(a.name);
                Console.WriteLine(a.phoneno);
                Console.WriteLine(a.add);
            }
        }

        [Then(@"result with multiple data should be displayed")]
        public void ThenResultWithMultipleDataShouldBeDisplayed()
        {
            Console.WriteLine("result should be displayed");
        }

    }
}
