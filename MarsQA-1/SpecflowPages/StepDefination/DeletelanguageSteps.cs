using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class DeletelanguageSteps
    {
        [Given(@"I am on language tab")]
        public void GivenIAmOnLanguageTab()
        {   //Opening language tab
            AddLanguageInProfileDetailsSteps x = new AddLanguageInProfileDetailsSteps();
            x.GivenIAmOnProfilePage();
            x.WhenIClickOnLanguageButton();
           // x.WhenIAddANewLanguage()
        }
        
        [When(@"I click on delete button")]
        public void WhenIClickOnDeleteButton()
        {//Deleting a language
         Driver.driver.FindElement(By.XPath("//td[text()='English']//following::i[2]")).Click();
            Thread.Sleep(3000);
        }

        [Then(@"I should be able to delete the language")]
        public void ThenIShouldBeAbleToDeleteTheLanguage()
        {   //Verifying whether the language deleted or not
            var popup = Driver.driver.FindElement(By.XPath("//div[text() ='English has been deleted from your languages']")).Text;
            Thread.Sleep(5000);

            if (popup == "English has been deleted from your languages")
            { 
                Console.WriteLine("Language Deleted");
            }
             else
            {
                Console.WriteLine("Language  has been not Deleted");
            }

        }
    }
}
