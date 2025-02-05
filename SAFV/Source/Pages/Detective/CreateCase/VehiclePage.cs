using OpenQA.Selenium;
using SAFV.Drivers;
using SAFV.Source.Components;
using SAFV.Source.Components.Detective.CreateCase;

namespace SAFV.Source.Pages.Detective.CreateCase
{
    public class VehiclePage : IncidentsPage
    {
        private IWebDriver _driver;


        public VehiclePage(IWebDriver driver) : base(driver)
        {
            _driver = driver;

        }

        public void GoToVehiclePage()
        {
            Console.WriteLine("Incident -- " + MenuComponent.Incidents.Text);
            Click(CaseMenuComponent.Vehicles);
        }

        public void CreateVehicles(Dictionary<string, string> riskAssessmentData)
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");

            

            Click(RiskAssessmentComponent.SaveRiskAssessment);
        }

        public int VehicleOriginCount()
        {
            return VehicleComponent.LstViewOrigin.Count;
        }
    }
}
