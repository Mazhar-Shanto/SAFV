using OpenQA.Selenium;
using SAFV.Drivers;
using SAFV.Source.Components;
using SAFV.Source.Components.CreateIncident;

namespace SAFV.Source.Pages.CreateIncident
{
    public class ReportPage : IncidentsPage
    {
        private IWebDriver _driver;


        public ReportPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;

        }

        public void GoToReportPage()
        {
            Console.WriteLine("Incident -- " + MenuComponent.Incidents.Text);
            Click(IncidentMenuComponent.Reports);
        }

        public void CreateReport() //Dictionary<string, string> evidenceData
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");

            Click(ReportComponent.SelectAllReport);
            Click(ReportComponent.GenerateForms);
            Toggle(ReportComponent.HandOverDocumentsToAnyone, "1");
            SendKeys(ReportComponent.HandOverTo, "Judge");
            Click(ReportComponent.Generate);

            _driver.SwitchTo().Window(_driver.WindowHandles[1]);

            Click(ReportComponent.GeneratePseudonymFormForVictimsForm);
            Click(ReportComponent.GenerateBookingForm);
            Click(ReportComponent.GenerateIncidentCaseReportForm);
            Click(ReportComponent.SelectChild);
            Click(ReportComponent.GenerateLawEnforcementNotificationForm);
            Click(ReportComponent.GenerateRiskAssessmentForm);
            Click(ReportComponent.GenerateVictimNotificationForm);
            Click(ReportComponent.GeneratePcAffidavitForm);
        }

        public void SendToDfps() //Dictionary<string, string> evidenceData
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");

            Click(ReportComponent.SelectAllReport);
            Click(ReportComponent.SendToDfps);

            if (ReportComponent.AlertMessage.Text.ToLower().Contains("successfull"))
            {
                Reporting.SetStepStatusPass("Sent to DFPS", _driver);
            }
            if (ReportComponent.AlertMessage.Text.ToLower().Contains("fail"))
            {
                Reporting.SetStepStatusFail("Send to DFPS failed: " + ReportComponent.AlertMessage.Text, _driver);
            }
        }
    }
}
