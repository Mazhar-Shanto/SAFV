using SAFV.Drivers;
using SAFV.Helper;
using SAFV.Helper.Detective;
using SAFV.Helper.Log;
using SAFV.Source.Pages;
using SAFV.Source.Pages.Detective.CreateCase;
using SAFV.Source.Pages.Detective;

namespace SAFV.Test
{
    [TestFixture, Order(7)]
    internal class DetectiveModeLinkedIncidentTest : Driver
    {
        [Test, Order(36)]
        public void CreateCaseFromIncidentTest()
        {
            // Read data
            var loginDataList = LoginDataReader.ReadLoginData();
            var caseDataList = CaseDataReader.ReadLinkedCaseData("Main");
            var caseCountDataList = CaseDataReader.ReadCaseCount();

            int loginDataCount = loginDataList.Count();

            //test
            for (int i = 0; i < loginDataCount; i++)
            {
                var loginData = loginDataList[i];
                var caseData = caseDataList[i];
                var caseCountData = caseCountDataList[i];

                Reporting.CreateTest("CreateCaseFromIncidentTest");

                HomePage homePage = new HomePage(_driver);
                LoginPage loginPage = new LoginPage(_driver);
                CasesPage casesPage = new CasesPage(_driver);

                string pageTitle = _driver.Title;

                if (pageTitle != null && !pageTitle.Contains("SAFV_Site"))
                {
                    loginPage.GoToLoginPage();
                    loginPage.Login(loginData["Username"], loginData["Password"]);
                }

                casesPage.GoToCaseCreateFromIncidentPage();

                string caseCountOld = caseCountData["CaseCount"];
                string caseNumberOld = caseCountData["CaseNumber"];
                string supplementCountOld = caseCountData["SupplementCount"];
                string supplementNumberOld = caseCountData["SupplementNumber"];
                string mainCaseForSupplement = caseCountData["MainCaseForSupplement"];

                int caseCountInt = Int32.Parse(caseCountOld) + 1;
                string caseCountNew = caseCountInt.ToString();

                string caseNumberNew = casesPage.CreateCaseFromIncidents(caseData, caseCountNew, mainCaseForSupplement);

                WriteToExcel.WriteDetectiveCaseLog(caseCountNew, caseNumberNew, supplementCountOld, supplementNumberOld, caseNumberNew);

                if (homePage.CheckMenuItems(caseNumberNew))
                {
                    Reporting.SetTestStatusPass();
                }
                else
                {
                    Reporting.SetTestStatusFail($"Case create from incidents failed.");
                }
            }
        }


        [Test, Order(37)]
        public void AllDataImportedTest()
        {
            // Read data
            var loginDataList = LoginDataReader.ReadLoginData();
            var caseCountDataList = CaseDataReader.ReadCaseCount();

            int loginDataCount = loginDataList.Count();

            //test
            for (int i = 0; i < loginDataCount; i++)
            {
                var loginData = loginDataList[i];
                var caseCountData = caseCountDataList[i];

                Reporting.CreateTest("AllDataImportedTest");

                HomePage homePage = new HomePage(_driver);
                LoginPage loginPage = new LoginPage(_driver);
                CasesPage casesPage = new CasesPage(_driver);
                LinkedIncidentPage linkedIncidentPage = new LinkedIncidentPage(_driver);

                string pageTitle = _driver.Title;

                if (pageTitle != null && !pageTitle.Contains("caseNumber"))
                {
                    loginPage.GoToLoginPage();
                    loginPage.Login(loginData["Username"], loginData["Password"]);
                }

                string caseCountOld = caseCountData["CaseCount"];
                string caseNumberOld = caseCountData["CaseNumber"];
                string supplementCountOld = caseCountData["SupplementCount"];
                string supplementNumberOld = caseCountData["SupplementNumber"];
                string mainCaseForSupplement = caseCountData["MainCaseForSupplement"];

                if (!homePage.CheckMenuItems(caseNumberOld))
                {
                    casesPage.GoToCasePage();
                    casesPage.SearchCase(caseNumberOld);
                    Thread.Sleep(3000);
                    casesPage.OpenCase();
                }

                int peopleCount = linkedIncidentPage.VerifyPeopleCount();
                if (peopleCount == 15)
                {
                    Reporting.SetStepStatusPass("All people Imported", _driver);
                }
                else
                {
                    Reporting.SetStepStatusFail($"All people not Imported !!! Expected: 15;   Found: {peopleCount}", _driver);
                }

                int locationCount = linkedIncidentPage.VerifyLocationCount();
                if (locationCount == 13)
                {
                    Reporting.SetStepStatusPass("All location Imported", _driver);
                }
                else
                {
                    Reporting.SetStepStatusFail($"All location not Imported !!! Expected: 13;   Found: {locationCount}", _driver);
                }

                int offenseCount = linkedIncidentPage.VerifyOffenseCount();
                if (offenseCount == 11)
                {
                    Reporting.SetStepStatusPass("All offense Imported", _driver);
                }
                else
                {
                    Reporting.SetStepStatusFail($"All offense not Imported !!! Expected: 11;   Found: {offenseCount}", _driver);
                }

                int riskAssessmentCount = linkedIncidentPage.VerifyRiskAssessmentCount();
                if (riskAssessmentCount == 8)
                {
                    Reporting.SetStepStatusPass("All risk assessment Imported", _driver);
                }
                else
                {
                    Reporting.SetStepStatusFail($"All risk assessment not Imported !!! Expected: 8;   Found: {riskAssessmentCount}", _driver);
                }

                int vehicleCount = linkedIncidentPage.VerifyVehicleCount();
                if(vehicleCount == 3)
                {
                    Reporting.SetStepStatusPass("All vehicle Imported", _driver);
                }
                else
                {
                    Reporting.SetStepStatusFail($"All vehicle not Imported !!! Expected: 3;   Found: {vehicleCount}", _driver);
                }

                int epoCount = linkedIncidentPage.VerifyEpoCount();
                if(epoCount == 0)
                {
                    Reporting.SetStepStatusPass("No EPO Imported", _driver);
                }
                else
                {
                    Reporting.SetStepStatusFail($"EPO Imported !!! Expected: 0;   Found: {epoCount}", _driver);
                }

                int evidenceCount = linkedIncidentPage.VerifyEvidenceCount();
                if(evidenceCount == 5)
                {
                    Reporting.SetStepStatusPass("All evidence Imported", _driver);
                }
                else
                {
                    Reporting.SetStepStatusFail($"All evidence not Imported !!! Expected: 5;   Found: {evidenceCount}", _driver);
                }
            }
        }


        [Test, Order(38)]
        public void AllDataReferenceTest()
        {
            // Read data
            var loginDataList = LoginDataReader.ReadLoginData();
            var caseCountDataList = CaseDataReader.ReadCaseCount();

            int loginDataCount = loginDataList.Count();

            //test
            for (int i = 0; i < loginDataCount; i++)
            {
                var loginData = loginDataList[i];
                var caseCountData = caseCountDataList[i];

                Reporting.CreateTest("AllDataReferenceTest");

                HomePage homePage = new HomePage(_driver);
                LoginPage loginPage = new LoginPage(_driver);
                CasesPage casesPage = new CasesPage(_driver);
                LinkedIncidentPage linkedIncidentPage = new LinkedIncidentPage(_driver);
                PeoplePage peoplePage = new PeoplePage(_driver);
                LocationPage locationPage = new LocationPage(_driver);
                OffensePage offensePage = new OffensePage(_driver);
                RiskAssessmentPage riskAssessmentPage = new RiskAssessmentPage(_driver);
                VehiclePage vehiclePage = new VehiclePage(_driver);
                EvidencePage evidencePage = new EvidencePage(_driver);

                string pageTitle = _driver.Title;

                if (pageTitle != null && !pageTitle.Contains("caseNumber"))
                {
                    loginPage.GoToLoginPage();
                    loginPage.Login(loginData["Username"], loginData["Password"]);
                }

                string caseCountOld = caseCountData["CaseCount"];
                string caseNumberOld = caseCountData["CaseNumber"];
                string supplementCountOld = caseCountData["SupplementCount"];
                string supplementNumberOld = caseCountData["SupplementNumber"];
                string mainCaseForSupplement = caseCountData["MainCaseForSupplement"];

                if (!homePage.CheckMenuItems(caseNumberOld))
                {
                    casesPage.GoToCasePage();
                    casesPage.SearchCase(caseNumberOld);
                    Thread.Sleep(3000);
                    casesPage.OpenCase();
                }

                peoplePage.GoToPeoplePage();
                int peopleOriginCount = peoplePage.PeopleOriginCount();
                if (peopleOriginCount == 15)
                {
                    Reporting.SetStepStatusPass("All imported people has reference link", _driver);
                }
                else
                {
                    Reporting.SetStepStatusFail($"All imported people does not have reference link !!! Expected: 15;   Found: {peopleOriginCount}", _driver);
                }

                locationPage.GoToLocationPage();
                int locationOriginCount = locationPage.LocationOriginCount();
                if (locationOriginCount == 13)
                {
                    Reporting.SetStepStatusPass("All imported location has reference link", _driver);
                }
                else
                {
                    Reporting.SetStepStatusFail($"All imported location does not have reference link !!! Expected: 13;   Found: {locationOriginCount}", _driver);
                }

                offensePage.GoToOffensePage();
                int offenseOriginCount = offensePage.OffenseOriginCount();
                if (offenseOriginCount == 11)
                {
                    Reporting.SetStepStatusPass("All imported offense has reference link", _driver);
                }
                else
                {
                    Reporting.SetStepStatusFail($"All imported offense does not have reference link !!! Expected: 11;   Found: {offenseOriginCount}", _driver);
                }

                riskAssessmentPage.GoToRiskAssessmentPage();
                int risAssessmentOriginCount = riskAssessmentPage.RiskAssessmentOriginCount();
                if (risAssessmentOriginCount == 8)
                {
                    Reporting.SetStepStatusPass("All imported risk assessment has reference link", _driver);
                }
                else
                {
                    Reporting.SetStepStatusFail($"All imported risk assessment does not have reference link !!! Expected: 8;   Found: {risAssessmentOriginCount}", _driver);
                }

                vehiclePage.GoToVehiclePage();
                int vehiclesOriginCount = vehiclePage.VehicleOriginCount();
                if (vehiclesOriginCount == 3)
                {
                    Reporting.SetStepStatusPass("All imported vehicle has reference link", _driver);
                }
                else
                {
                    Reporting.SetStepStatusFail($"All imported vehicle does not have reference link !!! Expected: 3;   Found: {vehiclesOriginCount}", _driver);
                }

                evidencePage.GoToEvidencePage();
                int evidenceOriginCount = evidencePage.EvidenceOriginCount();
                if (evidenceOriginCount == 5)
                {
                    Reporting.SetStepStatusPass("All imported evidence has reference link", _driver);
                }
                else
                {
                    Reporting.SetStepStatusFail($"All imported evidence does not have reference link !!! Expected: 5;   Found: {evidenceOriginCount}", _driver);
                }
            }
        }


        [Test, Order(39)]
        public void PeopleDataEditTest()
        {
            // Read data
            var loginDataList = LoginDataReader.ReadLoginData();
            var caseCountDataList = CaseDataReader.ReadCaseCount();

            int loginDataCount = loginDataList.Count();

            //test
            for (int i = 0; i < loginDataCount; i++)
            {
                var loginData = loginDataList[i];
                var caseCountData = caseCountDataList[i];

                Reporting.CreateTest("AllDataReferenceTest");

                HomePage homePage = new HomePage(_driver);
                LoginPage loginPage = new LoginPage(_driver);
                CasesPage casesPage = new CasesPage(_driver);
                LinkedIncidentPage linkedIncidentPage = new LinkedIncidentPage(_driver);
                PeoplePage peoplePage = new PeoplePage(_driver);
                LocationPage locationPage = new LocationPage(_driver);
                OffensePage offensePage = new OffensePage(_driver);
                RiskAssessmentPage riskAssessmentPage = new RiskAssessmentPage(_driver);
                VehiclePage vehiclePage = new VehiclePage(_driver);
                EvidencePage evidencePage = new EvidencePage(_driver);

                string pageTitle = _driver.Title;

                if (pageTitle != null && !pageTitle.Contains("caseNumber"))
                {
                    loginPage.GoToLoginPage();
                    loginPage.Login(loginData["Username"], loginData["Password"]);
                }

                string caseCountOld = caseCountData["CaseCount"];
                string caseNumberOld = caseCountData["CaseNumber"];
                string supplementCountOld = caseCountData["SupplementCount"];
                string supplementNumberOld = caseCountData["SupplementNumber"];
                string mainCaseForSupplement = caseCountData["MainCaseForSupplement"];

                if (!homePage.CheckMenuItems(caseNumberOld))
                {
                    casesPage.GoToCasePage();
                    casesPage.SearchCase(caseNumberOld);
                    Thread.Sleep(3000);
                    casesPage.OpenCase();
                }

                peoplePage.GoToPeoplePage();
                
            }
        }
    }
}
