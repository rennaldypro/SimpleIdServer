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
                TechTalk.SpecFlow.Table table234 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table234.AddRow(new string[] {
                            "grant_type",
                            "urn:openid:params:grant-type:ciba"});
                table234.AddRow(new string[] {
                            "client_id",
                            "fortyThreeClient"});
                table234.AddRow(new string[] {
                            "X-Testing-ClientCert",
                            "sidClient.crt"});
#line 5
 testRunner.When("execute HTTP POST request \'https://localhost:8080/mtls/token\'", ((string)(null)), table234, "When ");
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
                TechTalk.SpecFlow.Table table235 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table235.AddRow(new string[] {
                            "grant_type",
                            "urn:openid:params:grant-type:ciba"});
                table235.AddRow(new string[] {
                            "client_id",
                            "fortyTwoClient"});
                table235.AddRow(new string[] {
                            "X-Testing-ClientCert",
                            "sidClient.crt"});
#line 17
 testRunner.When("execute HTTP POST request \'https://localhost:8080/mtls/token\'", ((string)(null)), table235, "When ");
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
                TechTalk.SpecFlow.Table table236 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table236.AddRow(new string[] {
                            "grant_type",
                            "urn:openid:params:grant-type:ciba"});
                table236.AddRow(new string[] {
                            "client_id",
                            "fortyTwoClient"});
                table236.AddRow(new string[] {
                            "X-Testing-ClientCert",
                            "sidClient.crt"});
                table236.AddRow(new string[] {
                            "auth_req_id",
                            "id"});
#line 29
 testRunner.When("execute HTTP POST request \'https://localhost:8080/mtls/token\'", ((string)(null)), table236, "When ");
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
                TechTalk.SpecFlow.Table table237 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table237.AddRow(new string[] {
                            "client_id",
                            "fortyNineClient"});
                table237.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table237.AddRow(new string[] {
                            "scope",
                            "admin calendar"});
                table237.AddRow(new string[] {
                            "login_hint",
                            "user"});
                table237.AddRow(new string[] {
                            "user_code",
                            "password"});
#line 44
 testRunner.When("execute HTTP POST request \'https://localhost:8080/bc-authorize\'", ((string)(null)), table237, "When ");
#line hidden
#line 52
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 53
 testRunner.And("extract parameter \'auth_req_id\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table238 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table238.AddRow(new string[] {
                            "auth_req_id",
                            "$auth_req_id$"});
#line 55
 testRunner.And("execute HTTP POST JSON request \'http://localhost/bc-callback\'", ((string)(null)), table238, "And ");
#line hidden
                TechTalk.SpecFlow.Table table239 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table239.AddRow(new string[] {
                            "grant_type",
                            "urn:openid:params:grant-type:ciba"});
                table239.AddRow(new string[] {
                            "client_id",
                            "fiftyClient"});
                table239.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table239.AddRow(new string[] {
                            "auth_req_id",
                            "$auth_req_id$"});
#line 59
 testRunner.And("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table239, "And ");
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
                TechTalk.SpecFlow.Table table240 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table240.AddRow(new string[] {
                            "response_type",
                            "id_token"});
                table240.AddRow(new string[] {
                            "client_id",
                            "fourteenClient"});
                table240.AddRow(new string[] {
                            "state",
                            "state"});
                table240.AddRow(new string[] {
                            "response_mode",
                            "query"});
                table240.AddRow(new string[] {
                            "scope",
                            "openid email role"});
                table240.AddRow(new string[] {
                            "redirect_uri",
                            "http://localhost:8080"});
                table240.AddRow(new string[] {
                            "nonce",
                            "nonce"});
#line 74
 testRunner.When("execute HTTP GET request \'http://localhost/authorization\'", ((string)(null)), table240, "When ");
#line hidden
#line 84
 testRunner.And("extract parameter \'id_token\' from redirect url", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table241 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table241.AddRow(new string[] {
                            "client_id",
                            "fortyNineClient"});
                table241.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table241.AddRow(new string[] {
                            "scope",
                            "admin calendar"});
                table241.AddRow(new string[] {
                            "login_hint",
                            "user"});
                table241.AddRow(new string[] {
                            "user_code",
                            "password"});
#line 86
 testRunner.And("execute HTTP POST request \'https://localhost:8080/bc-authorize\'", ((string)(null)), table241, "And ");
#line hidden
#line 94
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 95
 testRunner.And("extract parameter \'auth_req_id\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table242 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table242.AddRow(new string[] {
                            "grant_type",
                            "urn:openid:params:grant-type:ciba"});
                table242.AddRow(new string[] {
                            "client_id",
                            "fortyNineClient"});
                table242.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table242.AddRow(new string[] {
                            "auth_req_id",
                            "$auth_req_id$"});
#line 97
 testRunner.And("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table242, "And ");
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
                TechTalk.SpecFlow.Table table243 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table243.AddRow(new string[] {
                            "sub",
                            "user"});
#line 111
 testRunner.And("build access_token and sign with the key \'keyid\'", ((string)(null)), table243, "And ");
#line hidden
                TechTalk.SpecFlow.Table table244 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table244.AddRow(new string[] {
                            "client_id",
                            "fortyNineClient"});
                table244.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table244.AddRow(new string[] {
                            "scope",
                            "admin calendar"});
                table244.AddRow(new string[] {
                            "login_hint",
                            "user"});
                table244.AddRow(new string[] {
                            "user_code",
                            "password"});
#line 115
 testRunner.When("execute HTTP POST request \'https://localhost:8080/bc-authorize\'", ((string)(null)), table244, "When ");
#line hidden
#line 123
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 124
 testRunner.And("extract parameter \'auth_req_id\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table245 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table245.AddRow(new string[] {
                            "auth_req_id",
                            "$auth_req_id$"});
                table245.AddRow(new string[] {
                            "action",
                            "1"});
                table245.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
#line 126
 testRunner.And("execute HTTP POST JSON request \'http://localhost/bc-callback\'", ((string)(null)), table245, "And ");
#line hidden
                TechTalk.SpecFlow.Table table246 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table246.AddRow(new string[] {
                            "grant_type",
                            "urn:openid:params:grant-type:ciba"});
                table246.AddRow(new string[] {
                            "client_id",
                            "fortyNineClient"});
                table246.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table246.AddRow(new string[] {
                            "auth_req_id",
                            "$auth_req_id$"});
#line 132
 testRunner.And("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table246, "And ");
#line hidden
#line 139
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 141
 testRunner.Then("JSON \'$.error\'=\'access_denied\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 142
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
