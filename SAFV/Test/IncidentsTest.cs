using SAFV.Drivers;
using SAFV.Helper;
using SAFV.Source.Pages;

namespace SAFV.Test
{
    internal class IncidentsTest : Driver
    {
        [Test]
        public void CreateIncidentTest()
        {
            // Read data
            var loginDataList = LoginDataReader.ReadLoginData();
            var incidentDataList = IncidentDataReader.ReadIncidentData();

            int loginDataCount = loginDataList.Count();

            //test
            for (int i = 0; i < loginDataCount; i++)
            {
                var loginData = loginDataList[i];
                var incidentData = incidentDataList[i];
                Reporting.CreateTest("IncidentTest");

                LoginPage loginPage = new LoginPage(_driver);
                IncidentsPage incidentsPage = new IncidentsPage(_driver);
                HomePage homePage = new HomePage(_driver);

                loginPage.GoToLoginPage();

                loginPage.Login(loginData["Username"], loginData["Password"]);
                incidentsPage.GoToIncidentPage();

                incidentsPage.CreateIncident(incidentData);
            }
        }
    }
}
