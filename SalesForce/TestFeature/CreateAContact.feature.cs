﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SalesForce.TestFeature
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("06 - Create_a_Contact_")]
    [NUnit.Framework.CategoryAttribute("Contacts")]
    public partial class _06_Create_A_Contact_Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "CreateAContact.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "06 - Create_a_Contact_", "\tAs a CCS staff I would \r\n\tI would like to create contact details\r\n\tSo that the c" +
                    "ontact details can be associated for various operations", ProgrammingLanguage.CSharp, new string[] {
                        "Contacts"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 7
#line 8
    testRunner.Given("I am on Contact Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create a contact with all fields populated")]
        [NUnit.Framework.CategoryAttribute("RegressionTest")]
        [NUnit.Framework.TestCaseAttribute("Test001", "Customer", "Help Desk Agent", "CSC", "General Contact", "0001", "Active", "01225895988", "0102", "07941373315", "Test001Customer@mailinator.com", "Test001Customer@mailinator.com", "Customer001", "England", "1 Queen Street", "Bristol", "Avon", "BS158BA", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Test002", "Customer", "Help Desk Agent", "CSC", "General Contact", "0001", "Active", "01225895988", "0102", "07941373315", "Test002Customer@mailinator.com", "Test002Customer@mailinator.com", "Customer002", "England", "2 Queen Street", "Bristol", "Avon", "BS158BA", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Test003", "Customer", "Help Desk Agent", "CSC", "General Contact", "0001", "Active", "01225895988", "0102", "07941373315", "Test003Customer@mailinator.com", "Test003Customer@mailinator.com", "Customer002", "England", "3 Queen Street", "Bristol", "Avon", "BS158BA", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Test001", "Supplier", "Help Desk Agent", "CSC", "General Contact", "0001", "Active", "01225895988", "0102", "07941373315", "Test001Supplier@mailinator.com", "Test001Supplier@mailinator.com", "Supplier001", "England", "1 Queen Street", "Bristol", "Avon", "BS158BA", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Test002", "Supplier", "Help Desk Agent", "CSC", "General Contact", "0001", "Active", "01225895988", "0102", "07941373315", "Test002Supplier@mailinator.com", "Test002Supplier@mailinator.com", "Supplier001", "England", "2 Queen Street", "Bristol", "Avon", "BS158BA", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Test003", "Supplier", "Help Desk Agent", "CSC", "General Contact", "0001", "Active", "01225895988", "0102", "07941373315", "Test003Supplier@mailinator.com", "Test003Supplier@mailinator.com", "Supplier001", "England", "3 Queen Street", "Bristol", "Avon", "BS158BA", new string[0])]
        public virtual void CreateAContactWithAllFieldsPopulated(
                    string firstName, 
                    string lastName, 
                    string jobTitle, 
                    string department, 
                    string contactType, 
                    string mktgCampaignRef, 
                    string status, 
                    string telephone, 
                    string extension, 
                    string mobile, 
                    string email, 
                    string addnlemail, 
                    string orgName, 
                    string country, 
                    string addressLine, 
                    string townCity, 
                    string county, 
                    string postcode, 
                    string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "RegressionTest"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create a contact with all fields populated", @__tags);
#line 10
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 11
 testRunner.When(string.Format("I enter new contact details {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10" +
                        "}, {11}, {12}, {13}, {14}, {15}, {16}, {17} and save the record", firstName, lastName, jobTitle, department, contactType, mktgCampaignRef, status, telephone, extension, mobile, email, addnlemail, orgName, country, addressLine, townCity, county, postcode), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 12
 testRunner.Then("contact record should be created successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion