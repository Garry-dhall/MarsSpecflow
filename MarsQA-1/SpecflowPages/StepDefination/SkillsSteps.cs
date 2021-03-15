using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class SkillsSteps
    {
        [Given(@"I am on Profile page")]
        public void GivenIAmOnProfilePage()
        {
            //Open Profile
            Driver.driver.FindElement(By.XPath("//A[text()='Profile']")).Click();
        }
        
        [When(@"I click on skills")]
        public void WhenIClickOnSkills()
        {
            Skills.clickOnSkillButton();
        }
        
        [When(@"I enter new skill details")]
        public void WhenIEnterNewSkillDetails()
        {
            Driver.TurnOnWait();
            Skills.addNewSkill();
        }
        
        [When(@"I click on add button")]
        public void WhenIClickOnAddButton()
        {
            Skills.clickOnAddButton();
        }

        [When(@"I click on edit button")]
        public void WhenIClickOnEditButton()
        {
            Skills.clickEditButton();
        }

        [When(@"I edit the skill name and level")]
        public void WhenIEditTheSkillNameAndLevel()
        {
            Skills.editSkill();
        }
        
        [When(@"I click on Update")]
        public void WhenIClickOnUpdate()
        {
            Skills.clickOnUpdateSkill();
        }

        [When(@"I click on cross button")]
        public void WhenIClickOnCrossButton()
        {
        //    Driver.Initialize();
        //    Driver.TurnOnWait();  
        //    ////call the SignIn class
        //    //SignIn.Login();
        //    Skills.clickOnSkillButton();
        //    Skills.deleteSkill();
        }


        [Then(@"I should be able to see added skill")]
        public void ThenIShouldBeAbleToSeeAddedSkill()
        {
            var popUp = Driver.driver.FindElement(By.XPath("//div[@class = 'ns-box ns-growl ns-effect-jelly ns-type-success ns-show']")).Text;
            var expectedv = "C# has been added to your skills";
            Assert.AreEqual(expectedv, popUp, "assertion failed");
            Console.WriteLine("Skill has been added");
        }
        
        [Then(@"I sould be able to see updated skill")]
        public void ThenISouldBeAbleToSeeUpdatedSkill()
        {
            var popUp = Driver.driver.FindElement(By.XPath("//div[@class = 'ns-box ns-growl ns-effect-jelly ns-type-success ns-show']")).Text;
            var expectedv = "API has been updated to your skills";
            Assert.AreEqual(expectedv, popUp, "assertion failed");
            Console.WriteLine("Skill has been updated");

        }
        
        //[Then(@"I should be able to see skill deleted")]
        //public void ThenIShouldBeAbleToSeeSkillDeleted()
        //{
        //    var popUp = Driver.driver.FindElement(By.XPath("//div[@class = 'ns-box ns-growl ns-effect-jelly ns-type-success ns-show']")).Text;
        //    var expectedv = "API has been deleted";
        //    Assert.AreEqual(expectedv, popUp, "assertion failed");
        //    Console.WriteLine("Skill updated");
        //}
    }
}
