namespace SalesForce.Pages
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
    using OpenQA.Selenium.Interactions;
    #endregion

    public class ContactsEditPage : BasePage
    {
        #region constructor
        public ContactsEditPage(IWebDriver Driver) : base(Driver)
        {          
        }
        #endregion

        #region Identify fields 
        private By _listSalutation = By.XPath("//*[@id='name_salutationcon2']");
        private By _txtFirstName = By.XPath("//*[@id='name_firstcon2']");
        private By _txtLastName = By.XPath("//*[@id='name_lastcon2']");
        private By _txtJobTitle = By.XPath("//*[@id='con5']");
        private By _txtDepartment = By.XPath("//*[@id='con6']");
        private By _chkBoxNotReceiveEml = By.XPath("//*[@id='00Nb0000009chgg']");
        private By _txtEmlUnqChk = By.XPath("//*[@id='00Nb0000009yeaF']");
        private By _listContactType = By.XPath("//*[@id='00Nb000000ASEWi']");
        private By _txtReportsTo = By.XPath("//*[@id='con8']");
        private By _txtMktgCampaignRef = By.XPath("//*[@id='00Nb0000009IaDp']");
        private By _listStatus = By.XPath("//*[@id='00Nb0000009cWU5']");
        private By _txtTelephone = By.XPath("//*[@id='con10']");
        private By _txtExtension = By.XPath("//*[@id='00Nb0000009ckUW']");
        private By _txtMobile = By.XPath("//*[@id='con12']");
        private By _txtEmail = By.XPath("//*[@id='con15']");
        private By _txtAdditionalEmail = By.XPath("//*[@id='00Nb000000ASEWf']");
        private By _chkBoxUsrResearchPart = By.XPath("//*[@id='00Nb000000AaUF6']");

        //private By _txtOrganisationName = By.XPath("//*[@id='ep']/div[2]/div[5]/table/tbody/tr/td[2]/div");
        private By _txtOrganisationName = By.Id("con4");

        private By _listCountry = By.XPath("//*[@id='con19country']");
        private By _txtAddressLine = By.XPath("//*[@id='con19street']");
        private By _txtTownOrCity = By.XPath("//*[@id='con19city']");
        private By _listCounty = By.XPath("//*[@id='con19state']");
        private By _txtPostCode = By.XPath("//*[@id='con19zip']");

        private By _txtNotes = By.XPath("//*[@id='00Nb0000009cWTzEAM_rta_body']");

        private By _btnSaveTop = By.XPath("//*[@id='topButtonRow']/input[1]");
        private By _btnSaveAndNewTop = By.XPath("//*[@id='topButtonRow']/input[2]");
        private By _btnCancelTop = By.XPath("//*[@id='topButtonRow']/input[3]");

        private By _btnSaveBottom = By.XPath("//*[@id='bottomButtonRow']/input[1]");
        private By _btnSaveAndNewBottom = By.XPath("//*[@id='bottomButtonRow']/input[2]");
        private By _btnCancelBottom = By.XPath("//*[@id='bottomButtonRow']/input[3]");
        #endregion

        #region Properties
        public IWebElement Title
        {
            get
            {
                return driver.FindElement(_listSalutation);
            }
        }
        public IWebElement FirstName
        {
            get
            {
                return driver.FindElement(_txtFirstName);
            }
        }
        public IWebElement LastName
        {
            get
            {
                return driver.FindElement(_txtLastName);
            }
        }
        public IWebElement JobTitle
        {
            get
            {
                return driver.FindElement(_txtJobTitle);
            }
        }
        public IWebElement Department
        {
            get
            {
                return driver.FindElement(_txtDepartment);
            }
        }
        public IWebElement NotReceiveCCSEmail
        {
            get
            {
                return driver.FindElement(_chkBoxNotReceiveEml);
            }
        }
        public IWebElement EmailUniqueCheck
        {
            get
            {
                return driver.FindElement(_txtEmlUnqChk);
            }
        }
        public IWebElement ContactType
        {
            get
            {
                return driver.FindElement(_listContactType);
            }
        }
        public IWebElement ReportsTo
        {
            get
            {
                return driver.FindElement(_txtReportsTo);
            }
        }
        public IWebElement MktgCampaignRef
        {
            get
            {
                return driver.FindElement(_txtMktgCampaignRef);
            }
        }
        public IWebElement Status
        {
            get
            {
                return driver.FindElement(_listStatus);
            }
        }
        public IWebElement Telephone
        {
            get
            {
                return driver.FindElement(_txtTelephone);
            }
        }
        public IWebElement Extension
        {
            get
            {
                return driver.FindElement(_txtExtension);
            }
        }
        public IWebElement Mobile
        {
            get
            {
                return driver.FindElement(_txtMobile);
            }
        }
        public IWebElement Email
        {
            get
            {
                return driver.FindElement(_txtEmail);
            }
        }
        public IWebElement AdditionalEmail
        {
            get
            {
                return driver.FindElement(_txtAdditionalEmail);
            }
        }
        public IWebElement UserResearchParticipant
        {
            get
            {
                return driver.FindElement(_chkBoxUsrResearchPart);
            }
        }
        public IWebElement OrganisationName
        {
            get
            {
                return driver.FindElement(_txtOrganisationName);
            }
        }
        public IWebElement Country
        {
            get
            {
                return driver.FindElement(_listCountry);
            }
        }
        public IWebElement AddressLine
        {
            get
            {
                return driver.FindElement(_txtAddressLine);
            }
        }
        public IWebElement TownOrCity
        {
            get
            {
                return driver.FindElement(_txtTownOrCity);
            }
        }
        public IWebElement County
        {
            get
            {
                return driver.FindElement(_listCounty);
            }
        }
        public IWebElement PostCode
        {
            get
            {
                return driver.FindElement(_txtPostCode);
            }
        }
        public IWebElement TXTNotes
        {
            get
            {
                return driver.FindElement(_txtNotes);
            }
        }

        public IWebElement TopSaveButton
        {
            get
            {
                return driver.FindElement(_btnSaveTop);
            }           
        }
        public IWebElement TopSaveAndNewButton
        {
            get
            {
                return driver.FindElement(_btnSaveAndNewTop);
            }
        }
        public IWebElement TopCancelButton
        {
            get
            {
                return driver.FindElement(_btnCancelTop);
            }
        }
        public IWebElement BottomSaveButton
        {
            get
            {
                return driver.FindElement(_btnSaveBottom);
            }
        }
        public IWebElement BottomSaveAndNewButton
        {
            get
            {
                return driver.FindElement(_btnSaveAndNewBottom);
            }
        }
        public IWebElement BottomCancelButton
        {
            get
            {
                return driver.FindElement(_btnCancelBottom);
            }
        }
        #endregion

        #region Public methods
        public void VerifyPage()
        {
            Assert.AreEqual("Contact Edit: New Contact ~Salesforce - Enterprise Edition", driver.Title);
        }
        public void SelectTitle(string title)
        {
            if (title != null)
            {
                var x2 = title;
                var x1 = "//*[contains(text(),'";
                var x3 = "')]";
                Thread.Sleep(3000);
                driver.FindElement(By.XPath(x1 + x2 + x3)).Click();

            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        public void EnterFirstName(string firstName)
        {
            GetDisplayedElement(_txtFirstName, 500, 15000).SendKeys(firstName);
        }
        public void EnterLastName(string lastName)
        {
            GetDisplayedElement(_txtLastName, 500, 15000).SendKeys(lastName);
        }
        public void EnterJobTitle(string jobTitle)
        {
            GetDisplayedElement(_txtJobTitle, 500, 15000).SendKeys(jobTitle);
        }
        public void EnterDepartment(string department)
        {
            GetDisplayedElement(_txtDepartment, 500, 15000).SendKeys(department);
        }
        public void ClickOnNotReceiveCCSEmailCheckBox(string emlchk)
        {
            if(emlchk == "Y")
            {
                GetDisplayedElement(_chkBoxNotReceiveEml, 500, 15000).Clear();
                GetDisplayedElement(_chkBoxNotReceiveEml, 500, 15000).Click();
            }
            else
            {
                GetDisplayedElement(_chkBoxNotReceiveEml, 500, 15000).Clear();
            }
            
        }
        public void EnterEmailUniqueCheck(string emlUnqChk)
        {
            GetDisplayedElement(_txtEmlUnqChk, 500, 15000).SendKeys(emlUnqChk);
        }
        public void SelectContactType(string contactType)
        {
            if (contactType != null)
            {
                var x2 = contactType;
                var x1 = "//*[contains(text(),'";
                var x3 = "')]";
                Thread.Sleep(3000);
                driver.FindElement(By.XPath(x1 + x2 + x3)).Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        public void EnterReportsTo(string reportsTo)
        {
            GetDisplayedElement(_txtReportsTo, 500, 15000).SendKeys(reportsTo);
        }
        public void EnterMarketingCampaignReference(string mktgCmpgnRef)
        {
            GetDisplayedElement(_txtMktgCampaignRef, 500, 15000).SendKeys(mktgCmpgnRef);
        }
        public void SelectStatus(string status)
        {
            if (status != null)
            {
                var x2 = status;
                var x1 = "//*[contains(text(),'";
                var x3 = "')]";
                Thread.Sleep(3000);
                driver.FindElement(By.XPath(x1 + x2 + x3)).Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }

        }
        public void EnterTelephone(string phone)
        {
            GetDisplayedElement(_txtTelephone, 500, 15000).SendKeys(phone);
        }
        public void EnterExtension(string extension)
        {
            GetDisplayedElement(_txtExtension, 500, 15000).SendKeys(extension);
        }
        public void EnterMobileNumber(string mobileNumber)
        {
            GetDisplayedElement(_txtMobile, 500, 15000).SendKeys(mobileNumber);
        }
        public void EnterEmailAddress(string email)
        {
            GetDisplayedElement(_txtEmail, 500, 15000).SendKeys(email);
        }
        public void EnterAdditionalEmailAddress(string addnlEmail)
        {
            GetDisplayedElement(_txtAdditionalEmail, 500, 15000).SendKeys(addnlEmail);
        }
        public void ClickOnUserResearchParticipantCheckBox(string participate)
        {
            if (participate == "Y")
            {
                GetDisplayedElement(_chkBoxUsrResearchPart, 500, 15000).Clear();
                GetDisplayedElement(_chkBoxUsrResearchPart, 500, 15000).Click();
            }
            else
            {
                GetDisplayedElement(_chkBoxUsrResearchPart, 500, 15000).Clear();
            }
        }
        public void EnterOrganisationName(string orgName)
        {
            GetDisplayedElement(_txtOrganisationName, 500, 2000).Clear();
            GetDisplayedElement(_txtOrganisationName, 500, 2000).SendKeys(orgName);
        }
        public void SelectCountry(string country)
        {
            if (country != null)
            {
                var x2 = country;
                var x1 = "//*[contains(text(),'";
                var x3 = "')]";
                Thread.Sleep(3000);
                driver.FindElement(By.XPath(x1 + x2 + x3)).Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }

        }
        public void EnterAddressLine(string addressLine)
        {
            GetDisplayedElement(_txtAddressLine, 500, 15000).SendKeys(addressLine);
        }
        public void EnterTownOrCity(string town)
        {
            GetDisplayedElement(_txtTownOrCity, 500, 15000).SendKeys(town);
        }
        public void SelectCounty(string county)
        {
            if (county != null)
            {
                var x2 = county;
                var x1 = "//*[contains(text(),'";
                var x3 = "')]";
                Thread.Sleep(3000);
                driver.FindElement(By.XPath(x1 + x2 + x3)).Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        public void EnterPostCode(string postcode)
        {
            GetDisplayedElement(_txtPostCode, 500, 15000).SendKeys(postcode);
        }
        public void EnterNotes(string notes)
        {
            GetDisplayedElement(_txtNotes, 500, 15000).SendKeys(notes);
        }

        public void ClickOnBottomSaveButton()
        {
            if (BottomSaveButton.Displayed)
            {
                BottomSaveButton.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        public void ClickOnTopSaveButton()
        {
            if (TopSaveButton.Displayed)
            {
                TopSaveButton.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        public void ClickOnBottomSaveAndNewButton()
        {
            if (BottomSaveAndNewButton.Displayed)
            {
                BottomSaveAndNewButton.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        public void ClickOnTopSaveAndNewButton()
        {
            if (TopSaveAndNewButton.Displayed)
            {
                TopSaveAndNewButton.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        public void ClickOnBottomCancelButton()
        {
            if (BottomCancelButton.Displayed)
            {
                BottomCancelButton.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        public void ClickOnTopCancelButton()
        {
            if (TopCancelButton.Displayed)
            {
                TopCancelButton.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        #endregion
    }
}
