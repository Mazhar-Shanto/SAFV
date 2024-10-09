using OpenQA.Selenium;
using SAFV.Drivers;
using SAFV.Source.Components;
using SAFV.Source.Components.CreateIncident;

namespace SAFV.Source.Pages.CreateIncident
{
    public class DigitalEvidencePage : IncidentsPage
    {
        private IWebDriver _driver;


        public DigitalEvidencePage(IWebDriver driver) : base(driver)
        {
            _driver = driver;

        }

        public void GoToDigitalEvidencePage()
        {
            Console.WriteLine("Incident -- " + MenuComponent.Incidents.Text);
            Click(IncidentMenuComponent.DigitalEvidence);
        }

        public void CreateDigitalEvidence(Dictionary<string, string> digitalEvidenceData)
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");

            Toggle(DigitalEvidenceComponent.WasDigitalEvidenceCollected, digitalEvidenceData["WasDigitalEvidenceCollected"]);

            if (digitalEvidenceData["WasDigitalEvidenceCollected"].ToLower() == "yes" || digitalEvidenceData["WasDigitalEvidenceCollected"].ToLower() == "true" || digitalEvidenceData["WasDigitalEvidenceCollected"].ToLower() == "1")
            {
                Toggle(DigitalEvidenceComponent.VideoBodyCamera, digitalEvidenceData["VideoBodyCamera"]);
                Toggle(DigitalEvidenceComponent.VideoInCar, digitalEvidenceData["VideoInCar"]);
                Toggle(DigitalEvidenceComponent.VideoOther, digitalEvidenceData["VideoOther"]);

                if (digitalEvidenceData["VideoOther"].ToLower() == "yes" || digitalEvidenceData["VideoOther"].ToLower() == "true" || digitalEvidenceData["VideoOther"].ToLower() == "1")
                {
                    SendKeys(DigitalEvidenceComponent.VideoOtherDescription, digitalEvidenceData["VideoOtherDescription"]);
                }

                Toggle(DigitalEvidenceComponent.Photographs, digitalEvidenceData["Photographs"]);

                if (digitalEvidenceData["Photographs"].ToLower() == "yes" || digitalEvidenceData["Photographs"].ToLower() == "true" || digitalEvidenceData["Photographs"].ToLower() == "1")
                {
                    SendKeys(DigitalEvidenceComponent.PhotographsDescription, digitalEvidenceData["PhotographsDescription"]);
                }

                Toggle(DigitalEvidenceComponent.Audiocall, digitalEvidenceData["Audiocall"]);
                Toggle(DigitalEvidenceComponent.Audio, digitalEvidenceData["Audio"]);

                if (digitalEvidenceData["Audio"].ToLower() == "yes" || digitalEvidenceData["Audio"].ToLower() == "true" || digitalEvidenceData["Audio"].ToLower() == "1")
                {
                    SendKeys(DigitalEvidenceComponent.AudioDescription, digitalEvidenceData["AudioDescription"]);
                }
            }
            else
            {
                SendKeys(DigitalEvidenceComponent.ExplainWhyNotCollected, digitalEvidenceData["ExplainWhyNotCollected"]);
            }

            Click(DigitalEvidenceComponent.SaveDigitalEvidence);
        }
    }
}
