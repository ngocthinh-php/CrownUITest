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

    public class PortalUserRegistrationPage : BasePage
    {
        #region Constructor
        public PortalUserRegistrationPage(IWebDriver driver) : base(driver) { }
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
        
        private By _labelReg = By.XPath("//*[@id='content']/div/div[2]/div/div[2]/div/div[1]");
        private By _labelTypeOfOrg = By.XPath("//*[@id='content']/div/div[2]/div/div[2]/div/div[2]");
        private By _optionPublicSector = By.XPath("//*[@id='content']/div/div[2]/div/div[2]/div/div[3]/div[1]/div/div[1]");
        //private By _optionPublicSector = By.CssSelector("div.check");
        private By _optionPrivateSector = By.XPath("//*[@id='content']/div/div[2]/div/div[2]/div/div[3]/div[2]/div/div[1]");

        private By _txtFirstName = By.XPath("//*[@placeholder='First Name']");
        private By _txtLastName = By.XPath("//*[@placeholder='Last Name']");
        private By _txtEmail = By.XPath("//*[@placeholder='Email']");

        private By _labelTnCmsg = By.XPath("//*[@id='content']/div/div[2]/div/div[2]/div/div[4]/div[2]/form/div[4]/div/label");
        private By _labelTnClnkTxt = By.LinkText("Terms & Conditions");
        private By _chkBoxTnC = By.XPath("//*[@type='checkbox']");
        //private By _chkBoxTnC = By.Id("312:0");
        private By _lnkLogin = By.LinkText("Login");
        private By _lnkPasswordReminder = By.LinkText("Forgotten your password?");
        //private By _lnkPasswordReminder = By.XPath("//*[@id='content']/div/div[2]/div/div[2]/div/div[4]/div[4]/div[1]/a");

        private By _labelPublicSectorRegistration = By.XPath("//*[@id='content']/div/div[2]/div/div[2]/div/div/div[1]/div[1]/div/h2");
        private By _labelThankYou = By.XPath("//*[@id='content']/div/div[2]/div/div[2]/div/div/div[1]/div[2]/div");
        private By _labelLittlemoreInformation = By.XPath("//*[@id='content']/div/div[2]/div/div[2]/div/div/div[1]/div[3]/div");
        private By _txtYourContactNumber = By.XPath("//*[@placeholder='Your contact number']");
        private By _lstSelectYourOrganisation = By.CssSelector("select.input-container.input.sfdc_usernameinput.sfdc.select.select.uiInput.uiInputSelect.uiInput--default.uiInput--select");
        
        private By _btnSignUp = By.XPath("//*[@id='content']/div/div[2]/div/div[2]/div/div[4]/div[2]/form/div[4]/button");
        private By _btnSignUp2 = By.XPath("//*[@id='content']/div/div[2]/div/div[2]/div/div/div[2]/form/div[3]/button");
        private By _btnSignUp3 = By.XPath("//*[@id='content']/div/div[2]/div/div[2]/div/div/div[2]/form/div[4]/button");

        private By _txtOtherOrganisation = By.XPath("//*[@placeholder='Your organisation']");
        #endregion

        #region On Selecting Private Option
        private By _labelSID4GOVmsg = By.XPath("//*[@id='content']/div/div[2]/div/div[2]/div/div[4]/div/div[1]");
        private By _btnGoToSID4GOV = By.XPath("//*[@id='content']/div/div[2]/div/div[2]/div/div[4]/div/div[2]/button");
        #endregion


        #region WebElement Definition
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
        public IWebElement RegistrationTxt
        {
            get
            {
                return driver.FindElement(_labelReg);
            }
        }
        public IWebElement TypeOfOrganisation
        {
            get
            {
                return driver.FindElement(_labelTypeOfOrg);
            }
        }
        public IWebElement PublicSector
        {
            get
            {
                return driver.FindElement(_optionPublicSector);
            }
        }
        public IWebElement PrivateSector
        {
            get
            {
                return driver.FindElement(_optionPrivateSector);
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
        public IWebElement EnterEmail
        {
            get
            {
                return driver.FindElement(_txtEmail);
            }
        }
        public IWebElement TandCText
        {
            get
            {
                return driver.FindElement(_labelTnCmsg);
            }
        }
        public IWebElement TandCTextlnk
        {
            get
            {
                return driver.FindElement(_labelTnClnkTxt);
            }
        }
        public IWebElement TandCCheckBox
        {
            get
            {
                return driver.FindElement(_chkBoxTnC);
            }
        }
        public IWebElement LogInLink
        {
            get
            {
                return driver.FindElement(_lnkLogin);
            }
        }
        public IWebElement PasswordReminder
        {
            get
            {
                return driver.FindElement(_lnkPasswordReminder);
            }
        }

        public IWebElement SID4GOVTxtMsg
        {
            get
            {
                return driver.FindElement(_labelSID4GOVmsg);
            }
        }
        public IWebElement Sid4GovBtn
        {
            get
            {
                return driver.FindElement(_btnGoToSID4GOV);
            }
        }

        public IWebElement PublicSectorRegistrationTxt
        {
            get
            {
                return driver.FindElement(_labelPublicSectorRegistration);
            }
        }
        public IWebElement ThankYouTxt
        {
            get
            {
                return driver.FindElement(_labelThankYou);
            }
        }
        public IWebElement LittlemoreInformationTxt
        {
            get
            {
                return driver.FindElement(_labelLittlemoreInformation);
            }
        }
        public IWebElement YourContactNumber
        {
            get
            {
                return driver.FindElement(_txtYourContactNumber);
            }
        }
        public IWebElement YourOrganisation
        {
            get
            {
                return driver.FindElement(_lstSelectYourOrganisation);
            }
        }
        public IWebElement OtherOrganisation
        {
            get
            {
                return driver.FindElement(_txtOtherOrganisation);
            }
        }
        public IWebElement SignUpBtn
        {
            get
            {
                return driver.FindElement(_btnSignUp);
            }
        }
        public IWebElement SignUpBtn2
        {
            get
            {
                return driver.FindElement(_btnSignUp2);
            }
        }
        public IWebElement SignUpBtn3
        {
            get
            {
                return driver.FindElement(_btnSignUp3);
            }
        }


        #endregion

        #region Public methods
        public void VerifyPage()
        {
            Assert.IsTrue(PageTitle.Displayed);
            Assert.IsTrue(CCSImage.Displayed);
            Assert.IsTrue(RegistrationTxt.Displayed);
            Assert.IsTrue(TypeOfOrganisation.Displayed);
            Assert.IsTrue(PublicSector.Displayed);
            Assert.IsTrue(PrivateSector.Displayed);
            Assert.AreEqual("What type of organisation do you work for?", driver.FindElement(By.XPath("//*[@id='content']/div/div[2]/div/div[2]/div/div[2]")).Text);
        }
        public void VerifyPublicOption()
        {
            Assert.IsTrue(CCSImage.Displayed);
            Assert.IsTrue(RegistrationTxt.Displayed);
            Assert.IsTrue(TypeOfOrganisation.Displayed);
            Assert.IsTrue(PublicSector.Displayed);
            Assert.IsTrue(PrivateSector.Displayed);
            Assert.IsTrue(FirstName.Displayed);
            Assert.IsTrue(LastName.Displayed);
            Assert.IsTrue(EnterEmail.Displayed);
            Assert.IsTrue(TandCText.Displayed);
            Assert.IsTrue(TandCTextlnk.Displayed);
            Assert.IsTrue(TandCCheckBox.Displayed);
            Assert.IsTrue(SignUpBtn.Displayed);
            Assert.IsTrue(LogInLink.Displayed);
            Assert.IsTrue(PasswordReminder.Displayed);
            Assert.AreEqual("Terms & Conditions", driver.FindElement(By.LinkText("Terms & Conditions")).Text);
        }

        public void RegistrationFailureEmailAddressRegistered()
        {
            Thread.Sleep(5000);
            Assert.AreEqual("This email address is already registered - please use a different email address or login.", driver.FindElement(By.CssSelector(".uiOutputRichText")).Text);
        }

        public void VerifyPublicOptionPart2()
        {
            Assert.IsTrue(YourContactNumber.Displayed);
            Assert.IsTrue(YourOrganisation.Displayed);
            Assert.IsTrue(SignUpBtn2.Displayed);
            Assert.AreEqual("Thank you.", driver.FindElement(By.XPath("//*[@id='content']/div/div[2]/div/div[2]/div/div/div[1]/div[2]/div")).Text);
        }
        public void VerifyPrivateOption()
        {
            Assert.IsTrue(CCSImage.Displayed);
            Assert.IsTrue(RegistrationTxt.Displayed);
            Assert.IsTrue(TypeOfOrganisation.Displayed);
            Assert.IsTrue(PublicSector.Displayed);
            Assert.IsTrue(PrivateSector.Displayed);
            Assert.IsTrue(SID4GOVTxtMsg.Displayed);
            Assert.IsTrue(Sid4GovBtn.Displayed);
            Assert.AreEqual("Please register with SID4GOV - the government's central scheme for private sector organisations. If you're already registered, please login using SID4GOV.", driver.FindElement(By.XPath("//*[@id='content']/div/div[2]/div/div[2]/div/div[4]/div/div[1]")).Text);
        }

        public void VerifyOtherOrganisationField()
        {
            Assert.IsTrue(YourContactNumber.Displayed);
            Assert.IsTrue(YourOrganisation.Displayed);
            Assert.IsTrue(OtherOrganisation.Displayed);
            Assert.IsTrue(SignUpBtn3.Displayed);
            Assert.AreEqual("Thank you.", driver.FindElement(By.XPath("//*[@id='content']/div/div[2]/div/div[2]/div/div/div[1]/div[2]/div")).Text);
        }

        //public void UserEntersFirstName(string firstName)
        //{
        //    GetDisplayedElement(_txtFirstName, 500, 15000).SendKeys(firstName);
        //}
        public void UserEntersFirstName(string firstName)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id='318:0']")));
            FirstName.Clear();
            FirstName.SendKeys(firstName);
            Thread.Sleep(2000);            
        }
        public void UserEntersLastName(string lastName)
        {
            GetDisplayedElement(_txtFirstName, 500, 15000).SendKeys(lastName);
        }
        public void UserEntersEmail(string email)
        {
            GetDisplayedElement(_txtEmail, 500, 15000).SendKeys(email);
        }
        public void UserClicksOnTnCCheckBox()
        {
            GetDisplayedElement(_chkBoxTnC, 500, 15000).Click();
        }
        
        public void UserEnterContactNumber(string contactNumber)
        {
            GetDisplayedElement(_txtYourContactNumber, 500, 15000).SendKeys(contactNumber);
        }
        public void UserSelectsOrganisation(string orgasationSelected)
        {
            GetDisplayedElement(_lstSelectYourOrganisation, 500, 15000).SendKeys(orgasationSelected);
        }
        public void UserEntersOtherOrganisation(string otherOrganisation)
        {
            GetDisplayedElement(_txtOtherOrganisation, 500, 15000).SendKeys(otherOrganisation);
        }

        public void ClickOnPublicSectorRadioBtn()
        {
            if (PublicSector.Displayed)
            {
                PublicSector.Click();
            }
            else
            {
                throw new Exception("Public Sector radio button not found");
            }
        }
        public void ClickOnPrivateSectorRadioBtn()
        {
            if (PrivateSector.Displayed)
            {
                PrivateSector.Click();
            }
            else
            {
                throw new Exception("Private Sector radio button not found");
            }
        }
 
        public void ClickOnTnCCheckBox()
        {
            if (TandCCheckBox.Displayed)
            {
                TandCCheckBox.Click();
            }
            else
            {
                throw new Exception("Terms and conditions Checkbox not found");
            }
        }
        public void ClickOnTncLink()
        {
            if (TandCTextlnk.Displayed)
            {
                TandCTextlnk.Click();
            }
            else
            {
                throw new Exception("Terms and conditions Link not found");
            }

        }
        public void ClickOnSignUpBtnInitial()
        {
            if (SignUpBtn.Displayed)
            {
                SignUpBtn.Click();
            }
            else
            {
                throw new Exception("Sign Up button is not found");
            }
        }
        public void ClickOnSignUpBtnFinal()
        {
            if (SignUpBtn2.Displayed)
            {
                SignUpBtn2.Click();
            }
            else
            {
                throw new Exception("Sign Up button is not found");
            }
        }
        public void ClickOnSignUpBtnOther()
        {
            if (SignUpBtn3.Displayed)
            {
                SignUpBtn3.Click();
            }
            else
            {
                throw new Exception("Sign Up button is not found");
            }
        }
        public void ClickOnLogInLink()
        {
            if (LogInLink.Displayed)
            {
                LogInLink.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }
        public void ClickOnForgotPasswordLink()
        {
            if (PasswordReminder.Displayed)
            {
                PasswordReminder.Click();
            }
            else
            {
                throw new Exception("Element is not found or not clickable");
            }
        }

        //public void SelectYourOrganisation()
        //{
        //    var option = driver.FindElement(_lstSelectYourOrganisation);
        //    var selectElement = new SelectElement(option);
        //    System.Threading.Thread.Sleep(5000);

        //    if (selectElement.SelectByText("Other"))
        //    {
        //        Assert.IsTrue(SignUpBtn3.Displayed);
        //        Assert.IsTrue(OtherOrganisation.Displayed);
        //    }
        //    else 
        //    {
        //        Assert.IsTrue(SignUpBtn2.Displayed);
        //    }            
        //}

        public void SelectTypeOfOrganisation()
        {
            try
            {
                if (PublicSector.Selected == true)
                {
                    VerifyPublicOption();
                }
                else if (PrivateSector.Selected == true)
                {
                    VerifyPrivateOption();
                }
            }
            catch (Exception)
            {
                throw new Exception("Organisation Type not selected");
            }
        }

        public void SelectYourOrganisation(string organisation)
        {
            if (YourOrganisation.Displayed)
            {
                YourOrganisation.Click();
                var x2 = organisation;
                var x1 = "//*[contains(text(),'";
                var x3 = "')]";
                Thread.Sleep(3000);
                //driver.FindElement(By.XPath("//*[contains(text(),'Mailinator')]")).Click();
                driver.FindElement(By.XPath(x1+x2+x3)).Click();
                
            }
            else
            {
                throw new Exception("organisation name could not be selected");
            }
        }

        #endregion

        public void UserEntersInitialInfo(string firstName, string lastName, string email)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementToBeClickable(_txtFirstName));
            FirstName.SendKeys(firstName);
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementToBeClickable(_txtLastName));
            LastName.SendKeys(lastName);
            Thread.Sleep(2000);
            wait.Until(ExpectedConditions.ElementToBeClickable(_txtEmail));
            EnterEmail.SendKeys(email);
        }
    }
}