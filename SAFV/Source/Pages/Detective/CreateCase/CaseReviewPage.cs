using OpenQA.Selenium;
using SAFV.Drivers;
using SAFV.Source.Components;
using SAFV.Source.Components.Detective.CreateCase;

namespace SAFV.Source.Pages.Detective.CreateCase
{
    public class CaseReviewPage : IncidentsPage
    {
        private IWebDriver _driver;


        public CaseReviewPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;

        }

        public void GoToIncidentReviewPage()
        {
            Console.WriteLine("Incident -- " + MenuComponent.Incidents.Text);
            Click(CaseMenuComponent.IncidentReview);
        }

        public void AddComment()
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");

            Click(CaseReviewComponent.CommentButton);
            SendKeys(CaseReviewComponent.Note, "Test note");
            Click(CaseReviewComponent.Save);
        }

        public void VerifyComment()
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");

            bool comment = false;

            //Click(IncidentReviewComponent.CommentButton);
            foreach (var Note in CaseReviewComponent.LstNote)
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
