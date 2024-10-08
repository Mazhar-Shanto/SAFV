using OpenQA.Selenium;
using SAFV.Drivers;
using SAFV.Source.Components;
using SAFV.Source.Components.CreateIncident;
using SAFV.Source.Components.CreateIncident.Offense;
using SAFV.Source.Components.CreateIncident.Location;
using SAFV.Source.Components.CreateIncident.Epo;
using OpenQA.Selenium.DevTools.V126.Debugger;

namespace SAFV.Source.Pages.CreateIncident
{
    public class EpoBookingPage : IncidentsPage
    {
        private IWebDriver _driver;


        public EpoBookingPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;

        }

        public void GoToEpoBookingPage()
        {
            Console.WriteLine("Incident -- " + MenuComponent.Incidents.Text);
            Click(IncidentMenuComponent.EpoBooking);
        }

        public void CreateEpoRequest(Dictionary<string, string> epoData)
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");

            Click(EpoComponent.CreateEpoRequest);

            Click(EpoComponent.OffenseGroup);
            Click(EpoComponent.LstOffenseGroup);
            Toggle(EpoComponent.RequestedByVictim, epoData["RequestedByVictim"]);
            Toggle(EpoComponent.RequestedByGuardian, epoData["RequestedByGuardian"]);

            if (epoData["RequestedByGuardian"].ToLower() == "true" || epoData["RequestedByGuardian"].ToLower() == "yes" || epoData["RequestedByGuardian"].ToLower() == "1")
            {
                SendKeys(EpoComponent.GuardiansName, epoData["GuardiansName"]);
            }

            Toggle(EpoComponent.RequestedByOfficer, epoData["RequestedByOfficer"]);
            Toggle(EpoComponent.RequestedByState, epoData["RequestedByState"]);

            if (epoData["RequestedByState"].ToLower() == "true" || epoData["RequestedByState"].ToLower() == "yes" || epoData["RequestedByState"].ToLower() == "1")
            {
                SendKeys(EpoComponent.StateAttorneyName, epoData["StateAttorneyName"]);
            }

            Toggle(EpoComponent.RequestedByMagistrate, epoData["RequestedByMagistrate"]);

            if (epoData["RequestedByMagistrate"].ToLower() == "true" || epoData["RequestedByMagistrate"].ToLower() == "yes" || epoData["RequestedByMagistrate"].ToLower() == "1")
            {
                SendKeys(EpoComponent.MagistratesName, epoData["MagistratesName"]);
            }

            Toggle(EpoComponent.HoldRequested, epoData["HoldRequested"]);

            if (epoData["HoldRequested"].ToLower() == "true" || epoData["HoldRequested"].ToLower() == "yes" || epoData["HoldRequested"].ToLower() == "1")
            {
                Toggle(EpoComponent.Hour24, epoData["Hour24"]);
                Toggle(EpoComponent.Hour48, epoData["Hour48"]);
                SendKeys(EpoComponent.ExplainHold, epoData["ExplainHold"]);
            }

            Click(EpoComponent.SaveEpo);

            if (EpoComponent.SuspectArrestCheck.GetAttribute("value").ToLower() == "true")
            {
                Click(EpoComponent.EpoRequestDocuments);
                Click(GenerateEpoRequestComponent.SelectAllforms);
                Click(GenerateEpoRequestComponent.GenerateRequestButton);
                Click(EpoComponent.SendEpoRequest);
                Click(SendEpoRequestComponent.JudicialOrganization);
                SelectOption(SendEpoRequestComponent.LstJudicialOrganization, epoData["JudicialOrganization"]);

                if (epoData["SignEpo"].ToLower() == "true" || epoData["SignEpo"].ToLower() == "yes" || epoData["SignEpo"].ToLower() == "1")
                {
                    Click(SendEpoRequestComponent.SendWithSigning);
                    Toggle(SendEpoRequestComponent.WitnessIsLocal, epoData[""]);

                    if (epoData["WitnessIsLocal"].ToLower() == "true" || epoData["WitnessIsLocal"].ToLower() == "yes" || epoData["WitnessIsLocal"].ToLower() == "1")
                    {
                        SendKeys(SendEpoRequestComponent.SignerName, epoData["SignerName"]);
                        Click(SendEpoRequestComponent.Judge);
                        SelectOption(SendEpoRequestComponent.LstJudge, epoData["Judge"]);

                        Click(SendEpoRequestComponent.CreateSigningRequest);

                        Click(SignEpoComponent.ReviewEpoRequest);
                        Click(SignEpoComponent.ApproveEpoRequest);
                        Click(SignEpoComponent.GoToSignature);

                        Thread.Sleep(2000);
                        Click(SignEpoComponent.ClearSign);
                        Draw(SignEpoComponent.SignatureCanvas, 60, 40, -60, 40);
                        Draw(SignEpoComponent.SignatureCanvas, -60, 40, -60, 0);
                        Draw(SignEpoComponent.SignatureCanvas, -60, 0, 60, 0);
                        Draw(SignEpoComponent.SignatureCanvas, 60, 0, 0, -40);
                        Draw(SignEpoComponent.SignatureCanvas, 0, -40, -40, -60);
                        Click(SignEpoComponent.SetupAndSign);
                        Click(SignEpoComponent.PlaceSignature);
                        Click(SignEpoComponent.SubmitSignature);
                        Click(SignEpoComponent.Approve);
                    }
                }

                if (epoData["SignEpo"].ToLower() == "no" || epoData["SignEpo"].ToLower() == "false" || epoData["SignEpo"].ToLower() == "0")
                {
                    Click(SendEpoRequestComponent.SendWithoutSigning);
                }
            }
            else
            {
                Reporting.SetStepStatusFail("Suspect not arrested. Can not generate EPO.", _driver);
                return;
            }
        }
    }
}
