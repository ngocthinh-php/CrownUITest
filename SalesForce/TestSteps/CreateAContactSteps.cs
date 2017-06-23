namespace SalesForce.TestSteps
{
    #region Using Directives
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
    using SalesForce.Hooks;
    #endregion

    [Binding]
    public sealed class CreateAContactSteps
    {
        [Given(@"I am on Contact Page")]
        public void GivenIAmOnContactPage()
        {
            TestBase.landing.ClickOnContactsTab();
            Thread.Sleep(2000);
            TestBase.contacts.VerifyPage();
            Thread.Sleep(2000);
            TestBase.contacts.ClickOnNewButton();
            Thread.Sleep(2000);
            //TestBase.contactEdit.VerifyPage();
            //Thread.Sleep(2000);

        }

     
        [When(@"I enter new contact details (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*) and save the record")]
        public void WhenIEnterNewContactDetailsTestContactActiveTestContactMailinator_ComCustomerAndSaveTheRecord(string firstName, string lastName, string jobTitle, string department, string contactType, string mktgCampaignRef, string status, string telephone, string extension, string mobile, string email, string addnlemail, string orgName, string country, string addressLine, string townCity, string county, string postcode)
        {
            
            TestBase.contactEdit.EnterFirstName(firstName);
            //Thread.Sleep(2000);
            TestBase.contactEdit.EnterLastName(lastName);
            //Thread.Sleep(2000);
            TestBase.contactEdit.EnterJobTitle(jobTitle);
            TestBase.contactEdit.EnterDepartment(department);
            
            TestBase.contactEdit.SelectContactType(contactType);
            Thread.Sleep(2000);
            TestBase.contactEdit.EnterMarketingCampaignReference(mktgCampaignRef);
            TestBase.contactEdit.SelectStatus(status);
            Thread.Sleep(2000);
            TestBase.contactEdit.EnterTelephone(telephone);
            //Thread.Sleep(2000);
            TestBase.contactEdit.EnterExtension(extension);
            TestBase.contactEdit.EnterMobileNumber(mobile);
            //Thread.Sleep(2000);
            TestBase.contactEdit.EnterEmailAddress(email);
            //Thread.Sleep(2000);
            TestBase.contactEdit.EnterAdditionalEmailAddress(addnlemail);
            TestBase.contactEdit.EnterOrganisationName(orgName);
            //Thread.Sleep(2000);
            TestBase.contactEdit.SelectCountry(country);
            Thread.Sleep(2000);
            TestBase.contactEdit.EnterAddressLine(addressLine);
            TestBase.contactEdit.EnterTownOrCity(townCity);
            Thread.Sleep(2000);
            TestBase.contactEdit.SelectCounty(county);
            Thread.Sleep(2000);
            TestBase.contactEdit.EnterPostCode(postcode);
            TestBase.contactEdit.ClickOnBottomSaveButton();
            Thread.Sleep(2000);
        }

        [Then(@"contact record should be created successfully")]
        public void ThenContactRecordShouldBeCreatedSuccessfully()
        {
            TestBase.contactRecord.VerifyPage();
            //Console.WriteLine("Record Created Successfully");
        }
    }
}
