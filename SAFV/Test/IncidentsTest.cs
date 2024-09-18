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
            var incidentInfoDataList = IncidentInfoDataReader.ReadIncidentInfoData();
            var victimDataList = PeopleDataReader.ReadVictimData();
            var suspectDataList = PeopleDataReader.ReadSuspectData();
            var witnessDataList = PeopleDataReader.ReadWitnessData();
            var otherPeopleDataList = PeopleDataReader.ReadOtherPeopleData();

            int loginDataCount = loginDataList.Count();

            //test
            for (int i = 0; i < loginDataCount; i++)
            {
                var loginData = loginDataList[i];
                var incidentData = incidentDataList[i];
                var incidentInfoData = incidentInfoDataList[i];
                var victimData = victimDataList[i];
                var suspectData = suspectDataList[i];
                var witnessData = witnessDataList[i];
                var optherPeopleData = otherPeopleDataList[i];

                Reporting.CreateTest("IncidentTest");

                LoginPage loginPage = new LoginPage(_driver);
                IncidentsPage incidentsPage = new IncidentsPage(_driver);
                HomePage homePage = new HomePage(_driver);

                loginPage.GoToLoginPage();

                loginPage.Login(loginData["Username"], loginData["Password"]);
                incidentsPage.GoToIncidentPage();

                incidentsPage.CreateIncident(incidentData);
                incidentsPage.CreateIncidentInfo(incidentInfoData);
                incidentsPage.CreatePeople(victimData);
                incidentsPage.GoToPeoplePage();
                incidentsPage.CreatePeople(suspectData);
                incidentsPage.GoToPeoplePage();
                incidentsPage.CreatePeople(witnessData);
                incidentsPage.GoToPeoplePage();
                incidentsPage.CreatePeople(optherPeopleData);
            }
        }
    }
}
