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
    public class TestBase : BasePage
    {
        public TestBase(IWebDriver driver): base(driver) {  }
        private static string BaseUrl = "https://crowncommercial--pemqa.cs83.my.salesforce.com/";
        public static LoginPage login = new LoginPage(driver);
        public static LandingPage landing = new LandingPage(driver);
        public static ArticleManagementPage articlemanagement = new ArticleManagementPage(driver);
        public static CasesPage cases = new CasesPage(driver);
        public static ContractsPage contracts = new ContractsPage(driver);
        public static ContactsPage contacts = new ContactsPage(driver);
        public static FrameworksPage frameworks = new FrameworksPage(driver);
        public static KnowledgePage knowledge = new KnowledgePage(driver);
        public static OrganisationsPage organisations = new OrganisationsPage(driver);
        public static OrganisationNewPage newOrg = new OrganisationNewPage(driver);
        public static OrganisationEditPage orgEdit = new OrganisationEditPage(driver);
        public static OrganisationRecordPage orgRecord = new OrganisationRecordPage(driver);
        public static ProfileHomePage home = new ProfileHomePage(driver);
        public static ReportsPage reports = new ReportsPage(driver);
        public static TriageLevelsPage triage = new TriageLevelsPage(driver);
        public static ChatterPage chatter = new ChatterPage(driver);
        public static AllTabsPage alltabs = new AllTabsPage(driver);
        



        [BeforeFeature ]
        public static void TestSetUp()
        {
           driver = SetWebDriver();
           GoToUrl(BaseUrl);
        }

        [AfterTestRun]
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
