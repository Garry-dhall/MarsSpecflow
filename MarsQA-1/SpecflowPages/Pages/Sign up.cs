using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
        private static IWebElement FirstName => Driver.driver.FindElement(By.XPath("//input[@name = 'firstName']"));

        //Identify LastName Textbox
        private static IWebElement LastName => Driver.driver.FindElement(By.XPath("//input[@name= 'lastName']"));

        //Identify Email Textbox
        private static IWebElement Email => Driver.driver.FindElement(By.XPath("//input[@name= 'email']"));

        //Identify Password Textbox
        private static IWebElement Password => Driver.driver.FindElement(By.XPath("//input[@name= 'password']"));



        //Identify Confirm Password Textbox
        private static IWebElement ConfirmPassword => Driver.driver.FindElement(By.XPath("//input[@name= 'confirmPassword']"));


        //Identify Term and Conditions Checkbox
        private static IWebElement Checkbox => Driver.driver.FindElement(By.XPath("//div[@class= 'ui checkbox ']//input"));

        //Identify join button
        private static IWebElement Joinbtn => Driver.driver.FindElement(By.XPath("//div[@id='submit-btn']"));


        public static void Join()
        {
            //Click on Join button
            JoinBtn.Click();
            Thread.Sleep(5000);
        }
        public static void EnterDetails()
        {
            //Populate the excel data
            ExcelLibHelper.PopulateInCollection(@"MarsQA-1\SpecflowTests\Data\Mars.xlsx", "Sign Up");
            
            //Enter FirstName
            FirstName.SendKeys(ExcelLibHelper.ReadData(2, "FirstName"));

            //Enter LastName
            LastName.SendKeys(ExcelLibHelper.ReadData(2, "LastName"));
    

            //Enter Email
            Email.SendKeys(ExcelLibHelper.ReadData(2, "Email"));
            Thread.Sleep(5000);

            //Enter Password
            Password.SendKeys(ExcelLibHelper.ReadData(2, "Password"));

            //Enter Password again to confirm
            ConfirmPassword.SendKeys(ExcelLibHelper.ReadData(2, "Confirm Pwd"));

            //Click on Checkbox
            Checkbox.Click();
        }
        public static void ClickOnJoinButton()
        { 
            //Click on join button to Sign Up
             Joinbtn.Click();
            Thread.Sleep(5000); 
            }
        }
    }



