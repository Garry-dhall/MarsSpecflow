using MarsQA_1.Helpers;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class UpdateProfileSteps
    {
        [Given(@"I am on Language tab")]
        public void GivenIAmOnLanguageTab()
        {   //Adding Language
            AddLanguageInProfileDetailsSteps y = new AddLanguageInProfileDetailsSteps();
            y.GivenIAmOnProfilePage();
            y.WhenIClickOnLanguageButton();
            y.WhenIAddANewLanguage();
            Thread.Sleep(5000);
        }
        
        [When(@"I click on edit button and edit existing language")]
        public void WhenIClickOnEditButtonAndEditExistingLanguage()
        {   //Editing Language
            Driver.driver.FindElement(By.XPath("//td[@class = 'right aligned']//child::i[@class = 'outline write icon']")).Click();
            Driver.driver.FindElement(By.XPath("//input[@name ='name']")).Clear();
            Driver.driver.FindElement(By.XPath("//input[@name = 'name']")).SendKeys("Russian");
            Thread.Sleep(4000);
            Driver.driver.FindElement(By.XPath("//input[@value = 'Update']")).Click();
            
        }
        
        [Then(@"I should be able to update language")]
        public void ThenIShouldBeAbleToUpdateLanguage()
        {   //Verifying the language is edited or not
            var newlanguage = Driver.driver.FindElement(By.XPath("//td[text()='Russian']")).Text;
            Thread.Sleep(10000);

            if (newlanguage == "Russian")
            {
                Console.WriteLine("Language updated successfully");
                Thread.Sleep(5000);
            }
            else
            {
                Console.WriteLine("Language not updated");
            }
        }

    }
}
