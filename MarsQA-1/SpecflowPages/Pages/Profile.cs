using MarsQA_1.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    class Profile
    {

        public static void ProfileButton()
        {
         IWebElement ProfileBtn = Driver.driver.FindElement(By.XPath("//A[text()= 'Profile']"));
            ProfileBtn.Click();
            
    }
        public static void Addlanguage(string lang)
        {
            IWebElement addLang = Driver.driver.FindElement(By.XPath("//A[text()= 'Profile']"));
            addLang.SendKeys(lang);
        }

    }
}
