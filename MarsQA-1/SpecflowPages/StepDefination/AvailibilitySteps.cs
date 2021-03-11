using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class AvailibilitySteps
    {
        [When(@"I click on edit button next to availibility")]
        public void WhenIClickOnEditButtonNextToAvailibility()
        {
            CreateProfile.clickOnselectAvailability();
        }

        [When(@"I select availibility")]
        public void WhenISelectAvailibility()
        {
            CreateProfile.SelectAvailibility();
            Thread.Sleep(3000);
        }

        [When(@"I click on edit button next to hours")]
        public void WhenIClickOnEditButtonNextToHours()
        {
            CreateProfile.clickOnHours();
        }

        [When(@"I select hours")]
        public void WhenISelectHours()
        {
            CreateProfile.selectHours();
            Thread.Sleep(3000);
        }

        [When(@"I click on edit button next to EarnTarget")]
        public void WhenIClickOnEditButtonNextToEarnTarget()
        {
            CreateProfile.clickOnEarnTarget();
        }

        [When(@"I select EarnTarget")]
        public void WhenISelectEarnTarget()
        {
            CreateProfile.selectEarnTarget();
            Thread.Sleep(3000);
        }

        [Then(@"I should be able to see selected availibility on profile")]
        public void ThenIShouldBeAbleToSeeSelectedAvailibilityOnProfile()
        {
            var expectedValue = "Availability updated";
            var actualValue = Driver.driver.FindElement(By.XPath("//div[contains(@class,'ns-box-inner')]")).Text;
            Assert.AreEqual(expectedValue, actualValue, "Availibility not selected");

        }

        [Then(@"I should be able to see selected hours on profile")]
        public void ThenIShouldBeAbleToSeeSelectedHoursOnProfile()
        {
            var expectedValue = "Availability updated";
            var actualValue = Driver.driver.FindElement(By.XPath("//div[contains(@class,'ns-box-inner')]")).Text;
            Assert.AreEqual(expectedValue, actualValue, "hours not selected");

        }

        [Then(@"I should be able to see selected EarnTarget on profile")]
        public void ThenIShouldBeAbleToSeeSelectedEarnTargetOnProfile()
        {
            var expectedValue = "Availability updated";
            var actualValue = Driver.driver.FindElement(By.XPath("//div[contains(@class,'ns-box-inner')]")).Text;
            Assert.AreEqual(expectedValue, actualValue, "EarnTarget not selected");
        }
    }
}

