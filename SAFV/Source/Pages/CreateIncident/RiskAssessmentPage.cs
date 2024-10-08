using OpenQA.Selenium;
using SAFV.Drivers;
using SAFV.Source.Components;
using SAFV.Source.Components.CreateIncident;
using SAFV.Source.Components.CreateIncident.Offense;
using SAFV.Source.Components.CreateIncident.Location;

namespace SAFV.Source.Pages.CreateIncident
{
    public class RiskAssessmentPage : IncidentsPage
    {
        private IWebDriver _driver;


        public RiskAssessmentPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;

        }

        public void GoToRiskAssessmentPage()
        {
            Console.WriteLine("Incident -- " + MenuComponent.Incidents.Text);
            Click(IncidentMenuComponent.RiskAssesment);
        }

        public void CreateRiskAssessment(Dictionary<string, string> riskAssessmentData)
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");

            Click(RiskAssessmentComponent.CreateNewRA);

            Click(RiskAssessmentComponent.Suspect);
            Click(RiskAssessmentComponent.LstSuspect);
            Click(RiskAssessmentComponent.Victim);
            Click(RiskAssessmentComponent.LstVictim);

            Radio(RiskAssessmentComponent.FamilyViolenceLikelyToOccur, riskAssessmentData["FamilyViolenceLikelyToOccur"]);
            Radio(RiskAssessmentComponent.UsedOrThreatenedWithWeapon, riskAssessmentData["UsedOrThreatenedWithWeapon"]);
            Radio(RiskAssessmentComponent.ThreatenedToKill, riskAssessmentData["ThreatenedToKill"]);
            Radio(RiskAssessmentComponent.SuspectHasGun, riskAssessmentData["SuspectHasGun"]);

            if (riskAssessmentData["SuspectHasGun"].ToLower() == "true" || riskAssessmentData["SuspectHasGun"].ToLower() == "yes" || riskAssessmentData["SuspectHasGun"].ToLower() == "1")
            {
                SendKeys(RiskAssessmentComponent.GunDetailsInfo, riskAssessmentData["GunDetailsInfo"]);
            }

            Radio(RiskAssessmentComponent.Strangulation, riskAssessmentData["Strangulation"]);
            Radio(RiskAssessmentComponent.Violence, riskAssessmentData["Violence"]);
            Radio(RiskAssessmentComponent.Jealousy, riskAssessmentData["Jealousy"]);
            Radio(RiskAssessmentComponent.Controlling, riskAssessmentData["Controlling"]);
            Radio(RiskAssessmentComponent.ViolenceIncreased, riskAssessmentData["ViolenceIncreased"]);

            if (riskAssessmentData["ViolenceIncreased"].ToLower() == "true" || riskAssessmentData["ViolenceIncreased"].ToLower() == "yes" || riskAssessmentData["ViolenceIncreased"].ToLower() == "1")
            {
                SendKeys(RiskAssessmentComponent.ViolenceIncreasedDescription, riskAssessmentData["ViolenceIncreasedDescription"]);
            }

            Radio(RiskAssessmentComponent.DestroyedItems, riskAssessmentData["DestroyedItems"]);
            Radio(RiskAssessmentComponent.HurtPets, riskAssessmentData["HurtPets"]);
            Radio(RiskAssessmentComponent.Unemployed, riskAssessmentData["Unemployed"]);
            Radio(RiskAssessmentComponent.Suicidal, riskAssessmentData["Suicidal"]);
            Radio(RiskAssessmentComponent.Spying, riskAssessmentData["Spying"]);
            Radio(RiskAssessmentComponent.ThreateningMessages, riskAssessmentData["ThreateningMessages"]);
            Radio(RiskAssessmentComponent.AlcoholAbuse, riskAssessmentData["AlcoholAbuse"]);
            Radio(RiskAssessmentComponent.DrugUse, riskAssessmentData["DrugUse"]);
            Radio(RiskAssessmentComponent.MightKillYou, riskAssessmentData["MightKillYou"]);
            Radio(RiskAssessmentComponent.ForcedSex, riskAssessmentData["ForcedSex"]);
            Radio(RiskAssessmentComponent.Separation, riskAssessmentData["Separation"]);
            Radio(RiskAssessmentComponent.RecentSeparation, riskAssessmentData["RecentSeparation"]);
            Radio(RiskAssessmentComponent.UnrelatedChild, riskAssessmentData["UnrelatedChild"]);
            Radio(RiskAssessmentComponent.PriorContacts, riskAssessmentData["PriorContacts"]);
            Radio(RiskAssessmentComponent.CourtAction, riskAssessmentData["CourtAction"]);
            SendKeys(RiskAssessmentComponent.AdditionalInfo, riskAssessmentData["AdditionalInfo"]);
            SendKeys(RiskAssessmentComponent.PriorProtectiveOrder, riskAssessmentData["PriorProtectiveOrder"]);
            SendKeys(RiskAssessmentComponent.DateTimeOfAssessment, riskAssessmentData["DateTimeOfAssessment"]);

            Click(RiskAssessmentComponent.SaveRiskAssessment);
        }
    }
}
