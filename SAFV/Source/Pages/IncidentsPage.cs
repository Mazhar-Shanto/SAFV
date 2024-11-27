using OpenQA.Selenium;
using SAFV.Drivers;
using SAFV.Source.Components;
using SAFV.Source.Components.CreateIncident;

namespace SAFV.Source.Pages
{
    public class IncidentsPage : BasePage
    {
        private IWebDriver _driver;


        public IncidentsPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;

        }

        public void GoToIncidentCreatePage()
        {
            Click(MenuComponent.Incidents);
            Click(MenuComponent.CreateNewIncidentButton);
        }

        public void GoToIncidentPage()
        {
            Click(MenuComponent.Incidents);
            Click(MenuComponent.IncidentsPage);
        }

        public void SearchIncident(string caseNumber)
        {
            Click(IncidentsComponent.CaseNumberFilter);
            SendKeys(IncidentsComponent.CaseSearchBox, caseNumber);
            Click(IncidentsComponent.CaseSearchButton);
        }

        public void SearchLockedIncident(string caseNumber)
        {
            Click(IncidentsComponent.LockedCaseNumberFilter);
            SendKeys(IncidentsComponent.LockedCaseSearchBox, caseNumber);
            Click(IncidentsComponent.LockedCaseSearchButton);
        }

        public void OpenIncident()
        {
            Thread.Sleep(2000);
            Click(IncidentsComponent.SearchedIncident);
        }

        public void ShowOtherOfficerIncidents()
        {
            Click(IncidentsComponent.ShowOtherOfficerIncidentsButton);
        }

        public void ShowOtherOfficerLockedIncidents()
        {
            Click(IncidentsComponent.ShowOtherOfficerLockedIncidentsButton);
        }

        public string CreateNewIncident(Dictionary<string, string> incidentData, string count, string mainCase)
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");

            string incidentCaseNumber = incidentData["IncidentCaseNumber"] + count;

            SendKeys(CreateIncidentComponent.ReportDate, incidentData["ReportDate"]);
            SendKeys(CreateIncidentComponent.IncidentCaseNumber, incidentCaseNumber);
            Select(CreateIncidentComponent.IncidentType, incidentData["IncidentType"]);
            Toggle(CreateIncidentComponent.ConfidentialMode, incidentData["ConfidentialMode"]);
            Click(CreateIncidentComponent.CaseType);
            SelectOption(CreateIncidentComponent.LstCaseType, incidentData["CaseType"]);

            if (incidentData["CaseType"].ToLower() == "supplement")
            {
                Click(CreateIncidentComponent.MainCase);
                SendKeys(CreateIncidentComponent.SearchMainCase, mainCase);
                Thread.Sleep(2000);
                SelectOption(CreateIncidentComponent.LstMainCase, mainCase);
            }

            Click(CreateIncidentComponent.CreateButton);

            return incidentCaseNumber;
        }
    }
}
