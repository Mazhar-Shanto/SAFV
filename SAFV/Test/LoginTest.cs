using SAFV.Drivers;
using SAFV.Source.Pages;
using SAFV.Helper;
using SAFV.Helper.Log;

namespace SAFV.Test
{
    public class LoginTest : Driver
    {
        [Test, Order(0)]
        public void SafvLogin()
        {
            // Read login data
            var loginDataList = LoginDataReader.ReadLoginData();

            // Test
            foreach (var row in loginDataList)
            {
                Reporting.CreateTest("LoginTest");

                LoginPage loginPage = new LoginPage(_driver);
                HomePage homePage = new HomePage(_driver);
                loginPage.GoToLoginPage();

                loginPage.Login(row["Username"], row["Password"]);

                try
                {
                    Assert.That(_driver.Title.Contains("Home Page - SAFV_Site"), "Login test failed for Username: " + row["Username"]);
                    Reporting.SetTestStatusPass();
                }
                catch (AssertionException e)
                {
                    Console.WriteLine($"Login test failed for Username: {row["Username"]}, Password: {row["Password"]}");
                    Console.WriteLine(e.Message);
                    Reporting.SetTestStatusFail($"Login test failed for Username: {row["Username"]}, Password: {row["Password"]}.");
                }

                homePage.Logout();
                Assert.That(_driver.Title.Contains("Log in - SAFV_TEST"), "Logout test failed for Username: " + row["Username"]);
            }
        }

        /*[Test]
        public void a()
        {
            string input = "ActsOfFamilyViolence\tStalking\tDirectCommunication\tThreatCommunication\tAnyCommunication\tPhysicalDistance\tYards\tPossessFirearm\tNearResidence\tNearPlaceOfEmployment\tNearSchool\tTracking\tGpsMonitoring\tGpsMonitoringDescription\tHumanTrafficking\tVictimNotification\tCourtAppearance\tVictimContact\tApproachResidence\tSchoolDaycare\tWeapons\tAlcoholDrugs\tPrescriptionMedications\tDrugTest\tCourtOrder\tOffense\tOtherConditions\tOtherConditionsDescription";

            // Split the string into words, ignoring multiple spaces
            string[] words = input.Split(new[] { "\t" }, StringSplitOptions.RemoveEmptyEntries);
            int count = 0;

            // Print each word on a new line
            foreach (string word in words)
            {
                Console.WriteLine("courtEpoConditionsColumnList.AddColumn(\"" + word + "\", \"" + word + "\");");
                count++;
            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(count);
        }*/
    }
}
