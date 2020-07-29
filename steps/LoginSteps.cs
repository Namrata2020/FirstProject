using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace NUnitTestProject1.steps
{
    
    [Binding]
    public sealed class LoginSteps
    {
       
        [Given(@"I launch the application")]
        public void GivenILaunchTheApplication()
        {
            Console.WriteLine("launch the app");
        }

        [Given(@"I have enter login details")]
        public void GivenIHaveEnterLoginDetails()
        {
            Console.WriteLine("enter the login details");
        }



        [Then(@"I should see Employee details link")]
        public void ThenIShouldSeeEmployeeDetailsLink()
        {
            
        }


    }
}
