using OpenQA.Selenium;
using SAFV.Drivers;
using SAFV.Source.Components;
using SAFV.Source.Components.CreateIncident;

namespace SAFV.Source.Pages.CreateIncident
{
    public class EvidencePage : IncidentsPage
    {
        private IWebDriver _driver;


        public EvidencePage(IWebDriver driver) : base(driver)
        {
            _driver = driver;

        }

        public void GoToEvidencePage()
        {
            Console.WriteLine("Incident -- " + MenuComponent.Incidents.Text);
            Click(IncidentMenuComponent.Evidence);
        }

        public void CreateEvidence(Dictionary<string, string> evidenceData)
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");

            Click(EvidenceComponent.AddEvidence);

            Click(EvidenceComponent.EvidenceType);
            SelectOption(EvidenceComponent.LstEvidenceType, evidenceData["EvidenceType"]);
            Click(EvidenceComponent.EvidenceDisposition);
            SelectOption(EvidenceComponent.LstEvidenceDisposition, evidenceData["EvidenceDisposition"]);
            Toggle(EvidenceComponent.CollectedFromPerson, evidenceData["CollectedFromPerson"]);

            if (evidenceData["CollectedFromPerson"].ToLower() == "yes" || evidenceData["CollectedFromPerson"].ToLower() == "true" || evidenceData["CollectedFromPerson"].ToLower() == "1")
            {
                if (!string.IsNullOrEmpty(evidenceData["Person"]))
                {
                    Click(EvidenceComponent.Person);
                    SelectOption(EvidenceComponent.LstPerson, evidenceData["Person"]);
                }

                Toggle(EvidenceComponent.PersonNotListed, evidenceData["PersonNotListed"]);

                if (evidenceData["PersonNotListed"].ToLower() == "yes" || evidenceData["PersonNotListed"].ToLower() == "true" || evidenceData["PersonNotListed"].ToLower() == "1")
                {
                    SendKeys(EvidenceComponent.PersonName, evidenceData["PersonName"]);
                }
            }

            SendKeys(EvidenceComponent.WhereFound, evidenceData["WhereFound"]);
            SendKeys(EvidenceComponent.EvidenceDescription, evidenceData["EvidenceDescription"]);
            Toggle(EvidenceComponent.WasSeized, evidenceData["WasSeized"]);

            if (evidenceData["EvidenceType"].ToLower() == "weapon")
            {
                Click(EvidenceComponent.TypeOfWeapon);
                SelectOption(EvidenceComponent.LstTypeOfWeapon, evidenceData["TypeOfWeapon"]);

                if (evidenceData["TypeOfWeapon"].ToLower() == "firearm (type not stated)" || evidenceData["TypeOfWeapon"].ToLower() == "handgun" || evidenceData["TypeOfWeapon"].ToLower() == "rifle" || evidenceData["TypeOfWeapon"].ToLower() == "shotgun" || evidenceData["TypeOfWeapon"].ToLower() == "other firearm")
                {
                    Click(EvidenceComponent.WeaponManufacturer);
                    SelectOption(EvidenceComponent.LstWeaponManufacturer, evidenceData["WeaponManufacturer"]);
                    Click(EvidenceComponent.WeaponCaliber);
                    SelectOption(EvidenceComponent.LstWeaponCaliber, evidenceData["WeaponCaliber"]);
                }
            }

            if (string.IsNullOrEmpty(evidenceData["EvidenceSerialNumber"]))
            {
                SendKeys(EvidenceComponent.EvidenceSerialNumber, "N/A");
            }
            else
            {
                SendKeys(EvidenceComponent.EvidenceSerialNumber, evidenceData["EvidenceSerialNumber"]);
            }

            if (!string.IsNullOrEmpty(evidenceData["EvidenceCollectedBy"]))
            {
                SendKeys(EvidenceComponent.EvidenceCollectedBy, evidenceData["EvidenceCollectedBy"]);
            }

            Click(EvidenceComponent.SaveEvidence);
        }
    }
}
