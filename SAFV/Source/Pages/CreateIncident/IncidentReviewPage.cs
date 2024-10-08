using OpenQA.Selenium;
using SAFV.Drivers;
using SAFV.Source.Components;
using SAFV.Source.Components.CreateIncident;

namespace SAFV.Source.Pages.CreateIncident
{
    public class IncidentReviewPage : IncidentsPage
    {
        private IWebDriver _driver;


        public IncidentReviewPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;

        }

        public void GoToIncidentReviewPage()
        {
            Console.WriteLine("Incident -- " + MenuComponent.Incidents.Text);
            Click(IncidentMenuComponent.IncidentReview);
        }

        public void AddComment()
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");

            Click(IncidentReviewComponent.CommentButton);
            SendKeys(IncidentReviewComponent.Note, "Test note");
            Click(IncidentReviewComponent.Save);
        }
    }
}
