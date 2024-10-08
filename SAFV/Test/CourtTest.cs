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
        [Test]
        public void CreateCourtEpoTest()
        {
            // Read data
            var loginDataList = LoginDataReader.ReadLoginData();
            var courtEpoDataList = CourtEpoDataReader.ReadCourtEpoData();
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
                var courtEpoSuspectData = courtEpoSuspectDataList[i];
                var courtEpoVictimData = courtEpoVictimDataList[i];
                var courtEpoOtherData = courtEpoOtherDataList[i];
                var courtEpoConditionsData = courtEpoConditionsDataList[i];

                Reporting.CreateTest("CreateSupplementTest");

                LoginPage loginPage = new LoginPage(_driver);
                CourtEpoPage courtEpoPage = new CourtEpoPage(_driver);
                CourtEpoSuspectInfoPage courtEpoSuspectInfoPage = new CourtEpoSuspectInfoPage(_driver);
                CourtEpoVictimInfoPage epoVictimInfoPage = new CourtEpoVictimInfoPage(_driver);
                CourtEpoOtherInfoPage courtEpoOtherInfoPage = new CourtEpoOtherInfoPage(_driver);
                CourtEpoConditionsPage courtEpoConditionsPage = new CourtEpoConditionsPage(_driver);

                loginPage.GoToLoginPage();

                loginPage.Login(loginData["JudgeUsername"], loginData["JudgePassword"]);
                courtEpoPage.GoToCourtEpoPage();
                courtEpoPage.CreateCourtEpo(courtEpoData);

                WriteToExcel.WriteEpoLog(courtEpoData["IncidentCaseNo"]);

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


        [Test]
        public void CourtEpoAssignTest()
        {
            // Read data
            var loginDataList = LoginDataReader.ReadLoginData();
            var courtEpoDataList = EpoDataReader.ReadEpoLogData();

            int loginDataCount = loginDataList.Count();

            //test
            for (int i = 0; i < loginDataCount; i++)
            {
                var loginData = loginDataList[i];
                var courtEpoData = courtEpoDataList[i];

                Reporting.CreateTest("CreateSupplementTest");

                LoginPage loginPage = new LoginPage(_driver);
                CourtEpoPage courtEpoPage = new CourtEpoPage(_driver);

                loginPage.GoToLoginPage();

                loginPage.Login(loginData["JudgeUsername"], loginData["JudgePassword"]);
                courtEpoPage.GoToCourtEpoPage();
                courtEpoPage.AssignCourtEpo(courtEpoData["EpoCaseNumber"]);
            }
        }


        [Test]
        public void CourtEpoManualCompleteTest()
        {
            // Read data
            var loginDataList = LoginDataReader.ReadLoginData();
            var courtEpoDataList = EpoDataReader.ReadEpoLogData();

            int loginDataCount = loginDataList.Count();

            //test
            for (int i = 0; i < loginDataCount; i++)
            {
                var loginData = loginDataList[i];
                var courtEpoData = courtEpoDataList[i];

                Reporting.CreateTest("CreateSupplementTest");

                LoginPage loginPage = new LoginPage(_driver);
                CourtEpoPage courtEpoPage = new CourtEpoPage(_driver);

                loginPage.GoToLoginPage();

                loginPage.Login(loginData["JudgeUsername"], loginData["JudgePassword"]);
                courtEpoPage.GoToCourtEpoPage();
                courtEpoPage.CourtEpoCompleteManually(courtEpoData["EpoCaseNumber"]);
            }
        }


        [Test]
        public void CourtEpoCancelTest()
        {
            // Read data
            var loginDataList = LoginDataReader.ReadLoginData();
            var courtEpoDataList = EpoDataReader.ReadEpoLogData();

            int loginDataCount = loginDataList.Count();

            //test
            for (int i = 0; i < loginDataCount; i++)
            {
                var loginData = loginDataList[i];
                var courtEpoData = courtEpoDataList[i];

                Reporting.CreateTest("CreateSupplementTest");

                LoginPage loginPage = new LoginPage(_driver);
                CourtEpoPage courtEpoPage = new CourtEpoPage(_driver);

                loginPage.GoToLoginPage();

                loginPage.Login(loginData["JudgeUsername"], loginData["JudgePassword"]);
                courtEpoPage.GoToCourtEpoPage();
                courtEpoPage.CourtEpoCancel(courtEpoData["EpoCaseNumber"]);
            }
        }


        [Test]
        public void CourtEpoRequestForSigningTest()
        {
            // Read data
            var loginDataList = LoginDataReader.ReadLoginData();
            var courtEpoDataList = EpoDataReader.ReadEpoLogData();

            int loginDataCount = loginDataList.Count();

            //test
            for (int i = 0; i < loginDataCount; i++)
            {
                var loginData = loginDataList[i];
                var courtEpoData = courtEpoDataList[i];

                Reporting.CreateTest("CreateSupplementTest");

                LoginPage loginPage = new LoginPage(_driver);
                CourtEpoPage courtEpoPage = new CourtEpoPage(_driver);

                loginPage.GoToLoginPage();

                loginPage.Login(loginData["JudgeUsername"], loginData["JudgePassword"]);
                courtEpoPage.GoToCourtEpoPage();
                courtEpoPage.CourtEpoRequestForSigning(courtEpoData["EpoCaseNumber"], "judge");
            }
        }


        [Test]
        public void CourtEpoJudgeSigningTest()
        {
            // Read data
            var loginDataList = LoginDataReader.ReadLoginData();
            var courtEpoDataList = EpoDataReader.ReadEpoLogData();

            int loginDataCount = loginDataList.Count();

            //test
            for (int i = 0; i < loginDataCount; i++)
            {
                var loginData = loginDataList[i];
                var courtEpoData = courtEpoDataList[i];

                Reporting.CreateTest("CreateSupplementTest");

                LoginPage loginPage = new LoginPage(_driver);
                CourtEpoPage courtEpoPage = new CourtEpoPage(_driver);

                loginPage.GoToLoginPage();

                loginPage.Login(loginData["JudgeUsername"], loginData["JudgePassword"]);
                courtEpoPage.GoToCourtEpoPage();
                courtEpoPage.CourtEpoJudgeSigning(courtEpoData["EpoCaseNumber"]);
            }
        }


        [Test]
        public void CourtEpoJudgeAndSuspectSigningTest()
        {
            // Read data
            var loginDataList = LoginDataReader.ReadLoginData();
            var courtEpoDataList = EpoDataReader.ReadEpoLogData();

            int loginDataCount = loginDataList.Count();

            //test
            for (int i = 0; i < loginDataCount; i++)
            {
                var loginData = loginDataList[i];
                var courtEpoData = courtEpoDataList[i];

                Reporting.CreateTest("CreateSupplementTest");

                LoginPage loginPage = new LoginPage(_driver);
                CourtEpoPage courtEpoPage = new CourtEpoPage(_driver);

                loginPage.GoToLoginPage();

                loginPage.Login(loginData["JudgeUsername"], loginData["JudgePassword"]);
                courtEpoPage.GoToCourtEpoPage();
                courtEpoPage.CourtEpoJudgeAndSuspectSigning(courtEpoData["EpoCaseNumber"]);
            }
        }
    }
}
