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

                Reporting.CreateTest("MainIncidentCreateTest");

                LoginPage loginPage = new LoginPage(_driver);
                IncidentsPage incidentsPage = new IncidentsPage(_driver);

                loginPage.GoToLoginPage();

                loginPage.Login(loginData["Username"], loginData["Password"]);
                incidentsPage.GoToIncidentPage();

                incidentsPage.CreateNewIncident(incidentData);
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

                Reporting.CreateTest("SupplementIncidentCreateTest");

                LoginPage loginPage = new LoginPage(_driver);
                IncidentsPage incidentsPage = new IncidentsPage(_driver);

                loginPage.GoToLoginPage();

                loginPage.Login(loginData["Username"], loginData["Password"]);
                incidentsPage.GoToIncidentPage();

                incidentsPage.CreateNewIncident(incidentData);
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

                Reporting.CreateTest("ConfidentialIncidentCreateTest");

                LoginPage loginPage = new LoginPage(_driver);
                IncidentsPage incidentsPage = new IncidentsPage(_driver);

                loginPage.GoToLoginPage();

                loginPage.Login(loginData["Username"], loginData["Password"]);
                incidentsPage.GoToIncidentPage();

                incidentsPage.CreateNewIncident(incidentData);
            }
        }


        [Test]
        public void CreateNewIncidentFullCycleTest()
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
            var masterSearchDataList = PeopleDataReader.ReadMasterSearchData();
            var locationDataList = LocationDataReader.ReadLocationData();
            var sceneDataList = LocationDataReader.ReadSceneData();
            var offenseDataList = OffenseDataReader.ReadOffenseData();
            var offenseSceneDataList = OffenseDataReader.ReadSceneData();
            var biasDataList = OffenseDataReader.ReadBiasData();
            var mannerDataList = OffenseDataReader.ReadMannerData();
            var offenseRiskAssessmentDataList = OffenseDataReader.ReadOffenseRiskAssessmentData();
            var useOfWeaponDataList = OffenseDataReader.ReadUseOfWeaponData();
            var aggAssaultDataList = OffenseDataReader.ReadAggAssaultData();
            var riskAssessmentDataList = RiskAssessmentDataReader.ReadRiskAssessmentData();
            var epoDataList = EpoDataReader.ReadEpoData();

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
                var masterSearchData = masterSearchDataList[i];
                var locationData = locationDataList[i];
                var sceneData = sceneDataList[i];
                var offenseData = offenseDataList[i];
                var offenseSceneData = offenseSceneDataList[i];
                var biasData = biasDataList[i];
                var mannerData = mannerDataList[i];
                var offenseRiskAssessmentData = offenseRiskAssessmentDataList[i];
                var useOfWeaponData = useOfWeaponDataList[i];
                var aggAssaultData = aggAssaultDataList[i];
                var riskAssessmentData = riskAssessmentDataList[i];
                var epoData = epoDataList[i];

                Reporting.CreateTest("IncidentFullCycleTest");

                LoginPage loginPage = new LoginPage(_driver);
                IncidentsPage incidentsPage = new IncidentsPage(_driver);
                IncidentInfoPage incidentInfoPage = new IncidentInfoPage(_driver);
                PeoplePage peoplePage = new PeoplePage(_driver);
                LocationPage locationPage = new LocationPage(_driver);
                OffensePage offensePage = new OffensePage(_driver);
                RiskAssessmentPage riskAssessmentPage = new RiskAssessmentPage(_driver);
                EpoBookingPage epoBookingPage = new EpoBookingPage(_driver);

                loginPage.GoToLoginPage();

                loginPage.Login(loginData["Username"], loginData["Password"]);
                incidentsPage.GoToIncidentPage();

                incidentsPage.CreateNewIncident(incidentData);
                incidentInfoPage.CreateIncidentInfo(incidentInfoData);
                peoplePage.CreatePeople(victimData);
                peoplePage.CreatePeopleMoreInfo(victimData);
                peoplePage.GoToPeoplePage();
                //peoplePage.CreatePeople(witnessData);
                //peoplePage.CreatePeopleMoreInfo(witnessData);
                peoplePage.CreatePeopleFromMaster(masterSearchData);
                peoplePage.GoToPeoplePage();
                peoplePage.CreatePeople(optherPeopleData);
                peoplePage.CreatePeopleMoreInfo(optherPeopleData);
                peoplePage.GoToPeoplePage();
                peoplePage.CreatePeople(suspectData);
                peoplePage.CreatePeopleMoreInfo(suspectData);
                peoplePage.CreatePeopleInterview(suspectInterviewData);
                peoplePage.CreateSuspectInfo(suspectInfoData);
                peoplePage.CreateMedicalEms(medicalEmsData);
                peoplePage.CreateDemeanorInfo(demeanorData);
                peoplePage.CreateEmergencyContact(emergencyContactData);
                peoplePage.CreateExternalInfo(externalInfoData);
                peoplePage.CreateSuspectEvidence(suspectEvidenceData);
                locationPage.GoToLocationPage();
                locationPage.CreateLocation(locationData);
                locationPage.CreateScene(sceneData);
                offensePage.GoToOffensePage();
                offensePage.CreateOffense(offenseData);
                offensePage.CreateOffenceScene(offenseSceneData);
                offensePage.CreateBias(biasData);
                offensePage.CreateManner(mannerData);
                offensePage.CreateRiskAssessment(offenseRiskAssessmentData);
                offensePage.CreateUseOfWeapon(useOfWeaponData);
                offensePage.CreateAggAssault(aggAssaultData);
                offensePage.CreatePcNarrative();
                riskAssessmentPage.GoToRiskAssessmentPage();
                riskAssessmentPage.CreateRiskAssessment(riskAssessmentData);
                epoBookingPage.GoToEpoBookingPage();
                epoBookingPage.CreateEpoRequest(epoData);
            }
        }
    }
}
