using SAFV.Drivers;
using SAFV.Helper;
using SAFV.Helper.Log;
using SAFV.Source.Pages;
using SAFV.Source.Pages.CreateIncident;

namespace SAFV.Test
{
    internal class SupplementsTest : Driver
    {
        [Test, Order(8)]
        public void CreateSupplementTest()
        {
            // Read data
            var loginDataList = LoginDataReader.ReadLoginData();
            var incidentDataList = IncidentDataReader.ReadIncidentData("Supplement");
            var incidentCountDataList = IncidentDataReader.ReadIncidentCount();

            int loginDataCount = loginDataList.Count();

            //test
            for (int i = 0; i < loginDataCount; i++)
            {
                var loginData = loginDataList[i];
                var incidentData = incidentDataList[i];
                var incidentCountData = incidentCountDataList[i];

                Reporting.CreateTest("CreateSupplementTest");

                LoginPage loginPage = new LoginPage(_driver);
                IncidentsPage incidentsPage = new IncidentsPage(_driver);

                loginPage.GoToLoginPage();

                loginPage.Login(loginData["Username"], loginData["Password"]);
                incidentsPage.GoToIncidentCreatePage();

                string caseCountOld = incidentCountData["CaseCount"];
                string caseNumberOld = incidentCountData["CaseNumber"];
                string supplementCountOld = incidentCountData["SupplementCount"];
                string supplementNumberOld = incidentCountData["SupplementNumber"];
                string mainCaseForSupplement = incidentCountData["MainCaseForSupplement"];

                int supplementCountInt = Int32.Parse(incidentCountData["SupplementCount"]) + 1;
                string supplementCountNew = supplementCountInt.ToString();

                string supplementNumberNew = incidentsPage.CreateNewIncident(incidentData, supplementCountNew, mainCaseForSupplement);

                WriteToExcel.WriteLog(caseCountOld, caseNumberOld, supplementCountNew, supplementNumberNew, mainCaseForSupplement);
            }
        }


        [Test, Order(9)]
        public void InheritPeopleFromMainTest()
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

                Reporting.CreateTest("InheritPeopleFromMainTest");

                LoginPage loginPage = new LoginPage(_driver);
                IncidentsPage incidentsPage = new IncidentsPage(_driver);
                PeoplePage peoplePage = new PeoplePage(_driver);

                loginPage.GoToLoginPage();

                loginPage.Login(loginData["Username"], loginData["Password"]);

                string caseCountOld = incidentCountData["CaseCount"];
                string caseNumberOld = incidentCountData["CaseNumber"];
                string supplementCountOld = incidentCountData["SupplementCount"];
                string supplementNumberOld = incidentCountData["SupplementNumber"];
                string mainCaseForSupplement = incidentCountData["MainCaseForSupplement"];

                incidentsPage.GoToIncidentPage();
                incidentsPage.SearchIncident(supplementNumberOld);
                Thread.Sleep(2000);
                incidentsPage.OpenIncident();
                peoplePage.GoToPeoplePage();
                peoplePage.AttachPeopleFromMainCase();
            }
        }


        [Test, Order(10)]
        public void CreatePeopleForSupplementTest()
        {
            // Read data
            var loginDataList = LoginDataReader.ReadLoginData();
            var incidentCountDataList = IncidentDataReader.ReadIncidentCount();
            var witnessDataList = PeopleDataReader.ReadWitnessData();
            var suspectDataList = PeopleDataReader.ReadSuspectData();
            var victimDataList = PeopleDataReader.ReadVictimData();

            int loginDataCount = loginDataList.Count();

            //test
            for (int i = 0; i < loginDataCount; i++)
            {
                var loginData = loginDataList[i];
                var incidentCountData = incidentCountDataList[i];
                var witnessData = witnessDataList[i];
                var suspectData = suspectDataList[i];
                var victimData = victimDataList[i];

                Reporting.CreateTest("CreatePeopleForSupplementTest");

                LoginPage loginPage = new LoginPage(_driver);
                IncidentsPage incidentsPage = new IncidentsPage(_driver);
                PeoplePage peoplePage = new PeoplePage(_driver);

                loginPage.GoToLoginPage();

                loginPage.Login(loginData["Username"], loginData["Password"]);

                string caseCountOld = incidentCountData["CaseCount"];
                string caseNumberOld = incidentCountData["CaseNumber"];
                string supplementCountOld = incidentCountData["SupplementCount"];
                string supplementNumberOld = incidentCountData["SupplementNumber"];
                string mainCaseForSupplement = incidentCountData["MainCaseForSupplement"];

                incidentsPage.GoToIncidentPage();
                incidentsPage.SearchIncident(supplementNumberOld);
                Thread.Sleep(2000);
                incidentsPage.OpenIncident();
                peoplePage.GoToPeoplePage();
                peoplePage.CreatePeople(witnessData);
                peoplePage.GoToPeoplePage();
                peoplePage.CreatePeople(suspectData);
                peoplePage.GoToPeoplePage();
                peoplePage.CreatePeople(victimData);
            }
        }


        [Test, Order(11)]
        public void InheritLocationFromMainTest()
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

                Reporting.CreateTest("InheritLocationFromMainTest");

                LoginPage loginPage = new LoginPage(_driver);
                IncidentsPage incidentsPage = new IncidentsPage(_driver);
                LocationPage locationPage = new LocationPage(_driver);

                loginPage.GoToLoginPage();

                loginPage.Login(loginData["Username"], loginData["Password"]);

                string caseCountOld = incidentCountData["CaseCount"];
                string caseNumberOld = incidentCountData["CaseNumber"];
                string supplementCountOld = incidentCountData["SupplementCount"];
                string supplementNumberOld = incidentCountData["SupplementNumber"];
                string mainCaseForSupplement = incidentCountData["MainCaseForSupplement"];

                incidentsPage.GoToIncidentPage();
                incidentsPage.SearchIncident(supplementNumberOld);
                Thread.Sleep(2000);
                incidentsPage.OpenIncident();
                locationPage.GoToLocationPage();
                locationPage.AttachLocationFromMainCase();
            }
        }


        [Test, Order(12)]
        public void CreateLocationForSupplementTest()
        {
            // Read data
            var loginDataList = LoginDataReader.ReadLoginData();
            var incidentCountDataList = IncidentDataReader.ReadIncidentCount();
            var locationDataList = LocationDataReader.ReadLocationData();

            int loginDataCount = loginDataList.Count();

            //test
            for (int i = 0; i < loginDataCount; i++)
            {
                var loginData = loginDataList[i];
                var incidentCountData = incidentCountDataList[i];
                var locationData = locationDataList[i];

                Reporting.CreateTest("CreateLocationForSupplementTest");

                LoginPage loginPage = new LoginPage(_driver);
                IncidentsPage incidentsPage = new IncidentsPage(_driver);
                LocationPage locationPage = new LocationPage(_driver);

                loginPage.GoToLoginPage();

                loginPage.Login(loginData["Username"], loginData["Password"]);

                string caseCountOld = incidentCountData["CaseCount"];
                string caseNumberOld = incidentCountData["CaseNumber"];
                string supplementCountOld = incidentCountData["SupplementCount"];
                string supplementNumberOld = incidentCountData["SupplementNumber"];
                string mainCaseForSupplement = incidentCountData["MainCaseForSupplement"];

                incidentsPage.GoToIncidentPage();
                incidentsPage.SearchIncident(supplementNumberOld);
                Thread.Sleep(2000);
                incidentsPage.OpenIncident();
                locationPage.GoToLocationPage();
                locationPage.CreateLocation(locationData);
            }
        }


        [Test, Order(13)]
        public void CreateOffenseForSupplementTest()
        {
            // Read data
            var loginDataList = LoginDataReader.ReadLoginData();
            var incidentCountDataList = IncidentDataReader.ReadIncidentCount();
            var locationDataList = LocationDataReader.ReadLocationData();
            var offenseDataList = OffenseDataReader.ReadOffenseData();
            var offenseSceneDataList = OffenseDataReader.ReadSceneData();
            var biasDataList = OffenseDataReader.ReadBiasData();
            var mannerDataList = OffenseDataReader.ReadMannerData();
            var offenseRiskAssessmentDataList = OffenseDataReader.ReadOffenseRiskAssessmentData();
            var useOfWeaponDataList = OffenseDataReader.ReadUseOfWeaponData();
            var aggAssaultDataList = OffenseDataReader.ReadAggAssaultData();

            int loginDataCount = loginDataList.Count();

            //test
            for (int i = 0; i < loginDataCount; i++)
            {
                var loginData = loginDataList[i];
                var incidentCountData = incidentCountDataList[i];
                var offenseData = offenseDataList[i];
                var offenseSceneData = offenseSceneDataList[i];
                var biasData = biasDataList[i];
                var mannerData = mannerDataList[i];
                var offenseRiskAssessmentData = offenseRiskAssessmentDataList[i];
                var useOfWeaponData = useOfWeaponDataList[i];
                var aggAssaultData = aggAssaultDataList[i];

                Reporting.CreateTest("CreateOffenseForSupplementTest");

                LoginPage loginPage = new LoginPage(_driver);
                IncidentsPage incidentsPage = new IncidentsPage(_driver);
                OffensePage offensePage = new OffensePage(_driver);

                loginPage.GoToLoginPage();

                loginPage.Login(loginData["Username"], loginData["Password"]);

                string caseCountOld = incidentCountData["CaseCount"];
                string caseNumberOld = incidentCountData["CaseNumber"];
                string supplementCountOld = incidentCountData["SupplementCount"];
                string supplementNumberOld = incidentCountData["SupplementNumber"];
                string mainCaseForSupplement = incidentCountData["MainCaseForSupplement"];

                incidentsPage.GoToIncidentPage();
                incidentsPage.SearchIncident(supplementNumberOld);
                Thread.Sleep(2000);
                incidentsPage.OpenIncident();
                offensePage.GoToOffensePage();
                offensePage.CreateOffense(offenseData);
                offensePage.CreateOffenceScene(offenseSceneData);
                offensePage.CreateBias(biasData);
                offensePage.CreateManner(mannerData);
                offensePage.CreateRiskAssessment(offenseRiskAssessmentData);
                offensePage.CreateUseOfWeapon(useOfWeaponData);
                offensePage.CreateAggAssault(aggAssaultData);
                offensePage.CreatePcNarrative();
            }
        }


        [Test, Order(14)]
        public void CreateRiskAssessmentForSupplementTest()
        {
            // Read data
            var loginDataList = LoginDataReader.ReadLoginData();
            var incidentCountDataList = IncidentDataReader.ReadIncidentCount();
            var riskAssessmentDataList = RiskAssessmentDataReader.ReadRiskAssessmentData();

            int loginDataCount = loginDataList.Count();

            //test
            for (int i = 0; i < loginDataCount; i++)
            {
                var loginData = loginDataList[i];
                var incidentCountData = incidentCountDataList[i];
                var riskAssessmentData = riskAssessmentDataList[i];

                Reporting.CreateTest("CreateRiskAssessmentForSupplementTest");

                LoginPage loginPage = new LoginPage(_driver);
                IncidentsPage incidentsPage = new IncidentsPage(_driver);
                RiskAssessmentPage riskAssessmentPage = new RiskAssessmentPage(_driver);

                loginPage.GoToLoginPage();

                loginPage.Login(loginData["Username"], loginData["Password"]);

                string caseCountOld = incidentCountData["CaseCount"];
                string caseNumberOld = incidentCountData["CaseNumber"];
                string supplementCountOld = incidentCountData["SupplementCount"];
                string supplementNumberOld = incidentCountData["SupplementNumber"];
                string mainCaseForSupplement = incidentCountData["MainCaseForSupplement"];

                incidentsPage.GoToIncidentPage();
                incidentsPage.SearchIncident(supplementNumberOld);
                Thread.Sleep(2000);
                incidentsPage.OpenIncident();
                riskAssessmentPage.GoToRiskAssessmentPage();
                riskAssessmentPage.CreateRiskAssessment(riskAssessmentData);
            }
        }


        [Test, Order(15)]
        public void CreateEpoForSupplementTest()
        {
            // Read data
            var loginDataList = LoginDataReader.ReadLoginData();
            var incidentCountDataList = IncidentDataReader.ReadIncidentCount();
            var epoDataList = EpoDataReader.ReadEpoData();

            int loginDataCount = loginDataList.Count();

            //test
            for (int i = 0; i < loginDataCount; i++)
            {
                var loginData = loginDataList[i];
                var incidentCountData = incidentCountDataList[i];
                var epoData = epoDataList[i];

                Reporting.CreateTest("CreateEpoForSupplementTest");

                LoginPage loginPage = new LoginPage(_driver);
                IncidentsPage incidentsPage = new IncidentsPage(_driver);
                EpoBookingPage epoBookingPage = new EpoBookingPage(_driver);

                loginPage.GoToLoginPage();

                loginPage.Login(loginData["Username"], loginData["Password"]);

                string caseCountOld = incidentCountData["CaseCount"];
                string caseNumberOld = incidentCountData["CaseNumber"];
                string supplementCountOld = incidentCountData["SupplementCount"];
                string supplementNumberOld = incidentCountData["SupplementNumber"];
                string mainCaseForSupplement = incidentCountData["MainCaseForSupplement"];

                incidentsPage.GoToIncidentPage();
                incidentsPage.SearchIncident(supplementNumberOld);
                Thread.Sleep(2000);
                incidentsPage.OpenIncident();
                epoBookingPage.GoToEpoBookingPage();
                epoBookingPage.CreateEpoRequest(epoData);
            }
        }


        [Test, Order(16)]
        public void CreateEvidenceForSupplementTest()
        {
            // Read data
            var loginDataList = LoginDataReader.ReadLoginData();
            var incidentCountDataList = IncidentDataReader.ReadIncidentCount();
            var evidenceDataList = EvidenceDataReader.ReadEvidenceData();

            int loginDataCount = loginDataList.Count();

            //test
            for (int i = 0; i < loginDataCount; i++)
            {
                var loginData = loginDataList[i];
                var incidentCountData = incidentCountDataList[i];
                var evidenceData = evidenceDataList[i];

                Reporting.CreateTest("CreateEvidenceForSupplementTest");

                LoginPage loginPage = new LoginPage(_driver);
                IncidentsPage incidentsPage = new IncidentsPage(_driver);
                EvidencePage evidencePage = new EvidencePage(_driver);

                loginPage.GoToLoginPage();

                loginPage.Login(loginData["Username"], loginData["Password"]);

                string caseCountOld = incidentCountData["CaseCount"];
                string caseNumberOld = incidentCountData["CaseNumber"];
                string supplementCountOld = incidentCountData["SupplementCount"];
                string supplementNumberOld = incidentCountData["SupplementNumber"];
                string mainCaseForSupplement = incidentCountData["MainCaseForSupplement"];

                incidentsPage.GoToIncidentPage();
                incidentsPage.SearchIncident(supplementNumberOld);
                Thread.Sleep(2000);
                incidentsPage.OpenIncident();
                evidencePage.GoToEvidencePage();
                evidencePage.CreateEvidence(evidenceData);
            }
        }


        [Test, Order(17)]
        public void CreateReportForSupplementTest()
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

                Reporting.CreateTest("CreateReportForSupplementTest");

                LoginPage loginPage = new LoginPage(_driver);
                IncidentsPage incidentsPage = new IncidentsPage(_driver);
                ReportPage reportPage = new ReportPage(_driver);

                loginPage.GoToLoginPage();

                loginPage.Login(loginData["Username"], loginData["Password"]);

                string caseCountOld = incidentCountData["CaseCount"];
                string caseNumberOld = incidentCountData["CaseNumber"];
                string supplementCountOld = incidentCountData["SupplementCount"];
                string supplementNumberOld = incidentCountData["SupplementNumber"];
                string mainCaseForSupplement = incidentCountData["MainCaseForSupplement"];

                incidentsPage.GoToIncidentPage();
                incidentsPage.SearchIncident(supplementNumberOld);
                Thread.Sleep(2000);
                incidentsPage.OpenIncident();
                reportPage.GoToReportPage();
                reportPage.CreateReport();
                reportPage.GoToReportPage();
                reportPage.SendToDfps();
            }
        }


        [Test, Order(18)]
        public void CreateDigitalEvidenceForSupplementTest()
        {
            // Read data
            var loginDataList = LoginDataReader.ReadLoginData();
            var incidentCountDataList = IncidentDataReader.ReadIncidentCount();
            var digitalEvidenceDataList = DigitalEvidenceDataReader.ReadDigitalEvidenceData();

            int loginDataCount = loginDataList.Count();

            //test
            for (int i = 0; i < loginDataCount; i++)
            {
                var loginData = loginDataList[i];
                var incidentCountData = incidentCountDataList[i];
                var digitalEvidenceData = digitalEvidenceDataList[i];

                Reporting.CreateTest("CreateDigitalEvidenceForSupplementTest");

                LoginPage loginPage = new LoginPage(_driver);
                IncidentsPage incidentsPage = new IncidentsPage(_driver);
                DigitalEvidencePage digitalEvidencePage = new DigitalEvidencePage(_driver);

                loginPage.GoToLoginPage();

                loginPage.Login(loginData["Username"], loginData["Password"]);

                string caseCountOld = incidentCountData["CaseCount"];
                string caseNumberOld = incidentCountData["CaseNumber"];
                string supplementCountOld = incidentCountData["SupplementCount"];
                string supplementNumberOld = incidentCountData["SupplementNumber"];
                string mainCaseForSupplement = incidentCountData["MainCaseForSupplement"];

                incidentsPage.GoToIncidentPage();
                incidentsPage.SearchIncident(supplementNumberOld);
                Thread.Sleep(2000);
                incidentsPage.OpenIncident();
                digitalEvidencePage.GoToDigitalEvidencePage();
                digitalEvidencePage.CreateDigitalEvidence(digitalEvidenceData);
            }
        }


        [Test, Order(19)]
        public void IncidentReviewForSupplementTest()
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

                Reporting.CreateTest("IncidentReviewForSupplementTest");

                LoginPage loginPage = new LoginPage(_driver);
                IncidentsPage incidentsPage = new IncidentsPage(_driver);
                IncidentReviewPage incidentReviewPage = new IncidentReviewPage(_driver);

                loginPage.GoToLoginPage();

                loginPage.Login(loginData["Username"], loginData["Password"]);

                string caseCountOld = incidentCountData["CaseCount"];
                string caseNumberOld = incidentCountData["CaseNumber"];
                string supplementCountOld = incidentCountData["SupplementCount"];
                string supplementNumberOld = incidentCountData["SupplementNumber"];
                string mainCaseForSupplement = incidentCountData["MainCaseForSupplement"];

                incidentsPage.GoToIncidentPage();
                incidentsPage.SearchIncident(supplementNumberOld);
                Thread.Sleep(2000);
                incidentsPage.OpenIncident();
                incidentReviewPage.GoToIncidentReviewPage();
                incidentReviewPage.AddComment();
            }
        }


        [Test, Order(20)]
        public void StatusHistoryForSupplementTest()
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

                string status;

                Reporting.CreateTest("StatusHistoryForSupplementTest");

                HomePage homePage = new HomePage(_driver);
                LoginPage loginPage = new LoginPage(_driver);
                IncidentsPage incidentsPage = new IncidentsPage(_driver);
                StatusHistoryPage statusHistoryPage = new StatusHistoryPage(_driver);

                loginPage.GoToLoginPage();

                loginPage.Login(loginData["Username"], loginData["Password"]);

                string caseCountOld = incidentCountData["CaseCount"];
                string caseNumberOld = incidentCountData["CaseNumber"];
                string supplementCountOld = incidentCountData["SupplementCount"];
                string supplementNumberOld = incidentCountData["SupplementNumber"];
                string mainCaseForSupplement = incidentCountData["MainCaseForSupplement"];

                incidentsPage.GoToIncidentPage();
                incidentsPage.SearchIncident(supplementNumberOld);
                Thread.Sleep(2000);
                incidentsPage.OpenIncident();
                statusHistoryPage.GoToStatusHistoryPage();
                status = statusHistoryPage.CheckStatus();

                if (status == "open")
                {
                    Reporting.SetStepStatusPass("Status is correct.", _driver);
                }
                else
                {
                    Reporting.SetStepStatusFail("Status is wrong!!!", _driver);
                }

                statusHistoryPage.SendForReview();
                homePage.Logout();

                loginPage.Login(loginData["Username2"], loginData["Password2"]);
                incidentsPage.GoToIncidentPage();
                incidentsPage.SearchIncident(supplementNumberOld);
                statusHistoryPage.GoToStatusHistoryPage();

                if (status == "in-review")
                {
                    Reporting.SetStepStatusPass("Status is correct.", _driver);
                }
                else
                {
                    Reporting.SetStepStatusFail("Status is wrong!!!", _driver);
                }

                statusHistoryPage.RejectCase();
                homePage.Logout();

                loginPage.Login(loginData["Username"], loginData["Password"]);
                incidentsPage.GoToIncidentPage();
                incidentsPage.SearchIncident(supplementNumberOld);
                Thread.Sleep(2000);
                incidentsPage.OpenIncident();
                statusHistoryPage.GoToStatusHistoryPage();
                status = statusHistoryPage.CheckStatus();

                if (status == "rejected")
                {
                    Reporting.SetStepStatusPass("Status is correct.", _driver);
                }
                else
                {
                    Reporting.SetStepStatusFail("Status is wrong!!!", _driver);
                }

                statusHistoryPage.SendForReview();
                homePage.Logout();

                loginPage.Login(loginData["Username2"], loginData["Password2"]);
                incidentsPage.GoToIncidentPage();
                incidentsPage.SearchIncident(supplementNumberOld);
                Thread.Sleep(2000);
                incidentsPage.OpenIncident();
                statusHistoryPage.GoToStatusHistoryPage();
                status = statusHistoryPage.CheckStatus();

                if (status == "in-review")
                {
                    Reporting.SetStepStatusPass("Status is correct.", _driver);
                }
                else
                {
                    Reporting.SetStepStatusFail("Status is wrong!!!", _driver);
                }

                statusHistoryPage.LockCase();
                status = statusHistoryPage.CheckStatus();

                if (status == "locked")
                {
                    Reporting.SetStepStatusPass("Status is correct.", _driver);
                }
                else
                {
                    Reporting.SetStepStatusFail("Status is wrong!!!", _driver);
                }

                statusHistoryPage.UnLockCase();
                homePage.Logout();

                loginPage.Login(loginData["Username"], loginData["Password"]);
                incidentsPage.GoToIncidentPage();
                incidentsPage.SearchIncident(supplementNumberOld);
                Thread.Sleep(2000);
                incidentsPage.OpenIncident();
                statusHistoryPage.GoToStatusHistoryPage();
                status = statusHistoryPage.CheckStatus();

                if (status == "open")
                {
                    Reporting.SetStepStatusPass("Status is correct.", _driver);
                }
                else
                {
                    Reporting.SetStepStatusFail("Status is wrong!!!", _driver);
                }
            }
        }
    }
}
