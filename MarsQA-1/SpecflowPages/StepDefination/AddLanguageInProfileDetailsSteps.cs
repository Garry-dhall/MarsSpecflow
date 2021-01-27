
using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class AddLanguageInProfileDetailsSteps
       
    {
        [Given(@"I am on profile page")]
        public void GivenIAmOnProfilePage()

        { 
           Driver.driver.FindElement(By.XPath("//A[text()='Profile']")).Click();
        }
        
        [When(@"I click on language button")]
        public void WhenIClickOnLanguageButton()
        {
            Driver.driver.FindElement(By.XPath("//A[text()='Languages']")).Click();
           
        }
        
        [When(@"I add a new language")]
        public void WhenIAddANewLanguage()
        {
            Driver.driver.FindElement(By.XPath("//div[text() = 'Add New']")).Click();
            Thread.Sleep(5000);
            //Add a language
            Driver.driver.FindElement(By.XPath("//input[@name ='name']")).SendKeys("English");
            //Choose language level 
            Driver.driver.FindElement(By.XPath("//select[@class ='ui dropdown']")).Click();
            Driver.driver.FindElement(By.XPath("//option[text() ='Fluent']")).Click();
            Thread.Sleep(5000);
            Driver.driver.FindElement(By.XPath("//input[@value = 'Add']")).Click();
        }

        [Then(@"I should be able to see new language in my profile")]
        public void ThenIShouldBeAbleToSeeNewLanguageInMyProfile()
        {   //Verifying language is added or not
            var language = Driver.driver.FindElement(By.XPath("//td[text() ='English']")).Text;
            Thread.Sleep(5000);

            if (language =="English")
            {
                Console.WriteLine("Language added successfully");
                Thread.Sleep(5000);
            }
            
            else
            {
                Console.WriteLine("Language not added");
            }
        }
    }
}
