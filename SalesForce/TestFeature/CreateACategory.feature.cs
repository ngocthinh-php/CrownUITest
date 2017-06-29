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
    [NUnit.Framework.DescriptionAttribute("03 - Create_a_Category_")]
    [NUnit.Framework.CategoryAttribute("Category")]
    public partial class _03_Create_A_Category_Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "CreateACategory.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "03 - Create_a_Category_", "\tIn order to manage enquiries and other requirements \r\n\tAs a Helpdesk Agent or an" +
                    " employee in other parts of CCS entity\r\n\tI would like to be given a mechanism to" +
                    " create cases", ProgrammingLanguage.CSharp, new string[] {
                        "Category"});
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
 testRunner.Given("I am on Category page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("01 Create Category data")]
        [NUnit.Framework.CategoryAttribute("RegressionTest")]
        [NUnit.Framework.TestCaseAttribute("Test Communications", "", "CAS Master Category", "", "CPV", "1500001", "", "", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Test Marketing", "MA", "CAS Category", "Test Communications", "", "151200001", "Test Communications", "", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Test Marketing Services", "", "CAS Sub Category", "Test Marketing", "", "151237300001", "Test Marketing", "A Test to sort out", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Test Marketing Spl Services", "", "CAS Sub Category", "Test Marketing", "", "151237500001", "Test Marketing", "A Test to sort out", new string[0])]
        public virtual void _01CreateCategoryData(string catName, string catCode, string catType, string parent, string codeType, string catExtId, string parentName, string pgDescription, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "RegressionTest"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("01 Create Category data", @__tags);
#line 11
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 12
 testRunner.When("I click on New Category button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 13
 testRunner.Then("I should be navigated to Category Edit page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 14
 testRunner.When(string.Format("I enter category details {0}, {1}, {2}, {3}, {4}, {5}, {6} and Save the record", catName, catCode, catType, parent, catExtId, parentName, pgDescription), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 15
 testRunner.Then("a Category record is created successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
