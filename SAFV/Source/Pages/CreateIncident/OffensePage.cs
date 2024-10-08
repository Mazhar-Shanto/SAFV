using OpenQA.Selenium;
using SAFV.Drivers;
using SAFV.Source.Components;
using SAFV.Source.Components.CreateIncident;
using SAFV.Source.Components.CreateIncident.Offense;
using SAFV.Source.Components.CreateIncident.Location;

namespace SAFV.Source.Pages.CreateIncident
{
    public class OffensePage : IncidentsPage
    {
        private IWebDriver _driver;


        public OffensePage(IWebDriver driver) : base(driver)
        {
            _driver = driver;

        }

        public void GoToOffensePage()
        {
            Console.WriteLine("Incident -- " + MenuComponent.Incidents.Text);
            Click(IncidentMenuComponent.Offenses);
        }

        public void CreateOffense(Dictionary<string, string> offenseData)
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");

            Click(OffenseComponent.AddOffense);

            //VerifyPageLabel(OffenseComponent.AddOffense, OffenseComponent.TabTitle.Text.ToLower(), "offense");

            Click(OffenseComponent.Suspect);
            Click(OffenseComponent.LstSuspect);
            Click(OffenseComponent.Victim);
            Click(OffenseComponent.LstVictim);
            SendKeys(OffenseComponent.DateOfOffense, offenseData["DateOfOffense"]);
            SendKeys(OffenseComponent.TimeOfOffense, offenseData["TimeOfOffense"]);
            Click(OffenseComponent.OffenseLocation);
            Click(OffenseComponent.LstOffenseLocation);
            Click(OffenseComponent.OffenseType);
            Click(OffenseComponent.LstOffenseType);

            Click(OffenseComponent.SaveOffense);
        }

        public void CreateOffenceScene(Dictionary<string, string> sceneData)
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");

            Click(OffenseMenuComponent.Scene);

            VerifyPageLabel(OffenseMenuComponent.Scene, OffenseComponent.TabTitle.Text.ToLower(), "scene");

            Toggle(SceneComponent.DidNotVisitScene, sceneData["DidNotVisitScene"]);

            if (sceneData["DidNotVisitScene"].ToLower() == "yes" || sceneData["DidNotVisitScene"].ToLower() == "true" || sceneData["DidNotVisitScene"].ToLower() == "1")
            {
                Toggle(SceneComponent.DidNotVisitSceneReason, sceneData["DidNotVisitSceneReason"]);
            }
            else
            {
                Toggle(SceneComponent.BrokenFurniture, sceneData["BrokenFurniture"]);
                Toggle(SceneComponent.BloodAtScene, sceneData["BloodAtScene"]);
                Toggle(SceneComponent.BrokenPhone, sceneData["BrokenPhone"]);
                Toggle(SceneComponent.HoleInWall, sceneData["HoleInWall"]);
                Toggle(SceneComponent.BrokenGlass, sceneData["BrokenGlass"]);
                Toggle(SceneComponent.ChildrenCrying, sceneData["ChildrenCrying"]);
                Toggle(SceneComponent.Weapon, sceneData["Weapon"]);
                Toggle(SceneComponent.LackOfUtilites, sceneData["LackOfUtilites"]);
                Toggle(SceneComponent.ClumpOfHair, sceneData["ClumpOfHair"]);
                Toggle(SceneComponent.DamagedKickedRemovedDoor, sceneData["DamagedKickedRemovedDoor"]);

                if (sceneData["DamagedKickedRemovedDoor"].ToLower() == "yes" || sceneData["DamagedKickedRemovedDoor"].ToLower() == "true" || sceneData["DamagedKickedRemovedDoor"].ToLower() == "1")
                {
                    SendKeys(SceneComponent.DoorToWhichRoom, sceneData["DoorToWhichRoom"]);
                }

                Toggle(SceneComponent.ForcedEntry, sceneData["ForcedEntry"]);

                if (sceneData["ForcedEntry"].ToLower() == "yes" || sceneData["ForcedEntry"].ToLower() == "true" || sceneData["ForcedEntry"].ToLower() == "1")
                {
                    SendKeys(SceneComponent.WhichLocation, sceneData["WhichLocation"]);
                }

                Toggle(SceneComponent.DrugsParaphernalia, sceneData["DrugsParaphernalia"]);
                Toggle(SceneComponent.Alcohol, sceneData["Alcohol"]);
                Toggle(SceneComponent.Other, sceneData["Other"]);

                if (sceneData["Other"].ToLower() == "yes" || sceneData["Other"].ToLower() == "true" || sceneData["Other"].ToLower() == "1")
                {
                    SendKeys(SceneComponent.OtherDescription, sceneData["OtherDescription"]);
                }

                SendKeys(SceneComponent.DescribeSceneUponYourArrival, sceneData["DescribeSceneUponYourArrival"]);
            }

            Click(SceneComponent.SaveScene);
        }

        public void CreateBias(Dictionary<string, string> biasData)
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");

            Click(OffenseMenuComponent.Bias);

            VerifyPageLabel(OffenseMenuComponent.Bias, OffenseComponent.TabTitle.Text.ToLower(), "bias");

            Toggle(BiasComponent.ByGender, biasData["ByGender"]);
            Click(BiasComponent.GenderBias);
            SelectOption(BiasComponent.LstGenderBias, biasData["GenderBias"]);
            Toggle(BiasComponent.ByGenderIdentity, biasData["ByGenderIdentity"]);
            Click(BiasComponent.GenderIdentityBias);
            SelectOption(BiasComponent.LstGenderIdentityBias, biasData["GenderIdentityBias"]);
            Toggle(BiasComponent.ByRace, biasData["ByRace"]);
            Click(BiasComponent.RaceBias);
            SelectOption(BiasComponent.LstRaceBias, biasData["RaceBias"]);
            Toggle(BiasComponent.ByReligion, biasData["ByReligion"]);
            Click(BiasComponent.ReligionBias);
            SelectOption(BiasComponent.LstReligionBias, biasData["ReligionBias"]);
            Toggle(BiasComponent.BySexualOrientation, biasData["BySexualOrientation"]);
            Click(BiasComponent.SexualOrientationBias);
            SelectOption(BiasComponent.LstSexualOrientation, biasData["SexualOrientationBias"]);
            Toggle(BiasComponent.ByDisability, biasData["ByDisability"]);
            Click(BiasComponent.DisabilityBias);
            SelectOption(BiasComponent.LstDisabilityBias, biasData["DisabilityBias"]);
            Toggle(BiasComponent.NoBias, biasData["NoBias"]);
            Click(BiasComponent.UnknownBias);
            SelectOption(BiasComponent.LstUnknownBias, biasData["UnknownBias"]);

            Click(BiasComponent.SaveBias);
        }

        public void CreateManner(Dictionary<string, string> mannerData)
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");

            Click(OffenseMenuComponent.Manner);

            VerifyPageLabel(OffenseMenuComponent.Manner, OffenseComponent.TabTitle.Text.ToLower(), "manner");

            Click(MannerComponent.AddNewManner);
            Click(MannerComponent.ActionOfSuspect);
            SelectOption(MannerComponent.LstActionOfSuspect, mannerData["ActionOfSuspect"]);

            if (mannerData["ActionOfSuspect"].ToLower() == "other" || mannerData["ActionOfSuspect"].ToLower() == "striking with an object")
            {
                SendKeys(MannerComponent.ActionDescription, mannerData["ActionDescription"]);
            }

            if (!string.IsNullOrEmpty(mannerData["ActionOfSuspect"]))
            {
                Click(MannerComponent.HowSuspectCommitAction);
                SelectOption(MannerComponent.LstHowSuspectCommitAction, mannerData["HowSuspectCommitAction"]);

                if (mannerData["HowSuspectCommitAction"].ToLower() == "known object")
                {
                    SendKeys(MannerComponent.DescribeObject, mannerData["DescribeObject"]);
                }

                if (!string.IsNullOrEmpty(mannerData["HowSuspectCommitAction"]))
                {
                    Toggle(MannerComponent.Face, mannerData["Face"]);
                    Toggle(MannerComponent.Upperbody, mannerData["Upperbody"]);
                    Toggle(MannerComponent.LowerBody, mannerData["LowerBody"]);
                    Toggle(MannerComponent.EntireBody, mannerData["EntireBody"]);
                    Toggle(MannerComponent.Head, mannerData["Head"]);
                    Toggle(MannerComponent.StomachAbdomen, mannerData["StomachAbdomen"]);
                    Toggle(MannerComponent.Genitals, mannerData["Genitals"]);
                    Toggle(MannerComponent.Neck, mannerData["Neck"]);
                    Toggle(MannerComponent.Throat, mannerData["Throat"]);
                    Toggle(MannerComponent.Extremities, mannerData["Extremities"]);
                }
            }

            Click(MannerComponent.SaveManner);
        }

        public void CreateRiskAssessment(Dictionary<string, string> riskAssessmentData)
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");

            Click(OffenseMenuComponent.RiskAssessment);

            VerifyPageLabel(OffenseMenuComponent.RiskAssessment, OffenseComponent.TabTitle.Text.ToLower(), "risk assessment");

            Radio(OffenseRiskAssessmentComponent.FamilyViolenceLikelyToOccur, riskAssessmentData["FamilyViolenceLikelyToOccur"]);
            Radio(OffenseRiskAssessmentComponent.UsedOrThreatenedWithWeapon, riskAssessmentData["UsedOrThreatenedWithWeapon"]);
            Radio(OffenseRiskAssessmentComponent.ThreatenedToKill, riskAssessmentData["ThreatenedToKill"]);
            Radio(OffenseRiskAssessmentComponent.SuspectHasGun, riskAssessmentData["SuspectHasGun"]);

            if (riskAssessmentData["SuspectHasGun"].ToLower() == "true" || riskAssessmentData["SuspectHasGun"].ToLower() == "yes" || riskAssessmentData["SuspectHasGun"].ToLower() == "1")
            {
                SendKeys(OffenseRiskAssessmentComponent.GunDetailsInfo, riskAssessmentData["GunDetailsInfo"]);
            }

            Radio(OffenseRiskAssessmentComponent.Strangulation, riskAssessmentData["Strangulation"]);
            Radio(OffenseRiskAssessmentComponent.Violence, riskAssessmentData["Violence"]);
            Radio(OffenseRiskAssessmentComponent.Jealousy, riskAssessmentData["Jealousy"]);
            Radio(OffenseRiskAssessmentComponent.Controlling, riskAssessmentData["Controlling"]);
            Radio(OffenseRiskAssessmentComponent.ViolenceIncreased, riskAssessmentData["ViolenceIncreased"]);

            if (riskAssessmentData["ViolenceIncreased"].ToLower() == "true" || riskAssessmentData["ViolenceIncreased"].ToLower() == "yes" || riskAssessmentData["ViolenceIncreased"].ToLower() == "1")
            {
                SendKeys(OffenseRiskAssessmentComponent.ViolenceIncreasedDescription, riskAssessmentData["ViolenceIncreasedDescription"]);
            }

            Radio(OffenseRiskAssessmentComponent.DestroyedItems, riskAssessmentData["DestroyedItems"]);
            Radio(OffenseRiskAssessmentComponent.HurtPets, riskAssessmentData["HurtPets"]);
            Radio(OffenseRiskAssessmentComponent.Unemployed, riskAssessmentData["Unemployed"]);
            Radio(OffenseRiskAssessmentComponent.Suicidal, riskAssessmentData["Suicidal"]);
            Radio(OffenseRiskAssessmentComponent.Spying, riskAssessmentData["Spying"]);
            Radio(OffenseRiskAssessmentComponent.ThreateningMessages, riskAssessmentData["ThreateningMessages"]);
            Radio(OffenseRiskAssessmentComponent.AlcoholAbuse, riskAssessmentData["AlcoholAbuse"]);
            Radio(OffenseRiskAssessmentComponent.DrugUse, riskAssessmentData["DrugUse"]);
            Radio(OffenseRiskAssessmentComponent.MightKillYou, riskAssessmentData["MightKillYou"]);
            Radio(OffenseRiskAssessmentComponent.ForcedSex, riskAssessmentData["ForcedSex"]);
            Radio(OffenseRiskAssessmentComponent.Separation, riskAssessmentData["Separation"]);
            Radio(OffenseRiskAssessmentComponent.RecentSeparation, riskAssessmentData["RecentSeparation"]);
            Radio(OffenseRiskAssessmentComponent.UnrelatedChild, riskAssessmentData["UnrelatedChild"]);
            Radio(OffenseRiskAssessmentComponent.PriorContacts, riskAssessmentData["PriorContacts"]);
            Radio(OffenseRiskAssessmentComponent.CourtAction, riskAssessmentData["CourtAction"]);
            SendKeys(OffenseRiskAssessmentComponent.AdditionalInfo, riskAssessmentData["AdditionalInfo"]);
            SendKeys(OffenseRiskAssessmentComponent.PriorProtectiveOrder, riskAssessmentData["PriorProtectiveOrder"]);
            SendKeys(OffenseRiskAssessmentComponent.DateTimeOfAssessment, riskAssessmentData["DateTimeOfAssessment"]);

            Click(OffenseRiskAssessmentComponent.SaveRiskAssessment);
        }

        public void CreateUseOfWeapon(Dictionary<string, string> useOfWeaponData)
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");

            Click(OffenseMenuComponent.UseOfWeapon);

            VerifyPageLabel(OffenseMenuComponent.UseOfWeapon, OffenseComponent.TabTitle.Text.ToLower(), "weapon");

            Click(UseOfWeaponComponent.CreateNewUseOfWeapon);
            Click(UseOfWeaponComponent.Person);
            Click(UseOfWeaponComponent.LstPerson);
            Click(UseOfWeaponComponent.WeaponType);
            SelectOption(UseOfWeaponComponent.LstWeaponType, useOfWeaponData["WeaponType"]);

            if (useOfWeaponData["WeaponType"].ToLower() == "other")
            {
                SendKeys(UseOfWeaponComponent.OtherDescription, useOfWeaponData["OtherDescription"]);
            }

            if (useOfWeaponData["WeaponType"].ToLower() != "motor vehicle" || useOfWeaponData["WeaponType"].ToLower() != "personal weapons (hands,feet,fist,teeth,etc.)" || useOfWeaponData["WeaponType"].ToLower() != "unknown" || useOfWeaponData["WeaponType"].ToLower() != "other")
            {
                Toggle(UseOfWeaponComponent.NoEvidence, useOfWeaponData["NoEvidence"]);

                if (useOfWeaponData["NoEvidence"].ToLower() == "true" || useOfWeaponData["NoEvidence"].ToLower() == "yes" || useOfWeaponData["NoEvidence"].ToLower() == "1")
                {
                    SendKeys(UseOfWeaponComponent.NoEvidenceReason, useOfWeaponData["NoEvidenceReason"]);
                }

                Click(UseOfWeaponComponent.Evidence);
                Click(UseOfWeaponComponent.LstEvidence);
            }

            Toggle(UseOfWeaponComponent.SelfDefence, useOfWeaponData["SelfDefence"]);
            Toggle(UseOfWeaponComponent.ThirdParty, useOfWeaponData["ThirdParty"]);
            Toggle(UseOfWeaponComponent.DisplayedOnly, useOfWeaponData["DisplayedOnly"]);

            Click(UseOfWeaponComponent.SaveUseOfWeapon);
        }

        public void CreateAggAssault(Dictionary<string, string> aggAssaultData)
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");

            Click(OffenseMenuComponent.AggAssault);

            VerifyPageLabel(OffenseMenuComponent.AggAssault, OffenseComponent.TabTitle.Text.ToLower(), "assault");

            Toggle(AggAssaultComponent.SeriousBodilyInjury, aggAssaultData["SeriousBodilyInjury"]);

            if (aggAssaultData["SeriousBodilyInjury"].ToLower() == "true" || aggAssaultData["SeriousBodilyInjury"].ToLower() == "yes" || aggAssaultData["SeriousBodilyInjury"].ToLower() == "1")
            {
                SendKeys(AggAssaultComponent.WhoGaveOpinion, aggAssaultData["WhoGaveOpinion"]);
                Toggle(AggAssaultComponent.SubstantialRiskOfDeath, aggAssaultData["SubstantialRiskOfDeath"]);

                if (aggAssaultData["SubstantialRiskOfDeath"].ToLower() == "true" || aggAssaultData["SubstantialRiskOfDeath"].ToLower() == "yes" || aggAssaultData["SubstantialRiskOfDeath"].ToLower() == "1")
                {
                    SendKeys(AggAssaultComponent.SubstantialRiskOfDeathDescription, aggAssaultData["SubstantialRiskOfDeathDescription"]);
                }

                Toggle(AggAssaultComponent.LossOrImpairment, aggAssaultData["LossOrImpairment"]);

                if (aggAssaultData["LossOrImpairment"].ToLower() == "true" || aggAssaultData["LossOrImpairment"].ToLower() == "yes" || aggAssaultData["LossOrImpairment"].ToLower() == "1")
                {
                    SendKeys(AggAssaultComponent.LossOrImpairmentDescription, aggAssaultData["LossOrImpairmentDescription"]);
                }

                Toggle(AggAssaultComponent.Disfigurement, aggAssaultData["Disfigurement"]);

                if (aggAssaultData["Disfigurement"].ToLower() == "true" || aggAssaultData["Disfigurement"].ToLower() == "yes" || aggAssaultData["Disfigurement"].ToLower() == "1")
                {
                    SendKeys(AggAssaultComponent.DisfigurementDescription, aggAssaultData["DisfigurementDescription"]);
                }
            }

            Toggle(AggAssaultComponent.DeadlyWeaponUsed, aggAssaultData["DeadlyWeaponUsed"]);

            if (aggAssaultData["DeadlyWeaponUsed"].ToLower() == "true" || aggAssaultData["DeadlyWeaponUsed"].ToLower() == "yes" || aggAssaultData["DeadlyWeaponUsed"].ToLower() == "1")
            {
                SendKeys(AggAssaultComponent.DeadlyWeaponUsedDescription, aggAssaultData["DeadlyWeaponUsedDescription"]);
            }

            Toggle(AggAssaultComponent.DeadlyWeaponExhibited, aggAssaultData["DeadlyWeaponExhibited"]);

            if (aggAssaultData["DeadlyWeaponExhibited"].ToLower() == "true" || aggAssaultData["DeadlyWeaponExhibited"].ToLower() == "yes" || aggAssaultData["DeadlyWeaponExhibited"].ToLower() == "1")
            {
                SendKeys(AggAssaultComponent.DeadlyWeaponExhibitedDescription, aggAssaultData["DeadlyWeaponExhibitedDescription"]);
            }

            SendKeys(AggAssaultComponent.SuspectUseOfWeapon, aggAssaultData["SuspectUseOfWeapon"]);

            Click(AggAssaultComponent.SaveAggAssault);
        }

        public void CreatePcNarrative()
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");

            Click(OffenseMenuComponent.PcNarrative);

            VerifyPageLabel(OffenseMenuComponent.AggAssault, OffenseComponent.TabTitle.Text.ToLower(), "narrative");

            Click(PcNarrativeComponent.GeneratePcNarrative);

            Thread.Sleep(5000);

            if (string.IsNullOrEmpty(PcNarrativeComponent.NarrativeText.Text))
            {
                Reporting.SetStepStatusFail("Narrative not generated!!!", _driver);
            }
            else
            {
                Click(PcNarrativeComponent.CopyAndPaste);
            }

            Click(PcNarrativeComponent.SavePcNarrative);
        }
    }
}