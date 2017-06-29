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

    public class CaseRecordPage : BasePage
    {
        #region Constructor
        public CaseRecordPage(IWebDriver Driver) : base(Driver)
        {
        }
        #endregion

        private By _lblCaseSubjectHeader = By.XPath("//*[@id='highlight_panel_5007E000005F9jm']/div[1]/table/tbody/tr/td[3]/div/div[2]");
        private By _lblCaseDescriptionHeader = By.XPath("//*[@id='highlight_panel_5007E000005F9jm']/div[1]/table/tbody/tr/td[3]/div/div[3]/div");
        //private By _lblCaseNumberHeader = By.XPath("//*[@id='highlight_panel_5007E000005F9jm']/div[1]/table/tbody/tr/td[3]/div/div[1]/span[3]/span");
        private By _lblCaseNumberHeader = By.CssSelector("#span.efhpCenterValue");
        private By _lblCaseStatusHeader = By.XPath("//*[@id='highlight_panel_5007E000005F9jm']/div[1]/table/tbody/tr/td[5]/table/tbody/tr[1]/td[2]/div/span");
        private By _lblCasePriorityHeader = By.XPath("//*[@id='highlight_panel_5007E000005F9jm']/div[1]/table/tbody/tr/td[5]/table/tbody/tr[2]/td[2]/div/span");
        private By _lblCaseOwnerHeader = By.XPath("//*[@id='efhp5007E000005F9jm_lookup005b0000005lkv0cas1']");
        private By _tabFeed = By.XPath("//*[@id='efpViews_5007E000005F9jm_option0']");
        private By _tabDetails = By.XPath("//*[@id='efpViews_5007E000005F9jm_option1']");
        private By _linkChangeOwner = By.XPath("//*[@id='cas1_ileinner']/a");
        private By _btnEditTop = By.XPath("//*[@id='topButtonRow']/input[3]");
        private By _btnDeleteTop = By.XPath("//*[@id='topButtonRow']/input[4]");
        private By _btnCloseCaseTop = By.XPath("//*[@id='topButtonRow']/input[5]");
        private By _btnCloneTop = By.XPath("//*[@id='topButtonRow']/input[6]");
        private By _btnSharingTop = By.XPath("//*[@id='topButtonRow']/input[7]");
        private By _btnEditBottom = By.XPath("//*[@id='bottomButtonRow']/input[3]");
        private By _btnDeleteBottom = By.XPath("//*[@id='bottomButtonRow']/input[4]");
        private By _btnCloseCaseBottom = By.XPath("//*[@id='bottomButtonRow']/input[5]");
        private By _btnCloneBottom = By.XPath("//*[@id='bottomButtonRow']/input[6]");
        private By _btnSharingBottom = By.XPath("//*[@id='bottomButtonRow']/input[7]");
        private By _btnMoveEmails = By.XPath("//*[@id='j_id0:j_id2:emailsPb:j_id3']/a");
        private By _btnNewCaseComments = By.XPath("//*[@id='5007E000005F9jm_RelatedCommentsList']/div[1]/div/div[1]/table/tbody/tr/td[2]/input");
        private By _lblFeedTitle = By.CssSelector("#h3.feedtitle");

        public IWebElement CaseSubjectHeader
        {
            get
            {
                return driver.FindElement(_lblCaseSubjectHeader);
            }
        }
        public IWebElement CaseDescriptionHeader
        {
            get
            {
                return driver.FindElement(_lblCaseDescriptionHeader);
            }
        }
        public IWebElement CaseNumberHeader
        {
            get
            {
                return driver.FindElement(_lblCaseNumberHeader);
            }
        }
        public IWebElement CaseStatusHeader
        {
            get
            {
                return driver.FindElement(_lblCaseStatusHeader);
            }
        }
        public IWebElement CasePriorityHeader
        {
            get
            {
                return driver.FindElement(_lblCasePriorityHeader);
            }
        }
        public IWebElement CaseOwnerHeader
        {
            get
            {
                return driver.FindElement(_lblCaseOwnerHeader);
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
        public IWebElement ChangeOwnerLink
        {
            get
            {
                return driver.FindElement(_linkChangeOwner);
            }
        }
        public IWebElement TopEditButton
        {
            get
            {
                return driver.FindElement(_btnEditTop);
            }
        }
        public IWebElement TopDeleteButton
        {
            get
            {
                return driver.FindElement(_btnDeleteTop);
            }
        }
        public IWebElement TopCloseCaseButton
        {
            get
            {
                return driver.FindElement(_btnCloseCaseTop);
            }
        }
        public IWebElement TopCloneButton
        {
            get
            {
                return driver.FindElement(_btnCloneTop);
            }
        }
        public IWebElement TopSharingButton
        {
            get
            {
                return driver.FindElement(_btnSharingTop);
            }
        }
        public IWebElement BottomEditButton
        {
            get
            {
                return driver.FindElement(_btnEditBottom);
            }
        }
        public IWebElement BottomDeleteButton
        {
            get
            {
                return driver.FindElement(_btnDeleteBottom);
            }
        }
        public IWebElement BottomCloseCaseButton
        {
            get
            {
                return driver.FindElement(_btnCloseCaseBottom);
            }
        }
        public IWebElement BottomCloneButton
        {
            get
            {
                return driver.FindElement(_btnCloneBottom);
            }
        }
        public IWebElement BottomSharingButton
        {
            get
            {
                return driver.FindElement(_btnSharingBottom);
            }
        }
        public IWebElement MoveEmailsButton
        {
            get
            {
                return driver.FindElement(_btnMoveEmails);
            }
        }
        public IWebElement NewCaseCommentsButton
        {
            get
            {
                return driver.FindElement(_btnNewCaseComments);
            }
        }
        public IWebElement GetFeedTitle
        {
            get
            {
                return driver.FindElement(_lblFeedTitle);
            }
        }

        public void VerifyPage()
        {
            //Assert.AreEqual("Case: "+CaseNumberHeader.Text+" ~ Salesforce - Enterprise Edition", driver.Title);
            //Assert.AreEqual("All Updates for this case", GetFeedTitle.Text);
            Console.WriteLine("All Updates for this case");
        }

        public void ClickOnFeedTab()
        {
            if (FeedTab.Displayed)
            {
                FeedTab.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        public void ClickOnDetailsTab()
        {
            if (DetailsTab.Displayed)
            {
                DetailsTab.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        public void ClickOnChangeOwnerLink()
        {
            if (ChangeOwnerLink.Displayed)
            {
                ChangeOwnerLink.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        public void ClickOnTopEditButton()
        {
            if (TopEditButton.Displayed)
            {
                TopEditButton.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        public void ClickOnTopDeleteButton()
        {
            if (TopDeleteButton.Displayed)
            {
                TopDeleteButton.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        public void ClickOnTopCloseCaseButton()
        {
            if (TopCloseCaseButton.Displayed)
            {
                TopCloseCaseButton.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        public void ClickOnTopCloneButton()
        {
            if (TopCloneButton.Displayed)
            {
                TopCloneButton.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        public void ClickOnTopSharingButton()
        {
            if (TopSharingButton.Displayed)
            {
                TopSharingButton.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        public void ClickOnBottomEditButton()
        {
            if (BottomEditButton.Displayed)
            {
                BottomEditButton.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        public void ClickOnBottomDeleteButton()
        {
            if (BottomDeleteButton.Displayed)
            {
                BottomDeleteButton.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        public void ClickOnBottomCloseCaseButton()
        {
            if (BottomCloseCaseButton.Displayed)
            {
                BottomCloseCaseButton.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        public void ClickOnBottomCloneButton()
        {
            if (BottomCloneButton.Displayed)
            {
                BottomCloneButton.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        public void ClickOnBottomSharingButton()
        {
            if (BottomSharingButton.Displayed)
            {
                BottomSharingButton.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        public void ClickOnMoveEmailsButton()
        {
            if (MoveEmailsButton.Displayed)
            {
                MoveEmailsButton.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        public void ClickOnNewCaseCommentsButton()
        {
            if (NewCaseCommentsButton.Displayed)
            {
                NewCaseCommentsButton.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        public void ClickOnConfirmDelete()
        {
            if (isAlertPresent() == true)
            {
                driver.SwitchTo().Alert().Accept();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        public Boolean isAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
