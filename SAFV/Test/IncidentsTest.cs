using SAFV.Drivers;
using SAFV.Helper;
using SAFV.Helper.Log;
using SAFV.Source.Pages;
using SAFV.Source.Pages.CreateIncident;

namespace SAFV.Test
{
    internal class IncidentsTest : Driver
    {
        [Test, Order(1)]
        public void CreateMainIncidentTest()
        {
            // Read data
            var loginDataList = LoginDataReader.ReadLoginData();
            var incidentDataList = IncidentDataReader.ReadIncidentData("Main");
            var incidentCountDataList = IncidentDataReader.ReadIncidentCount();

            int loginDataCount = loginDataList.Count();

            //test
            for (int i = 0; i < loginDataCount; i++)
            {
                var loginData = loginDataList[i];
                var incidentData = incidentDataList[i];
                var incidentCountData = incidentCountDataList[i];

                Reporting.CreateTest("CreateMainIncidentTest");

                LoginPage loginPage = new LoginPage(_driver);
                IncidentsPage incidentsPage = new IncidentsPage(_driver);

                string pageTitle = _driver.Title;

                if (pageTitle != null && !pageTitle.Contains("SAFV_Site"))
                {
                    loginPage.GoToLoginPage();
                    loginPage.Login(loginData["Username"], loginData["Password"]);
                }

                incidentsPage.GoToIncidentCreatePage();

                string caseCountOld = incidentCountData["CaseCount"];
                string caseNumberOld = incidentCountData["CaseNumber"];
                string supplementCountOld = incidentCountData["SupplementCount"];
                string supplementNumberOld = incidentCountData["SupplementNumber"];
                string mainCaseForSupplement = incidentCountData["MainCaseForSupplement"];

                int caseCountInt = Int32.Parse(caseCountOld) + 1;
                string caseCountNew = caseCountInt.ToString();

                string caseNumberNew = incidentsPage.CreateNewIncident(incidentData, caseCountNew, mainCaseForSupplement);

                WriteToExcel.WriteLog(caseCountNew, caseNumberNew, supplementCountOld, supplementNumberOld, mainCaseForSupplement);
            }
        }


        [Test, Order(2)]
        public void CreateConfidentialIncidentTest()
        {
            // Read data
            var loginDataList = LoginDataReader.ReadLoginData();
            var incidentDataList = IncidentDataReader.ReadIncidentData("Confidential");
            var incidentCountDataList = IncidentDataReader.ReadIncidentCount();

            int loginDataCount = loginDataList.Count();

            //test
            for (int i = 0; i < loginDataCount; i++)
            {
                var loginData = loginDataList[i];
                var incidentData = incidentDataList[i];
                var incidentCountData = incidentCountDataList[i];

                Reporting.CreateTest("CreateConfidentialIncidentTest");

                LoginPage loginPage = new LoginPage(_driver);
                IncidentsPage incidentsPage = new IncidentsPage(_driver);

                string pageTitle = _driver.Title;

                if (pageTitle != null && !pageTitle.Contains("SAFV_Site"))
                {
                    loginPage.GoToLoginPage();
                    loginPage.Login(loginData["Username"], loginData["Password"]);
                }

                incidentsPage.GoToIncidentCreatePage();

                string caseCountOld = incidentCountData["CaseCount"];
                string caseNumberOld = incidentCountData["CaseNumber"];
                string supplementCountOld = incidentCountData["SupplementCount"];
                string supplementNumberOld = incidentCountData["SupplementNumber"];
                string mainCaseForSupplement = incidentCountData["MainCaseForSupplement"];

                int caseCountInt = Int32.Parse(caseCountOld) + 1;
                string caseCountNew = caseCountInt.ToString();

                string caseNumberNew = incidentsPage.CreateNewIncident(incidentData, caseCountNew, mainCaseForSupplement);

                WriteToExcel.WriteLog(caseCountNew, caseNumberNew, supplementCountOld, supplementNumberOld, mainCaseForSupplement);
            }
        }


        [Test, Order(3)]
        public void CreateNewIncidentFullCycleTest()
        {
            // Read data
            var loginDataList = LoginDataReader.ReadLoginData();
            var incidentDataList = IncidentDataReader.ReadIncidentData("Main");
            var incidentCountDataList = IncidentDataReader.ReadIncidentCount();
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
            var evidenceDataList = EvidenceDataReader.ReadEvidenceData();

            int loginDataCount = loginDataList.Count();

            //test
            for (int i = 0; i < loginDataCount; i++)
            {
                var loginData = loginDataList[i];
                var incidentData = incidentDataList[i];
                var incidentCountData = incidentCountDataList[i];
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
                var evidenceData = evidenceDataList[i];

                Reporting.CreateTest("CreateNewIncidentFullCycleTest");

                LoginPage loginPage = new LoginPage(_driver);
                IncidentsPage incidentsPage = new IncidentsPage(_driver);
                IncidentInfoPage incidentInfoPage = new IncidentInfoPage(_driver);
                PeoplePage peoplePage = new PeoplePage(_driver);
                LocationPage locationPage = new LocationPage(_driver);
                OffensePage offensePage = new OffensePage(_driver);
                RiskAssessmentPage riskAssessmentPage = new RiskAssessmentPage(_driver);
                EpoBookingPage epoBookingPage = new EpoBookingPage(_driver);
                EvidencePage evidencePage = new EvidencePage(_driver);
                ReportPage reportPage = new ReportPage(_driver);

                string pageTitle = _driver.Title;

                if (pageTitle != null && !pageTitle.Contains("SAFV_Site"))
                {
                    loginPage.GoToLoginPage();
                    loginPage.Login(loginData["Username"], loginData["Password"]);
                }

                incidentsPage.GoToIncidentCreatePage();

                string caseCountOld = incidentCountData["CaseCount"];
                string caseNumberOld = incidentCountData["CaseNumber"];
                string supplementCountOld = incidentCountData["SupplementCount"];
                string supplementNumberOld = incidentCountData["SupplementNumber"];
                string mainCaseForSupplement = incidentCountData["MainCaseForSupplement"];

                int caseCountInt = Int32.Parse(caseCountOld) + 1;
                string caseCountNew = caseCountInt.ToString();

                string caseNumberNew = incidentsPage.CreateNewIncident(incidentData, caseCountNew, mainCaseForSupplement);

                WriteToExcel.WriteLog(caseCountNew, caseNumberNew, supplementCountOld, supplementNumberOld, mainCaseForSupplement);

                incidentInfoPage.CreateIncidentInfo(incidentInfoData);
                peoplePage.GoToPeoplePage();
                //peoplePage.CreatePeople(witnessData);
                //peoplePage.CreatePeopleMoreInfo(witnessData);
                peoplePage.CreatePeopleFromMaster(masterSearchData);
                peoplePage.GoToPeoplePage();
                peoplePage.CreatePeople(victimData);
                peoplePage.CreatePeopleMoreInfo(victimData);
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
                //offensePage.CreateUseOfWeapon(useOfWeaponData);
                offensePage.CreateAggAssault(aggAssaultData);
                offensePage.CreatePcNarrative();
                riskAssessmentPage.GoToRiskAssessmentPage();
                riskAssessmentPage.CreateRiskAssessment(riskAssessmentData);
                epoBookingPage.GoToEpoBookingPage();
                epoBookingPage.CreateEpoRequest(epoData);

                WriteToExcel.WriteEpoLog(caseNumberNew);

                evidencePage.GoToEvidencePage();
                evidencePage.CreateEvidence(evidenceData);
            }
        }


        [Test, Order(4)]
        public void GenerateReportTest()
        {
            // Read data
            var loginDataList = LoginDataReader.ReadLoginData();
            var incidentCountDataList = IncidentDataReader.ReadIncidentCount();

            int loginDataCount = loginDataList.Count();

            //test
            for (int i = 0; i < loginDataCount; i++)
            {
                var loginData = loginDataList[i];
                var incidentCountData = incidentCountDataList[i];

                Reporting.CreateTest("GenerateReportTest");

                LoginPage loginPage = new LoginPage(_driver);
                IncidentsPage incidentsPage = new IncidentsPage(_driver);
                PeoplePage peoplePage = new PeoplePage(_driver);
                ReportPage reportPage = new ReportPage(_driver);

                string pageTitle = _driver.Title;

                if (pageTitle != null && !pageTitle.Contains("SAFV_Site"))
                {
                    loginPage.GoToLoginPage();
                    loginPage.Login(loginData["Username"], loginData["Password"]);
                }

                incidentsPage.GoToIncidentPage();

                string caseCountOld = incidentCountData["CaseCount"];
                string caseNumberOld = incidentCountData["CaseNumber"];
                string supplementCountOld = incidentCountData["SupplementCount"];
                string supplementNumberOld = incidentCountData["SupplementNumber"];
                string mainCaseForSupplement = incidentCountData["MainCaseForSupplement"];
                incidentsPage.SearchIncident(caseNumberOld);
                Thread.Sleep(3000);
                incidentsPage.OpenIncident();
                reportPage.GoToReportPage();
                reportPage.CreateReport();
                _driver.Close();
                _driver.SwitchTo().Window(_driver.WindowHandles[0]);
            }
        }


        [Test, Order(5)]
        public void SendToDfpsTest()
        {
            // Read data
            var loginDataList = LoginDataReader.ReadLoginData();
            var incidentCountDataList = IncidentDataReader.ReadIncidentCount();

            int loginDataCount = loginDataList.Count();

            //test
            for (int i = 0; i < loginDataCount; i++)
            {
                var loginData = loginDataList[i];
                var incidentCountData = incidentCountDataList[i];

                Reporting.CreateTest("SendToDfpsTest");

                LoginPage loginPage = new LoginPage(_driver);
                IncidentsPage incidentsPage = new IncidentsPage(_driver);
                PeoplePage peoplePage = new PeoplePage(_driver);
                ReportPage reportPage = new ReportPage(_driver);

                string pageTitle = _driver.Title;

                if (pageTitle != null && !pageTitle.Contains("SAFV_Site"))
                {
                    loginPage.GoToLoginPage();
                    loginPage.Login(loginData["Username"], loginData["Password"]);
                }

                incidentsPage.GoToIncidentPage();

                string caseCountOld = incidentCountData["CaseCount"];
                string caseNumberOld = incidentCountData["CaseNumber"];
                string supplementCountOld = incidentCountData["SupplementCount"];
                string supplementNumberOld = incidentCountData["SupplementNumber"];
                string mainCaseForSupplement = incidentCountData["MainCaseForSupplement"];
                incidentsPage.SearchIncident(caseNumberOld);
                Thread.Sleep(3000);
                incidentsPage.OpenIncident();
                reportPage.GoToReportPage();
                reportPage.SendToDfps();
            }
        }


        [Test, Order(6)]
        public void MasterPeopleSyncTest()
        {
            // Read data
            var loginDataList = LoginDataReader.ReadLoginData();
            var incidentDataList = IncidentDataReader.ReadIncidentData("Main");
            var incidentCountDataList = IncidentDataReader.ReadIncidentCount();
            var victimDataList = PeopleDataReader.ReadVictimData();

            int loginDataCount = loginDataList.Count();

            //test
            for (int i = 0; i < loginDataCount; i++)
            {
                var loginData = loginDataList[i];
                var incidentData = incidentDataList[i];
                var incidentCountData = incidentCountDataList[i];
                var victimData = victimDataList[i];

                Reporting.CreateTest("MasterPeopleSyncTest");

                LoginPage loginPage = new LoginPage(_driver);
                IncidentsPage incidentsPage = new IncidentsPage(_driver);
                PeoplePage peoplePage = new PeoplePage(_driver);

                string pageTitle = _driver.Title;

                if (pageTitle != null && !pageTitle.Contains("SAFV_Site"))
                {
                    loginPage.GoToLoginPage();
                    loginPage.Login(loginData["Username"], loginData["Password"]);
                }

                incidentsPage.GoToIncidentCreatePage();

                string caseCountOld = incidentCountData["CaseCount"];
                string caseNumberOld = incidentCountData["CaseNumber"];
                string supplementCountOld = incidentCountData["SupplementCount"];
                string supplementNumberOld = incidentCountData["SupplementNumber"];
                string mainCaseForSupplement = incidentCountData["MainCaseForSupplement"];

                int caseCountInt = Int32.Parse(caseCountOld) + 1;
                string caseCountNew = caseCountInt.ToString();

                string caseNumberNew = incidentsPage.CreateNewIncident(incidentData, caseCountNew, mainCaseForSupplement);

                WriteToExcel.WriteLog(caseCountNew, caseNumberNew, supplementCountOld, supplementNumberOld, mainCaseForSupplement);
                peoplePage.GoToPeoplePage();
                peoplePage.CreatePeople(victimData);
                if (peoplePage.VerifyMasterDataSync(victimData))
                {
                    Reporting.SetTestStatusPass();
                }
                else
                {
                    Reporting.SetTestStatusFail();
                }
                _driver.Close();
                _driver.SwitchTo().Window(_driver.WindowHandles[0]);
            }
        }


        [Test, Order(7)]
        public void MasterPeopleUpdateAndLogTest()
        {
            // Read data
            var loginDataList = LoginDataReader.ReadLoginData();
            var incidentDataList = IncidentDataReader.ReadIncidentData("Main");
            var incidentCountDataList = IncidentDataReader.ReadIncidentCount();
            var victimDataList = PeopleDataReader.ReadVictimData();

            int loginDataCount = loginDataList.Count();

            //test
            for (int i = 0; i < loginDataCount; i++)
            {
                var loginData = loginDataList[i];
                var incidentData = incidentDataList[i];
                var incidentCountData = incidentCountDataList[i];
                var victimData = victimDataList[i];

                Reporting.CreateTest("MasterPeopleUpdateAndLogTest");

                LoginPage loginPage = new LoginPage(_driver);
                IncidentsPage incidentsPage = new IncidentsPage(_driver);
                PeoplePage peoplePage = new PeoplePage(_driver);

                string pageTitle = _driver.Title;

                if (pageTitle != null && !pageTitle.Contains("SAFV_Site"))
                {
                    loginPage.GoToLoginPage();
                    loginPage.Login(loginData["Username"], loginData["Password"]);
                }

                incidentsPage.GoToIncidentCreatePage();

                string caseCountOld = incidentCountData["CaseCount"];
                string caseNumberOld = incidentCountData["CaseNumber"];
                string supplementCountOld = incidentCountData["SupplementCount"];
                string supplementNumberOld = incidentCountData["SupplementNumber"];
                string mainCaseForSupplement = incidentCountData["MainCaseForSupplement"];

                int caseCountInt = Int32.Parse(caseCountOld) + 1;
                string caseCountNew = caseCountInt.ToString();

                string caseNumberNew = incidentsPage.CreateNewIncident(incidentData, caseCountNew, mainCaseForSupplement);

                WriteToExcel.WriteLog(caseCountNew, caseNumberNew, supplementCountOld, supplementNumberOld, mainCaseForSupplement);
                peoplePage.GoToPeoplePage();
                peoplePage.CreatePeople(victimData);
                if (peoplePage.VerifyMasterDataSync(victimData))
                {
                    _driver.Close();
                    _driver.SwitchTo().Window(_driver.WindowHandles[0]);
                    peoplePage.UpdatePeople("Updated last name");

                    if (peoplePage.VerifyMasterDataLog(victimData["LastName"], "Updated last name"))
                    {
                        Reporting.SetTestStatusPass();
                    }
                    else
                    {
                        Reporting.SetTestStatusFail();
                    }
                }
                else
                {
                    Reporting.SetTestStatusFail();
                }
            }
        }
    }
}
