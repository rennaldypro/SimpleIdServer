﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SimpleIdServer.IdServer.Host.Acceptance.Tests.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class TokenErrorsFeature : object, Xunit.IClassFixture<TokenErrorsFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "TokenErrors.feature"
#line hidden
        
        public TokenErrorsFeature(TokenErrorsFeature.FixtureData fixtureData, SimpleIdServer_IdServer_Host_Acceptance_Tests_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "TokenErrors", "\tCheck errors returned by the token endpoint", ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public void TestInitialize()
        {
        }
        
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Send an empty request")]
        [Xunit.TraitAttribute("FeatureTitle", "TokenErrors")]
        [Xunit.TraitAttribute("Description", "Send an empty request")]
        public void SendAnEmptyRequest()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Send an empty request", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 4
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table505 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
#line 5
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table505, "When ");
#line hidden
#line 8
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 10
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 11
 testRunner.And("JSON \'$.error\'=\'invalid_grant\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 12
 testRunner.And("JSON \'$.error_description\'=\'bad grant type\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="authorization cannot used twice")]
        [Xunit.TraitAttribute("FeatureTitle", "TokenErrors")]
        [Xunit.TraitAttribute("Description", "authorization cannot used twice")]
        public void AuthorizationCannotUsedTwice()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("authorization cannot used twice", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 14
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 15
 testRunner.Given("authenticate a user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table506 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table506.AddRow(new string[] {
                            "response_type",
                            "code"});
                table506.AddRow(new string[] {
                            "client_id",
                            "thirdClient"});
                table506.AddRow(new string[] {
                            "state",
                            "state"});
                table506.AddRow(new string[] {
                            "redirect_uri",
                            "http://localhost:8080"});
                table506.AddRow(new string[] {
                            "response_mode",
                            "query"});
                table506.AddRow(new string[] {
                            "scope",
                            "secondScope"});
#line 16
 testRunner.When("execute HTTP GET request \'https://localhost:8080/authorization\'", ((string)(null)), table506, "When ");
#line hidden
#line 25
 testRunner.And("extract parameter \'code\' from redirect url", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 26
 testRunner.And("extract parameter \'state\' from redirect url", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table507 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table507.AddRow(new string[] {
                            "client_id",
                            "thirdClient"});
                table507.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table507.AddRow(new string[] {
                            "grant_type",
                            "authorization_code"});
                table507.AddRow(new string[] {
                            "code",
                            "$code$"});
                table507.AddRow(new string[] {
                            "redirect_uri",
                            "http://localhost:8080"});
#line 28
 testRunner.And("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table507, "And ");
#line hidden
                TechTalk.SpecFlow.Table table508 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table508.AddRow(new string[] {
                            "client_id",
                            "thirdClient"});
                table508.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table508.AddRow(new string[] {
                            "grant_type",
                            "authorization_code"});
                table508.AddRow(new string[] {
                            "code",
                            "$code$"});
                table508.AddRow(new string[] {
                            "redirect_uri",
                            "http://localhost:8080"});
#line 36
 testRunner.And("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table508, "And ");
#line hidden
#line 44
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 46
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 47
 testRunner.And("JSON \'$.error\'=\'invalid_grant\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 48
 testRunner.And("JSON \'$.error_description\'=\'authorization code has already been used, all tokens " +
                        "previously issued have been revoked\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                TokenErrorsFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                TokenErrorsFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
