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
    public partial class UMAResourceFeature : object, Xunit.IClassFixture<UMAResourceFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "UMAResource.feature"
#line hidden
        
        public UMAResourceFeature(UMAResourceFeature.FixtureData fixtureData, SimpleIdServer_IdServer_Host_Acceptance_Tests_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "UMAResource", "\tCheck the endpoint /rreguri\t", ProgrammingLanguage.CSharp, featureTags);
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
        
        [Xunit.SkippableFactAttribute(DisplayName="add UMA resource")]
        [Xunit.TraitAttribute("FeatureTitle", "UMAResource")]
        [Xunit.TraitAttribute("Description", "add UMA resource")]
        public void AddUMAResource()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("add UMA resource", null, tagsOfScenario, argumentsOfScenario, featureTags);
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
                TechTalk.SpecFlow.Table table472 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table472.AddRow(new string[] {
                            "client_id",
                            "fiftyThreeClient"});
                table472.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table472.AddRow(new string[] {
                            "scope",
                            "uma_protection"});
                table472.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
#line 5
 testRunner.When("execute HTTP POST request \'http://localhost/token\'", ((string)(null)), table472, "When ");
#line hidden
#line 12
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 13
 testRunner.And("extract parameter \'access_token\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table473 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table473.AddRow(new string[] {
                            "resource_scopes",
                            "[\"scope1\",\"scope2\"]"});
                table473.AddRow(new string[] {
                            "subject",
                            "user1"});
                table473.AddRow(new string[] {
                            "icon_uri",
                            "icon"});
                table473.AddRow(new string[] {
                            "name#fr",
                            "nom"});
                table473.AddRow(new string[] {
                            "name#en",
                            "name"});
                table473.AddRow(new string[] {
                            "description#fr",
                            "descriptionFR"});
                table473.AddRow(new string[] {
                            "description#en",
                            "descriptionEN"});
                table473.AddRow(new string[] {
                            "type",
                            "type"});
                table473.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
#line 15
 testRunner.And("execute HTTP POST JSON request \'http://localhost/rreguri\'", ((string)(null)), table473, "And ");
#line hidden
#line 27
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 29
 testRunner.Then("HTTP status code equals to \'201\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 30
 testRunner.And("JSON exists \'_id\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 31
 testRunner.And("JSON exists \'user_access_policy_uri\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="get UMA resource")]
        [Xunit.TraitAttribute("FeatureTitle", "UMAResource")]
        [Xunit.TraitAttribute("Description", "get UMA resource")]
        public void GetUMAResource()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("get UMA resource", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 33
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table474 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table474.AddRow(new string[] {
                            "client_id",
                            "fiftyThreeClient"});
                table474.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table474.AddRow(new string[] {
                            "scope",
                            "uma_protection"});
                table474.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
#line 34
 testRunner.When("execute HTTP POST request \'http://localhost/token\'", ((string)(null)), table474, "When ");
#line hidden
#line 41
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 42
 testRunner.And("extract parameter \'access_token\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table475 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table475.AddRow(new string[] {
                            "resource_scopes",
                            "[\"scope1\",\"scope2\"]"});
                table475.AddRow(new string[] {
                            "subject",
                            "user1"});
                table475.AddRow(new string[] {
                            "icon_uri",
                            "icon"});
                table475.AddRow(new string[] {
                            "name#fr",
                            "nom"});
                table475.AddRow(new string[] {
                            "name#en",
                            "name"});
                table475.AddRow(new string[] {
                            "description#fr",
                            "descriptionFR"});
                table475.AddRow(new string[] {
                            "description#en",
                            "descriptionEN"});
                table475.AddRow(new string[] {
                            "type",
                            "type"});
                table475.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
#line 44
 testRunner.And("execute HTTP POST JSON request \'http://localhost/rreguri\'", ((string)(null)), table475, "And ");
#line hidden
#line 56
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 57
 testRunner.And("extract parameter \'_id\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table476 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table476.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
#line 59
 testRunner.And("execute HTTP GET request \'http://localhost/rreguri/$_id$\'", ((string)(null)), table476, "And ");
#line hidden
#line 63
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 65
 testRunner.Then("HTTP status code equals to \'200\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 66
 testRunner.And("JSON exists \'resource_scopes\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 67
 testRunner.And("JSON \'icon_uri\'=\'icon\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 68
 testRunner.And("JSON \'name#fr\'=\'nom\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 69
 testRunner.And("JSON \'name#en\'=\'name\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 70
 testRunner.And("JSON \'description#fr\'=\'descriptionFR\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 71
 testRunner.And("JSON \'description#en\'=\'descriptionEN\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 72
 testRunner.And("JSON \'type\'=\'type\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="delete UMA resource")]
        [Xunit.TraitAttribute("FeatureTitle", "UMAResource")]
        [Xunit.TraitAttribute("Description", "delete UMA resource")]
        public void DeleteUMAResource()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("delete UMA resource", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 74
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table477 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table477.AddRow(new string[] {
                            "client_id",
                            "fiftyThreeClient"});
                table477.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table477.AddRow(new string[] {
                            "scope",
                            "uma_protection"});
                table477.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
#line 75
 testRunner.When("execute HTTP POST request \'http://localhost/token\'", ((string)(null)), table477, "When ");
#line hidden
#line 82
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 83
 testRunner.And("extract parameter \'access_token\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table478 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table478.AddRow(new string[] {
                            "resource_scopes",
                            "[\"scope1\",\"scope2\"]"});
                table478.AddRow(new string[] {
                            "subject",
                            "user1"});
                table478.AddRow(new string[] {
                            "icon_uri",
                            "icon"});
                table478.AddRow(new string[] {
                            "name#fr",
                            "nom"});
                table478.AddRow(new string[] {
                            "name#en",
                            "name"});
                table478.AddRow(new string[] {
                            "description#fr",
                            "descriptionFR"});
                table478.AddRow(new string[] {
                            "description#en",
                            "descriptionEN"});
                table478.AddRow(new string[] {
                            "type",
                            "type"});
                table478.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
#line 85
 testRunner.And("execute HTTP POST JSON request \'http://localhost/rreguri\'", ((string)(null)), table478, "And ");
#line hidden
#line 97
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 98
 testRunner.And("extract parameter \'_id\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table479 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table479.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
#line 100
 testRunner.And("execute HTTP DELETE request \'http://localhost/rreguri/$_id$\'", ((string)(null)), table479, "And ");
#line hidden
#line 104
 testRunner.Then("HTTP status code equals to \'204\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="add UMA permissions")]
        [Xunit.TraitAttribute("FeatureTitle", "UMAResource")]
        [Xunit.TraitAttribute("Description", "add UMA permissions")]
        public void AddUMAPermissions()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("add UMA permissions", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 106
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table480 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table480.AddRow(new string[] {
                            "client_id",
                            "fiftyThreeClient"});
                table480.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table480.AddRow(new string[] {
                            "scope",
                            "uma_protection"});
                table480.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
#line 107
 testRunner.When("execute HTTP POST request \'http://localhost/token\'", ((string)(null)), table480, "When ");
#line hidden
#line 114
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 115
 testRunner.And("extract parameter \'access_token\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table481 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table481.AddRow(new string[] {
                            "resource_scopes",
                            "[\"scope1\",\"scope2\"]"});
                table481.AddRow(new string[] {
                            "subject",
                            "user1"});
                table481.AddRow(new string[] {
                            "icon_uri",
                            "icon"});
                table481.AddRow(new string[] {
                            "name#fr",
                            "nom"});
                table481.AddRow(new string[] {
                            "name#en",
                            "name"});
                table481.AddRow(new string[] {
                            "description#fr",
                            "descriptionFR"});
                table481.AddRow(new string[] {
                            "description#en",
                            "descriptionEN"});
                table481.AddRow(new string[] {
                            "type",
                            "type"});
                table481.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
#line 117
 testRunner.And("execute HTTP POST JSON request \'http://localhost/rreguri\'", ((string)(null)), table481, "And ");
#line hidden
#line 129
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 130
 testRunner.And("extract parameter \'_id\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table482 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table482.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
                table482.AddRow(new string[] {
                            "permissions",
                            "[ { \"claims\": [ { \"name\": \"sub\", \"value\": \"user\" } ], \"scopes\": [ \"scope\" ] } ]"});
#line 132
 testRunner.And("execute HTTP PUT JSON request \'http://localhost/rreguri/$_id$/permissions\'", ((string)(null)), table482, "And ");
#line hidden
#line 137
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 139
 testRunner.Then("HTTP status code equals to \'200\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 140
 testRunner.And("JSON exists \'_id\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="delete UMA permissions")]
        [Xunit.TraitAttribute("FeatureTitle", "UMAResource")]
        [Xunit.TraitAttribute("Description", "delete UMA permissions")]
        public void DeleteUMAPermissions()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("delete UMA permissions", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 142
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table483 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table483.AddRow(new string[] {
                            "client_id",
                            "fiftyThreeClient"});
                table483.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table483.AddRow(new string[] {
                            "scope",
                            "uma_protection"});
                table483.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
#line 143
 testRunner.When("execute HTTP POST request \'http://localhost/token\'", ((string)(null)), table483, "When ");
#line hidden
#line 150
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 151
 testRunner.And("extract parameter \'access_token\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table484 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table484.AddRow(new string[] {
                            "resource_scopes",
                            "[\"scope1\",\"scope2\"]"});
                table484.AddRow(new string[] {
                            "subject",
                            "user1"});
                table484.AddRow(new string[] {
                            "icon_uri",
                            "icon"});
                table484.AddRow(new string[] {
                            "name#fr",
                            "nom"});
                table484.AddRow(new string[] {
                            "name#en",
                            "name"});
                table484.AddRow(new string[] {
                            "description#fr",
                            "descriptionFR"});
                table484.AddRow(new string[] {
                            "description#en",
                            "descriptionEN"});
                table484.AddRow(new string[] {
                            "type",
                            "type"});
                table484.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
#line 153
 testRunner.And("execute HTTP POST JSON request \'http://localhost/rreguri\'", ((string)(null)), table484, "And ");
#line hidden
#line 165
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 166
 testRunner.And("extract parameter \'_id\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table485 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table485.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
                table485.AddRow(new string[] {
                            "permissions",
                            "[ { \"claims\": [ { \"name\": \"sub\", \"value\": \"user\" } ], \"scopes\": [ \"scope\" ] } ]"});
#line 168
 testRunner.And("execute HTTP POST JSON request \'http://localhost/rreguri/$_id$/permissions\'", ((string)(null)), table485, "And ");
#line hidden
                TechTalk.SpecFlow.Table table486 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table486.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
#line 173
 testRunner.And("execute HTTP DELETE request \'http://localhost/rreguri/$_id$\'", ((string)(null)), table486, "And ");
#line hidden
#line 177
 testRunner.Then("HTTP status code equals to \'204\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
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
                UMAResourceFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                UMAResourceFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
