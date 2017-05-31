using System;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using SalesForce.Pages;
using SalesForce.Hooks;
using SalesForce.TestFeature;

namespace SalesForce.Hooks
{
    [Binding]
  public class SFTestBase : SFBasePage
    {
        public SFTestBase(IWebDriver driver): base(driver) {  }
        private static string BaseUrl = "https://crowncommercial--pemqa.cs83.my.salesforce.com/";
        public static SFLoginPage login = new SFLoginPage(driver);
        public static SFHomePage home = new SFHomePage(driver);

        [BeforeFeature ]
        public static void TestSetUp()
        {
           driver = SetWebDriver();
           GoToUrl(BaseUrl);
        }

        [AfterFeature]
        public static void TestTearDown()
        {
            driver.Close();
        }

        //protected override bool CurrentPage()
        //{
        //   throw new NotImplementedException();
        //}
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

        ////Capture Screenshot
        //public static void takeScreenshot(String filename)
        //{
        //    ITakesScreenshot screenshotHandler = driver as ITakesScreenshot;
        //    Screenshot screenshot = screenshotHandler.GetScreenshot();
        //    screenshot.SaveAsFile(filename + "png", ScreenshotImageFormat.Png);
        //}
    }
}
