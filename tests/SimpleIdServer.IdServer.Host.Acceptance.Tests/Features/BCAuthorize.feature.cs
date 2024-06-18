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
    public partial class BCAuthorizeFeature : object, Xunit.IClassFixture<BCAuthorizeFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "BCAuthorize.feature"
#line hidden
        
        public BCAuthorizeFeature(BCAuthorizeFeature.FixtureData fixtureData, SimpleIdServer_IdServer_Host_Acceptance_Tests_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "BCAuthorize", "\tCheck result returned by the /mtls/bc-authorize endpoint", ProgrammingLanguage.CSharp, featureTags);
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
        
        [Xunit.SkippableFactAttribute(DisplayName="Authentication response is returned with interval because PING is used")]
        [Xunit.TraitAttribute("FeatureTitle", "BCAuthorize")]
        [Xunit.TraitAttribute("Description", "Authentication response is returned with interval because PING is used")]
        public void AuthenticationResponseIsReturnedWithIntervalBecausePINGIsUsed()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Authentication response is returned with interval because PING is used", null, tagsOfScenario, argumentsOfScenario, featureTags);
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
#line 5
 testRunner.Given("authenticate a user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 6
 testRunner.And("build expiration time and add \'10\' seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table52 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table52.AddRow(new string[] {
                            "aud",
                            "https://localhost:8080"});
                table52.AddRow(new string[] {
                            "iss",
                            "fortyTwoClient"});
                table52.AddRow(new string[] {
                            "exp",
                            "$exp$"});
                table52.AddRow(new string[] {
                            "jti",
                            "jti"});
                table52.AddRow(new string[] {
                            "login_hint",
                            "user"});
                table52.AddRow(new string[] {
                            "scope",
                            "secondScope"});
                table52.AddRow(new string[] {
                            "client_notification_token",
                            "04bcf708-dfba-4719-a3d3-b213322e2c38"});
                table52.AddRow(new string[] {
                            "user_code",
                            "password"});
#line 7
 testRunner.And("build JWS request object for client \'fortyTwoClient\' and sign with the key \'keyId" +
                        "\'", ((string)(null)), table52, "And ");
#line hidden
                TechTalk.SpecFlow.Table table53 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table53.AddRow(new string[] {
                            "X-Testing-ClientCert",
                            "sidClient.crt"});
                table53.AddRow(new string[] {
                            "client_id",
                            "fortyTwoClient"});
                table53.AddRow(new string[] {
                            "request",
                            "$request$"});
#line 18
 testRunner.When("execute HTTP POST request \'https://localhost:8080/mtls/bc-authorize\'", ((string)(null)), table53, "When ");
#line hidden
#line 24
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 26
 testRunner.Then("JSON \'expires_in\'=\'120\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 27
 testRunner.And("JSON \'interval\'=\'5\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 28
 testRunner.And("JSON exists \'auth_req_id\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Authentication response is returned without interval because PUSH is used")]
        [Xunit.TraitAttribute("FeatureTitle", "BCAuthorize")]
        [Xunit.TraitAttribute("Description", "Authentication response is returned without interval because PUSH is used")]
        public void AuthenticationResponseIsReturnedWithoutIntervalBecausePUSHIsUsed()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Authentication response is returned without interval because PUSH is used", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 30
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 31
 testRunner.Given("authenticate a user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 32
 testRunner.And("build expiration time and add \'10\' seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table54 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table54.AddRow(new string[] {
                            "aud",
                            "https://localhost:8080"});
                table54.AddRow(new string[] {
                            "iss",
                            "fortyThreeClient"});
                table54.AddRow(new string[] {
                            "exp",
                            "$exp$"});
                table54.AddRow(new string[] {
                            "jti",
                            "jti"});
                table54.AddRow(new string[] {
                            "login_hint",
                            "user"});
                table54.AddRow(new string[] {
                            "scope",
                            "secondScope"});
                table54.AddRow(new string[] {
                            "client_notification_token",
                            "04bcf708-dfba-4719-a3d3-b213322e2c38"});
                table54.AddRow(new string[] {
                            "user_code",
                            "password"});
#line 33
 testRunner.And("build JWS request object for client \'fortyThreeClient\' and sign with the key \'key" +
                        "Id\'", ((string)(null)), table54, "And ");
#line hidden
                TechTalk.SpecFlow.Table table55 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table55.AddRow(new string[] {
                            "X-Testing-ClientCert",
                            "sidClient.crt"});
                table55.AddRow(new string[] {
                            "client_id",
                            "fortyThreeClient"});
                table55.AddRow(new string[] {
                            "request",
                            "$request$"});
#line 44
 testRunner.When("execute HTTP POST request \'https://localhost:8080/mtls/bc-authorize\'", ((string)(null)), table55, "When ");
#line hidden
#line 50
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 52
 testRunner.Then("JSON \'expires_in\'=\'120\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 53
 testRunner.And("JSON exists \'auth_req_id\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 54
 testRunner.And("JSON doesn\'t exist \'$.interval\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
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
                BCAuthorizeFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                BCAuthorizeFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
