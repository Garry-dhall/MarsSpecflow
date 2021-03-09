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
        public static void SigninStep()
        {
            Driver.NavigateUrl();
            Thread.Sleep(5000);
            SignInBtn.Click();
            Email.SendKeys(ExcelLibHelper.ReadData(3, "username"));
            Thread.Sleep(5000);
            Password.SendKeys(ExcelLibHelper.ReadData(3, "password"));
            LoginBtn.Click();
            Thread.Sleep(5000);
        }
        public static void Login()
        {
            Driver.NavigateUrl();

            Thread.Sleep(5000);
            //Enter Url
            Driver.driver.FindElement(By.XPath("//A[@class='item'][text()='Sign In']")).Click();
            Thread.Sleep(5000);
            //Enter Username
            Driver.driver.FindElement(By.XPath("(//input[@name = 'email'])")).SendKeys("garrydhallnz@gmail.com");
           
            //Enter password
            Driver.driver.FindElement(By.XPath("//INPUT[@type='password']")).SendKeys("Chef@123");

            //Click on Login Button
            Driver.driver.FindElement(By.XPath("//BUTTON[@class='fluid ui teal button'][text()='Login']")).Click();

        }
    }
}