using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsQA_1.Helpers;
using OpenQA.Selenium;

namespace MarsQA_1.SpecflowPages.Pages
{ 
            public static class SignUp
    { 
        //Finding the Join 
        private static IWebElement JoinBtn => Driver.driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/button"));

        //Identify FirstName Textbox
        private static IWebElement FirstName => Driver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/form/div[1]/input"));

        //Identify LastName Textbox
        private static IWebElement LastName => Driver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/form/div[2]/input"));

        //Identify Email Textbox
        private static IWebElement Email => Driver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/form/div[3]/input"));

        //Identify Password Textbox
        private static IWebElement Password => Driver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/form/div[4]/input"));



        //Identify Confirm Password Textbox
        private static IWebElement ConfirmPassword => Driver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/form/div[5]/input"));


        //Identify Term and Conditions Checkbox
        private static IWebElement Checkbox => Driver.driver.FindElement(By.XPath("html/body/div[2]/div/div/div/form/div[6]/div/div/input"));

        //Identify join button
        private static IWebElement Joinbtn => Driver.driver.FindElement(By.XPath("//*[@id='submit-btn']"));


        public static void Join()
        {
            //Click on Join button
            JoinBtn.Click();
        }
        public static void EnterDetails()
        {
            var fileName = @"Mars\OnBoarding Task\Onboarding Task\Mars\MarsQA - 1\ExcelData.xlsx";

            //Populate the excel data
            ExcelLibHelper.PopulateInCollection(fileName, "Sign up");

            //Enter FirstName
            FirstName.SendKeys(ExcelLibHelper.ReadData(2, "FirstName"));

            //Enter LastName
            LastName.SendKeys(ExcelLibHelper.ReadData(2, "LastName"));

            //Enter Email
            Email.SendKeys(ExcelLibHelper.ReadData(2, "Email"));

            //Enter Password
            Password.SendKeys(ExcelLibHelper.ReadData(2, "Password"));

            //Enter Password again to confirm
            ConfirmPassword.SendKeys(ExcelLibHelper.ReadData(2, "ConfirmPwd"));

            //Click on Checkbox
            Checkbox.Click();
        }
        public static void ClickOnJoinButton()
        { 
            //Click on join button to Sign Up
             JoinBtn.Click();
                
            }
        }
    }



