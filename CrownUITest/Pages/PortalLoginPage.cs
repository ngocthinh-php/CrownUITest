namespace CrownUITest.Pages
{
    #region Using Directives
    using CrownUITest.Hooks;
    using NUnit.Framework;
    using System;
    using TechTalk.SpecFlow;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;
    using System.Threading;
    #endregion

    public class PortalLoginPage :BasePage
    {
       #region Constructor
        public PortalLoginPage(IWebDriver driver) :base (driver)  {  }
        #endregion

      #region Properties and fields
      public string Email { get; set; }
      public string Password { get; set; }
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
        private By _imgCCS = By.XPath("//*[@id='content']/div/div[1]/div/div/div/span/img");
        private By _LoginScrMsg = By.XPath("//*[@id='content']/div/div[2]/div/div[1]/div/div[1]/table/tbody/tr/td/p/span/span");
        private By _btnSID4GOV = By.XPath("//*[@id='content']/div/div[2]/div/div[2]/div/ul/li/button");
        private By _txtPublicSectorLogin = By.XPath(".//*[@id='content']/div/div[2]/div/div[3]/div/div[1]/p/span/span/strong");
        private By _typeEmail = By.XPath("//*[@id='67:2;a']");
        private By _typePassword = By.XPath("//*[@id='77:2;a']");
        private By _btnLogIn = By.XPath("//*[@id='content']/div/div[3]/div/div/div/div[3]/button/span");
        private By _lnkRegister = By.LinkText("Register");
        //private By _lnkForgotPassword = By.Id("sfdc_forgot");
        private By _lnkForgotPassword = By.LinkText("Forgot your password?");

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
                return driver.FindElement(_LoginScrMsg);
            }
        }
        public IWebElement Sid4GovBtn
        {
            get
            {
                return driver.FindElement(_btnSID4GOV);
            }
        }
        public IWebElement PublicSectorLogin
        {
            get
            {
                return driver.FindElement(_txtPublicSectorLogin);
            }
        }
        public IWebElement UserEmail {
          get {
              return driver.FindElement(_typeEmail);
          }
         
      }
        public IWebElement UserPassword
      {
          get 
          {
              return driver.FindElement(_typePassword);
          }
      }
        public IWebElement LogInBtn
      {
          get
          {
              return driver.FindElement(_btnLogIn);
          }

      }
        public IWebElement RegisterLnk
        {
            get
            {
                return driver.FindElement(_lnkRegister);
            }
        }
        public IWebElement ForgottenPasswordLnk
        {
            get
            {
                return driver.FindElement(_lnkForgotPassword);
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
            Assert.IsTrue(PublicSectorLogin.Displayed);
            Assert.IsTrue(UserEmail.Displayed);
            Assert.IsTrue(UserPassword.Displayed);
            Assert.IsTrue(LogInBtn.Displayed);
            Assert.IsTrue(RegisterLnk.Displayed);
            Assert.IsTrue(ForgottenPasswordLnk.Displayed);
        }

        public void VerifyLoginFailurePage()
        {
            Assert.IsTrue(PageTitle.Displayed);
            Assert.IsTrue(CCSImage.Displayed);
            Assert.IsTrue(SomeMessage.Displayed);
            Assert.IsTrue(Sid4GovBtn.Displayed);
            Assert.IsTrue(PublicSectorLogin.Displayed);
            Assert.IsTrue(UserEmail.Displayed);
            Assert.IsTrue(UserPassword.Displayed);
            Assert.IsTrue(LogInBtn.Displayed);
            Assert.IsTrue(RegisterLnk.Displayed);
            Assert.IsTrue(ForgottenPasswordLnk.Displayed);
            Assert.AreEqual("Your login attempt has failed. Make sure the username and password are correct.", driver.FindElement(By.XPath("//*[@id='error']/div")).Text);
        }

        public void EnterUserEmail(string email)
        {
            GetDisplayedElement(_typeEmail, 500, 15000).SendKeys(email);
        }
        public void EnterUserPassword(string password)
        {
            GetDisplayedElement(_typePassword, 500, 15000).SendKeys(password);
        }
        public void UserLogin(string email, string password)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementToBeClickable(_typeEmail));
            UserEmail.Clear();
            UserEmail.SendKeys(email);
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementToBeClickable(_typePassword));
            UserPassword.Clear();
            UserPassword.SendKeys(password);
        }

        public void ClickOnLogIn()
            {
            if (LogInBtn.Displayed)
                {
                LogInBtn.Click();
                Thread.Sleep(5000);
                }
            else
                {
                    throw new Exception("Element is not found or not clickable") ;
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
        public void ClickOnForgottenPassword()
        {
            if (ForgottenPasswordLnk.Displayed)
            {
                ForgottenPasswordLnk.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        #endregion
    }
}
