using OpenQA.Selenium;
using SAFV.Drivers;
using SAFV.Source.Components;
using SAFV.Source.Components.Detective.CreateCase;

namespace SAFV.Source.Pages.Detective.CreateCase
{
    public class CaseInfoPage : IncidentsPage
    {
        private IWebDriver _driver;


        public CaseInfoPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        public void GoToCaseInfoPage()
        {
            Console.WriteLine("Incident -- " + MenuComponent.Incidents.Text);
            Click(CaseMenuComponent.Case);
        }

        public void CreateCaseInfo(Dictionary<string, string> incidentInfoData)
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");

            Click(CaseMenuComponent.Case);
            SendKeys(CaseInfoComponent.District, incidentInfoData["District"]);
            Toggle(CaseInfoComponent.ChildrenInvolved, incidentInfoData["ChildrenInvolved"]);

            if (incidentInfoData["ChildrenInvolved"].ToLower() == "yes" || incidentInfoData["ChildrenInvolved"].ToLower() == "true" || incidentInfoData["ChildrenInvolved"].ToLower() == "1")
            {
                Toggle(CaseInfoComponent.RequiresCpsNotification, incidentInfoData["RequiresCpsNotification"]);
                Toggle(CaseInfoComponent.CpsHaveBeenCalled, incidentInfoData["CpsHaveBeenCalled"]);
                SendKeys(CaseInfoComponent.CpsNumber, incidentInfoData["CpsNumber"]);
                SendKeys(CaseInfoComponent.CpsNotifedDate, incidentInfoData["CpsNotifedAt"]);
                SendKeys(CaseInfoComponent.CpsSafetyIssues, incidentInfoData["CpsSafetyIssues"]);
            }

            SendKeys(CaseInfoComponent.OfficerPrimaryConcern, incidentInfoData["OfficerPrimaryConcern"]);
            SendKeys(CaseInfoComponent.SuspectedMethManufacture, incidentInfoData["SuspectedMethManufacture"]);
            SendKeys(CaseInfoComponent.SensitiveIssues, incidentInfoData["SensitiveIssues"]);
            Toggle(CaseInfoComponent.Covid19Exposure, incidentInfoData["Covid19Exposure"]);
            Click(CaseInfoComponent.HowPoliceContacted);
            SelectOption(CaseInfoComponent.LstHowPoliceContacted, incidentInfoData["HowPoliceContacted"]);
            Click(CaseInfoComponent.WhatWasBeingReported);
            SelectOption(CaseInfoComponent.LstWhatWasBeingReported, incidentInfoData["WhatWasBeingReported"]);
            SendKeys(CaseInfoComponent.DispatchedDate, incidentInfoData["DispatchedDate"]);
            SendKeys(CaseInfoComponent.DispatchedTime, incidentInfoData["DispatchedTime"]);
        }
    }
}
