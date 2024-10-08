using OpenQA.Selenium;
using SAFV.Drivers;
using SAFV.Source.Components;
using SAFV.Source.Components.CreateIncident;

namespace SAFV.Source.Pages.CreateIncident
{
    public class StatusHistoryPage : IncidentsPage
    {
        private IWebDriver _driver;


        public StatusHistoryPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;

        }

        public void GoToStatusHistoryPage()
        {
            Console.WriteLine("Incident -- " + MenuComponent.Incidents.Text);
            Click(IncidentMenuComponent.StatusHistory);
        }

        public void SendForReview() //Dictionary<string, string> evidenceData
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");

            Click(StatusHistoryComponent.SubmitForReview);
            Click(StatusHistoryComponent.ConfirmSubmitForReview);
            Click(StatusHistoryComponent.ReportGenerateNo);
        }

        public void RejectCase() //Dictionary<string, string> evidenceData
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");

            Click(StatusHistoryComponent.RejectIncident);
            Click(StatusHistoryComponent.ConfirmReject);
        }

        public void LockCase() //Dictionary<string, string> evidenceData
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");

            Click(StatusHistoryComponent.LockIncident);
            Click(StatusHistoryComponent.ConfirmLock);
        }

        public void UnLockCase() //Dictionary<string, string> evidenceData
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");

            Click(StatusHistoryComponent.UnLockIncident);
            Click(StatusHistoryComponent.ConfirmUnLock);
        }

        public string CheckStatus() //Dictionary<string, string> evidenceData
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");

            if (StatusHistoryComponent.Status.Text.ToLower() == "status")
            {
                Reporting.SetStepStatusPass("Status is correct.", _driver);
            }

            return StatusHistoryComponent.Status.Text.ToLower();
        }
    }
}
