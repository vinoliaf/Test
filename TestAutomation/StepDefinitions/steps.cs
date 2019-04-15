using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace TestAutomation.StepDefinitions
{
    [Binding]
    class steps
    {
    
            [Given(@"Policy Wise Web page")]
            public void GivenPolicyWiseWebPage()
            {
            Console.Out.WriteLine("Given");
            }

            [When(@"I Click on the Get Quote button for Modern Car")]
            public void WhenIClickOnTheGetQuoteButtonForModernCar()
            {
            Console.Out.WriteLine("When");
        }

            [Then(@"I Should be able to fill all fields on Vehicle details page")]
            public void ThenIShouldBeAbleToFillAllFieldsOnVehicleDetailsPage()
            {
            Console.Out.WriteLine("Then");
        }
        
    }
}
