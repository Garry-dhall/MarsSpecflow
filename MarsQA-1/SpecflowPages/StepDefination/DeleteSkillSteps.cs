using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class DeleteSkillSteps
    {
        [When(@"I do click on skills")]
        public void WhenIDoClickOnSkills()
        {
            Skills.clickOnSkillButton();
        }
        
        [When(@"I select delete button")]
        public void WhenISelectDeleteButton()
        {
            Skills.deleteSkill();
        }
        
        [Then(@"Skill should be deleted")]
        public void ThenSkillShouldBeDeleted()
        {
            Driver.TurnOnWait();
            var popUp = Driver.driver.FindElement(By.XPath("//div[contains(@class,'ns-box-inner')]")).Text;
            var expectedv = "API has been deleted";
            Assert.AreEqual(expectedv, popUp, "assertion failed");
            Console.WriteLine("Skill Deleted");
            Thread.Sleep(5000);


        }
    }
    
}
