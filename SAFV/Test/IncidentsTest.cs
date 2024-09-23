using SAFV.Drivers;
using SAFV.Helper;
using SAFV.Source.Pages;
using SAFV.Source.Pages.CreateIncident;

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
            var medicalEmsDataList = PeopleDataReader.ReadMedicalEmsData();
            var demeanorDataList = PeopleDataReader.ReadDemeanorData();
            var emergencyContactDataList = PeopleDataReader.ReadEmergencyContactData();
            var externalInfoDataList = PeopleDataReader.ReadExternalInfoData();
            var suspectEvidenceDataList = PeopleDataReader.ReadSuspectEvidenceData();

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
                var medicalEmsData = medicalEmsDataList[i];
                var demeanorData = demeanorDataList[i];
                var emergencyContactData = emergencyContactDataList[i];
                var externalInfoData = externalInfoDataList[i];
                var suspectEvidenceData = suspectEvidenceDataList[i];

                Reporting.CreateTest("IncidentTest");

                LoginPage loginPage = new LoginPage(_driver);
                IncidentsPage incidentsPage = new IncidentsPage(_driver);
                IncidentInfoPage incidentInfoPage = new IncidentInfoPage(_driver);
                PeoplePage peoplePage = new PeoplePage(_driver);

                loginPage.GoToLoginPage();

                loginPage.Login(loginData["Username"], loginData["Password"]);
                incidentsPage.GoToIncidentPage();

                incidentsPage.CreateIncident(incidentData);
                incidentInfoPage.CreateIncidentInfo(incidentInfoData);
                peoplePage.CreatePeople(victimData);
                peoplePage.GoToPeoplePage();
                peoplePage.CreatePeople(witnessData);
                peoplePage.GoToPeoplePage();
                peoplePage.CreatePeople(optherPeopleData);
                peoplePage.GoToPeoplePage();
                peoplePage.CreatePeople(suspectData);
                peoplePage.CreatePeopleInterview(suspectInterviewData);
                peoplePage.CreateSuspectInfo(suspectInfoData);
                peoplePage.CreateMedicalEms(medicalEmsData);
                peoplePage.CreateDemeanorInfo(demeanorData);
                peoplePage.CreateEmergencyContact(emergencyContactData);
                peoplePage.CreateExternalInfo(externalInfoData);
                peoplePage.CreateExternalInfo(suspectEvidenceData);
            }
        }
    }
}
