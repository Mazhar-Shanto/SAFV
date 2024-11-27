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

        public void VerifyComment()
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");

            bool comment = false;

            //Click(IncidentReviewComponent.CommentButton);
            foreach (var Note in IncidentReviewComponent.LstNote)
            {
                if (Note.Text == "Test note")
                {
                    comment = true;
                }
            }

            if (comment)
            {
                Reporting.SetStepStatusPass("Comment done", _driver);
            }
            else
            {
                Reporting.SetStepStatusFail("Comment done", _driver);
            }
        }
    }
}
