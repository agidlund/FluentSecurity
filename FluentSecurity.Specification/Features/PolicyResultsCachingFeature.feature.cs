﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.8.1.0
//      SpecFlow Generator Version:1.8.0.0
//      Runtime Version:4.0.30319.239
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace FluentSecurity.Specification.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Caching of PolicyResults")]
    public partial class CachingOfPolicyResultsFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "PolicyResultsCachingFeature.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Caching of PolicyResults", "In order to improve performance of applications using FluentSecurity\r\nAs a develo" +
                    "per\r\nI want the ability to cache results of policies", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Cache results of policy for all controllers")]
        public virtual void CacheResultsOfPolicyForAllControllers()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Cache results of policy for all controllers", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line 10
 testRunner.Given("the cache strategy of all controllers is set to PerHttpRequest for WriterPolicy");
#line 11
 testRunner.When("enforcing WriterPolicy for BlogController AddPost");
#line 12
 testRunner.Then("it should cache result PerHttpRequest");
#line 13
 testRunner.Then("it should cache result with key \"*_*_WriterPolicy\"");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Cache results of policy for specific controller")]
        public virtual void CacheResultsOfPolicyForSpecificController()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Cache results of policy for specific controller", ((string[])(null)));
#line 16
this.ScenarioSetup(scenarioInfo);
#line 20
 testRunner.Given("the cache strategy of BlogController is set to PerHttpRequest for WriterPolicy");
#line 21
 testRunner.When("enforcing WriterPolicy for BlogController AddPost");
#line 22
 testRunner.Then("it should cache result PerHttpRequest");
#line 23
 testRunner.Then("it should cache result with key \"BlogController_*_WriterPolicy\"");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Cache results of policy for specific controller and action")]
        public virtual void CacheResultsOfPolicyForSpecificControllerAndAction()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Cache results of policy for specific controller and action", ((string[])(null)));
#line 26
this.ScenarioSetup(scenarioInfo);
#line 30
 testRunner.Given("the cache strategy of BlogController AddPost is set to PerHttpRequest for WriterP" +
                    "olicy");
#line 31
 testRunner.When("enforcing WriterPolicy for BlogController AddPost");
#line 32
 testRunner.Then("it should cache result PerHttpRequest");
#line 33
 testRunner.Then("it should cache result with key \"BlogController_AddPost_WriterPolicy\"");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Override cache lifecycle of policy for specific controller and action")]
        public virtual void OverrideCacheLifecycleOfPolicyForSpecificControllerAndAction()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Override cache lifecycle of policy for specific controller and action", ((string[])(null)));
#line 36
this.ScenarioSetup(scenarioInfo);
#line 41
 testRunner.Given("the cache strategy of BlogController is set to PerHttpRequest for WriterPolicy");
#line 42
 testRunner.And("the cache strategy of BlogController AddPost is set to DoNotCache for WriterPolic" +
                    "y");
#line 43
 testRunner.When("enforcing WriterPolicy for BlogController AddPost");
#line 44
 testRunner.Then("it should not cache result");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Override cache lifecyle of policy for specific controller")]
        public virtual void OverrideCacheLifecyleOfPolicyForSpecificController()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Override cache lifecyle of policy for specific controller", ((string[])(null)));
#line 47
this.ScenarioSetup(scenarioInfo);
#line 52
 testRunner.Given("the cache strategy of BlogController AddPost is set to PerHttpSession for WriterP" +
                    "olicy");
#line 53
 testRunner.And("the cache strategy of BlogController is set to PerHttpRequest for WriterPolicy");
#line 54
 testRunner.When("enforcing WriterPolicy for BlogController AddPost");
#line 55
 testRunner.Then("it should cache result PerHttpRequest");
#line 56
 testRunner.Then("it should cache result with key \"BlogController_*_WriterPolicy\"");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Override cache level of policy for all controllers")]
        public virtual void OverrideCacheLevelOfPolicyForAllControllers()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Override cache level of policy for all controllers", ((string[])(null)));
#line 59
this.ScenarioSetup(scenarioInfo);
#line 63
 testRunner.Given("the cache strategy of all controllers is set to PerHttpRequest by ControllerActio" +
                    "n for WriterPolicy");
#line 64
 testRunner.When("enforcing WriterPolicy for BlogController AddPost");
#line 65
 testRunner.Then("it should cache result PerHttpRequest");
#line 66
 testRunner.Then("it should cache result with key \"BlogController_AddPost_WriterPolicy\"");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Override cache level of policy for specific controller")]
        public virtual void OverrideCacheLevelOfPolicyForSpecificController()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Override cache level of policy for specific controller", ((string[])(null)));
#line 69
this.ScenarioSetup(scenarioInfo);
#line 73
 testRunner.Given("the cache strategy of BlogController is set to PerHttpRequest by ControllerAction" +
                    " for WriterPolicy");
#line 74
 testRunner.When("enforcing WriterPolicy for BlogController AddPost");
#line 75
 testRunner.Then("it should cache result PerHttpRequest");
#line 76
 testRunner.Then("it should cache result with key \"BlogController_AddPost_WriterPolicy\"");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Override cache level of policy for specific controller action")]
        public virtual void OverrideCacheLevelOfPolicyForSpecificControllerAction()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Override cache level of policy for specific controller action", ((string[])(null)));
#line 79
this.ScenarioSetup(scenarioInfo);
#line 83
 testRunner.Given("the cache strategy of BlogController AddPost is set to PerHttpRequest by Policy f" +
                    "or WriterPolicy");
#line 84
 testRunner.When("enforcing WriterPolicy for BlogController AddPost");
#line 85
 testRunner.Then("it should cache result PerHttpRequest");
#line 86
 testRunner.Then("it should cache result with key \"*_*_WriterPolicy\"");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Clear cache strategies for specific controller")]
        public virtual void ClearCacheStrategiesForSpecificController()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Clear cache strategies for specific controller", ((string[])(null)));
#line 89
this.ScenarioSetup(scenarioInfo);
#line 94
 testRunner.Given("the cache strategy of all controllers is set to PerHttpRequest for WriterPolicy");
#line 95
 testRunner.And("the cache strategies of BlogController is cleared");
#line 96
 testRunner.When("enforcing WriterPolicy for BlogController AddPost");
#line 97
 testRunner.Then("it should not cache result");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Clear cache strategies for specific controller action")]
        public virtual void ClearCacheStrategiesForSpecificControllerAction()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Clear cache strategies for specific controller action", ((string[])(null)));
#line 100
this.ScenarioSetup(scenarioInfo);
#line 105
 testRunner.Given("the cache strategy of all controllers is set to PerHttpRequest for WriterPolicy");
#line 106
 testRunner.And("the cache strategies of BlogController AddPost is cleared");
#line 107
 testRunner.When("enforcing WriterPolicy for BlogController AddPost");
#line 108
 testRunner.Then("it should not cache result");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion