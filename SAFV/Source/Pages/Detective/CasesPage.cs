using OpenQA.Selenium;
using SAFV.Drivers;
using SAFV.Helper;
using SAFV.Source.Components;
using SAFV.Source.Components.Detective;
using SAFV.Source.Components.Detective.CreateCase;

namespace SAFV.Source.Pages.Detective
{
    internal class CasesPage : BasePage
    {
        private IWebDriver _driver;

        public CasesPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        public void GoToCaseCreatePage()
        {
            Click(MenuComponent.Cases);
            Click(MenuComponent.CreateNewCaseButton);
        }

        public void GoToCaseCreateFromIncidentPage()
        {
            Click(MenuComponent.Cases);
            Click(MenuComponent.CreateCaseFromIncidentButton);
        }

        public void GoToCasePage()
        {
            Click(MenuComponent.Cases);
            Click(MenuComponent.CasesPage);
        }

        public void SearchCase(string caseNumber)
        {
            Click(CasesComponent.CaseNumberFilter);
            SendKeys(CasesComponent.CaseSearchBox, caseNumber);
            Click(CasesComponent.CaseSearchButton);
        }

        public void SearchLockedCase(string caseNumber)
        {
            Click(CasesComponent.LockedCaseNumberFilter);
            SendKeys(CasesComponent.LockedCaseSearchBox, caseNumber);
            Click(CasesComponent.LockedCaseSearchButton);
        }

        public void OpenCase()
        {
            Thread.Sleep(2000);
            Click(CasesComponent.SearchedCase);
        }

        public void ShowOtherOfficerCases()
        {
            Click(CasesComponent.ShowOtherOfficerCasesButton);
        }

        public void ShowOtherOfficerLockedCases()
        {
            Click(CasesComponent.ShowOtherOfficerLockedCasesButton);
        }

        public string CreateNewCase(Dictionary<string, string> caseData, string count, string mainCase)
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");

            string detectiveCaseNumber = caseData["DetectiveCaseNumber"] + count;

            SendKeys(CreateCaseComponent.ReportDate, caseData["ReportDate"]);
            SendKeys(CreateCaseComponent.DetectiveCaseNumber, detectiveCaseNumber);
            Select(CreateCaseComponent.IncidentType, caseData["IncidentType"]);
            Toggle(CreateCaseComponent.ConfidentialMode, caseData["ConfidentialMode"]);
            Click(CreateCaseComponent.CaseType);
            SelectOption(CreateCaseComponent.LstCaseType, caseData["CaseType"]);

            if (caseData["CaseType"].ToLower() == "supplement")
            {
                Click(CreateCaseComponent.MainCase);
                SendKeys(CreateCaseComponent.SearchMainCase, mainCase);
                Thread.Sleep(2000);
                SelectOption(CreateCaseComponent.LstMainCase, mainCase);
            }

            Click(CreateCaseComponent.CreateButton);

            return detectiveCaseNumber;
        }

        public string CreateCaseFromIncidents(Dictionary<string, string> caseData, string count, string mainCase)
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");

            string detectiveCaseNumber = caseData["DetectiveCaseNumber"] + count;

            SendKeys(CreateCaseComponent.ReportDate, caseData["ReportDate"]);
            SendKeys(CreateCaseComponent.DetectiveCaseNumber, detectiveCaseNumber);
            Select(CreateCaseComponent.IncidentType, caseData["IncidentType"]);
            Toggle(CreateCaseComponent.ConfidentialMode, caseData["ConfidentialMode"]);
            Click(CreateCaseComponent.CaseType);
            SelectOption(CreateCaseComponent.LstCaseType, caseData["CaseType"]);

            if (caseData["CaseType"].ToLower() == "supplement")
            {
                Click(CreateCaseComponent.MainCase);
                SendKeys(CreateCaseComponent.SearchMainCase, mainCase);
                Thread.Sleep(500);
                SelectOption(CreateCaseComponent.LstMainCase, mainCase);
            }

            string[] incidents = caseData["Incidents"]
                .Split([";"], StringSplitOptions.RemoveEmptyEntries)
                .Select(incident => incident.Trim())
                .ToArray();


            foreach (string incident in incidents)
            {
                Click(CreateCaseComponent.Incidents);
                SendKeys(CreateCaseComponent.SearchIncidents, incident);
                Thread.Sleep(2000);
                SelectOption(CreateCaseComponent.LstIncidents, incident);
                Click(CreateCaseComponent.AddToList);
            }

            Click(CreateCaseComponent.CreateCaseFromIncidents);

            return detectiveCaseNumber;
        }
    }
}