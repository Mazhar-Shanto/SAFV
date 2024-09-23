using SAFV.Drivers;
using SAFV.Helper;
using SAFV.Source.Pages;

namespace SAFV.Test
{
    internal class IncidentsTest : Driver
    {
        [Test]
        public void CreateMainIncidentTest()
        {
            // Read data
            var loginDataList = LoginDataReader.ReadLoginData();
            var incidentDataList = IncidentDataReader.ReadIncidentData("Main");

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


        [Test]
        public void CreateSupplementIncidentTest()
        {
            // Read data
            var loginDataList = LoginDataReader.ReadLoginData();
            var incidentDataList = IncidentDataReader.ReadIncidentData("Supplement");

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


        [Test]
        public void CreateConfidentialIncidentTest()
        {
            // Read data
            var loginDataList = LoginDataReader.ReadLoginData();
            var incidentDataList = IncidentDataReader.ReadIncidentData("Confidential");

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


        [Test]
        public void CreateIncidentFullCycleTest()
        {
            // Read data
            var loginDataList = LoginDataReader.ReadLoginData();
            var incidentDataList = IncidentDataReader.ReadIncidentData("Main");
            var incidentInfoDataList = IncidentInfoDataReader.ReadIncidentInfoData();
            var victimDataList = PeopleDataReader.ReadVictimData();
            var witnessDataList = PeopleDataReader.ReadWitnessData();
            var otherPeopleDataList = PeopleDataReader.ReadOtherPeopleData();

            var suspectDataList = PeopleDataReader.ReadSuspectData();
            var suspectInterviewDataList = PeopleDataReader.ReadSuspectInterviewData();
            var suspectInfoDataList = PeopleDataReader.ReadSuspectInfoData();
            var emergencyContactDataList = PeopleDataReader.ReadEmergencyContactData();
            var externalInfoDataList = PeopleDataReader.ReadExternalInfoData();

            int loginDataCount = loginDataList.Count();

            //test
            for (int i = 0; i < loginDataCount; i++)
            {
                var loginData = loginDataList[i];
                var incidentData = incidentDataList[i];
                var incidentInfoData = incidentInfoDataList[i];
                var victimData = victimDataList[i];
                var witnessData = witnessDataList[i];
                var optherPeopleData = otherPeopleDataList[i];

                var suspectData = suspectDataList[i];
                var suspectInterviewData = suspectInterviewDataList[i];
                var suspectInfoData = suspectInfoDataList[i];
                var emergencyContactData = emergencyContactDataList[i];
                var externalInfoData = externalInfoDataList[i];

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
                incidentsPage.CreatePeople(witnessData);
                incidentsPage.GoToPeoplePage();
                incidentsPage.CreatePeople(optherPeopleData);
                incidentsPage.GoToPeoplePage();
                incidentsPage.CreatePeople(suspectData);
                incidentsPage.CreatePeopleInterview(suspectInterviewData);
                incidentsPage.CreateSuspectInfo(suspectInfoData);
                incidentsPage.CreateExternalInfo(externalInfoData);
            }
        }
    }
}
