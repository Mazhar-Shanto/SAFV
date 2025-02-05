using OpenQA.Selenium;
using SAFV.Drivers;
using SAFV.Source.Components;
using SAFV.Source.Components.Detective.CreateCase;

namespace SAFV.Source.Pages.Detective.CreateCase
{
    public class LinkedIncidentPage : IncidentsPage
    {
        private IWebDriver _driver;


        public LinkedIncidentPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;

        }

        public void GoToLinkedIncidentPage()
        {
            Console.WriteLine("Incident -- " + MenuComponent.Incidents.Text);
            Click(CaseMenuComponent.LinkedIncidents);
        }

        public void ViewIncident(string incidentNumber)
        {
            SelectOption(LinkedIncidentComponent.LstIncidents, incidentNumber);
        }

        public int VerifyPeopleCount()
        {
            return Int32.Parse(CaseMenuComponent.PeopleCount.Text);
        }

        public int VerifyLocationCount()
        {
            return Int32.Parse(CaseMenuComponent.LocationCount.Text);
        }

        public int VerifyOffenseCount()
        {
            return Int32.Parse(CaseMenuComponent.OffensCount.Text);
        }

        public int VerifyRiskAssessmentCount()
        {
            return Int32.Parse(CaseMenuComponent.RiskAssessmentCount.Text);
        }

        public int VerifyVehicleCount()
        {
            return Int32.Parse(CaseMenuComponent.VehicleCount.Text);
        }

        public int VerifyEpoCount()
        {
            return Int32.Parse(CaseMenuComponent.EpoCount.Text);
        }

        public int VerifyEvidenceCount()
        {
            return Int32.Parse(CaseMenuComponent.EvidenceCount.Text);
        }
    }
}
