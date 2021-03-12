using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.Helpers
{
    public class Driver
    {
        //Initialize the browser
        public static IWebDriver driver { get; set; }

        public static void Initialize()
        {
            //Defining the browser
            driver = new ChromeDriver();
                //(@"C:\Users\minty\OneDrive\Desktop\Chromepath");
            TurnOnWait();
            //Maximise the window
            driver.Manage().Window.Maximize();
        }

        public static string BaseUrl
        {
            get { return ConstantHelpers.Url; }
        }


        //Implicit Wait
        public static void TurnOnWait()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        }

        public static void NavigateUrl()
        {
            TurnOnWait();
            driver.Navigate().GoToUrl("http://192.168.99.100:5000");
        }

        //Close the browser
        public static void Close()
        {
            driver.Close();
        }

    }
}
