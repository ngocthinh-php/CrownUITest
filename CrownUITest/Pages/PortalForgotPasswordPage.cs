namespace CrownUITest.Pages
{
    #region Using Directives
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using OpenQA.Selenium;
    using NUnit.Framework;
    using OpenQA.Selenium.Support.UI;
    using System.Threading;
    #endregion

    public class PortalForgotPasswordPage : BasePage
    {
        #region Constructor
        public PortalForgotPasswordPage(IWebDriver driver) : base(driver) { }
        #endregion

        #region Properties and fields
        public string Email { get; set; }
        protected override bool CurrentPage()
        {
            try
            {
                return PageTitle.Displayed;
            }
            catch (Exception)
            {

                throw new NotImplementedException();
            }

        }

        private By _PageTitle = By.XPath("//*[@id='LoginNew']");
        private By _imgCCS = By.XPath("//*[@id='content']/div/div[2]/div/div[1]/div/span/img");
        private By _ForgotPwdScrMsg = By.XPath("//*[@id='content']/div/div[2]/div/div[2]/div/div[1]/div/p");
        private By _btnSID4GOV = By.XPath("//*[@id='content']/div/div[2]/div/div[3]/div/ul/li/button");
        private By _txtResetYourPwd = By.XPath("//*[@id='content']/div/div[2]/div/div[4]/div/div[1]/h1/span");
        private By _txtSomeMoreTxt = By.XPath("//*[@id='content']/div/div[2]/div/div[5]/div/div[1]/div/span");
        private By _typePwResetEmail = By.XPath("//*[@id='85:88;a']");
        private By _btnSendPwdResetEmil = By.XPath("//*[@id='content']/div/div[2]/div/div[6]/div/div[2]/button");
        private By _lnkRegister = By.LinkText("Register");
        private By _lnkLogin = By.LinkText("Login");

        public IWebElement PageTitle
        {
            get
            {
                return driver.FindElement(_PageTitle);
            }
        }
        public IWebElement CCSImage
        {
            get
            {
                return driver.FindElement(_imgCCS);
            }
        }
        public IWebElement SomeMessage
        {
            get
            {
                return driver.FindElement(_ForgotPwdScrMsg);
            }
        }
        public IWebElement Sid4GovBtn
        {
            get
            {
                return driver.FindElement(_btnSID4GOV);
            }
        }
        public IWebElement ResetYourPasswordTxt
        {
            get
            {
                return driver.FindElement(_txtResetYourPwd);
            }
        }
        public IWebElement ResetYourPasswordMoreTxt
        {
            get
            {
                return driver.FindElement(_txtSomeMoreTxt);
            }
        }
        public IWebElement PwdResetEmail
        {
            get
            {
                return driver.FindElement(_typePwResetEmail);
            }

        }
        public IWebElement PwdResetBtn
        {
            get
            {
                return driver.FindElement(_btnSendPwdResetEmil);
            }

        }
        public IWebElement RegisterLnk
        {
            get
            {
                return driver.FindElement(_lnkRegister);
            }
        }
        public IWebElement LoginLnk
        {
            get
            {
                return driver.FindElement(_lnkLogin);
            }
        }
        #endregion

        #region Public methods
        public void VerifyPage()
        {
            Assert.IsTrue(PageTitle.Displayed);
            Assert.IsTrue(CCSImage.Displayed);
            Assert.IsTrue(SomeMessage.Displayed);
            Assert.IsTrue(Sid4GovBtn.Displayed);
            Assert.IsTrue(ResetYourPasswordTxt.Displayed);
            Assert.IsTrue(ResetYourPasswordMoreTxt.Displayed);
            Assert.IsTrue(PwdResetEmail.Displayed);
            Assert.IsTrue(PwdResetBtn.Displayed);
            Assert.IsTrue(RegisterLnk.Displayed);
            Assert.IsTrue(LoginLnk.Displayed);
        }
        public void EnterPwdResetEmail(string email)
        {
            GetDisplayedElement(_typePwResetEmail, 500, 15000).SendKeys(email);
        }
        //public void UserEntersEmail(string email)
        //{
        //    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        //    wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id='85:88;a']")));
        //    //PwdResetEmail.Clear();
        //    PwdResetEmail.SendKeys(email);
        //    Thread.Sleep(2000);            
        //}
        public void ClickOnLogIn()
        {
            if (LoginLnk.Displayed)
            {
                LoginLnk.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        public void ClickOnRegister()
        {
            if (RegisterLnk.Displayed)
            {
                RegisterLnk.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        public void ClickOnSendPwdResetEmil()
        {
            if (PwdResetBtn.Displayed)
            {
                PwdResetBtn.Click();
                //Thread.Sleep(2000);
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        #endregion
    }
}