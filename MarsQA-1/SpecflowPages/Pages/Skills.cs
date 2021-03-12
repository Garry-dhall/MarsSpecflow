using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    class Skills
    {
        public static void clickOnSkillButton()
        {
            Driver.TurnOnWait();
            Driver.driver.FindElement(By.XPath("//a[text() = 'Skills']")).Click();
        }
        public static void addNewSkill()
        {
            Driver.TurnOnWait();
            Driver.driver.FindElement(By.XPath("//div[@class='ui teal button'][text()='Add New']")).Click();
            Thread.Sleep(4000);
            IWebElement Text =  Driver.driver.FindElement(By.XPath("//input[@name ='name']"));
            ExcelLibHelper.PopulateInCollection(@"MarsQA-1\SpecflowTests\Data\Mars.xlsx", "Skills");
            Text.SendKeys(ExcelLibHelper.ReadData(2, "SkillName"));
            IWebElement selectLevel = Driver.driver.FindElement(By.XPath("//Select[@name ='level']"));
            selectLevel.Click();
            SelectElement select = new SelectElement(selectLevel);
            select.SelectByValue("Intermediate");
        }
        public static void clickOnAddButton()
        {
            Driver.driver.FindElement(By.XPath("//input[@value ='Add']")).Click();
            Thread.Sleep(5000);
        }
        //ns-box ns-growl ns-effect-jelly ns-type-success ns-show
        public static void clickEditButton()
        {
            IList<IWebElement> rowCount = Driver.driver.FindElements(By.XPath("//h3[text() = 'Skills']//following::table//tbody//tr//td[1]"));
            int row = rowCount.Count;
            Console.WriteLine(row);
            for (int i = 1; i <= row; i++)
            {
                var skillname = Driver.driver.FindElement(By.XPath("//div[@class = 'ui bottom attached tab segment tooltip-target active']//tbody[" + i + "]//tr//td[1]")).Text;
                var clickEdit = Driver.driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']//tbody[" + i + "]//tr[1]//td//i[@class = 'outline write icon']"));
                var expectVal = "aa";
                Driver.TurnOnWait();
                if (expectVal == skillname)
                {
                    Assert.AreEqual(expectVal, skillname, "Skillname not found");
                    clickEdit.Click();
                    Console.WriteLine("Edit Clicked");
                }
            }
        }
        public static void editSkill()
        {
            
            var clickOnSkillName = Driver.driver.FindElement(By.XPath("//input[@value = 'aa']"));
            clickOnSkillName.Click();
            clickOnSkillName.Clear();
            Thread.Sleep(3000);
            clickOnSkillName.SendKeys("API");
        }
        public static void clickOnUpdateSkill()
        {
            Driver.driver.FindElement(By.XPath("//input[@value = 'Update']")).Click();
            Thread.Sleep(3000);
        }

        public static void deleteSkill()
        {
            Driver.TurnOnWait();
            IList<IWebElement> rowCount = Driver.driver.FindElements(By.XPath("//h3[text() = 'Skills']//following::table//tbody//tr//td[1]"));
            int row = rowCount.Count;
            Console.WriteLine(row);
            for(int a = 1; a<=row; a++)
            {
                var clickDel = Driver.driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']//tbody["+ a +"]//tr[1]//td//span[@class ='button'][2]"));
                var skilledname = Driver.driver.FindElement(By.XPath("//div[@class = 'ui bottom attached tab segment tooltip-target active']//tbody[" + a + "]//tr//td[1]")).Text;
                var expectValue = "API";
                if(expectValue == skilledname)
                    {
                    Assert.AreEqual(expectValue, skilledname, "Assertion failed");
                    clickDel.Click();
                    break;
                }

            }


        }
    }
}
