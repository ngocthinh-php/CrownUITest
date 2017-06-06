namespace SalesForce.Pages
{
    #region Using Directives
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using OpenQA.Selenium;
    using NUnit.Framework;
    using System.Threading;
    #endregion

    public class OrganisationRecordPage : BasePage
    {
        #region constructor
        public OrganisationRecordPage(IWebDriver Driver) : base(Driver)
        {
        }
        #endregion

        #region Properties and fields
        private By _lblOrganisationNameHeader = By.XPath("//*[@id='contactHeaderRow']/div[2]/h2");
        private By _tabFeed = By.XPath("//*[@id='efpViews_0014E00000XY6VH_option0']");
        private By _tabDetails = By.XPath("//*[@id='efpViews_0014E00000XY6VH_option1']");
        private By _btnEditTop = By.XPath("//*[@id='topButtonRow']/input[3]");
        private By _btnEditBottom = By.XPath("//*[@id='bottomButtonRow']/input[3]");
        private By _btnDeleteTop = By.XPath("//*[@id='topButtonRow']/input[4]");
        private By _btnDeleteBottom = By.XPath("//*[@id='bottomButtonRow']/input[4]");
        private By _btnSharingTop = By.XPath("//*[@id='topButtonRow']/input[5]");
        private By _btnSharingBottom = By.XPath("//*[@id='bottomButtonRow']/input[5]");
        private By _btnAddressFinderTop = By.XPath("//*[@id='topButtonRow']/input[6]");
        private By _btnAddressFinderBottom = By.XPath("//*[@id='bottomButtonRow']/input[6]");
        private By _lblOrganisationRecordType = By.XPath("//*[@id='RecordType_ileinner']");
        private By _lblOrganisationName = By.XPath("//*[@id='acc2_ileinner']");
        private By _lblStatus = By.XPath("//*[@id='00Nb0000009cWS7_ileinner']");
        private By _frameCases = By.XPath("//*[@id='0014E00000XY6VH_RelatedCaseList']/div[1]/div");
        private By _frameOpenActivities = By.XPath("//*[@id='0014E00000XY6VH_RelatedActivityList']/div[1]/div");
        private By _frameRisksAndIssues = By.XPath("//*[@id='0014E00000XY6VH_00Nb000000ASETq']/div[1]/div");
        private By _frameContacts = By.XPath("//*[@id='0014E00000XY6VH_RelatedContactList']/div[1]/div");
        private By _frameNotesAndAttachments = By.XPath("//*[@id='0014E00000XY6VH_RelatedNoteList']/div[1]/div");
        private By _frameOrganisationHistory = By.XPath("//*[@id='0014E00000XY6VH_RelatedEntityHistoryList']/div[1]/div");
        private By _frameFrameworkInterests = By.XPath("//*[@id='0014E00000XY6VH_00N4E000000wrEs']/div[1]/div");
        private By _btnNewCase = By.XPath("//*[@id='0014E00000XY6VH_RelatedCaseList']/div[1]/div/div[1]/table/tbody/tr/td[2]/input");
        private By _btnNewTask = By.XPath("//*[@id='0014E00000XY6VH_RelatedActivityList']/div[1]/div/div[1]/table/tbody/tr/td[2]/input[1]");
        private By _btnNewEvent = By.XPath("//*[@id='0014E00000XY6VH_RelatedActivityList']/div[1]/div/div[1]/table/tbody/tr/td[2]/input[2]");
        private By _btnNewRisksAndIssues = By.XPath("//*[@id='0014E00000XY6VH_00Nb000000ASETq']/div[1]/div/div[1]/table/tbody/tr/td[2]/input");
        private By _btnNewContact = By.XPath("//*[@id='0014E00000XY6VH_RelatedContactList']/div[1]/div/div[1]/table/tbody/tr/td[2]/input[1]");
        private By _btnMergeContacts = By.XPath("//*[@id='0014E00000XY6VH_RelatedContactList']/div[1]/div/div[1]/table/tbody/tr/td[2]/input[2]");
        private By _btnLogACall = By.XPath("//*[@id='0014E00000XY6VH_RelatedHistoryList']/div[1]/div/div[1]/table/tbody/tr/td[2]/input");
        private By _btnNewContract = By.XPath("//*[@id='0014E00000XY6VH_00Nb000000ASESs']/div[1]/div/div[1]/table/tbody/tr/td[2]/input");
        private By _btnNewNote = By.XPath("//*[@id='0014E00000XY6VH_RelatedNoteList']/div[1]/div/div[1]/table/tbody/tr/td[2]/input[1]");
        private By _btnAttachFile = By.XPath("//*[@id='0014E00000XY6VH_RelatedNoteList']/div[1]/div/div[1]/table/tbody/tr/td[2]/input[2]");
        private By _btnNewFrameworkInterest = By.XPath("//*[@id='0014E00000XY6VH_00N4E000000wrEs']/div[1]/div/div[1]/table/tbody/tr/td[2]/input");
        #endregion

        #region define element attributes
        public IWebElement OrganisationNameHeader
        {
            get
            {
                return driver.FindElement(_lblOrganisationNameHeader);
            }
        }
        public IWebElement FeedTab
        {
            get
            {
                return driver.FindElement(_tabFeed);
            }
        }
        public IWebElement DetailsTab
        {
            get
            {
                return driver.FindElement(_tabDetails);
            }
        }
        #endregion

        #region public method
        public void VerifyPage(string organisationName)
        {
            Assert.AreEqual(organisationName, OrganisationNameHeader.Text);
        }
        public void VerifyNewOrganisationPage(string organisationName)
        {
            Assert.AreEqual(("'Organisation: '+ organisationName + ' ~ Salesforce - Enterprise Edition'"), driver.Title);
        }
        
        #endregion
    }
}
