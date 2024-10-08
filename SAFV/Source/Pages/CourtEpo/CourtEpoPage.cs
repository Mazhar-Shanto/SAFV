using OpenQA.Selenium;
using SAFV.Drivers;
using SAFV.Source.Components;
using SAFV.Source.Components.CourtEpo;
using SAFV.Source.Components.CreateIncident.Epo;
using System.Linq;
using System.Numerics;

namespace SAFV.Source.Pages.CourtEpo
{
    public class CourtEpoPage : BasePage
    {
        private IWebDriver _driver;

        public CourtEpoPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        public void GoToCourtEpoPage()
        {
            Click(MenuComponent.Courts);
            Click(MenuComponent.Epo);
        }

        public void CreateCourtEpo(Dictionary<string, string> courtEpoData)
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");

            Click(CourtEpoComponent.CreateCourtEpo);

            Click(CreateCourtEpoComponent.CourtName);
            SelectOption(CreateCourtEpoComponent.LstCourtName, courtEpoData["CourtName"]);
            Click(CreateCourtEpoComponent.TypeOfIncident);
            SelectOption(CreateCourtEpoComponent.LstTypeOfIncident, courtEpoData["TypeOfIncident"]);
            SendKeys(CreateCourtEpoComponent.CourtCaseNo, courtEpoData["CourtCaseNo"]);
            SendKeys(CreateCourtEpoComponent.IncidentCaseNo, courtEpoData["IncidentCaseNo"]);
            SendKeys(CreateCourtEpoComponent.Ori, courtEpoData["Ori"]);
            Click(CreateCourtEpoComponent.CountyOfArrest);
            SelectOption(CreateCourtEpoComponent.LstCountyOfArrest, courtEpoData["CountyOfArrest"]);
            Click(CreateCourtEpoComponent.CountyOfOffense);
            SelectOption(CreateCourtEpoComponent.LstCountyOfOffense, courtEpoData["CountyOfOffense"]);
            SendKeys(CreateCourtEpoComponent.RequestedDate, courtEpoData["RequestedDate"]);
            Click(CreateCourtEpoComponent.LstOrderEffectiveUntil.ElementAt(Int32.Parse(courtEpoData["OrderEffectiveUntil"])));
            Toggle(CreateCourtEpoComponent.RequestedByCourt, courtEpoData["RequestedByCourt"]);
            Toggle(CreateCourtEpoComponent.RequestedByVictim, courtEpoData["RequestedByVictim"]);
            Toggle(CreateCourtEpoComponent.RequestedByGuardian, courtEpoData["RequestedByGuardian"]);

            if (courtEpoData["RequestedByGuardian"].ToLower() == "true" || courtEpoData["RequestedByGuardian"].ToLower() == "yes" || courtEpoData["RequestedByGuardian"].ToLower() == "1")
            {
                SendKeys(CreateCourtEpoComponent.GuardianName, courtEpoData["GuardianName"]);
            }

            Toggle(CreateCourtEpoComponent.RequestedByOfficer, courtEpoData["RequestedByOfficer"]);

            if (courtEpoData["RequestedByOfficer"].ToLower() == "true" || courtEpoData["RequestedByOfficer"].ToLower() == "yes" || courtEpoData["RequestedByOfficer"].ToLower() == "1")
            {
                SendKeys(CreateCourtEpoComponent.OfficerName, courtEpoData["OfficerName"]);
                SendKeys(CreateCourtEpoComponent.OfficerAgency, courtEpoData["OfficerAgency"]);
                SendKeys(CreateCourtEpoComponent.OfficerPhone, courtEpoData["OfficerPhone"]);
            }

            Toggle(CreateCourtEpoComponent.RequestedByState, courtEpoData["RequestedByState"]);

            if (courtEpoData["RequestedByState"].ToLower() == "true" || courtEpoData["RequestedByState"].ToLower() == "yes" || courtEpoData["RequestedByState"].ToLower() == "1")
            {
                SendKeys(CreateCourtEpoComponent.StateAttorneyName, courtEpoData["StateAttorneyName"]);
            }

            Toggle(CreateCourtEpoComponent.SeriousBodilyInjuryOccurred, courtEpoData["SeriousBodilyInjuryOccurred"]);
            Toggle(CreateCourtEpoComponent.UseOfWeaponOccurred, courtEpoData["UseOfWeaponOccurred"]);
            Toggle(CreateCourtEpoComponent.IssueFamilyViolenceHold, courtEpoData["IssueFamilyViolenceHold"]);

            if (courtEpoData["IssueFamilyViolenceHold"].ToLower() == "true" || courtEpoData["IssueFamilyViolenceHold"].ToLower() == "yes" || courtEpoData["IssueFamilyViolenceHold"].ToLower() == "1")
            {
                Toggle(CreateCourtEpoComponent.HoldForPeriod, courtEpoData["HoldForPeriod"]);

                if (courtEpoData["HoldForPeriod"].ToLower() == "true" || courtEpoData["HoldForPeriod"].ToLower() == "yes" || courtEpoData["HoldForPeriod"].ToLower() == "1")
                {
                    SendKeys(CreateCourtEpoComponent.NotLessThanHours, courtEpoData["NotLessThanHours"]);
                    SendKeys(CreateCourtEpoComponent.NotMoreThanHours, courtEpoData["NotMoreThanHours"]);
                }

                Toggle(CreateCourtEpoComponent.HoldUntilSpecifiedDate, courtEpoData["HoldUntilSpecifiedDate"]);

                if (courtEpoData["HoldUntilSpecifiedDate"].ToLower() == "true" || courtEpoData["HoldUntilSpecifiedDate"].ToLower() == "yes" || courtEpoData["HoldUntilSpecifiedDate"].ToLower() == "1")
                {
                    SendKeys(CreateCourtEpoComponent.DateToRelease, courtEpoData["DateToRelease"]);
                }
            }

            Toggle(CreateCourtEpoComponent.ProduceConditionOfBond, courtEpoData["ProduceConditionOfBond"]);
            Toggle(CreateCourtEpoComponent.ProduceMagistrateProtectiveOrder, courtEpoData["ProduceMagistrateProtectiveOrder"]);
            Toggle(CreateCourtEpoComponent.VictimAddressInformationConfidential, courtEpoData["VictimAddressInformationConfidential"]);

            Click(CreateCourtEpoComponent.SaveCourtEpo);
        }

        public void AssignCourtEpo(string epoCaseNumber)
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");

            Click(CourtEpoComponent.FilterUnAssignedCourtEpo);
            SendKeys(CourtEpoComponent.UnAssignedCourtEpoSearchBox, epoCaseNumber);

            if (CourtEpoComponent.UnAssignedCourtEpoGridCount.Text.ToLower().Contains("1"))
            {
                Click(CourtEpoComponent.UnAssignedCourtEpoAssignButton);
                Click(CourtEpoComponent.ConfirmAssign);
            }
            else
            {
                Reporting.SetStepStatusFail("Epo request not found.", _driver);
                return;
            }
        }

        public void CourtEpoCompleteManually(string epoCaseNumber)
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");

            Click(CourtEpoComponent.FilterAssignedCourtEpo);
            SendKeys(CourtEpoComponent.AssignedCourtEpoSearchBox, epoCaseNumber);

            if (CourtEpoComponent.AssignedCourtEpoGridCount.Text.ToLower().Contains("1"))
            {
                Click(CourtEpoComponent.SelectCourtEpo);
            }
            else
            {
                Reporting.SetStepStatusFail("Epo request not assigned.", _driver);
                return;
            }

            Click(CourtEpoComponent.GenerateDocs);

            if (CourtEpoComponent.AlertMessage.Text.ToLower().Contains("then try again"))
            {
                if (CourtEpoComponent.AlertMessage.Text.ToLower().Contains("produce a condition of bond"))
                {
                    Click(CreateCourtEpoComponent.ProduceConditionOfBond);
                }

                if (CourtEpoComponent.AlertMessage.Text.ToLower().Contains("produce magistrate's protective order"))
                {
                    Click(CreateCourtEpoComponent.ProduceMagistrateProtectiveOrder);
                }

                Click(CreateCourtEpoComponent.SaveCourtEpo);
                Click(CourtEpoComponent.GenerateDocs);
            }

            Click(CourtEpoComponent.County);
            Click(CourtEpoComponent.LstCounty);
            Click(CourtEpoComponent.GenerateOrder);
            Click(CourtEpoComponent.CompleteEpoManually);
        }

        public void CourtEpoCancel(string epoCaseNumber)
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");

            Click(CourtEpoComponent.FilterAssignedCourtEpo);
            SendKeys(CourtEpoComponent.AssignedCourtEpoSearchBox, epoCaseNumber);

            if (CourtEpoComponent.AssignedCourtEpoGridCount.Text.ToLower().Contains("1"))
            {
                Click(CourtEpoComponent.SelectCourtEpo);
            }
            else
            {
                Reporting.SetStepStatusFail("Epo request not assigned.", _driver);
                return;
            }

            Click(CourtEpoComponent.GenerateDocs);

            if (CourtEpoComponent.AlertMessage.Text.ToLower().Contains("then try again"))
            {
                if (CourtEpoComponent.AlertMessage.Text.ToLower().Contains("produce a condition of bond"))
                {
                    Click(CreateCourtEpoComponent.ProduceConditionOfBond);
                }

                if (CourtEpoComponent.AlertMessage.Text.ToLower().Contains("produce magistrate's protective order"))
                {
                    Click(CreateCourtEpoComponent.ProduceMagistrateProtectiveOrder);
                }

                Click(CreateCourtEpoComponent.SaveCourtEpo);
                Click(CourtEpoComponent.GenerateDocs);
            }

            Click(CourtEpoComponent.County);
            Click(CourtEpoComponent.LstCounty);
            Click(CourtEpoComponent.GenerateOrder);
            Click(CourtEpoComponent.CancelCourtEpo);
        }

        public void CourtEpoRequestForSigning(string epoCaseNumber, string signingOption)
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");

            Click(CourtEpoComponent.FilterAssignedCourtEpo);
            SendKeys(CourtEpoComponent.AssignedCourtEpoSearchBox, epoCaseNumber);

            if (CourtEpoComponent.AssignedCourtEpoGridCount.Text.ToLower().Contains("1"))
            {
                Click(CourtEpoComponent.SelectCourtEpo);
            }
            else
            {
                Reporting.SetStepStatusFail("Epo request not assigned.", _driver);
                return;
            }

            Click(CourtEpoComponent.GenerateDocs);

            if (CourtEpoComponent.AlertMessage.Text.ToLower().Contains("then try again"))
            {
                if (CourtEpoComponent.AlertMessage.Text.ToLower().Contains("produce a condition of bond"))
                {
                    Click(CreateCourtEpoComponent.ProduceConditionOfBond);
                }

                if (CourtEpoComponent.AlertMessage.Text.ToLower().Contains("produce magistrate's protective order"))
                {
                    Click(CreateCourtEpoComponent.ProduceMagistrateProtectiveOrder);
                }

                Click(CreateCourtEpoComponent.SaveCourtEpo);
                Click(CourtEpoComponent.GenerateDocs);
            }

            Click(CourtEpoComponent.County);
            Click(CourtEpoComponent.LstCounty);
            Click(CourtEpoComponent.GenerateOrder);
            Click(CourtEpoComponent.RequestForSigning);

            if (signingOption.ToLower() == "judge")
            {
                Click(CourtEpoComponent.SigningOption);
                Click(CourtEpoComponent.JudgeSigning);
                Click(CourtEpoComponent.SigningRequestButton);
            }

            if (signingOption.ToLower() == "judge and suspect")
            {
                Click(CourtEpoComponent.SigningOption);
                Click(CourtEpoComponent.JudgeAndSuspectSigning);
                Click(CourtEpoComponent.SigningRequestButton);
            }
        }

        public void CourtEpoJudgeSigning(string epoCaseNumber)
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");

            SendKeys(CourtEpoComponent.OrganizationSearchBox, epoCaseNumber);

            if (CourtEpoComponent.OrganizationEpoCount.Text.Contains("1 of 1"))
            {
                Click(CourtEpoComponent.StartSigningOrganizationEpo);
            }
            else
            {
                SendKeys(CourtEpoComponent.OtherSearchBox, epoCaseNumber);

                if (CourtEpoComponent.OtherEpoCount.Text.Contains("1 of 1"))
                {
                    Click(CourtEpoComponent.StartSigningOtherEpo);
                }
                else
                {
                    Reporting.SetStepStatusFail("Epo not found!!!", _driver);
                }
            }
            
            //Click(CourtEpoComponent.SignAndReview);
            Click(CourtEpoComponent.Next);

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

            Click(SignEpoComponent.Approve);

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

        public void CourtEpoJudgeAndSuspectSigning(string epoCaseNumber)
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");

            SendKeys(CourtEpoComponent.OrganizationSearchBox, epoCaseNumber);

            if (CourtEpoComponent.OrganizationEpoCount.Text.Contains("1 of 1"))
            {
                Click(CourtEpoComponent.StartSigningOrganizationEpo);
            }
            else
            {
                SendKeys(CourtEpoComponent.OtherSearchBox, epoCaseNumber);

                if (CourtEpoComponent.OtherEpoCount.Text.Contains("1 of 1"))
                {
                    Click(CourtEpoComponent.StartSigningOtherEpo);
                }
                else
                {
                    Reporting.SetStepStatusFail("Epo not found!!!", _driver);
                }
            }

            //Click(CourtEpoComponent.SignAndReview);
            Click(CourtEpoComponent.Next);

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

            Click(CourtEpoComponent.ContinueSuspectSigning);

            Click(CourtEpoComponent.SignAndReview);
            Click(CourtEpoComponent.Next);

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

            Click(SignEpoComponent.Approve);
        }
    }
}
