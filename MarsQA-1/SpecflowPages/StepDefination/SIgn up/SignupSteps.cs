using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using System;
using TechTalk.SpecFlow;
using static MarsQA_1.Helpers.CommonMethods;

namespace MarsQA_1.Feature
{
    [Binding]
    public class SignupSteps
    {
        
        [Given(@"I am on home page")]
        public void GivenIAmOnHomePage()

        {
            Driver.Initialize();
            Driver.NavigateUrl();        
        }
        
        [When(@"I clicked on Join button")]
        public void WhenIClickedOnJoinButton()
        {
            Driver.TurnOnWait();
            SignUp.Join();
        }
        
        [When(@"I Enter valid credentials")]
        public void WhenIEnterValidCredentials()
        {
            Driver.TurnOnWait();
            SignUp.EnterDetails();
        }
        
        [When(@"I click on join button")]
        public void WhenIClickOnJoinButton()
        {
            Driver.TurnOnWait();
            SignUp.ClickOnJoinButton();

        }
        
        [Then(@"I should be able to Register successfully\.")]
        public void ThenIShouldBeAbleToRegisterSuccessfully_()
        {

            try
            {

                CommonMethods.ExtentReports();
                CommonMethods.test = CommonMethods.Extent.StartTest("Registration");
                string expectedValue = "Registration successful";
                string actualValue = Driver.driver.FindElement(By.XPath("//div[contains(@class,'ns-box-inner')]")).Text;
                Assert.AreEqual(expectedValue, actualValue, "Registration not done");
                CommonMethods.test.Log(LogStatus.Pass, "Reigistration Done");
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "Test Pass Screenshot");
            }
            catch (Exception e)

            {
                CommonMethods.test.Log(LogStatus.Fail, "Reigistration Unsuccessfull", e.Message);
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "Test Fail Screenshot");
                

            }
            CommonMethods.Extent.EndTest(test);
            CommonMethods.Extent.Flush();
            Driver.Close();

        }
    }
}
