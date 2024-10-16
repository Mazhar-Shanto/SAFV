using OpenQA.Selenium;
using SAFV.Drivers;
using SAFV.Source.Components.CourtEpo;

namespace SAFV.Source.Pages.CourtEpo
{
    public class CourtEpoConditionsPage : BasePage
    {
        private IWebDriver _driver;

        public CourtEpoConditionsPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        public void GoToCourtEpoConditionsPage()
        {
            ScrollToTop();
            Click(CourtEpoMenuComponent.Conditions);
        }

        public void CreateEpoConditions(Dictionary<string, string> courtEpoConditionsData)
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");

            Toggle(CourtEpoConditionsComponent.ActsOfFamilyViolence, courtEpoConditionsData["ActsOfFamilyViolence"]);
            Toggle(CourtEpoConditionsComponent.Stalking, courtEpoConditionsData["Stalking"]);
            Toggle(CourtEpoConditionsComponent.DirectCommunication, courtEpoConditionsData["DirectCommunication"]);
            Toggle(CourtEpoConditionsComponent.ThreatCommunication, courtEpoConditionsData["ThreatCommunication"]);
            Toggle(CourtEpoConditionsComponent.AnyCommunication, courtEpoConditionsData["AnyCommunication"]);
            Toggle(CourtEpoConditionsComponent.PhysicalDistance, courtEpoConditionsData["PhysicalDistance"]);

            if (courtEpoConditionsData["PhysicalDistance"].ToLower() == "yes" || courtEpoConditionsData["PhysicalDistance"].ToLower() == "true" || courtEpoConditionsData["PhysicalDistance"].ToLower() == "1")
            {
                SendKeys(CourtEpoConditionsComponent.Yards, courtEpoConditionsData["Yards"]);
                Toggle(CourtEpoConditionsComponent.NearResidence, courtEpoConditionsData["NearResidence"]);
                Toggle(CourtEpoConditionsComponent.NearPlaceOfEmployment, courtEpoConditionsData["NearPlaceOfEmployment"]);
                Toggle(CourtEpoConditionsComponent.NearSchool, courtEpoConditionsData["NearSchool"]);
            }
            
            Toggle(CourtEpoConditionsComponent.PossessFirearm, courtEpoConditionsData["PossessFirearm"]);
            Toggle(CourtEpoConditionsComponent.Tracking, courtEpoConditionsData["Tracking"]);
            Toggle(CourtEpoConditionsComponent.GpsMonitoring, courtEpoConditionsData["GpsMonitoring"]);

            if (courtEpoConditionsData["GpsMonitoring"].ToLower() == "yes" || courtEpoConditionsData["GpsMonitoring"].ToLower() == "true" || courtEpoConditionsData["GpsMonitoring"].ToLower() == "1")
            {
                SendKeys(CourtEpoConditionsComponent.GpsMonitoringDescription, courtEpoConditionsData["GpsMonitoringDescription"]);
            }

            Toggle(CourtEpoConditionsComponent.HumanTrafficking, courtEpoConditionsData["HumanTrafficking"]);
            Toggle(CourtEpoConditionsComponent.VictimNotification, courtEpoConditionsData["VictimNotification"]);
            Toggle(CourtEpoConditionsComponent.CourtAppearance, courtEpoConditionsData["CourtAppearance"]);
            Toggle(CourtEpoConditionsComponent.VictimContact, courtEpoConditionsData["VictimContact"]);
            Toggle(CourtEpoConditionsComponent.ApproachResidence, courtEpoConditionsData["ApproachResidence"]);
            Toggle(CourtEpoConditionsComponent.SchoolDaycare, courtEpoConditionsData["SchoolDaycare"]);
            Toggle(CourtEpoConditionsComponent.Weapons, courtEpoConditionsData["Weapons"]);
            Toggle(CourtEpoConditionsComponent.AlcoholDrugs, courtEpoConditionsData["AlcoholDrugs"]);
            Toggle(CourtEpoConditionsComponent.PrescriptionMedications, courtEpoConditionsData["PrescriptionMedications"]);
            Toggle(CourtEpoConditionsComponent.DrugTest, courtEpoConditionsData["DrugTest"]);
            Toggle(CourtEpoConditionsComponent.CourtOrder, courtEpoConditionsData["CourtOrder"]);
            Toggle(CourtEpoConditionsComponent.Offense, courtEpoConditionsData["Offense"]);
            Toggle(CourtEpoConditionsComponent.OtherConditions, courtEpoConditionsData["OtherConditions"]);

            if (courtEpoConditionsData["OtherConditions"].ToLower() == "yes" || courtEpoConditionsData["OtherConditions"].ToLower() == "true" || courtEpoConditionsData["OtherConditions"].ToLower() == "1")
            {
                SendKeys(CourtEpoConditionsComponent.OtherConditionsDescription, courtEpoConditionsData["OtherConditionsDescription"]);
            }

            Click(CourtEpoConditionsComponent.SaveCourtEpoConditions);
        }
    }
}
