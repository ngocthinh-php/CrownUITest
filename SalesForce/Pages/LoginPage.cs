using System.Threading;

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
    #endregion

    public class LoginPage : BasePage
    {
        #region Constructor
        public LoginPage(IWebDriver Driver) : base(Driver){ }
        #endregion

        #region Identify fields 
        private By _labelUsername = By.XPath("//*[@id='usernamegroup']/label");
        private By _labelPassword = By.XPath("//*[@id='login_form']/label");
        private By _labelRememberMe = By.XPath("//*[@id='login_form']/div[3]/label");
        //private By _typeUserName = By.XPath("//*[@id='login_form']/label");
        private By _typeUserName = By.Id("username");
        //private By _typePassword = By.XPath("//*[@id='password']");
        private By _typePassword = By.Id("password");
        private By _btnLogIn = By.XPath("//*[@id='Login']");
        //private By _chkBoxRememberMe = By.XPath("//*[@id='rememberUn']");
        private By _chkBoxRememberMe = By.Id("rememberUn");
        private By _lnkForgotPassword = By.XPath("//*[@id='forgot_password_link']");
        #endregion

        #region Properties
        public IWebElement UserEmail
        {
            get
            {
                return driver.FindElement(_typeUserName);
            }

        }
        public IWebElement UserPassword
        {
            get
            {
                return driver.FindElement(_typePassword);
            }
        }
        public IWebElement ForgottenPasswordLnk
        {
            get
            {
                return driver.FindElement(_lnkForgotPassword);
            }
        }
        public IWebElement RememberMe
        {
            get
            {
                return driver.FindElement(_chkBoxRememberMe);
            }
        }
        public IWebElement LoginButton
        {
            get
            {
                return driver.FindElement(_btnLogIn);
            }
        }
        #endregion

        #region Public methods
        public void VerifyPage()
        {
            Assert.AreEqual("Login | Salesforce", driver.Title);

        }

        public void VerifyLoginFailurePage()
        {
            Assert.AreEqual("Your login attempt has failed. Make sure the username and password are correct.", driver.FindElement(By.XPath("//*[@id='error']/div")).Text);
        }

        public void EnterUserEmail(string email)
        {
            GetDisplayedElement(_typeUserName, 500, 15000).SendKeys(email);
        }
        public void EnterUserPassword(string password)
        {
            GetDisplayedElement(_typePassword, 500, 15000).SendKeys(password);
        }
        public void UserLogin(string email, string password)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));
            wait.Until(ExpectedConditions.ElementToBeClickable(_typeUserName));
            UserEmail.Clear();
            UserEmail.SendKeys(email);
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementToBeClickable(_typePassword));
            UserPassword.Clear();
            UserPassword.SendKeys(password);
            Thread.Sleep(2000);
        }
        public void ClickOnLogIn()
        {
            if (LoginButton.Displayed)
            {
                LoginButton.Click();
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
        public void ClickOnRememberMe()
        {
            if (RememberMe.Displayed)
            {
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                IWebElement hiddenLink = driver.FindElement(_chkBoxRememberMe);
                String script = "arguments[0].click();";
                js.ExecuteScript(script, hiddenLink);

                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));
                wait.Until(ExpectedConditions.ElementToBeClickable(_chkBoxRememberMe));
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }


        #endregion
    }
}
    

