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

        public void GoToIncidentPage()
        {
            Console.WriteLine("Incident -- " + MenuComponent.Incidents.Text);
            Click(MenuComponent.Incidents);
            Click(MenuComponent.CreateNewIncidentButton);
        }

        public void CreateNewIncident(Dictionary<string, string> incidentData)
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");

            SendKeys(CreateIncidentComponent.ReportDate, incidentData["ReportDate"]);
            SendKeys(CreateIncidentComponent.IncidentCaseNumber, incidentData["IncidentCaseNumber"]);
            Select(CreateIncidentComponent.IncidentType, incidentData["IncidentType"]);
            Toggle(CreateIncidentComponent.ConfidentialMode, incidentData["ConfidentialMode"]);
            Click(CreateIncidentComponent.CaseType);
            SelectOption(CreateIncidentComponent.LstCaseType, incidentData["CaseType"]);

            if (incidentData["CaseType"].ToLower() == "supplement")
            {
                Click(CreateIncidentComponent.MainCase);
                SendKeys(CreateIncidentComponent.SearchMainCase, incidentData["MainCase"]);
                Thread.Sleep(2000);
                SelectOption(CreateIncidentComponent.LstMainCase, incidentData["MainCase"]);
            }

            Click(CreateIncidentComponent.CreateButton);
        }
    }
}
