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

    public class CaseEditPage : BasePage
    {
        #region Constructor
        public CaseEditPage(IWebDriver Driver) : base(Driver)
        {
        }
        #endregion

        #region Properties and fields
        //Enquiry Case Elements------------------------------
        private By _lblCaseRecordType = By.XPath("//*[@id='ep']/div[2]/div[2]/table/tbody/tr[2]/td[4]");
        private By _txtOrganisationName = By.XPath("//*[@id='cas4']");
        private By _txtContactName = By.XPath("//*[@id='cas3']");//By.XPath("//*[@id='cas3']")
        private By _listTeam = By.XPath("//*[@id='00Nb000000ASEUx']");
        private By _listStatus = By.XPath("//*[@id='cas7']");
        private By _listPriority = By.XPath("//*[@id='cas8']");
        private By _txtTriageLevel = By.XPath("//*[@id='CF00Nb0000009IPcp']");
        private By _listCaseOrigin = By.XPath("//*[@id='cas11']");
        private By _txtSubject = By.XPath("//*[@id='cas14']");
        private By _txtDescription = By.XPath("//*[@id='cas15']");
        //-----------------------------------------------------

        private By _listTechnologyTeam = By.XPath("//*[@id='00Nb000000ASLvR']");
        private By _listWorkflow = By.XPath("//*[@id='00Nb000000ASLvS']");
        private By _listCategory = By.XPath("//*[@id='00Nb000000ASLxF']");
        private By _listSupportClassification = By.XPath("//*[@id='00Nb000000ASLvQ']");
        private By _listSCLevel1 = By.XPath("//*[@id='00Nb000000ASLvO']");
        private By _listSCLevel2 = By.XPath("//*[@id='00Nb000000ASLvP']");

        private By _btnSaveTop = By.XPath("//*[@id='topButtonRow']/input[1]");
        private By _btnSaveAndCloseTop = By.XPath("//*[@id='topButtonRow']/input[2]");
        private By _btnSaveAndNewTop = By.XPath("//*[@id='topButtonRow']/input[3]");
        private By _btnCancelTop = By.XPath("//*[@id='topButtonRow']/input[4]");

        private By _btnSaveBottom = By.XPath("//*[@id='bottomButtonRow']/input[1]");
        private By _btnSaveAndCloseBottom = By.XPath("//*[@id='bottomButtonRow']/input[2]");
        private By _btnSaveAndNewBottom = By.XPath("//*[@id='bottomButtonRow']/input[3]");
        private By _btnCancelBottom = By.XPath("//*[@id='bottomButtonRow']/input[4]");

        //Procurement Case Specific
        private By _txtOrgName = By.XPath("//*[@id='cas4']");
        private By _txtProcReference = By.XPath("//*[@id='00Nb000000ASEVb']");
        private By _listProcStatus = By.XPath("//*[@id='cas7']");
        private By _listValue = By.XPath("//*[@id='00Nb000000ASEWO']");
        private By _listStraImpToCustomer = By.XPath("//*[@id='00Nb000000ASEW8']");
        private By _listSourComplexity = By.XPath("//*[@id='00Nb000000ASEW3']");
        private By _listCcsTeam = By.XPath("//*[@id='00Nb000000ASEZp']");
        private By _txtProcCASCategory = By.XPath("//*[@id='CF00Nb000000ASEUK']");
        private By _listProcCaseOrigin = By.XPath("//*[@id='cas11']");
        private By _txtProcSubject = By.XPath("//*[@id='cas14']");
        private By _txtProcDescription = By.XPath("//*[@id='cas15']");
        private By _listCoErgAppReqlist = By.XPath("//*[@id='00Nb000000ASEUO']");
        private By _listDwpCARList = By.XPath("//*[@id='00Nb000000ASEUm']");
        private By _listolncAppReqList = By.XPath("//*[@id='00Nb000000ASEVT']");
        private By _listmodrcaAppReqList = By.XPath("//*[@id='00Nb000000ASEVK']");
        private By _listdwpmcatAppReqList = By.XPath("//*[@id='00Nb000000ASEUp']");
        private By _listProcPriority = By.XPath("//*[@id='cas8']");
        #endregion

        #region Procurement objects
        public IWebElement OrgNameTxt
        {
            get
            {
                return driver.FindElement(_txtOrgName);
            }
        }
        public IWebElement ProcReferenceTxt
        {
            get
            {
                return driver.FindElement(_txtProcReference);
            }
        }
        public IWebElement ProcStatusList
        {
            get
            {
                return driver.FindElement(_listProcStatus);
            }
        }
        public IWebElement ProcValueList
        {
            get
            {
                return driver.FindElement(_listValue);
            }
        }
        public IWebElement StraImpToCustomerList
        {
            get
            {
                return driver.FindElement(_listStraImpToCustomer);
            }
        }
        public IWebElement SourComplexityList
        {
            get
            {
                return driver.FindElement(_listSourComplexity);
            }
        }
        public IWebElement CcsTeamList
        {
            get
            {
                return driver.FindElement(_listCcsTeam);
            }
        }
        public IWebElement ProcCASCategoryTxt
        {
            get
            {
                return driver.FindElement(_txtProcCASCategory);
            }
        }
        public IWebElement ProcCaseOriginList
        {
            get
            {
                return driver.FindElement(_listProcCaseOrigin);
            }
        }
        public IWebElement ProcSubjectTxt
        {
            get
            {
                return driver.FindElement(_txtProcSubject);
            }
        }
        public IWebElement ProcDescriptionTxt
        {
            get
            {
                return driver.FindElement(_txtProcDescription);
            }
        }
        public IWebElement CoErgAppReqlistList
        {
            get
            {
                return driver.FindElement(_listCoErgAppReqlist);
            }
        }
        public IWebElement DwpCARList
        {
            get
            {
                return driver.FindElement(_listDwpCARList);
            }
        }
        public IWebElement OlncAppReqList
        {
            get
            {
                return driver.FindElement(_listolncAppReqList);
            }
        }
        public IWebElement ModrcaAppReqList
        {
            get
            {
                return driver.FindElement(_listmodrcaAppReqList);
            }
        }
        public IWebElement DwpmcatAppReqList
        {
            get
            {
                return driver.FindElement(_listdwpmcatAppReqList);
            }
        }
        public IWebElement ProcPriorityList
        {
            get
            {
                return driver.FindElement(_listProcPriority);
            }
        }
        #endregion

        #region define element attributes
        public IWebElement CaseRecordType
        {
            get
            {
                return driver.FindElement(_lblCaseRecordType);
            }
        }
        public IWebElement OrganisationName
        {
            get
            {
                return driver.FindElement(_txtOrganisationName);
            }
        }
        public IWebElement ContactName
        {
            get
            {
                return driver.FindElement(_txtContactName);
            }
        }
        public IWebElement Team
        {
            get
            {
                return driver.FindElement(_listTeam);
            }
        }
        public IWebElement CaseStatus
        {
            get
            {
                return driver.FindElement(_listStatus);
            }
        }
        public IWebElement CasePriority
        {
            get
            {
                return driver.FindElement(_listPriority);
            }
        }
        public IWebElement TriageLevel
        {
            get
            {
                return driver.FindElement(_txtTriageLevel);
            }
        }
        public IWebElement CaseOrigin
        {
            get
            {
                return driver.FindElement(_listCaseOrigin);
            }
        }
        public IWebElement Subject
        {
            get
            {
                return driver.FindElement(_txtSubject);
            }
        }
        public IWebElement Description
        {
            get
            {
                return driver.FindElement(_txtDescription);
            }
        }
        public IWebElement Workflow
        {
            get
            {
                return driver.FindElement(_listWorkflow);
            }
        }
        public IWebElement Category
        {
            get
            {
                return driver.FindElement(_listCategory);
            }
        }
        public IWebElement SupportClassification
        {
            get
            {
                return driver.FindElement(_listSupportClassification);
            }
        }
        public IWebElement SCLevel1
        {
            get
            {
                return driver.FindElement(_listSCLevel1);
            }
        }
        public IWebElement SCLevel2
        {
            get
            {
                return driver.FindElement(_listSCLevel2);
            }
        }
        public IWebElement TechnologyTeam
        {
            get
            {
                return driver.FindElement(_listTechnologyTeam);
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
        public IWebElement TopSaveAndCloseBtn
        {
            get
            {
                return driver.FindElement(_btnSaveAndCloseTop);
            }
        }
        public IWebElement BottomSaveAndCloseBtn
        {
            get
            {
                return driver.FindElement(_btnSaveAndCloseBottom);
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
            Assert.AreEqual("Case Edit: New Case ~ Salesforce - Enterprise Edition", driver.Title);
        }
        public void ClickOnTopSaveBtn()
        {
            if (TopSaveBtn.Displayed)
            {
                TopSaveBtn.Click();
            }
            else
            {
                throw new Exception("Save Button could not be found");
            }
        }
        public void ClickOnBottomSaveBtn()
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
        public void ClickOnTopSaveAndCloseBtn()
        {
            if (TopSaveAndCloseBtn.Displayed)
            {
                TopSaveAndCloseBtn.Click();
            }
            else
            {
                Exception e;
            }
        }
        public void ClickOnBottomSaveAndCloseBtn()
        {
            if (BottomSaveAndCloseBtn.Displayed)
            {
                BottomSaveAndCloseBtn.Click();
            }
            else
            {
                Exception e;
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

        public void EnterOrganisationName(string orgName)
        {
            GetDisplayedElement(_txtOrganisationName, 500, 15000).SendKeys(orgName);
        }
        public void EnterContactName(string contactName)
        {
            GetDisplayedElement(_txtContactName, 500, 15000).SendKeys(contactName);
        }
        public void SelectATeam(string team)
        {
            if (Team.Displayed)
            {
                Team.Click();
                var x2 = team;
                var x1 = "//*[contains(text(),'";
                var x3 = "')]";
                Thread.Sleep(3000);
                driver.FindElement(By.XPath(x1 + x2 + x3)).Click();

            }
            else
            {
                throw new Exception("Team could not be selected");
            }
        }
        public void SelectATechnologyTeam(string technologyTeam)
        {
            if (TechnologyTeam.Displayed)
            {
                TechnologyTeam.Click();
                var x2 = technologyTeam;
                var x1 = "//*[contains(text(),'";
                var x3 = "')]";
                Thread.Sleep(3000);
                driver.FindElement(By.XPath(x1 + x2 + x3)).Click();

            }
            else
            {
                throw new Exception("Team could not be selected");
            }
        }
        public void SelectCaseStatus(string status)
        {
            IWebElement dropDownListBox = driver.FindElement(_listStatus);
            SelectElement clickThis = new SelectElement(dropDownListBox);
            //Thread.Sleep(2000);
            clickThis.SelectByText(status);
            //Thread.Sleep(2000);

        }
        public void SelectCasePriority(string priority)
        {
            if (CasePriority.Displayed)
            {
                CasePriority.Click();
                var x2 = priority;
                var x1 = "//*[contains(text(),'";
                var x3 = "')]";
                Thread.Sleep(3000);
                driver.FindElement(By.XPath(x1 + x2 + x3)).Click();

            }
            else
            {
                throw new Exception("Case Priority could not be selected");
            }
        }
        public void EnterTriageLevel(string triageLevel)
        {
            GetDisplayedElement(_txtTriageLevel, 500, 15000).SendKeys(triageLevel);
        }
        public void SelectCaseOrigin(string caseOrigin)
        {
            IWebElement dropDownListBox = driver.FindElement(_listCaseOrigin);
            SelectElement clickThis = new SelectElement(dropDownListBox);
            Thread.Sleep(2000);
            clickThis.SelectByText(caseOrigin);
            //Thread.Sleep(2000);
        }
        public void EnterCaseSubject(string subject)
        {
            GetDisplayedElement(_txtSubject, 500, 15000).SendKeys(subject);
        }
        public void EnterCaseDescription(string description)
        {
            GetDisplayedElement(_txtDescription, 500, 15000).SendKeys(description);
        }
        public void SelectWorkflow(string workFlow)
        {
            IWebElement dropDownListBox = driver.FindElement(_listWorkflow);
            SelectElement clickThis = new SelectElement(dropDownListBox);
            //Thread.Sleep(2000);
            clickThis.SelectByText(workFlow);
            //Thread.Sleep(2000);
        }
        public void SelectCategory(string category)
        {
            IWebElement dropDownListBox = driver.FindElement(_listCategory);
            SelectElement clickThis = new SelectElement(dropDownListBox);
            //Thread.Sleep(2000);
            clickThis.SelectByText(category);
            //Thread.Sleep(2000);
        }
        public void SelectSupportClassification(string supportClassification)
        {
            IWebElement dropDownListBox = driver.FindElement(_listSupportClassification);
            SelectElement clickThis = new SelectElement(dropDownListBox);
            //Thread.Sleep(2000);
            clickThis.SelectByText(supportClassification);
            //Thread.Sleep(2000);
        }
        public void SelectSCLevel1(string SCLevel1)
        {
            IWebElement dropDownListBox = driver.FindElement(_listSCLevel1);
            SelectElement clickThis = new SelectElement(dropDownListBox);
            //Thread.Sleep(2000);
            clickThis.SelectByText(SCLevel1);
            //Thread.Sleep(2000);
        }
        public void SelectSCLevel2(string SCLevel2)
        {
            IWebElement dropDownListBox = driver.FindElement(_listSCLevel2);
            SelectElement clickThis = new SelectElement(dropDownListBox);
            //Thread.Sleep(2000);
            clickThis.SelectByText(SCLevel2);
            //Thread.Sleep(2000);
        }

        //Procurement Case Specific
        public void EnterOrgNameTxt(string orgName)
        {
            GetDisplayedElement(_txtOrgName, 500, 15000).SendKeys(orgName);
        }
        public void EnterProcReferenceTxt(string procReference)
        {
            GetDisplayedElement(_txtProcReference, 500, 15000).SendKeys(procReference);          
        }        
        public void SelectProcStatusList(string status)
        {
            IWebElement dropDownListBox = driver.FindElement(_listProcStatus);
            SelectElement clickThis = new SelectElement(dropDownListBox);
            //Thread.Sleep(2000);
            clickThis.SelectByText(status);
            //Thread.Sleep(2000);
        }
        public void SelectProcValueList(string value)
        {
            IWebElement dropDownListBox = driver.FindElement(_listValue);
            SelectElement clickThis = new SelectElement(dropDownListBox);
            //Thread.Sleep(2000);
            clickThis.SelectByText(value);
            //Thread.Sleep(2000);
        }
        public void SelectStraImpToCustomerList(string straImpToCustomer)
        {
            IWebElement dropDownListBox = driver.FindElement(_listStraImpToCustomer);
            SelectElement clickThis = new SelectElement(dropDownListBox);
            //Thread.Sleep(2000);
            clickThis.SelectByText(straImpToCustomer);
            //Thread.Sleep(2000);
        }
        public void SelectSourComplexityList(string sourComplexity)
        {
            IWebElement dropDownListBox = driver.FindElement(_listSourComplexity);
            SelectElement clickThis = new SelectElement(dropDownListBox);
            //Thread.Sleep(2000);
            clickThis.SelectByText(sourComplexity);
            //Thread.Sleep(2000);
        }
        public void SelectCcsTeamList(string ccsTeam)
        {
            IWebElement dropDownListBox = driver.FindElement(_listCcsTeam);
            SelectElement clickThis = new SelectElement(dropDownListBox);
            //Thread.Sleep(2000);
            clickThis.SelectByText(ccsTeam);
            //Thread.Sleep(2000);
        }
        public void EnterProcCASCategoryTxt(string CASCategory)
        {
            GetDisplayedElement(_txtProcCASCategory, 500, 15000).SendKeys(CASCategory);
        }
        public void SelectProcCaseOriginList(string caseOrigin)
        {
            IWebElement dropDownListBox = driver.FindElement(_listProcCaseOrigin);
            SelectElement clickThis = new SelectElement(dropDownListBox);
            //Thread.Sleep(2000);
            clickThis.SelectByText(caseOrigin);
            //Thread.Sleep(2000);
        }
        public void EnterProcSubjectTxt(string subject)
        {
            GetDisplayedElement(_txtProcSubject, 500, 15000).SendKeys(subject);
        }
        public void EnterProcDescriptionTxt(string description)
        {
            GetDisplayedElement(_txtProcDescription, 500, 15000).SendKeys(description);
        }
        public void SelectCoErgAppReqlistList(string coErgAppReqlist)
        {
            IWebElement dropDownListBox = driver.FindElement(_listCoErgAppReqlist);
            SelectElement clickThis = new SelectElement(dropDownListBox);
            //Thread.Sleep(2000);
            clickThis.SelectByText(coErgAppReqlist);
            //Thread.Sleep(2000);
        }
        public void SelectDwpCARList(string dwpCARList)
        {
            IWebElement dropDownListBox = driver.FindElement(_listDwpCARList);
            SelectElement clickThis = new SelectElement(dropDownListBox);
            //Thread.Sleep(2000);
            clickThis.SelectByText(dwpCARList);
            //Thread.Sleep(2000);
        }
        public void SelectOlncAppReqList(string olncAppReqList)
        {
            IWebElement dropDownListBox = driver.FindElement(_listolncAppReqList);
            SelectElement clickThis = new SelectElement(dropDownListBox);
            //Thread.Sleep(2000);
            clickThis.SelectByText(olncAppReqList);
            //Thread.Sleep(2000);
        }
        public void SelectModrcaAppReqList(string modrcaAppReqList)
        {
            IWebElement dropDownListBox = driver.FindElement(_listmodrcaAppReqList);
            SelectElement clickThis = new SelectElement(dropDownListBox);
            //Thread.Sleep(2000);
            clickThis.SelectByText(modrcaAppReqList);
            //Thread.Sleep(2000);
        }
        public void SelectDwpmcatAppReqList(string dwpmcatAppReqList)
        {
            IWebElement dropDownListBox = driver.FindElement(_listdwpmcatAppReqList);
            SelectElement clickThis = new SelectElement(dropDownListBox);
            //Thread.Sleep(2000);
            clickThis.SelectByValue(dwpmcatAppReqList);
            //Thread.Sleep(2000);
        }
        public void SelectProcPriorityList(string priority)
        {
            IWebElement dropDownListBox = driver.FindElement(_listProcPriority);
            SelectElement clickThis = new SelectElement(dropDownListBox);
            //Thread.Sleep(2000);
            clickThis.SelectByValue(priority);
            //Thread.Sleep(2000);
        }

        /*
        public void CreateEnquiryCase(string orgName, string contactName, string team, string status, string priority, string triageLevel, string caseOrigin, string subject, string description)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));
            wait.Until(ExpectedConditions.ElementToBeClickable(_txtOrganisationName));
            OrganisationName.Clear();
            OrganisationName.SendKeys(orgName);
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementToBeClickable(_txtContactName));
            ContactName.Clear();
            ContactName.SendKeys(contactName);
            Thread.Sleep(2000);

            if (Team.Displayed)
            {
                Team.Click();
                var x2 = team;
                var x1 = "//*[contains(text(),'";
                var x3 = "')]";
                Thread.Sleep(3000);
                driver.FindElement(By.XPath(x1 + x2 + x3)).Click();

            }
            else
            {
                throw new Exception("Team could not be selected");
            }
            if (CaseStatus.Displayed == true)
            {
                CaseStatus.Click();
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
            if (CasePriority.Displayed)
            {
                CasePriority.Click();
                var x2 = priority;
                var x1 = "//*[contains(text(),'";
                var x3 = "')]";
                Thread.Sleep(3000);
                driver.FindElement(By.XPath(x1 + x2 + x3)).Click();

            }
            else
            {
                throw new Exception("Case Priority could not be selected");
            }

            wait.Until(ExpectedConditions.ElementToBeClickable(_txtTriageLevel));
            TriageLevel.Clear();
            TriageLevel.SendKeys(triageLevel);
            Thread.Sleep(2000);

            if (CaseOrigin.Displayed)
            {
                CaseOrigin.Click();
                var x2 = caseOrigin;
                var x1 = "//*[contains(text(),'";
                var x3 = "')]";
                Thread.Sleep(3000);
                driver.FindElement(By.XPath(x1 + x2 + x3)).Click();

            }
            else
            {
                throw new Exception("Case Origin could not be selected");
            }

            wait.Until(ExpectedConditions.ElementToBeClickable(_txtSubject));
            Subject.Clear();
            Subject.SendKeys(subject);
            Thread.Sleep(2000);

            wait.Until(ExpectedConditions.ElementToBeClickable(_txtDescription));
            Description.Clear();
            Description.SendKeys(description);
            Thread.Sleep(2000);

        }
        */
        public void CreateTechSupportCase(string orgName, string contactName, string technologyTeam, string caseOrigin, string workflow, string category, string status, string priority, string supportClassification, string SCLevel1, string SCLevel2, string subject, string description)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));

            wait.Until(ExpectedConditions.ElementToBeClickable(_txtOrganisationName));
            OrganisationName.Clear();
            OrganisationName.SendKeys(orgName);
            Thread.Sleep(2000);

            wait.Until(ExpectedConditions.ElementToBeClickable(_txtContactName));
            ContactName.Clear();
            ContactName.SendKeys(contactName);
            Thread.Sleep(2000);

            if (TechnologyTeam.Displayed)
            {
                TechnologyTeam.Click();
                var x2 = technologyTeam;
                var x1 = "//*[contains(text(),'";
                var x3 = "')]";
                Thread.Sleep(3000);
                driver.FindElement(By.XPath(x1 + x2 + x3)).Click();

            }
            else
            {
                throw new Exception("Team could not be selected");
            }

            IWebElement dropDownOriginListBox = driver.FindElement(_listCaseOrigin);
            SelectElement clickOrigin = new SelectElement(dropDownOriginListBox);
            //Thread.Sleep(2000);
            clickOrigin.SelectByText(caseOrigin);
            //Thread.Sleep(2000);

            IWebElement dropDownWorkFlowListBox = driver.FindElement(_listWorkflow);
            SelectElement clickWorkFlow = new SelectElement(dropDownWorkFlowListBox);
            //Thread.Sleep(2000);
            clickWorkFlow.SelectByText(workflow);
            //Thread.Sleep(2000);

            IWebElement dropDownCategoryListBox = driver.FindElement(_listCategory);
            SelectElement clickCategory = new SelectElement(dropDownCategoryListBox);
            //Thread.Sleep(2000);
            clickCategory.SelectByText(category);
            //Thread.Sleep(2000);

            IWebElement dropDownStatusListBox = driver.FindElement(_listStatus);
            SelectElement clickStatus = new SelectElement(dropDownStatusListBox);
            Thread.Sleep(2000);
            clickStatus.SelectByText(status);
            Thread.Sleep(2000);

            if (CasePriority.Displayed)
            {
                CasePriority.Click();
                var x2 = priority;
                var x1 = "//*[contains(text(),'";
                var x3 = "')]";
                Thread.Sleep(3000);
                driver.FindElement(By.XPath(x1 + x2 + x3)).Click();

            }
            else
            {
                throw new Exception("Case Priority could not be selected");
            }

            IWebElement dropDownSCListBox = driver.FindElement(_listSupportClassification);
            SelectElement clickSC = new SelectElement(dropDownSCListBox);
            //Thread.Sleep(2000);
            clickSC.SelectByText(supportClassification);
            //Thread.Sleep(2000);

            IWebElement dropDownSCL1ListBox = driver.FindElement(_listSCLevel1);
            SelectElement clickSCL1 = new SelectElement(dropDownSCL1ListBox);
            //Thread.Sleep(2000);
            clickSCL1.SelectByText(SCLevel1);
            //Thread.Sleep(2000);

            IWebElement dropDownSCL2ListBox = driver.FindElement(_listSCLevel2);
            SelectElement clickSCL2 = new SelectElement(dropDownSCL2ListBox);
            //Thread.Sleep(2000);
            clickSCL2.SelectByText(SCLevel2);
            //Thread.Sleep(2000);

            wait.Until(ExpectedConditions.ElementToBeClickable(_txtSubject));
            Subject.Clear();
            Subject.SendKeys(subject);
            Thread.Sleep(2000);

            wait.Until(ExpectedConditions.ElementToBeClickable(_txtDescription));
            Description.Clear();
            Description.SendKeys(description);
            Thread.Sleep(2000);

        }

        #endregion
    }
}
