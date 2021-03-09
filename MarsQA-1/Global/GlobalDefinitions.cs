using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;


namespace MarsQA_1.Global
{
    class GlobalDefinitions
    {

        //Initialise the browser
        public static IWebDriver driver { get; set; }

        #region WaitforElement 

        public static void wait(int time)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(time);

        }
        //public static IWebElement WaitForElement(IWebDriver driver, By by, int timeOutinSeconds)
        //{
        //    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutinSeconds));
        //   // return (wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(by)));
           #endregion
        
    }
}
