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
    using OpenQA.Selenium.Support.UI;
    #endregion

    public class OrganisationEditPage : BasePage
    {
        #region Constructor
        public OrganisationEditPage(IWebDriver Driver) : base(Driver)
        {
        }
        #endregion

        #region Properties and fields
        private By _lblOrganisationRecordType = By.XPath("//*[@id='ep']/div[2]/div[2]/table/tbody/tr[1]/td[2]");
        private By _txtOrganisationName = By.XPath("//*[@id='acc2']");
        private By _txtOrganisationAbbreviation = By.XPath("//*[@id='00Nb0000009cWRw']");
        private By _txtParentOrganisation = By.XPath("//*[@id='acc3']");
        private By _imgSearchParentOrganisation = By.XPath("//*[@id='acc3_lkwgt']/img");
        private By _txtRelationshipToParent = By.XPath("//*[@id='00Nb000000ASESL']");
        private By _lstSector = By.XPath("//*[@id='00Nb0000009cWS5']");
        private By _lstOrganisationType = By.XPath("//*[@id='00Nb0000009cWS8']");
        private By _lstCCSExecutiveSponsor = By.XPath("//*[@id='CF00Nb000000ASESB_mlktp']");
        private By _txtCCSExecutiveSponsor = By.XPath("//*[@id='CF00Nb000000ASESB']");
        private By _imgCCSExecutiveSponsor = By.XPath("//*[@id='CF00Nb000000ASESB_lkwgt']/img");
        private By _lstCCSSavingsLead = By.XPath("//*[@id='CF00Nb000000ASESA_mlktp']");
        private By _txtCCSSavingsLead = By.XPath("//*[@id='CF00Nb000000ASESA']");
        private By _imgCCSSavingsLead = By.XPath("//*[@id='CF00Nb000000ASESA_lkwgt']/img");
        private By _lstStatus = By.XPath("//*[@id='00Nb0000009cWS7']");
        private By _txtSpendThisFy = By.XPath("//*[@id='00Nb0000009cWS6']");
        private By _txtMarketingCampaignReference = By.XPath("//*[@id='00N4E000000wrEu']");
        private By _lstCountry = By.XPath("//*[@id='acc17country']");
        private By _txtStreet = By.XPath("//*[@id='acc17street']");
        private By _txtCity = By.XPath("//*[@id='acc17city']");
        private By _lstCounty = By.XPath("//*[@id='acc17state']");
        private By _txtPostCode = By.XPath("//*[@id='acc17zip']");
        private By _txtWebsite = By.XPath("//*[@id='acc12']");
        private By _btnSaveTop = By.XPath("//*[@id='topButtonRow']/input[1]");
        private By _btnSaveAndNewTop = By.XPath("//*[@id='topButtonRow']/input[2]");
        private By _btnCancelTop = By.XPath("//*[@id='topButtonRow']/input[3]");
        private By _btnSaveBottom = By.XPath("//*[@id='bottomButtonRow']/input[1]");
        private By _btnSaveAndNewBottom = By.XPath("//*[@id='bottomButtonRow']/input[2]");
        private By _btnCancelBottom = By.XPath("//*[@id='bottomButtonRow']/input[3]");
        private By _txtDUNSNumber = By.XPath("//*[@id='00Nb000000ASESE']");
        private By _txtIndirectSME = By.XPath("//*[@id='00N7E0000017tSI']");
        #endregion

        #region define element attributes
        public IWebElement OrganisationRecordType
        {
            get
            {
                return driver.FindElement(_lblOrganisationRecordType);
            }
        }
        public IWebElement OrganisationName
        {
            get
            {
                return driver.FindElement(_txtOrganisationName);
            }
        }
        public IWebElement OrganisationAbbreviation
        {
            get
            {
                return driver.FindElement(_txtOrganisationAbbreviation);
            }
        }
        public IWebElement ParentOrganisation
        {
            get
            {
                return driver.FindElement(_txtParentOrganisation);
            }
        }
        public IWebElement SearchParentOrganisation
        {
            get
            {
                return driver.FindElement(_imgSearchParentOrganisation);
            }
        }
        public IWebElement RelationshipToParent
        {
            get
            {
                return driver.FindElement(_txtRelationshipToParent);
            }
        }
        public IWebElement Sector
        {
            get
            {
                return driver.FindElement(_lstSector);
            }
        }
        public IWebElement OrganisationType
        {
            get
            {
                return driver.FindElement(_lstOrganisationType);
            }
        }
        public IWebElement DUNSNumber
        {
            get
            {
                return driver.FindElement(_txtDUNSNumber);
            }
        }
        public IWebElement IndirectSME
        {
            get
            {
                return driver.FindElement(_txtIndirectSME);
            }
        }
        public IWebElement CCSExecutiveSponsorList
        {
            get
            {
                return driver.FindElement(_lstCCSExecutiveSponsor);
            }
        }
        public IWebElement CCSExecutiveSponsorTxt
        {
            get
            {
                return driver.FindElement(_txtCCSExecutiveSponsor);
            }
        }
        public IWebElement CCSExecutiveSponsorImg
        {
            get
            {
                return driver.FindElement(_imgCCSExecutiveSponsor);
            }
        }
        public IWebElement CCSSavingsLeadList
        {
            get
            {
                return driver.FindElement(_lstCCSSavingsLead);
            }
        }
        public IWebElement CCSSavingsLeadText
        {
            get
            {
                return driver.FindElement(_txtCCSSavingsLead);
            }
        }
        public IWebElement CCSSavingsLeadImg
        {
            get
            {
                return driver.FindElement(_imgCCSSavingsLead);
            }
        }
        public IWebElement StatusList
        {
            get
            {
                return driver.FindElement(_lstStatus);
            }
        }
        public IWebElement SpendThisFyText
        {
            get
            {
                return driver.FindElement(_txtSpendThisFy);
            }
        }
        public IWebElement MarketingCampaignReferenceText
        {
            get
            {
                return driver.FindElement(_txtMarketingCampaignReference);
            }
        }
        public IWebElement CountryList
        {
            get
            {
                return driver.FindElement(_lstCountry);
            }
        }
        public IWebElement StreetText
        {
            get
            {
                return driver.FindElement(_txtStreet);
            }
        }
        public IWebElement CityText
        {
            get
            {
                return driver.FindElement(_txtCity);
            }
        }
        public IWebElement CountyList
        {
            get
            {
                return driver.FindElement(_lstCounty);
            }
        }
        public IWebElement PostCodeText
        {
            get
            {
                return driver.FindElement(_txtPostCode);
            }
        }
        public IWebElement WebsiteText
        {
            get
            {
                return driver.FindElement(_txtWebsite);
            }
        }
        public IWebElement TopSaveBtn
        {
            get
            {
                return driver.FindElement(_btnSaveTop);
            }
        }
        public IWebElement BottomSaveBtn
        {
            get
            {
                return driver.FindElement(_btnSaveBottom);
            }
        }
        public IWebElement TopSaveAndNewBtn
        {
            get
            {
                return driver.FindElement(_btnSaveAndNewTop);
            }
        }
        public IWebElement BottomSaveAndNewBtn
        {
            get
            {
                return driver.FindElement(_btnSaveAndNewBottom);
            }
        }
        public IWebElement CancelButtonTop
        {
            get
            {
                return driver.FindElement(_btnCancelTop);
            }
        }
        public IWebElement CancelButtonBottom
        {
            get
            {
                return driver.FindElement(_btnCancelBottom);
            }
        }
        #endregion

        #region public method
        public void VerifyPage()
        {
            Assert.AreEqual("Organisation Edit: New Organisation ~ Salesforce - Enterprise Edition", driver.Title);
        }
        public void VerifyNewOrganisationPage(string organisationName)
        {
            Assert.AreEqual(("'Organisation: '+ organisationName + ' ~ Salesforce - Enterprise Edition'"), driver.Title);
        }
        public void ClickTopSaveBtn()
        {
            if(TopSaveBtn.Displayed)
            {
                TopSaveBtn.Click();
            }
            else
            {
                throw new Exception("Save Button could not be found");
            }
        }
        public void ClickBottomSaveBtn()
        {
            if (BottomSaveBtn.Displayed)
            {
                BottomSaveBtn.Click();
            }
            else
            {
                throw new Exception("Save Button could not be found");
            } 
        }
        public void ClickTopSaveAndNewBtn()
        {
            if (TopSaveAndNewBtn.Displayed)
            {
                TopSaveAndNewBtn.Click();
            }
            else
            {
                throw new Exception("Save & New Button could not be found");
            }
        }
        public void ClickBottomSaveAndNewBtn()
        {
            if (BottomSaveAndNewBtn.Displayed)
            {
                BottomSaveAndNewBtn.Click();
            }
            else
            {
                throw new Exception("Save & New Button could not be found");
            }
        }
        public void ClickCancelButtonTop()
        {
            if (CancelButtonTop.Displayed)
            {
                CancelButtonTop.Click();
            }
            else
            {
                throw new Exception("Cancel Button could not be found");
            }
        }
        public void ClickCancelButtonBottom()
        {
            if (CancelButtonBottom.Displayed)
            {
                CancelButtonBottom.Click();
            }
            else
            {
                throw new Exception("Cancel Button could not be found");
            }
        }
        public void SelectASector(string selectSector)
        {
            if (Sector.Displayed)
            {
                IWebElement dropDownListBox = Sector;
                SelectElement clickThis = new SelectElement(dropDownListBox);
                clickThis.SelectByText(selectSector);

                //Sector.Click();
                //var x2 = selectSector;
                //var x1 = "//*[contains(text(),'";
                //var x3 = "')]";
                //Thread.Sleep(3000);
                //driver.FindElement(By.XPath(x1 + x2 + x3)).Click();

            }
            else
            {
                throw new Exception("Sector could not be selected");
            }
        }
        public void SelectOrganisationType(string orgType)
        {
            if (OrganisationType.Displayed)
            {
                IWebElement dropDownListBox = OrganisationType;
                SelectElement clickThis = new SelectElement(dropDownListBox);
                clickThis.SelectByText(orgType);

                //OrganisationType.Click();
                //var x2 = orgType;
                //var x1 = "//*[contains(text(),'";
                //var x3 = "')]";
                //Thread.Sleep(3000);
                //driver.FindElement(By.XPath(x1 + x2 + x3)).Click();

            }
            else
            {
                throw new Exception("Organisation Type could not be selected");
            }
        }
        public void SelectStatus(string status)
        {
            if (StatusList.Displayed == true)
            {
                StatusList.Click();
                var x2 = status;
                var x1 = "//*[contains(text(),'";
                var x3 = "')]";
                Thread.Sleep(3000);
                driver.FindElement(By.XPath(x1 + x2 + x3)).Click();

            }
            else
            {
                throw new Exception("Status List could not be selected");
            }
        }
        public void EnterOrganisationName(string organisationName)
        {
            GetDisplayedElement(_txtOrganisationName, 500, 15000).SendKeys(organisationName);
        }
        public void EnterDUNSNumber(string dunsNumber)
        {
            GetDisplayedElement(_txtDUNSNumber, 500, 15000).SendKeys(dunsNumber);
        }
        public void EnterIndirectSME(string indirectSME)
        {
            GetDisplayedElement(_txtIndirectSME, 500, 15000).SendKeys(indirectSME);
        }
        #endregion
    }
}
