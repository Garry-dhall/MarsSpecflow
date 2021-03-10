using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class SignInSteps
    {
        [Given(@"I am on homepage")]
        public void GivenIAmOnHomepage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on SignIn button")]
        public void WhenIClickOnSignInButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter valid credentials")]
        public void WhenIEnterValidCredentials(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on Login Button")]
        public void WhenIClickOnLoginButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be able to login successfully")]
        public void ThenIShouldBeAbleToLoginSuccessfully()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
