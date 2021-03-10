using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace MarsQA_1.Feature
{
    [Binding]
    public class SignInSteps

    {

        [Given(@"I am on homepage")]
        public void GivenIAmOnHomepage()
        {
            Driver.TurnOnWait();
            Driver.Initialize();
            Driver.NavigateUrl();
        }
        
        [When(@"I click on SignIn button")]
        public void WhenIClickOnSignInButton()
        {
            Driver.TurnOnWait();
            SignIn.ClickSignInBtn();
        }
        
        [When(@"I enter valid credentials")]
        public void WhenIEnterValidCredentials(Table table)
        {
            //dynamic tableDetails = table.

        }
        
        [When(@"I click on Login Button")]
        public void WhenIClickOnLoginButton()
        {
            Driver.TurnOnWait();
            SignIn.ClickOnLoginBtn();
        }
        
        [Then(@"I should be able to login successfully")]
        public void ThenIShouldBeAbleToLoginSuccessfully()
        {
           
        }
    }
}
