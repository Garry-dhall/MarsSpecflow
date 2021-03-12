using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class DescriptionSteps
    {
        [When(@"I click on Desciption edit button")]
        public void WhenIClickOnDesciptionEditButton()
        {
            Driver.driver.FindElement(By.XPath("//*[text() = 'Description']//i")).Click();
        }
        
        [When(@"I enter text in description")]
        public void WhenIEnterTextInDescription()
        {
            Driver.TurnOnWait();
            IWebElement descEnter = Driver.driver.FindElement(By.XPath("//textarea[@name = 'value']"));
            descEnter.Clear();
            descEnter.SendKeys("Docker, Selenium");
        }
        
        [When(@"I click on save button")]
        public void WhenIClickOnSaveButton()
        {
            Driver.driver.FindElement(By.XPath("//button[text() ='Save'][@type ='button']")).Click();
            Driver.TurnOnWait();
        }
        
        [Then(@"I should be able to save descrition")]
        public void ThenIShouldBeAbleToSaveDescrition()
        {
            var exptedV = "Description has been saved successfully";
            var actualV = Driver.driver.FindElement(By.XPath("//div[contains(@class,'ns-box-inner')]")).Text;
            Assert.AreEqual(exptedV, actualV, "Description has not been added");
            Console.WriteLine("Description has been added");
        }
    }
}
