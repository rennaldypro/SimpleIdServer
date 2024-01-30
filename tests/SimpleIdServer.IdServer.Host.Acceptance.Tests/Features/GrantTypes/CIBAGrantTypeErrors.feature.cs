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
    public partial class CIBAGrantTypeErrorsFeature : object, Xunit.IClassFixture<CIBAGrantTypeErrorsFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "CIBAGrantTypeErrors.feature"
#line hidden
        
        public CIBAGrantTypeErrorsFeature(CIBAGrantTypeErrorsFeature.FixtureData fixtureData, SimpleIdServer_IdServer_Host_Acceptance_Tests_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/GrantTypes", "CIBAGrantTypeErrors", "\tCheck errors returned when using \'urn:openid:params:grant-type:ciba\' grant-type", ProgrammingLanguage.CSharp, featureTags);
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
        
        [Xunit.SkippableFactAttribute(DisplayName="Only PING or POLL modes are supported to get a token")]
        [Xunit.TraitAttribute("FeatureTitle", "CIBAGrantTypeErrors")]
        [Xunit.TraitAttribute("Description", "Only PING or POLL modes are supported to get a token")]
        public void OnlyPINGOrPOLLModesAreSupportedToGetAToken()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Only PING or POLL modes are supported to get a token", null, tagsOfScenario, argumentsOfScenario, featureTags);
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
                TechTalk.SpecFlow.Table table217 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table217.AddRow(new string[] {
                            "grant_type",
                            "urn:openid:params:grant-type:ciba"});
                table217.AddRow(new string[] {
                            "client_id",
                            "fortyThreeClient"});
                table217.AddRow(new string[] {
                            "X-Testing-ClientCert",
                            "sidClient.crt"});
#line 5
 testRunner.When("execute HTTP POST request \'https://localhost:8080/mtls/token\'", ((string)(null)), table217, "When ");
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
 testRunner.And("JSON \'$.error_description\'=\'only ping or poll mode can be used to get tokens\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="parameter auth_req_id is required")]
        [Xunit.TraitAttribute("FeatureTitle", "CIBAGrantTypeErrors")]
        [Xunit.TraitAttribute("Description", "parameter auth_req_id is required")]
        public void ParameterAuth_Req_IdIsRequired()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("parameter auth_req_id is required", null, tagsOfScenario, argumentsOfScenario, featureTags);
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
                TechTalk.SpecFlow.Table table218 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table218.AddRow(new string[] {
                            "grant_type",
                            "urn:openid:params:grant-type:ciba"});
                table218.AddRow(new string[] {
                            "client_id",
                            "fortyTwoClient"});
                table218.AddRow(new string[] {
                            "X-Testing-ClientCert",
                            "sidClient.crt"});
#line 17
 testRunner.When("execute HTTP POST request \'https://localhost:8080/mtls/token\'", ((string)(null)), table218, "When ");
#line hidden
#line 23
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 24
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 25
 testRunner.And("JSON \'$.error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 26
 testRunner.And("JSON \'$.error_description\'=\'missing parameter auth_req_id\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="authorization request must exists")]
        [Xunit.TraitAttribute("FeatureTitle", "CIBAGrantTypeErrors")]
        [Xunit.TraitAttribute("Description", "authorization request must exists")]
        public void AuthorizationRequestMustExists()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("authorization request must exists", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 28
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table219 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table219.AddRow(new string[] {
                            "grant_type",
                            "urn:openid:params:grant-type:ciba"});
                table219.AddRow(new string[] {
                            "client_id",
                            "fortyTwoClient"});
                table219.AddRow(new string[] {
                            "X-Testing-ClientCert",
                            "sidClient.crt"});
                table219.AddRow(new string[] {
                            "auth_req_id",
                            "id"});
#line 29
 testRunner.When("execute HTTP POST request \'https://localhost:8080/mtls/token\'", ((string)(null)), table219, "When ");
#line hidden
#line 36
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 37
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 38
 testRunner.And("JSON \'$.error\'=\'invalid_grant\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 39
 testRunner.And("JSON \'$.error_description\'=\'authorization request doesn\'t exist\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="client must be the same")]
        [Xunit.TraitAttribute("FeatureTitle", "CIBAGrantTypeErrors")]
        [Xunit.TraitAttribute("Description", "client must be the same")]
        public void ClientMustBeTheSame()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("client must be the same", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 41
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 42
 testRunner.Given("authenticate a user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table220 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table220.AddRow(new string[] {
                            "client_id",
                            "fortyNineClient"});
                table220.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table220.AddRow(new string[] {
                            "scope",
                            "admin calendar"});
                table220.AddRow(new string[] {
                            "login_hint",
                            "user"});
                table220.AddRow(new string[] {
                            "user_code",
                            "password"});
#line 44
 testRunner.When("execute HTTP POST request \'https://localhost:8080/bc-authorize\'", ((string)(null)), table220, "When ");
#line hidden
#line 52
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 53
 testRunner.And("extract parameter \'auth_req_id\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table221 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table221.AddRow(new string[] {
                            "auth_req_id",
                            "$auth_req_id$"});
#line 55
 testRunner.And("execute HTTP POST JSON request \'http://localhost/bc-callback\'", ((string)(null)), table221, "And ");
#line hidden
                TechTalk.SpecFlow.Table table222 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table222.AddRow(new string[] {
                            "grant_type",
                            "urn:openid:params:grant-type:ciba"});
                table222.AddRow(new string[] {
                            "client_id",
                            "fiftyClient"});
                table222.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table222.AddRow(new string[] {
                            "auth_req_id",
                            "$auth_req_id$"});
#line 59
 testRunner.And("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table222, "And ");
#line hidden
#line 66
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 68
 testRunner.Then("JSON \'$.error\'=\'invalid_grant\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 69
 testRunner.And("JSON \'$.error_description\'=\'the client is not authorized to use the auth_req_id\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="authorization request must be confirmed")]
        [Xunit.TraitAttribute("FeatureTitle", "CIBAGrantTypeErrors")]
        [Xunit.TraitAttribute("Description", "authorization request must be confirmed")]
        public void AuthorizationRequestMustBeConfirmed()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("authorization request must be confirmed", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 71
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 72
 testRunner.Given("authenticate a user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table223 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table223.AddRow(new string[] {
                            "response_type",
                            "id_token"});
                table223.AddRow(new string[] {
                            "client_id",
                            "fourteenClient"});
                table223.AddRow(new string[] {
                            "state",
                            "state"});
                table223.AddRow(new string[] {
                            "response_mode",
                            "query"});
                table223.AddRow(new string[] {
                            "scope",
                            "openid email role"});
                table223.AddRow(new string[] {
                            "redirect_uri",
                            "http://localhost:8080"});
                table223.AddRow(new string[] {
                            "nonce",
                            "nonce"});
#line 74
 testRunner.When("execute HTTP GET request \'http://localhost/authorization\'", ((string)(null)), table223, "When ");
#line hidden
#line 84
 testRunner.And("extract parameter \'id_token\' from redirect url", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table224 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table224.AddRow(new string[] {
                            "client_id",
                            "fortyNineClient"});
                table224.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table224.AddRow(new string[] {
                            "scope",
                            "admin calendar"});
                table224.AddRow(new string[] {
                            "login_hint",
                            "user"});
                table224.AddRow(new string[] {
                            "user_code",
                            "password"});
#line 86
 testRunner.And("execute HTTP POST request \'https://localhost:8080/bc-authorize\'", ((string)(null)), table224, "And ");
#line hidden
#line 94
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 95
 testRunner.And("extract parameter \'auth_req_id\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table225 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table225.AddRow(new string[] {
                            "grant_type",
                            "urn:openid:params:grant-type:ciba"});
                table225.AddRow(new string[] {
                            "client_id",
                            "fortyNineClient"});
                table225.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table225.AddRow(new string[] {
                            "auth_req_id",
                            "$auth_req_id$"});
#line 97
 testRunner.And("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table225, "And ");
#line hidden
#line 104
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 106
 testRunner.Then("JSON \'$.error\'=\'authorization_pending\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 107
 testRunner.And("JSON \'$.error_description\'=\'the authorization request has not been confirmed\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="authorization request cannot be rejected")]
        [Xunit.TraitAttribute("FeatureTitle", "CIBAGrantTypeErrors")]
        [Xunit.TraitAttribute("Description", "authorization request cannot be rejected")]
        public void AuthorizationRequestCannotBeRejected()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("authorization request cannot be rejected", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 109
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 110
 testRunner.Given("authenticate a user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table226 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table226.AddRow(new string[] {
                            "client_id",
                            "fortyNineClient"});
                table226.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table226.AddRow(new string[] {
                            "scope",
                            "admin calendar"});
                table226.AddRow(new string[] {
                            "login_hint",
                            "user"});
                table226.AddRow(new string[] {
                            "user_code",
                            "password"});
#line 112
 testRunner.When("execute HTTP POST request \'https://localhost:8080/bc-authorize\'", ((string)(null)), table226, "When ");
#line hidden
#line 120
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 121
 testRunner.And("extract parameter \'auth_req_id\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table227 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table227.AddRow(new string[] {
                            "auth_req_id",
                            "$auth_req_id$"});
                table227.AddRow(new string[] {
                            "action",
                            "1"});
#line 123
 testRunner.And("execute HTTP POST JSON request \'http://localhost/bc-callback\'", ((string)(null)), table227, "And ");
#line hidden
                TechTalk.SpecFlow.Table table228 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table228.AddRow(new string[] {
                            "grant_type",
                            "urn:openid:params:grant-type:ciba"});
                table228.AddRow(new string[] {
                            "client_id",
                            "fortyNineClient"});
                table228.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table228.AddRow(new string[] {
                            "auth_req_id",
                            "$auth_req_id$"});
#line 128
 testRunner.And("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table228, "And ");
#line hidden
#line 135
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 137
 testRunner.Then("JSON \'$.error\'=\'access_denied\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 138
 testRunner.And("JSON \'$.error_description\'=\'the authorization request has been rejected\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
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
                CIBAGrantTypeErrorsFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                CIBAGrantTypeErrorsFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
