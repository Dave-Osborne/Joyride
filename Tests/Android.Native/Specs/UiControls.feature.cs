﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.34209
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Tests.Android.Native.Specs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Ui Control")]
    [NUnit.Framework.CategoryAttribute("android")]
    public partial class UiControlFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "UiControls.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Ui Control", "In order to interact with form elements\r\nAs a user\r\nI want to be able to enter te" +
                    "xt, toggle checkboxes, etc.", ProgrammingLanguage.CSharp, new string[] {
                        "android"});
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
testRunner.Given("I launch the \"Api Demo\" mobile application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Should be able to see an Left Title label present on screen")]
        public virtual void ShouldBeAbleToSeeAnLeftTitleLabelPresentOnScreen()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Should be able to see an Left Title label present on screen", ((string[])(null)));
#line 10
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 11
testRunner.Given("I tap the \"App\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 12
testRunner.And("I tap the \"Activity\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
testRunner.When("I tap the \"Custom Title\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 14
testRunner.Then("the field \"Left Title\" should be present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Should not see left title label change")]
        public virtual void ShouldNotSeeLeftTitleLabelChange()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Should not see left title label change", ((string[])(null)));
#line 17
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 18
testRunner.Given("I tap the \"App\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 19
testRunner.And("I tap the \"Activity\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
testRunner.And("I tap the \"Custom Title\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 21
testRunner.When("I enter \"New Left Title\" in the \"Left\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 22
testRunner.Then("I should not see the text of element \"Left Title\" equals \"New Left Title\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Should be able to enter text and verify saved changes")]
        public virtual void ShouldBeAbleToEnterTextAndVerifySavedChanges()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Should be able to enter text and verify saved changes", ((string[])(null)));
#line 24
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 25
testRunner.Given("I tap the \"App\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 26
testRunner.And("I tap the \"Activity\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
testRunner.And("I tap the \"Custom Title\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
testRunner.And("I enter \"New Left Title\" in the \"Left\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
testRunner.When("I tap the \"Change Left\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 30
testRunner.Then("I should see the text of element \"Left Title\" equals \"New Left Title\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Should show label when checkox is enabled")]
        public virtual void ShouldShowLabelWhenCheckoxIsEnabled()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Should show label when checkox is enabled", ((string[])(null)));
#line 32
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 33
testRunner.Given("I tap the \"App\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 34
testRunner.And("I tap the \"Activity\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 35
testRunner.And("I moderately scroll the screen down", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
testRunner.And("I tap the \"Presentation\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
testRunner.When("I check the \"Show All Displays\" checkbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 38
testRunner.Then("I should see the \"Show All Displays\" checkbox checked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 39
testRunner.And("I should see a label equals text \"Display #0: Built-in Screen\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Should not show label when checkox is enabled")]
        public virtual void ShouldNotShowLabelWhenCheckoxIsEnabled()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Should not show label when checkox is enabled", ((string[])(null)));
#line 41
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 42
testRunner.Given("I tap the \"App\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 43
testRunner.And("I tap the \"Activity\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 44
testRunner.And("I moderately scroll the screen down", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 45
testRunner.And("I tap the \"Presentation\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 46
testRunner.And("I check the \"Show All Displays\" checkbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 47
testRunner.When("I uncheck the \"Show All Displays\" checkbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 48
testRunner.Then("I should not see the \"Show All Displays\" checkbox checked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 49
testRunner.And("I should not see a label equals text \"Display #0: Built-in Screen\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Should be able to clear text")]
        public virtual void ShouldBeAbleToClearText()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Should be able to clear text", ((string[])(null)));
#line 51
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 52
testRunner.Given("I tap the \"App\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 53
testRunner.And("I tap the \"Activity\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 54
testRunner.And("I tap the \"Custom Title\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 55
testRunner.And("I clear the text for field \"Left\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 56
testRunner.When("I tap the \"Change Left\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 57
testRunner.Then("I should see the text of field \"Left\" cleared", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
