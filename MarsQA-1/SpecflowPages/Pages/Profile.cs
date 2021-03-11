using MarsQA_1.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.Pages
{
    class CreateProfile
    {
        public static void clickOnselectAvailability()
        {
            IWebElement avail = Driver.driver.FindElement(By.XPath("//*[contains(text(), 'Availability')]//following::i[1]"));
            avail.Click();
        }
        public static void SelectAvailibility()
        { 
            ExcelLibHelper.PopulateInCollection(@"MarsQA-1\SpecflowTests\Data\Mars.xlsx", "Profile");
            Driver.TurnOnWait();
            IWebElement availDropdown = Driver.driver.FindElement(By.XPath("//select[@name ='availabiltyType']"));
            availDropdown.Click();
            SelectElement sel = new SelectElement(availDropdown);
            sel.SelectByText(ExcelLibHelper.ReadData(2, "Availability"));
        }
        public static void clickOnHours()
        {
            IWebElement hours = Driver.driver.FindElement(By.XPath("//*[contains(text(), 'Availability')]//following::i[3]"));
            hours.Click();
        }

        public static void selectHours()
        {
            ExcelLibHelper.PopulateInCollection(@"MarsQA-1\SpecflowTests\Data\Mars.xlsx", "Profile");
            Driver.TurnOnWait();   
            IWebElement hourDropdown = Driver.driver.FindElement(By.XPath("//select[@name ='availabiltyHour']"));
            hourDropdown.Click();
            SelectElement sel = new SelectElement(hourDropdown);
            sel.SelectByText(ExcelLibHelper.ReadData(2, "Hours"));
        }
        public static void clickOnEarnTarget()
        {
            IWebElement target = Driver.driver.FindElement(By.XPath("//*[contains(text(), 'Availability')]//following::i[5]"));
            target.Click();
        }
        public static void selectEarnTarget()
        {
            ExcelLibHelper.PopulateInCollection(@"MarsQA-1\SpecflowTests\Data\Mars.xlsx", "Profile");
            IWebElement targetDropdown = Driver.driver.FindElement(By.XPath("//select[@name ='availabiltyTarget']"));
            targetDropdown.Click();
            SelectElement sel = new SelectElement(targetDropdown);
            sel.SelectByText(ExcelLibHelper.ReadData(2, "EarnTarget"));
        }

        public static void Descritpion()
        {
            Driver.TurnOnWait();
            IWebElement Desc = Driver.driver.FindElement(By.XPath("//*[text() = 'Description']//i"));
            Desc.Click();
            IWebElement descEnter = Driver.driver.FindElement(By.XPath("//textarea[@name = 'value']"));
            descEnter.SendKeys("Docker, Selenium");
            Driver.driver.FindElement(By.XPath("//button[text() ='Save'][@type ='button']")).Click();
        }
    }
}

