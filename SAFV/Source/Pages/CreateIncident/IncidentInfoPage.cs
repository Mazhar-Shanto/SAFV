using OpenQA.Selenium;
using SAFV.Drivers;
using SAFV.Source.Components;
using SAFV.Source.Components.CreateIncident;
using SAFV.Source.Components.CreateIncident.People;
using SAFV.Source.Components.CreateIncident.People.Suspect;

namespace SAFV.Source.Pages.CreateIncident
{
    public class IncidentInfoPage : BasePage
    {
        private IWebDriver _driver;


        public IncidentInfoPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        public void GoToIncidentInfoPage()
        {
            Console.WriteLine("Incident -- " + MenuComponent.Incidents.Text);
            Click(IncidentMenuComponent.Incident);
        }

        public void CreateIncidentInfo(Dictionary<string, string> incidentInfoData)
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");

            Click(IncidentMenuComponent.Incident);
            SendKeys(IncidentInfoComponent.District, incidentInfoData["District"]);
            Toggle(IncidentInfoComponent.ChildrenInvolved, incidentInfoData["ChildrenInvolved"]);

            if (incidentInfoData["ChildrenInvolved"].ToLower() == "yes" || incidentInfoData["ChildrenInvolved"].ToLower() == "true" || incidentInfoData["ChildrenInvolved"].ToLower() == "1")
            {
                Toggle(IncidentInfoComponent.RequiresCpsNotification, incidentInfoData["RequiresCpsNotification"]);
                Toggle(IncidentInfoComponent.CpsHaveBeenCalled, incidentInfoData["CpsHaveBeenCalled"]);
                SendKeys(IncidentInfoComponent.CpsNumber, incidentInfoData["CpsNumber"]);
                SendKeys(IncidentInfoComponent.CpsNotifedDate, incidentInfoData["CpsNotifedAt"]);
                SendKeys(IncidentInfoComponent.CpsSafetyIssues, incidentInfoData["CpsSafetyIssues"]);
            }

            SendKeys(IncidentInfoComponent.OfficerPrimaryConcern, incidentInfoData["OfficerPrimaryConcern"]);
            SendKeys(IncidentInfoComponent.SuspectedMethManufacture, incidentInfoData["SuspectedMethManufacture"]);
            SendKeys(IncidentInfoComponent.SensitiveIssues, incidentInfoData["SensitiveIssues"]);
            Toggle(IncidentInfoComponent.Covid19Exposure, incidentInfoData["Covid19Exposure"]);
            Click(IncidentInfoComponent.HowPoliceContacted);
            SelectOption(IncidentInfoComponent.LstHowPoliceContacted, incidentInfoData["HowPoliceContacted"]);
            Click(IncidentInfoComponent.WhatWasBeingReported);
            SelectOption(IncidentInfoComponent.LstWhatWasBeingReported, incidentInfoData["WhatWasBeingReported"]);
            SendKeys(IncidentInfoComponent.DispatchedDate, incidentInfoData["DispatchedDate"]);
            SendKeys(IncidentInfoComponent.DispatchedTime, incidentInfoData["DispatchedTime"]);
        }
    }
}
