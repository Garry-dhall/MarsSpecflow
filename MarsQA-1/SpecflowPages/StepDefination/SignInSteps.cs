using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using System.Threading;
using MarsQA_1.SpecflowPages;
using NUnit.Framework;
using static MarsQA_1.Helpers.CommonMethods;

namespace MarsQA_1.Feature
{
    [Binding]
    public class SignInSteps

    {

        [Given(@"I am on homepage")]
        public void GivenIAmOnHomepage()
        {
            Driver.Initialize();
            Driver.NavigateUrl();
            Driver.TurnOnWait();
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
            Driver.TurnOnWait();
            dynamic tableDetails = table.CreateInstance<Credentials>();
            Driver.driver.FindElement(By.XPath("//input[@name = 'email']")).SendKeys(tableDetails.Email);
            Driver.driver.FindElement(By.XPath("//INPUT[@type='password']")).SendKeys(tableDetails.Password);
            Thread.Sleep(5000);
        }
        
        [When(@"I click on Login Button")]
        public void WhenIClickOnLoginButton()
        {
            SignIn.ClickOnLoginBtn();
        }
        
        [Then(@"I should be able to login successfully")]
        public void ThenIShouldBeAbleToLoginSuccessfully()
        {
            Driver.TurnOnWait();
            try
            {
                
                CommonMethods.ExtentReports();
                CommonMethods.test = CommonMethods.Extent.StartTest("Signin");
                var expectedValue = "Hi garry";
                var actualValue = Driver.driver.FindElement(By.XPath("//span[text() ='garry']")).Text;
                Assert.AreEqual(expectedValue, actualValue, "Login not successful");
                CommonMethods.test.Log(LogStatus.Pass, "SignIn Successful");
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "Pass");
            }
            catch(Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "SignIn not Successful", e.Message);
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "Fail");
            }
            CommonMethods.Extent.EndTest(test);
            CommonMethods.Extent.Flush();
            Driver.Close();

        }
    }
}
