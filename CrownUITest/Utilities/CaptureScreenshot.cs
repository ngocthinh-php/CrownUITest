using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Events;
using System.IO;
using AventStack.ExtentReports;
using NUnit.Framework;
using System.Drawing.Imaging;

namespace CrownUITest.Pages
{
    [TestFixture]
    public class CaptureScreenshot : BasePage
    {
        public CaptureScreenshot(IWebDriver Driver) : base(Driver)
        {
        }

        protected override bool CurrentPage()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Path of the image taken.
        /// </summary>
        private string FileName
        {
            get
            {
                return string.Format(
                    @"C:\SeleniumScreenshot\Screenshot-{0}.jpg", DateTime.Now.ToString("ddMMyyyy-HHmmss"));
            }
        }

        /// <summary>
        /// Takes a screen shot of the current content of the browser.
        /// </summary>
        /// <returns>Uri of the screenshot taken.</returns>
        public string TestCaptureScreenshot()
        {
            var screenshotDriver = (ITakesScreenshot)driver;
            var screenshot = screenshotDriver.GetScreenshot();
            var fileName = FileName;
            screenshot.SaveAsFile(fileName,ImageFormat.Jpeg);

            //Log.Write( LoggingSeverity.Information, LoggingArea.SeleniumTests,   string.Format("Taken at screenshot: {0}", fileName));
            return fileName;
        }

        //public ExtentReports extent;
        //public ExtentTest test;

        //[OneTimeSetUp]
        //public void StartReport()
        //{
        //    string pth = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
        //    string actualPath = pth.Substring(0, pth.LastIndexOf("bin"));
        //    string projectPath = new Uri(actualPath).LocalPath;

        //    string reportPath = projectPath + "Report\\MyOwnReport.html";
        //    extent = new ExtentReports(reportPath, true);

        //    extent.AddSystemInfo("Host Name", "Chitta")
        //        .AddSystemInfo("Environment", "QA")
        //        .AddSystemInfo("User Name", "Chitta Jena");

        //    extent.LoadConfig(projectPath + "extent-config.xml");
        //}

        //[Test]
        //public void DemoReportPass()
        //{
        //    test = extent.StartTest("DemoReportPass");
        //    Assert.IsTrue(true);
        //    test.Log(LogStatus.Pass, "Assert Pass as condition is True");
        //}
        //[Test]
        //public void DemoReportFail()
        //{
        //    test = extent.StartTest("DemoReportFail");
        //    Assert.IsTrue(false);
        //    test.Log(LogStatus.Pass, "Assert Pass as condition is False");
        //}

        //[TearDown]
        //public void GetResult()
        //{
        //    var status = TestContext.CurrentContext.Result.Outcome.Status;
        //    var stackTrace = "<pre>" + TestContext.CurrentContext.Result.StackTrace + "</pre>";
        //    var errorMessage = TestContext.CurrentContext.Result.Message;
        //    if (status == NUnit.Framework.Interfaces.TestStatus.Failed)
        //    {
        //        test.Log(LogStatus.Fail, stackTrace + errorMessage);

        //    }
        //    extent.EndTest(test);
        //}
        //[OneTimeTearDown]
        //public void EndReport()
        //{
        //    extent.Flush();
        //    extent.Close();
        //}

        //public CaptureScreenshot(IWebDriver Driver) : base(Driver)
        //{
        //    Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
        //    ss.SaveAsFile("C:\\sample.png", System.Drawing.Imaging.ImageFormat.Png);

        //}
    }
}
