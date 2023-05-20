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
    public partial class CredentialOfferFeature : object, Xunit.IClassFixture<CredentialOfferFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "CredentialOffer.feature"
#line hidden
        
        public CredentialOfferFeature(CredentialOfferFeature.FixtureData fixtureData, SimpleIdServer_IdServer_Host_Acceptance_Tests_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "CredentialOffer", "\tCheck result returned by credential_offer API", ProgrammingLanguage.CSharp, featureTags);
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
        
        [Xunit.SkippableFactAttribute(DisplayName="get a credential_offer url")]
        [Xunit.TraitAttribute("FeatureTitle", "CredentialOffer")]
        [Xunit.TraitAttribute("Description", "get a credential_offer url")]
        public void GetACredential_OfferUrl()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("get a credential_offer url", null, tagsOfScenario, argumentsOfScenario, featureTags);
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
                TechTalk.SpecFlow.Table table130 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table130.AddRow(new string[] {
                            "response_type",
                            "code"});
                table130.AddRow(new string[] {
                            "client_id",
                            "fiftyEightClient"});
                table130.AddRow(new string[] {
                            "state",
                            "state"});
                table130.AddRow(new string[] {
                            "response_mode",
                            "query"});
                table130.AddRow(new string[] {
                            "redirect_uri",
                            "http://localhost:8080"});
                table130.AddRow(new string[] {
                            "nonce",
                            "nonce"});
                table130.AddRow(new string[] {
                            "scope",
                            "credential_offer"});
#line 7
 testRunner.When("execute HTTP GET request \'http://localhost/authorization\'", ((string)(null)), table130, "When ");
#line hidden
#line 17
 testRunner.And("extract parameter \'code\' from redirect url", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table131 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table131.AddRow(new string[] {
                            "client_id",
                            "fiftyEightClient"});
                table131.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table131.AddRow(new string[] {
                            "grant_type",
                            "authorization_code"});
                table131.AddRow(new string[] {
                            "code",
                            "$code$"});
                table131.AddRow(new string[] {
                            "redirect_uri",
                            "http://localhost:8080"});
#line 19
 testRunner.And("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table131, "And ");
#line hidden
#line 27
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 28
 testRunner.And("extract parameter \'$.access_token\' from JSON body into \'accessToken\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table132 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table132.AddRow(new string[] {
                            "Authorization",
                            "Bearer $accessToken$"});
#line 30
 testRunner.And("execute HTTP GET request \'http://localhost/credential_offer/credentialOfferId\'", ((string)(null)), table132, "And ");
#line hidden
#line 34
 testRunner.And("extract query parameters into JSON", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 36
 testRunner.Then("JSON exists \'credential_offer\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
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
                CredentialOfferFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                CredentialOfferFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
