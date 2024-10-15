
using SAFV.Drivers;
using SAFV.Helper;
using SAFV.Helper.Log;
using SAFV.Source.Pages;
using SAFV.Source.Pages.CourtEpo;
using SAFV.Source.Pages.CreateIncident;

namespace SAFV.Test
{
    internal class QuickBookTest : Driver
    {
        [Test, Order(28)]
        public void CreateQuickBookTest()
        {
            // Read data
            var loginDataList = LoginDataReader.ReadLoginData();
            var quickBookLogDataList = QuickBookDataReader.ReadQuickBookLogData();
            var quickBookIncidentDataList = QuickBookDataReader.ReadQuickBookIncidentData();
            var quickBookOffenseDataList = QuickBookDataReader.ReadQuickBookOffenseData();
            var quickBookVictimDataList = QuickBookDataReader.ReadQuickBookVictimData();
            var quickBookVictimRelocationDataList = QuickBookDataReader.ReadQuickBookVictimRelocationData();
            var quickBookVictimAddressDataList = QuickBookDataReader.ReadQuickBookVictimAddressData();
            var quickBookVictimInjuryDataList = QuickBookDataReader.ReadQuickBookVictimInjuryData();
            var quickBookVictimMedicalDataList = QuickBookDataReader.ReadQuickBookVictimMedicalEmsData();
            var quickBookSuspectDataList = QuickBookDataReader.ReadQuickBookSuspectData();
            var quickBookSuspectInfoDataList = QuickBookDataReader.ReadQuickBookSuspectInfoData();
            var quickBookEvidenceDataList = QuickBookDataReader.ReadQuickBookEvidenceData();
            var quickBookRiskAssessmentDataList = QuickBookDataReader.ReadQuickBookRiskAssessmentData();
            var quickBookEpoDataList = QuickBookDataReader.ReadQuickBookEpoData();

            int loginDataCount = loginDataList.Count();

            //test
            for (int i = 0; i < loginDataCount; i++)
            {
                var loginData = loginDataList[i];
                var quickBookLogData = quickBookLogDataList[i];
                var quickBookIncidentData = quickBookIncidentDataList[i];
                var quickBookOffenseData = quickBookOffenseDataList[i];
                var quickBookVictimData = quickBookVictimDataList[i];
                var quickBookVictimRelocationData = quickBookVictimRelocationDataList[i];
                var quickBookVictimAddressData = quickBookVictimAddressDataList[i];
                var quickBookVictimInjuryData = quickBookVictimInjuryDataList[i];
                var quickBookVictimMedicalData = quickBookVictimMedicalDataList[i];
                var quickBookSuspectData = quickBookSuspectDataList[i];
                var quickBookSuspectInfoData = quickBookSuspectInfoDataList[i];
                var quickBookEvidenceData = quickBookEvidenceDataList[i];
                var quickBookRiskAssessmentData = quickBookRiskAssessmentDataList[i];
                var quickBookEpoData = quickBookEpoDataList[i];

                Reporting.CreateTest("CreateMainIncidentTest");

                LoginPage loginPage = new LoginPage(_driver);
                QuickBookPage quickBookPage = new QuickBookPage(_driver);

                loginPage.GoToLoginPage();

                loginPage.Login(loginData["Username"], loginData["Password"]);
                quickBookPage.GoToQuickBookCreatePage();

                string quickBookCaseCountOld = quickBookLogData["QuickBookCaseCount"];
                string quickBookCaseNumberOld = quickBookLogData["QuickBookCaseNumber"];
                string quickBookSupplementCountOld = quickBookLogData["QuickBookSupplementCount"];
                string quickBookSupplementNumberOld = quickBookLogData["QuickBookSupplementNumber"];
                string quickBookMainCaseForSupplement = quickBookLogData["QuickBookMainCaseForSupplement"];

                int quickBookCaseCountOldInt = Int32.Parse(quickBookCaseCountOld) + 1;
                string quickBookCaseCountNew = quickBookCaseCountOldInt.ToString();

                string quickBookCaseNumberNew = quickBookPage.CreateNewQuickBookIncident(quickBookIncidentData, quickBookCaseCountNew, quickBookMainCaseForSupplement);

                WriteToExcel.WriteQuickBookLog(quickBookCaseCountNew, quickBookCaseNumberNew, quickBookSupplementCountOld, quickBookSupplementNumberOld, quickBookMainCaseForSupplement);

                quickBookPage.CreateQuickBookOffense(quickBookOffenseData);
                quickBookPage.CreateQuickBookVictim(quickBookVictimData);
                quickBookPage.CreateQuickBookVictimRelocatingAddress(quickBookVictimRelocationData);
                quickBookPage.CreateQuickBookVictimAddress(quickBookVictimAddressData);
                quickBookPage.CreateQuickBookVictimInjury(quickBookVictimInjuryData);
                quickBookPage.CreateQuickBookVictimMedical(quickBookVictimMedicalData);
                quickBookPage.CreateQuickBookSuspectFromMaster(quickBookSuspectData);
                quickBookPage.CreateQuickBookSuspectInfo(quickBookSuspectInfoData);
                quickBookPage.GoToQuickBookEvidencePage();
                quickBookPage.CreateQuickBookEvidence(quickBookEvidenceData);
                quickBookPage.GoToQuickBookRiskAssessmentPage();
                quickBookPage.CreateQuickBookRiskAssessment(quickBookRiskAssessmentData);
                quickBookPage.CreateQuickBookEpoRequest(quickBookEpoData);
            }
        }
    }
}
