using MarsQA_1.Helpers;
using OpenQA.Selenium;
using System.Threading;

namespace MarsQA_1.Pages
{
    public static class SignIn
    {
        private static IWebElement SignInBtn =>  Driver.driver.FindElement(By.XPath("//A[@class='item'][text()='Sign In']"));
        private static IWebElement Email => Driver.driver.FindElement(By.XPath("(//input[@name = 'email'])"));
        private static IWebElement Password => Driver.driver.FindElement(By.XPath("//INPUT[@type='password']"));
        private static IWebElement LoginBtn => Driver.driver.FindElement(By.XPath("//BUTTON[@class='fluid ui teal button'][text()='Login']"));
        public static void ClickSignInBtn()
        {
            SignInBtn.Click();
        }
        public static void EnterCredentials()
        {
            ExcelLibHelper.PopulateInCollection(@"MarsQA-1\SpecflowTests\Data\Mars.xlsx", "Credentials");
            Email.SendKeys(ExcelLibHelper.ReadData(3, "username"));
            Password.SendKeys(ExcelLibHelper.ReadData(3, "password"));
        }
        public static void ClickOnLoginBtn()
        { 
            LoginBtn.Click();
            Thread.Sleep(5000);
        }
        public static void Login()
        {
           Driver.NavigateUrl();
            Driver.TurnOnWait();
           Driver.driver.FindElement(By.XPath("//A[@class='item'][text()='Sign In']")).Click();
            //Enter Username
           Driver.driver.FindElement(By.XPath("(//input[@name = 'email'])")).SendKeys("garrydhallnz@gmail.com");
           //Enter password
           Driver.driver.FindElement(By.XPath("//INPUT[@type='password']")).SendKeys("Test@123");
            //Click on Login Button
           Driver.driver.FindElement(By.XPath("//BUTTON[@class='fluid ui teal button'][text()='Login']")).Click();
            Thread.Sleep(4000);
        }
    }
}