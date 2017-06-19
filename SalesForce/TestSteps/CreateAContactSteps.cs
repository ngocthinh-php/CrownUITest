using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using SalesForce.Pages;
using TechTalk.SpecFlow;

namespace SalesForce.TestSteps
{
    class CreateAContactSteps
    {
        [Given(@"I am on Contact Page")]
        public void GivenIAmOnContactPage()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I should be directed to Contact Edit Page")]
        public void ThenIShouldBeDirectedToContactEditPage()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I enter new contact details")]
        public void WhenIEnterNewContactDetails()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"contact record should be created successfully")]
        public void ThenContactRecordShouldBeCreatedSuccessfully()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
