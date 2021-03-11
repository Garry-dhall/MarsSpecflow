using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;
using static MarsQA_1.Helpers.CommonMethods;

namespace MarsQA_1.Utils
{
    [Binding]
    public class Start : Driver
    {

        [BeforeScenario("@mytag")]
        public void Setup()
        {
            //launch the browser
            Initialize();
            Driver.TurnOnWait();
            ExcelLibHelper.PopulateInCollection(@"MarsQA-1\SpecflowTests\Data\Mars.xlsx", "Credentials");
            //call the SignIn class
            SignIn.Login();
        }

        [AfterScenario("@mytag")]
        public void TearDown()
        {

            // Screenshot
            string img = CommonMethods.SaveScreenShotClass.SaveScreenshot(Driver.driver, "Report");
            CommonMethods.ExtentReports();
           CommonMethods.test = CommonMethods.Extent.StartTest("Reports");
            test.Log(LogStatus.Info, "Snapshot below: " + test.AddScreenCapture(img));
            // end test. (Reports)
            CommonMethods.Extent.EndTest(test);
            // calling Flush writes everything to the log file (Reports)
            CommonMethods.Extent.Flush();
            //Close the browser
            //Driver.Close();

        }
    }
}

