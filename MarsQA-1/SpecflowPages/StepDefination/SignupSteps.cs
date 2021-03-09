using MarsQA_1.Global;
using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class SignupSteps
    {
        
        [Given(@"I am on home page")]
        public void GivenIAmOnHomePage()

        {
            Driver.NavigateUrl();
            
            
        }
        
        [When(@"I clicked on Join button")]
        public void WhenIClickedOnJoinButton()
        {
            
            SignUp.Join();
           
        }
        
        [When(@"I Enter valid credentials")]
        public void WhenIEnterValidCredentials()
        {
            GlobalDefinitions.wait(5);
            SignUp.EnterDetails();
        }
        
        [When(@"I click on join button")]
        public void WhenIClickOnJoinButton()
        {
            GlobalDefinitions.wait(5);
            SignUp.ClickOnJoinButton();

        }
        
        [Then(@"I should be able to Register successfully\.")]
        public void ThenIShouldBeAbleToRegisterSuccessfully_()
        {
           
        }
    }
}
