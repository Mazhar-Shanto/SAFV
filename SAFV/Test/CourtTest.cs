using SAFV.Drivers;
using SAFV.Helper;
using SAFV.Helper.Log;
using SAFV.Source.Components.CourtEpo;
using SAFV.Source.Pages;
using SAFV.Source.Pages.CourtEpo;
using SAFV.Source.Pages.CreateIncident;

namespace SAFV.Test
{
    internal class CourtTest : Driver
    {
        [Test, Order(21)]
        public void CreateCourtEpoTest()
        {
            // Read data
            var loginDataList = LoginDataReader.ReadLoginData();
            var courtEpoDataList = CourtEpoDataReader.ReadCourtEpoData();
            var courtEpoLogDataList = CourtEpoDataReader.ReadCourtEpoLogData();
            var courtEpoSuspectDataList = EpoPersonDataReader.ReadCourtEpoSuspectData();
            var courtEpoVictimDataList = EpoPersonDataReader.ReadCourtEpoVictimData();
            var courtEpoOtherDataList = EpoPersonDataReader.ReadCourtEpoOtherData();
            var courtEpoConditionsDataList = CourtEpoDataReader.ReadCourtEpoConditionsData();

            int loginDataCount = loginDataList.Count();

            //test
            for (int i = 0; i < loginDataCount; i++)
            {
                var loginData = loginDataList[i];
                var courtEpoData = courtEpoDataList[i];
                var courtEpoLogData = courtEpoLogDataList[i];
                var courtEpoSuspectData = courtEpoSuspectDataList[i];
                var courtEpoVictimData = courtEpoVictimDataList[i];
                var courtEpoOtherData = courtEpoOtherDataList[i];
                var courtEpoConditionsData = courtEpoConditionsDataList[i];

                Reporting.CreateTest("CreateCourtEpoTest");

                LoginPage loginPage = new LoginPage(_driver);
                CourtEpoPage courtEpoPage = new CourtEpoPage(_driver);
                CourtEpoSuspectInfoPage courtEpoSuspectInfoPage = new CourtEpoSuspectInfoPage(_driver);
                CourtEpoVictimInfoPage epoVictimInfoPage = new CourtEpoVictimInfoPage(_driver);
                CourtEpoOtherInfoPage courtEpoOtherInfoPage = new CourtEpoOtherInfoPage(_driver);
                CourtEpoConditionsPage courtEpoConditionsPage = new CourtEpoConditionsPage(_driver);

                loginPage.GoToLoginPage();

                string pageTitle = _driver.Title;

                if (pageTitle != null && !pageTitle.Contains("SAFV_Site"))
                {
                    loginPage.Login(loginData["JudgeUsername"], loginData["JudgePassword"]);
                }

                courtEpoPage.GoToCourtEpoPage();

                string courtEpoCaseNumberOld = courtEpoLogData["EpoCaseNumber"];
                string courtEpoCaseCountOld = courtEpoLogData["EpoCaseCount"];

                int courtEpoCaseCountOldInt = Int32.Parse(courtEpoCaseCountOld) + 1;
                string courtEpoCaseCountNew = courtEpoCaseCountOldInt.ToString();

                string courtEpoCaseNumberNew = courtEpoPage.CreateCourtEpo(courtEpoData, courtEpoCaseCountNew);

                WriteToExcel.WriteCourtEpoLog(courtEpoCaseNumberNew, courtEpoCaseCountNew);

                courtEpoSuspectInfoPage.GoToCourtEpoSuspectInfoPage();
                courtEpoSuspectInfoPage.CreateEpoSuspectInfo(courtEpoSuspectData);
                epoVictimInfoPage.GoToCourtEpoVictimInfoPage();
                epoVictimInfoPage.CreateEpoVictimInfo(courtEpoVictimData);
                courtEpoOtherInfoPage.GoToCourtEpoOtherInfoPage();
                courtEpoOtherInfoPage.CreateEpoOtherInfo(courtEpoOtherData);
                courtEpoConditionsPage.GoToCourtEpoConditionsPage();
                courtEpoConditionsPage.CreateEpoConditions(courtEpoConditionsData);
            }
        }


        [Test, Order(22)]
        public void CourtEpoAssignTest()
        {
            // Read data
            var loginDataList = LoginDataReader.ReadLoginData();
            var courtEpoDataList = CourtEpoDataReader.ReadCourtEpoLogData();

            int loginDataCount = loginDataList.Count();

            //test
            for (int i = 0; i < loginDataCount; i++)
            {
                var loginData = loginDataList[i];
                var courtEpoData = courtEpoDataList[i];

                Reporting.CreateTest("CourtEpoAssignTest");

                LoginPage loginPage = new LoginPage(_driver);
                CourtEpoPage courtEpoPage = new CourtEpoPage(_driver);

                loginPage.GoToLoginPage();

                string pageTitle = _driver.Title;

                if (pageTitle != null && !pageTitle.Contains("SAFV_Site"))
                {
                    loginPage.Login(loginData["JudgeUsername"], loginData["JudgePassword"]);
                }

                courtEpoPage.GoToCourtEpoPage();
                courtEpoPage.AssignCourtEpo(courtEpoData["EpoCaseNumber"]);
            }
        }


        [Test, Order(23)]
        public void CourtEpoManualCompleteTest()
        {
            // Read data
            var loginDataList = LoginDataReader.ReadLoginData();
            var courtEpoDataList = CourtEpoDataReader.ReadCourtEpoLogData();

            int loginDataCount = loginDataList.Count();

            //test
            for (int i = 0; i < loginDataCount; i++)
            {
                var loginData = loginDataList[i];
                var courtEpoData = courtEpoDataList[i];

                Reporting.CreateTest("CourtEpoManualCompleteTest");

                LoginPage loginPage = new LoginPage(_driver);
                CourtEpoPage courtEpoPage = new CourtEpoPage(_driver);

                loginPage.GoToLoginPage();

                string pageTitle = _driver.Title;

                if (pageTitle != null && !pageTitle.Contains("SAFV_Site"))
                {
                    loginPage.Login(loginData["JudgeUsername"], loginData["JudgePassword"]);
                }

                courtEpoPage.GoToCourtEpoPage();
                courtEpoPage.CourtEpoCompleteManually(courtEpoData["EpoCaseNumber"]);
            }
        }


        [Test, Order(24)]
        public void CourtEpoCancelTest()
        {
            // Read data
            var loginDataList = LoginDataReader.ReadLoginData();
            var courtEpoDataList = CourtEpoDataReader.ReadCourtEpoLogData();

            int loginDataCount = loginDataList.Count();

            //test
            for (int i = 0; i < loginDataCount; i++)
            {
                var loginData = loginDataList[i];
                var courtEpoData = courtEpoDataList[i];

                Reporting.CreateTest("CourtEpoCancelTest");

                LoginPage loginPage = new LoginPage(_driver);
                CourtEpoPage courtEpoPage = new CourtEpoPage(_driver);

                loginPage.GoToLoginPage();

                string pageTitle = _driver.Title;

                if (pageTitle != null && !pageTitle.Contains("SAFV_Site"))
                {
                    loginPage.Login(loginData["JudgeUsername"], loginData["JudgePassword"]);
                }

                courtEpoPage.GoToCourtEpoPage();
                courtEpoPage.CourtEpoCancel(courtEpoData["EpoCaseNumber"]);
            }
        }


        [Test, Order(25)]
        public void CourtEpoRequestForSigningTest()
        {
            // Read data
            var loginDataList = LoginDataReader.ReadLoginData();
            var courtEpoDataList = EpoDataReader.ReadIncidentEpoLogData();

            int loginDataCount = loginDataList.Count();

            //test
            for (int i = 0; i < loginDataCount; i++)
            {
                var loginData = loginDataList[i];
                var courtEpoData = courtEpoDataList[i];

                Reporting.CreateTest("CourtEpoRequestForSigningTest");

                LoginPage loginPage = new LoginPage(_driver);
                CourtEpoPage courtEpoPage = new CourtEpoPage(_driver);

                loginPage.GoToLoginPage();

                string pageTitle = _driver.Title;

                if (pageTitle != null && !pageTitle.Contains("SAFV_Site"))
                {
                    loginPage.Login(loginData["JudgeUsername"], loginData["JudgePassword"]);
                }

                courtEpoPage.GoToCourtEpoPage();
                courtEpoPage.AssignCourtEpo(courtEpoData["EpoCaseNumber"]);
                courtEpoPage.GoToCourtEpoPage();
                courtEpoPage.CourtEpoRequestForSigning(courtEpoData["EpoCaseNumber"], "judge");
            }
        }


        [Test, Order(26)]
        public void CourtEpoJudgeSigningTest()
        {
            // Read data
            var loginDataList = LoginDataReader.ReadLoginData();
            var courtEpoDataList = EpoDataReader.ReadIncidentEpoLogData();

            int loginDataCount = loginDataList.Count();

            //test
            for (int i = 0; i < loginDataCount; i++)
            {
                var loginData = loginDataList[i];
                var courtEpoData = courtEpoDataList[i];

                Reporting.CreateTest("CourtEpoJudgeSigningTest");

                LoginPage loginPage = new LoginPage(_driver);
                CourtEpoPage courtEpoPage = new CourtEpoPage(_driver);

                loginPage.GoToLoginPage();

                string pageTitle = _driver.Title;

                if (pageTitle != null && !pageTitle.Contains("SAFV_Site"))
                {
                    loginPage.Login(loginData["JudgeUsername"], loginData["JudgePassword"]);
                }

                courtEpoPage.GoToCourtEpoPage();
                courtEpoPage.AssignCourtEpo(courtEpoData["EpoCaseNumber"]);
                courtEpoPage.GoToCourtEpoSigningPage();
                courtEpoPage.CourtEpoJudgeSigning(courtEpoData["EpoCaseNumber"]);
            }
        }


        [Test, Order(27)]
        public void CourtEpoJudgeAndSuspectSigningTest()
        {
            // Read data
            var loginDataList = LoginDataReader.ReadLoginData();
            var courtEpoDataList = CourtEpoDataReader.ReadCourtEpoLogData();

            int loginDataCount = loginDataList.Count();

            //test
            for (int i = 0; i < loginDataCount; i++)
            {
                var loginData = loginDataList[i];
                var courtEpoData = courtEpoDataList[i];

                Reporting.CreateTest("CourtEpoJudgeAndSuspectSigningTest");

                LoginPage loginPage = new LoginPage(_driver);
                CourtEpoPage courtEpoPage = new CourtEpoPage(_driver);

                loginPage.GoToLoginPage();

                string pageTitle = _driver.Title;

                if (pageTitle != null && !pageTitle.Contains("SAFV_Site"))
                {
                    loginPage.Login(loginData["JudgeUsername"], loginData["JudgePassword"]);
                }

                courtEpoPage.GoToCourtEpoSigningPage();
                courtEpoPage.CourtEpoJudgeAndSuspectSigning(courtEpoData["EpoCaseNumber"]);
            }
        }
    }
}
