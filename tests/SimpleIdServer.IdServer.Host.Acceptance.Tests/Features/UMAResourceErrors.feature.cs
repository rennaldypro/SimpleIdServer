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
    public partial class UMAResourceErrorsFeature : object, Xunit.IClassFixture<UMAResourceErrorsFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "UMAResourceErrors.feature"
#line hidden
        
        public UMAResourceErrorsFeature(UMAResourceErrorsFeature.FixtureData fixtureData, SimpleIdServer_IdServer_Host_Acceptance_Tests_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "UMAResourceErrors", "\tCheck errors returned by the /rreguri\t", ProgrammingLanguage.CSharp, featureTags);
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
        
        [Xunit.SkippableFactAttribute(DisplayName="cannot retrieve unknown UMA resource")]
        [Xunit.TraitAttribute("FeatureTitle", "UMAResourceErrors")]
        [Xunit.TraitAttribute("Description", "cannot retrieve unknown UMA resource")]
        public void CannotRetrieveUnknownUMAResource()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("cannot retrieve unknown UMA resource", null, tagsOfScenario, argumentsOfScenario, featureTags);
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
                TechTalk.SpecFlow.Table table449 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table449.AddRow(new string[] {
                            "client_id",
                            "fiftyThreeClient"});
                table449.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table449.AddRow(new string[] {
                            "scope",
                            "uma_protection"});
                table449.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
#line 5
 testRunner.When("execute HTTP POST request \'http://localhost/token\'", ((string)(null)), table449, "When ");
#line hidden
#line 12
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 13
 testRunner.And("extract parameter \'access_token\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table450 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table450.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
#line 15
 testRunner.And("execute HTTP GET request \'http://localhost/rreguri/1\'", ((string)(null)), table450, "And ");
#line hidden
#line 19
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 21
 testRunner.Then("HTTP status code equals to \'404\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 22
 testRunner.Then("JSON \'error\'=\'not_found\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 23
 testRunner.Then("JSON \'error_description\'=\'the UMA resource doesn\'t exist\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Impossible to add UMA resource when resource_scopes parameter is missing")]
        [Xunit.TraitAttribute("FeatureTitle", "UMAResourceErrors")]
        [Xunit.TraitAttribute("Description", "Impossible to add UMA resource when resource_scopes parameter is missing")]
        public void ImpossibleToAddUMAResourceWhenResource_ScopesParameterIsMissing()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Impossible to add UMA resource when resource_scopes parameter is missing", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 25
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table451 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table451.AddRow(new string[] {
                            "client_id",
                            "fiftyThreeClient"});
                table451.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table451.AddRow(new string[] {
                            "scope",
                            "uma_protection"});
                table451.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
#line 26
 testRunner.When("execute HTTP POST request \'http://localhost/token\'", ((string)(null)), table451, "When ");
#line hidden
#line 33
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 34
 testRunner.And("extract parameter \'access_token\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table452 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table452.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
#line 36
 testRunner.And("execute HTTP POST JSON request \'http://localhost/rreguri\'", ((string)(null)), table452, "And ");
#line hidden
#line 40
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 42
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 43
 testRunner.Then("JSON \'error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 44
 testRunner.Then("JSON \'error_description\'=\'missing parameter resource_scopes\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Impossible to add UMA resource when subject parameter is missing")]
        [Xunit.TraitAttribute("FeatureTitle", "UMAResourceErrors")]
        [Xunit.TraitAttribute("Description", "Impossible to add UMA resource when subject parameter is missing")]
        public void ImpossibleToAddUMAResourceWhenSubjectParameterIsMissing()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Impossible to add UMA resource when subject parameter is missing", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 46
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table453 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table453.AddRow(new string[] {
                            "client_id",
                            "fiftyThreeClient"});
                table453.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table453.AddRow(new string[] {
                            "scope",
                            "uma_protection"});
                table453.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
#line 47
 testRunner.When("execute HTTP POST request \'http://localhost/token\'", ((string)(null)), table453, "When ");
#line hidden
#line 54
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 55
 testRunner.And("extract parameter \'access_token\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table454 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table454.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
                table454.AddRow(new string[] {
                            "resource_scopes",
                            "[ \"scope\" ]"});
#line 57
 testRunner.And("execute HTTP POST JSON request \'http://localhost/rreguri\'", ((string)(null)), table454, "And ");
#line hidden
#line 62
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 64
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 65
 testRunner.Then("JSON \'error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 66
 testRunner.Then("JSON \'error_description\'=\'missing parameter subject\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Impossible to update UMA resource when resource_scopes is missing")]
        [Xunit.TraitAttribute("FeatureTitle", "UMAResourceErrors")]
        [Xunit.TraitAttribute("Description", "Impossible to update UMA resource when resource_scopes is missing")]
        public void ImpossibleToUpdateUMAResourceWhenResource_ScopesIsMissing()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Impossible to update UMA resource when resource_scopes is missing", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 68
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table455 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table455.AddRow(new string[] {
                            "client_id",
                            "fiftyThreeClient"});
                table455.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table455.AddRow(new string[] {
                            "scope",
                            "uma_protection"});
                table455.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
#line 69
 testRunner.When("execute HTTP POST request \'http://localhost/token\'", ((string)(null)), table455, "When ");
#line hidden
#line 76
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 77
 testRunner.And("extract parameter \'access_token\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table456 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table456.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
#line 79
 testRunner.And("execute HTTP PUT JSON request \'http://localhost/rreguri/id\'", ((string)(null)), table456, "And ");
#line hidden
#line 83
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 85
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 86
 testRunner.Then("JSON \'error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 87
 testRunner.Then("JSON \'error_description\'=\'missing parameter resource_scopes\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Impossible to update an unknown UMA resource")]
        [Xunit.TraitAttribute("FeatureTitle", "UMAResourceErrors")]
        [Xunit.TraitAttribute("Description", "Impossible to update an unknown UMA resource")]
        public void ImpossibleToUpdateAnUnknownUMAResource()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Impossible to update an unknown UMA resource", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 89
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table457 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table457.AddRow(new string[] {
                            "client_id",
                            "fiftyThreeClient"});
                table457.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table457.AddRow(new string[] {
                            "scope",
                            "uma_protection"});
                table457.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
#line 90
 testRunner.When("execute HTTP POST request \'http://localhost/token\'", ((string)(null)), table457, "When ");
#line hidden
#line 97
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 98
 testRunner.And("extract parameter \'access_token\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table458 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table458.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
                table458.AddRow(new string[] {
                            "resource_scopes",
                            "[ \"scope\" ]"});
#line 100
 testRunner.And("execute HTTP PUT JSON request \'http://localhost/rreguri/unknown\'", ((string)(null)), table458, "And ");
#line hidden
#line 105
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 107
 testRunner.Then("HTTP status code equals to \'404\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 108
 testRunner.Then("JSON \'error\'=\'not_found\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 109
 testRunner.Then("JSON \'error_description\'=\'the UMA resource doesn\'t exist\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Impossible to remove an unknown UMA resource")]
        [Xunit.TraitAttribute("FeatureTitle", "UMAResourceErrors")]
        [Xunit.TraitAttribute("Description", "Impossible to remove an unknown UMA resource")]
        public void ImpossibleToRemoveAnUnknownUMAResource()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Impossible to remove an unknown UMA resource", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 111
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table459 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table459.AddRow(new string[] {
                            "client_id",
                            "fiftyThreeClient"});
                table459.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table459.AddRow(new string[] {
                            "scope",
                            "uma_protection"});
                table459.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
#line 112
 testRunner.When("execute HTTP POST request \'http://localhost/token\'", ((string)(null)), table459, "When ");
#line hidden
#line 119
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 120
 testRunner.And("extract parameter \'access_token\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table460 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table460.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
#line 122
 testRunner.And("execute HTTP DELETE request \'http://localhost/rreguri/unknown\'", ((string)(null)), table460, "And ");
#line hidden
#line 126
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 128
 testRunner.Then("HTTP status code equals to \'404\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 129
 testRunner.Then("JSON \'error\'=\'not_found\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 130
 testRunner.Then("JSON \'error_description\'=\'the UMA resource doesn\'t exist\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Impossible to update the permissions when the permissions parameter is missing")]
        [Xunit.TraitAttribute("FeatureTitle", "UMAResourceErrors")]
        [Xunit.TraitAttribute("Description", "Impossible to update the permissions when the permissions parameter is missing")]
        public void ImpossibleToUpdateThePermissionsWhenThePermissionsParameterIsMissing()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Impossible to update the permissions when the permissions parameter is missing", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 132
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table461 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table461.AddRow(new string[] {
                            "client_id",
                            "fiftyThreeClient"});
                table461.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table461.AddRow(new string[] {
                            "scope",
                            "uma_protection"});
                table461.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
#line 133
 testRunner.When("execute HTTP POST request \'http://localhost/token\'", ((string)(null)), table461, "When ");
#line hidden
#line 140
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 141
 testRunner.And("extract parameter \'access_token\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table462 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table462.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
#line 143
 testRunner.And("execute HTTP PUT JSON request \'http://localhost/rreguri/id/permissions\'", ((string)(null)), table462, "And ");
#line hidden
#line 147
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 149
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 150
 testRunner.Then("JSON \'error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 151
 testRunner.Then("JSON \'error_description\'=\'missing parameter permissions\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Impossible to update the permissions when the UMA resource doesn\'t exist")]
        [Xunit.TraitAttribute("FeatureTitle", "UMAResourceErrors")]
        [Xunit.TraitAttribute("Description", "Impossible to update the permissions when the UMA resource doesn\'t exist")]
        public void ImpossibleToUpdateThePermissionsWhenTheUMAResourceDoesntExist()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Impossible to update the permissions when the UMA resource doesn\'t exist", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 153
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table463 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table463.AddRow(new string[] {
                            "client_id",
                            "fiftyThreeClient"});
                table463.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table463.AddRow(new string[] {
                            "scope",
                            "uma_protection"});
                table463.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
#line 154
 testRunner.When("execute HTTP POST request \'http://localhost/token\'", ((string)(null)), table463, "When ");
#line hidden
#line 161
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 162
 testRunner.And("extract parameter \'access_token\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table464 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table464.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
                table464.AddRow(new string[] {
                            "permissions",
                            "[ { claims: [ { name: \"sub\", value: \"user\" } ], scopes: [ \"scope\" ] } ]"});
#line 164
 testRunner.And("execute HTTP PUT JSON request \'http://localhost/rreguri/unknown/permissions\'", ((string)(null)), table464, "And ");
#line hidden
#line 169
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 171
 testRunner.Then("HTTP status code equals to \'404\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 172
 testRunner.Then("JSON \'error\'=\'not_found\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 173
 testRunner.Then("JSON \'error_description\'=\'the UMA resource doesn\'t exist\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Impossible to remove permissions when the UMA resource doesn\'t exist")]
        [Xunit.TraitAttribute("FeatureTitle", "UMAResourceErrors")]
        [Xunit.TraitAttribute("Description", "Impossible to remove permissions when the UMA resource doesn\'t exist")]
        public void ImpossibleToRemovePermissionsWhenTheUMAResourceDoesntExist()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Impossible to remove permissions when the UMA resource doesn\'t exist", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 175
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table465 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table465.AddRow(new string[] {
                            "client_id",
                            "fiftyThreeClient"});
                table465.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table465.AddRow(new string[] {
                            "scope",
                            "uma_protection"});
                table465.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
#line 176
 testRunner.When("execute HTTP POST request \'http://localhost/token\'", ((string)(null)), table465, "When ");
#line hidden
#line 183
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 184
 testRunner.And("extract parameter \'access_token\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table466 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table466.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
#line 186
 testRunner.And("execute HTTP DELETE request \'http://localhost/rreguri/unknown/permissions\'", ((string)(null)), table466, "And ");
#line hidden
#line 190
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 192
 testRunner.Then("HTTP status code equals to \'404\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 193
 testRunner.Then("JSON \'error\'=\'not_found\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 194
 testRunner.Then("JSON \'error_description\'=\'the UMA resource doesn\'t exist\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Impossible to get permissions when the UMA resource doesn\'t exist")]
        [Xunit.TraitAttribute("FeatureTitle", "UMAResourceErrors")]
        [Xunit.TraitAttribute("Description", "Impossible to get permissions when the UMA resource doesn\'t exist")]
        public void ImpossibleToGetPermissionsWhenTheUMAResourceDoesntExist()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Impossible to get permissions when the UMA resource doesn\'t exist", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 196
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table467 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table467.AddRow(new string[] {
                            "client_id",
                            "fiftyThreeClient"});
                table467.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table467.AddRow(new string[] {
                            "scope",
                            "uma_protection"});
                table467.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
#line 197
 testRunner.When("execute HTTP POST request \'http://localhost/token\'", ((string)(null)), table467, "When ");
#line hidden
#line 204
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 205
 testRunner.And("extract parameter \'access_token\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table468 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table468.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
#line 207
 testRunner.And("execute HTTP GET request \'http://localhost/rreguri/unknown/permissions\'", ((string)(null)), table468, "And ");
#line hidden
#line 211
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 213
 testRunner.Then("HTTP status code equals to \'404\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 214
 testRunner.Then("JSON \'error\'=\'not_found\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 215
 testRunner.Then("JSON \'error_description\'=\'the UMA resource doesn\'t exist\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
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
                UMAResourceErrorsFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                UMAResourceErrorsFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
