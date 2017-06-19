using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SalesForce.Pages
{
    public class ChatterPage: BasePage
    {
        #region constructor
        public ChatterPage(IWebDriver Driver) : base(Driver)
        {
        }
        #endregion

        #region Properties and fields
        //private By _lnkPost = By.XPath("//*[@id='publisherAttachTextPost']/span[1]");
        private By _lnkPost = By.XPath("//*[@id='publisherAttachTextPost']/span[1]");
        private By _lnkQuestion = By.XPath("//*[@id='publisherAttachQuestionPost']/span[1]");
        private By _lnkLogACall = By.LinkText("Log a Call");
        private By _lnkMore = By.LinkText("More");
        private By _lnkNewTask = By.LinkText("New Task");
        private By _lnkNewContact = By.LinkText("New Contact");
        private By _lnkNewCase = By.LinkText("New Case");
        private By _iFramePost = By.XPath("//*[@id='cke_171_contents']/iframe");
        private By _iFrameQuestion = By.XPath("//*[@id='ext-gen2']");
        private By _btnShare = By.XPath("//*[@id='publishersharebutton']");
        private By _txtQuestionTitle = By.XPath("//*[@id='publisherQuestionTitle']");
        //=======================================================================
        //Question Details Element can not be detected for input
        // private By _txtQuestionDetails = By.TagName("p");
        // private By _txtQuestionDetails = By.CssSelector("#body.chatterPublisherRTE.cke_editable.cke_editable_themed.cke_contents_ltr.cke_show_borders.placeholder > p");// [contains(text(),'Anything else? Add it here ...')] 
        private By _txtQuestionDetails = By.XPath("html/body/p[2]"); //.//*[contains(text(),'Anything else? Add it here ...')]");          
                                                                     // ("//*[contains(@class, 'chatterPublisherRTE')][@contenteditable='true']/p")
        //=======================================================================
        private By _btnAsk = By.XPath("//*[@id='publishersharebutton']");
        private By _txtSubject = By.XPath("//*[@id='tsk5__09Db0000001NE3U']");
        private By _txtComment = By.XPath("//*[@id='tsk6__09Db0000001NE3U']");
        private By _selectName = By.XPath("//*[@id='tsk2__09Db0000001NE3U_mlktp']");
        private By _txtContact = By.XPath("//*[@id='tsk2__09Db0000001NE3U']");
        private By _selectRelatedTo = By.XPath("//*[@id='tsk3__09Db0000001NE3U_mlktp']");
        private By _txtRelatedTo = By.XPath("//*[@id='tsk3__09Db0000001NE3U']");
        private By _btnLogACall = By.XPath("//*[@id='publishersharebutton']");
        private By _selectShowUpdates = By.XPath("//*[@id='filterDisplay']");
        private By _upsertedQuestionText = By.XPath("//*[contains(text(),'Chatter Automation Test001')]");
        string textp1 = "//*[contains(text(),'";
        string textp2 = "Chatter Automation Test001";
        string textp3 = "')]";
        //private By _lnkPostQuestionCreation = By.XPath("//*[@id='topicContainer0D57E00000E0EeR']/div/a");
        //private By _lnkPostQuestionCreation = By.ClassName("questionTitle");
        #endregion

        #region Element attributes
        public void ElementQuestionText(string serchText)
        {
            textp2 = serchText;
            string fulltext = textp1+ textp2+ textp3;
            //return driver.FindElement(By.XPath(fulltext));
            
        }

        public IWebElement UpsertQuestionText
        {
            get
            {
                return driver.FindElement(_upsertedQuestionText);
            }
        }

        //public IWebElement PostQuestionCreationLink
        //{
        //    get
        //    {
        //        return driver.FindElement(_lnkPostQuestionCreation);
        //    }
        //}
        public IWebElement PostLink
        {
            get
            {
                return driver.FindElement(_lnkPost);
            }
        }
        public IWebElement QuestionLink
        {
            get
            {
                return driver.FindElement(_lnkQuestion);
            }
        }
        public IWebElement LogACallLink
        {
            get
            {
                return driver.FindElement(_lnkLogACall);
            }
        }
        public IWebElement MoreLink
        {
            get
            {
                return driver.FindElement(_lnkMore);
            }
        }
        public IWebElement NewTaskLink
        {
            get
            {
                return driver.FindElement(_lnkNewTask);
            }
        }
        public IWebElement NewContactLink
        {
            get
            {
                return driver.FindElement(_lnkNewContact);
            }
        }
        public IWebElement NewCaseLink
        {
            get
            {
                return driver.FindElement(_lnkNewCase);
            }
        }
        public IWebElement QuestionTitleText
        {
            get
            {
                return driver.FindElement(_txtQuestionTitle);
            }
        }
        public IWebElement QuestionDetailsText
        {
            get
            {
                return driver.FindElement(_txtQuestionDetails);
            }
        }
        public IWebElement SubjectText
        {
            get
            {
                return driver.FindElement(_txtSubject);
            }
        }
        public IWebElement CommentText
        {
            get
            {
                return driver.FindElement(_txtComment);
            }
        }
        public IWebElement NameContactOrLeadList
        {
            get
            {
                return driver.FindElement(_selectName);
            }
        }
        public IWebElement ContactText
        {
            get
            {
                return driver.FindElement(_txtContact);
            }
        }
        public IWebElement RelatedToList
        {
            get
            {
                return driver.FindElement(_selectRelatedTo);
            }
        }
        public IWebElement RelatedToText
        {
            get
            {
                return driver.FindElement(_txtRelatedTo);
            }
        }
        public IWebElement ShowUpdates
        {
            get
            {
                return driver.FindElement(_selectShowUpdates);
            }
        }
        public IWebElement ShareButton
        {
            get
            {
                return driver.FindElement(_btnShare);
            }
        }
        public IWebElement AskButton
        {
            get
            {
                return driver.FindElement(_btnShare);
            }
        }
        public IWebElement LogACallButton
        {
            get
            {
                return driver.FindElement(_btnLogACall);
            }
        }
        #endregion

        #region Public methods
        public void VerifyPage()
        {
            Assert.AreEqual("Chatter ~ Salesforce - Enterprise Edition", driver.Title);
        }
        //public void VerifyTextPostQuestionCreation()
        //{
        //    Assert.AreEqual("Click to add topics:", PostQuestionCreationLink);
        //}
        public void UserEntersQuestionTitle(string qTitle)
        {
            GetDisplayedElement(_txtQuestionTitle, 500, 15000).SendKeys(qTitle);
        }
        //public void UserEntersQuestionDetails(string qDetl)
        //{
        //    GetDisplayedElement(_txtQuestionDetails, 500, 15000).SendKeys(qDetl);
        //}

        //public void EnterAQuestion(string qTitle, string qDetl)
        //{
        //    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));
        //    wait.Until(ExpectedConditions.ElementToBeClickable(_txtQuestionTitle));
        //    QuestionTitleText.Clear();
        //    QuestionTitleText.SendKeys(qTitle);
        //    Thread.Sleep(2000);
        //   // Assert.IsTrue(QuestionDetailsText.Displayed);
        //   // driver.SwitchTo().Frame(driver.FindElement(_iFrameQuestion));
        //   // wait.Until(ExpectedConditions.ElementToBeClickable(_txtQuestionDetails));
        //    QuestionDetailsText.Click();
        //    QuestionDetailsText.SendKeys(qDetl);
        //    Thread.Sleep(2000);
        //}
        public void ClickOnPostLink()
        {
            if (PostLink.Displayed)
            {
                PostLink.Click();
            }

            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        public void ClickOnQuestionLink()
        {
            if (QuestionLink.Displayed)
            {
                QuestionLink.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        public void ClickOnLogACallLink()
        {
            if (LogACallLink.Displayed)
            {
                LogACallLink.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        public void ClickOnMoreLink()
        {
            if (MoreLink.Displayed)
            {
                MoreLink.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        public void ClickOnNewTaskLink()
        {
            if (NewTaskLink.Displayed)
            {
                NewTaskLink.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        public void ClickOnNewContactLink()
        {
            if (NewContactLink.Displayed)
            {
                NewContactLink.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        public void ClickOnNewCaseLink()
        {
            if (NewCaseLink.Displayed)
            {
                NewCaseLink.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        public void ClickOnShareButton()
        {
            if (ShareButton.Displayed)
            {
                ShareButton.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        public void ClickOnAskButton()
        {
            if (AskButton.Displayed)
            {
                AskButton.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        public void ClickOnLogACallButton()
        {
            if (LogACallButton.Displayed)
            {
                LogACallButton.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        public void SelectFromShowUpdatesList(string showUpdates)
        {
            if (ShowUpdates.Displayed)
            {
                ShowUpdates.Click();
                var x2 = showUpdates;
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
        //public void ClickOnDeleteButton()
        //{
        //    if (DeleteButton.Displayed)
        //    {
        //        DeleteButton.Click();
        //    }
        //    else
        //    {
        //        throw new Exception("Element is not found or not clickable");
        //    }
        //}
        public void ClickOnConfirmDelete()
        {

            driver.SwitchTo().Alert().Accept();

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
#endregion
    }
}
