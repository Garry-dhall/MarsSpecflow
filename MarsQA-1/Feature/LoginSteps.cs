using MarsQA_1.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class LoginSteps
    {
        [Given(@"I login to the website")]
        public void GivenILoginToTheWebsite()
        {
            SignIn.Login();
        }
    }
}
