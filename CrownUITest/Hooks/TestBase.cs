using CrownUITest.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;
using CrownUITest.Utilities;

namespace CrownUITest.Hooks
{
[Binding]
  public class TestBase : BasePage
    {
        public TestBase(IWebDriver driver): base(driver) {  }
        //PEMQA
        //private static string BaseUrl = "https://pemqa-ccs-portal.cs83.force.com/s/login/";
        //BAUQA
        private static string BaseUrl = "https://crowncommercial--bauqa.cs86.my.salesforce.com/";
        public static PortalLoginPage login = new PortalLoginPage(driver);
        public static PortalHomePage home = new PortalHomePage(driver);
        public static PortalForgotPasswordPage forgotpassword = new PortalForgotPasswordPage(driver);
        public static PortalCheckPasswordResetEmailPage passwordresetemail = new PortalCheckPasswordResetEmailPage(driver);
        public static PortalUserRegistrationPage userreg = new PortalUserRegistrationPage(driver);
        public static PortalSelfRegisterConfirmationPage regconfirm = new PortalSelfRegisterConfirmationPage(driver);
        public static CaptureScreenshot  print = new CaptureScreenshot(driver);
        //public static PopUP up = new PopUP(driver);
        private static StringBuilder verificationErrors;

        [BeforeScenario]
        public static void SetUpBeforeScenario() { }
        [BeforeFeature ]
        public static void TestSetUp()
        {
           driver = SetWebDriver();
           GoToUrl(BaseUrl);
           verificationErrors = new StringBuilder();
        }

        [AfterFeature]
        public static void TestTearDown()
        {
           try
            {
                driver.Close();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }

            Assert.AreEqual("", verificationErrors.ToString());
            TestResultUtilities.EndTestResultString();
            TestResultUtilities.WriteToHtmlFile(TestResultUtilities.testResultHtmlString.ToString(), "SeleniumMasterLoginTestResult.html");
        }
        [AfterScenario]
        public static void AfterTestScenario() { }

        protected override bool CurrentPage()
        {
           throw new NotImplementedException();
        }
        public static void GoToUrl(string url)
        {
            try
            {
                driver.Navigate().GoToUrl(url);
                driver.Manage().Window.Maximize();                
            }
            catch (Exception e)
            {
                throw;
            }
        }
        public static IWebDriver WebDriver
        {
            get
            {
                if (driver == null)
                {
                    driver = SetWebDriver();
                }
                return driver;
            }
        }
        private static IWebDriver SetWebDriver()
        {
            try
            {
                return SetChromeDriver();
            }
            catch (Exception)
            {
                throw;
            }
        }
        private IWebDriver SetFirefoxDriver()
        {
            try
            {
                var binary = new FirefoxBinary(@"C:\Program Files(x86)\Mozilla Firefox\firefox.exe");
                var profile = new FirefoxProfile();
                profile.AcceptUntrustedCertificates = true;
                profile.DeleteAfterUse = true;

                return new FirefoxDriver(profile);
            }
            catch (Exception)
            {

                throw;
            }
        }
        private static IWebDriver SetChromeDriver()
        {
            try
            {
                return new ChromeDriver();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private string driverparams = "{\"Driver\":\"Firefox\"}";

        //Capture Screenshot
        public static void takeScreenshot(String filename)
        {
            ITakesScreenshot screenshotHandler = driver as ITakesScreenshot;
            Screenshot screenshot = screenshotHandler.GetScreenshot();
            screenshot.SaveAsFile(filename + "png", ScreenshotImageFormat.Png);
        }
    }
}
