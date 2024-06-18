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
namespace SimpleIdServer.IdServer.Host.Acceptance.Tests.Features.GrantTypes
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class TokenExchangeGrantTypeErrorsFeature : object, Xunit.IClassFixture<TokenExchangeGrantTypeErrorsFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "TokenExchangeGrantTypeErrors.feature"
#line hidden
        
        public TokenExchangeGrantTypeErrorsFeature(TokenExchangeGrantTypeErrorsFeature.FixtureData fixtureData, SimpleIdServer_IdServer_Host_Acceptance_Tests_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/GrantTypes", "TokenExchangeGrantTypeErrors", "\tCheck errors returned when using \'urn:ietf:params:oauth:grant-type:token-exchang" +
                    "e\' grant-type", ProgrammingLanguage.CSharp, featureTags);
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
        
        [Xunit.SkippableFactAttribute(DisplayName="Parameter \'subject_token\' is required")]
        [Xunit.TraitAttribute("FeatureTitle", "TokenExchangeGrantTypeErrors")]
        [Xunit.TraitAttribute("Description", "Parameter \'subject_token\' is required")]
        public void ParameterSubject_TokenIsRequired()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Parameter \'subject_token\' is required", null, tagsOfScenario, argumentsOfScenario, featureTags);
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
                TechTalk.SpecFlow.Table table340 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table340.AddRow(new string[] {
                            "grant_type",
                            "urn:ietf:params:oauth:grant-type:token-exchange"});
                table340.AddRow(new string[] {
                            "client_id",
                            "sixtySixClient"});
                table340.AddRow(new string[] {
                            "client_secret",
                            "password"});
#line 5
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table340, "When ");
#line hidden
#line 11
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 12
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 13
 testRunner.And("JSON \'$.error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 14
 testRunner.And("JSON \'$.error_description\'=\'missing parameter subject_token\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Parameter \'subject_token_type\' is required")]
        [Xunit.TraitAttribute("FeatureTitle", "TokenExchangeGrantTypeErrors")]
        [Xunit.TraitAttribute("Description", "Parameter \'subject_token_type\' is required")]
        public void ParameterSubject_Token_TypeIsRequired()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Parameter \'subject_token_type\' is required", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 16
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table341 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table341.AddRow(new string[] {
                            "grant_type",
                            "urn:ietf:params:oauth:grant-type:token-exchange"});
                table341.AddRow(new string[] {
                            "client_id",
                            "sixtySixClient"});
                table341.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table341.AddRow(new string[] {
                            "subject_token",
                            "subject"});
#line 17
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table341, "When ");
#line hidden
#line 24
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 25
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 26
 testRunner.And("JSON \'$.error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 27
 testRunner.And("JSON \'$.error_description\'=\'missing parameter subject_token_type\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Parameter \'subject_token_type\' is not recognized")]
        [Xunit.TraitAttribute("FeatureTitle", "TokenExchangeGrantTypeErrors")]
        [Xunit.TraitAttribute("Description", "Parameter \'subject_token_type\' is not recognized")]
        public void ParameterSubject_Token_TypeIsNotRecognized()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Parameter \'subject_token_type\' is not recognized", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 29
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table342 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table342.AddRow(new string[] {
                            "grant_type",
                            "urn:ietf:params:oauth:grant-type:token-exchange"});
                table342.AddRow(new string[] {
                            "client_id",
                            "sixtySixClient"});
                table342.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table342.AddRow(new string[] {
                            "subject_token",
                            "subject"});
                table342.AddRow(new string[] {
                            "subject_token_type",
                            "tokentype"});
#line 30
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table342, "When ");
#line hidden
#line 38
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 39
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 40
 testRunner.And("JSON \'$.error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 41
 testRunner.And("JSON \'$.error_description\'=\'the token type tokentype is not supported\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Parameter \'requested_token_type\' is not recognized")]
        [Xunit.TraitAttribute("FeatureTitle", "TokenExchangeGrantTypeErrors")]
        [Xunit.TraitAttribute("Description", "Parameter \'requested_token_type\' is not recognized")]
        public void ParameterRequested_Token_TypeIsNotRecognized()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Parameter \'requested_token_type\' is not recognized", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 43
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table343 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table343.AddRow(new string[] {
                            "grant_type",
                            "urn:ietf:params:oauth:grant-type:token-exchange"});
                table343.AddRow(new string[] {
                            "client_id",
                            "sixtySixClient"});
                table343.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table343.AddRow(new string[] {
                            "subject_token",
                            "subject"});
                table343.AddRow(new string[] {
                            "subject_token_type",
                            "urn:ietf:params:oauth:token-type:access_token"});
                table343.AddRow(new string[] {
                            "requested_token_type",
                            "invalid"});
#line 44
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table343, "When ");
#line hidden
#line 53
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 54
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 55
 testRunner.And("JSON \'$.error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 56
 testRunner.And("JSON \'$.error_description\'=\'the requested token type invalid is not supported\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Subject cannot be extracted from the subject_token")]
        [Xunit.TraitAttribute("FeatureTitle", "TokenExchangeGrantTypeErrors")]
        [Xunit.TraitAttribute("Description", "Subject cannot be extracted from the subject_token")]
        public void SubjectCannotBeExtractedFromTheSubject_Token()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Subject cannot be extracted from the subject_token", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 58
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table344 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table344.AddRow(new string[] {
                            "key",
                            "value"});
#line 59
 testRunner.Given("build access_token and sign with the key \'keyid\'", ((string)(null)), table344, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table345 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table345.AddRow(new string[] {
                            "grant_type",
                            "urn:ietf:params:oauth:grant-type:token-exchange"});
                table345.AddRow(new string[] {
                            "client_id",
                            "sixtySixClient"});
                table345.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table345.AddRow(new string[] {
                            "subject_token",
                            "$access_token$"});
                table345.AddRow(new string[] {
                            "subject_token_type",
                            "urn:ietf:params:oauth:token-type:access_token"});
#line 63
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table345, "When ");
#line hidden
#line 71
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 72
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 73
 testRunner.And("JSON \'$.error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 74
 testRunner.And("JSON \'$.error_description\'=\'the subject cannot be extracted from the subject_toke" +
                        "n\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="The parameter \'actor_subject_type\' is not recognized")]
        [Xunit.TraitAttribute("FeatureTitle", "TokenExchangeGrantTypeErrors")]
        [Xunit.TraitAttribute("Description", "The parameter \'actor_subject_type\' is not recognized")]
        public void TheParameterActor_Subject_TypeIsNotRecognized()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The parameter \'actor_subject_type\' is not recognized", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 76
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table346 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table346.AddRow(new string[] {
                            "client_id",
                            "clientId"});
#line 77
 testRunner.Given("build access_token and sign with the key \'keyid\'", ((string)(null)), table346, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table347 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table347.AddRow(new string[] {
                            "grant_type",
                            "urn:ietf:params:oauth:grant-type:token-exchange"});
                table347.AddRow(new string[] {
                            "client_id",
                            "sixtySixClient"});
                table347.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table347.AddRow(new string[] {
                            "subject_token",
                            "$access_token$"});
                table347.AddRow(new string[] {
                            "subject_token_type",
                            "urn:ietf:params:oauth:token-type:access_token"});
                table347.AddRow(new string[] {
                            "actor_token_type",
                            "invalid"});
#line 81
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table347, "When ");
#line hidden
#line 90
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 91
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 92
 testRunner.And("JSON \'$.error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 93
 testRunner.And("JSON \'$.error_description\'=\'the actor type invalid is not supported\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
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
                TokenExchangeGrantTypeErrorsFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                TokenExchangeGrantTypeErrorsFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
