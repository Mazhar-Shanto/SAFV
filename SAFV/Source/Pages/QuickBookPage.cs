
using OpenQA.Selenium;
using SAFV.Drivers;
using SAFV.Source.Components;
using SAFV.Source.Components.CreateIncident;
using SAFV.Source.Components.CreateIncident.Offense;
using SAFV.Source.Components.CreateIncident.People.Suspect;
using SAFV.Source.Components.QuickBook;
using SAFV.Source.Components.QuickBook.QuickBookSuspect;
using SAFV.Source.Components.QuickBook.QuickBookVictim;

namespace SAFV.Source.Pages
{
    public class QuickBookPage : BasePage
    {
        private IWebDriver _driver;


        public QuickBookPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;

        }

        public void GoToQuickBookCreatePage()
        {
            Console.WriteLine("Incident -- " + MenuComponent.Incidents.Text);
            Click(MenuComponent.Incidents);
            Click(MenuComponent.CreateQuickBook);
        }

        public void GoToQuickBookEvidencePage()
        {
            Click(QuickBookMenuComponent.Evidence);
        }

        public string CreateNewQuickBookIncident(Dictionary<string, string> quickBookData, string count, string mainCase)
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");

            string quickBookCaseNumber = quickBookData["CaseType"] + count;

            SendKeys(CreateQuickBookIncidentComponent.ReportDate, quickBookData["ReportDate"]);
            SendKeys(CreateQuickBookIncidentComponent.IncidentCaseNumber, quickBookCaseNumber);
            Select(CreateQuickBookIncidentComponent.IncidentType, quickBookData["IncidentType"]);
            Toggle(CreateQuickBookIncidentComponent.ConfidentialMode, quickBookData["ConfidentialMode"]);
            Click(CreateQuickBookIncidentComponent.CaseType);
            SelectOption(CreateQuickBookIncidentComponent.LstCaseType, quickBookData["CaseType"]);

            if (quickBookData["CaseType"].ToLower() == "supplement")
            {
                Click(CreateQuickBookIncidentComponent.MainCase);
                SendKeys(CreateQuickBookIncidentComponent.SearchMainCase, mainCase);
                Thread.Sleep(2000);
                SelectOption(CreateQuickBookIncidentComponent.LstMainCase, mainCase);
            }

            SendKeys(CreateQuickBookIncidentComponent.DispatchedDate, quickBookData["DispatchedDate"]);
            SendKeys(CreateQuickBookIncidentComponent.DispatchedTime, quickBookData["DispatchedTime"]);
            Click(CreateQuickBookIncidentComponent.HowPoliceNotified);
            SelectOption(CreateQuickBookIncidentComponent.LstHowPoliceNotified, quickBookData["HowPoliceNotified"]);
            Click(CreateQuickBookIncidentComponent.WhatWasBeingReported);
            SelectOption(CreateQuickBookIncidentComponent.LstWhatWasBeingReported, quickBookData["WhatWasBeingReported"]);

            Click(CreateQuickBookIncidentComponent.LocationType);
            SelectOption(CreateQuickBookIncidentComponent.LstLocationType, quickBookData["LocationType"]);
            Click(CreateQuickBookIncidentComponent.AddressGroup);
            SelectOption(CreateQuickBookIncidentComponent.LstAddressGroup, quickBookData["AddressGroup"]);
            SendKeys(CreateQuickBookIncidentComponent.Address1, quickBookData["Address1"]);
            SendKeys(CreateQuickBookIncidentComponent.Address2, quickBookData["Address2"]);
            SendKeys(CreateQuickBookIncidentComponent.City, quickBookData["City"]);
            SendKeys(CreateQuickBookIncidentComponent.State, quickBookData["State"]);
            Click(CreateQuickBookIncidentComponent.County);
            SelectOption(CreateQuickBookIncidentComponent.LstCounty, quickBookData["County"]);
            SendKeys(CreateQuickBookIncidentComponent.ZipCode, quickBookData["ZipCode"]);
            Toggle(CreateQuickBookIncidentComponent.DispatchedLocation, quickBookData["DispatchedLocation"]);

            if (quickBookData["DispatchedLocation"].ToLower() == "yes" || quickBookData["DispatchedLocation"].ToLower() == "true" || quickBookData["DispatchedLocation"].ToLower() == "1")
            {
                Click(CreateQuickBookIncidentComponent.DispatchedLocationType);
                SelectOption(CreateQuickBookIncidentComponent.LstDispatchedLocationType, quickBookData["DispatchedLocationType"]);
                Click(CreateQuickBookIncidentComponent.DispatchedLocationAddressGroup);
                SelectOption(CreateQuickBookIncidentComponent.LstDispatchedLocationAddressGroup, quickBookData["DispatchedLocationAddressGroup"]);
                SendKeys(CreateQuickBookIncidentComponent.DispatchedLocationAddress1, quickBookData["DispatchedLocationAddress1"]);
                SendKeys(CreateQuickBookIncidentComponent.DispatchedLocationAddress2, quickBookData["DispatchedLocationAddress2"]);
                SendKeys(CreateQuickBookIncidentComponent.DispatchedLocationCity, quickBookData["DispatchedLocationCity"]);
                SendKeys(CreateQuickBookIncidentComponent.DispatchedLocationState, quickBookData["DispatchedLocationState"]);
                Click(CreateQuickBookIncidentComponent.DispatchedLocationCounty);
                SelectOption(CreateQuickBookIncidentComponent.LstDispatchedLocationCounty, quickBookData["DispatchedLocationCounty"]);
                SendKeys(CreateQuickBookIncidentComponent.DispatchedLocationZipCode, quickBookData["DispatchedLocationZipCode"]);
            }

            Click(CreateQuickBookIncidentComponent.SaveAndNext);

            return quickBookCaseNumber;
        }

        public void CreateQuickBookOffense(Dictionary<string, string> quickBookOffenseData)
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");

            SendKeys(QuickBookOffenseComponent.DateOfOffense, quickBookOffenseData["DateOfOffense"]);
            SendKeys(QuickBookOffenseComponent.TimeOfOffense, quickBookOffenseData["TimeOfOffense"]);
            Click(QuickBookOffenseComponent.Location);
            Click(QuickBookOffenseComponent.LstLocation.ElementAt(0));
            Click(QuickBookOffenseComponent.OffenseType);
            SelectOption(QuickBookOffenseComponent.LstOffenseType, quickBookOffenseData["OffenseType"]);
            Click(QuickBookOffenseComponent.AddOffenseButton);
            Click(QuickBookOffenseComponent.Next);
        }

        public void CreateQuickBookVictimFromMaster(Dictionary<string, string> quickBookVictimData)
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");

            SendKeys(QuickBookVictimComponent.FirstName, quickBookVictimData["FirstName"]);
            Click(QuickBookVictimComponent.LstFirstName.ElementAt(0));
        }

        public void CreateQuickBookVictim(Dictionary<string, string> quickBookVictimData)
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");

            SendKeys(QuickBookVictimComponent.FirstName, quickBookVictimData["FirstName"]);
            SendKeys(QuickBookVictimComponent.LastName, quickBookVictimData["LastName"]);
            Toggle(QuickBookVictimComponent.VictimWouldLikeToUsePseudonym, quickBookVictimData["VictimWouldLikeToUsePseudonym"]);
            Click(QuickBookVictimComponent.ConfirmPseudonym);
            SendKeys(QuickBookVictimComponent.VictimRealFirstName, quickBookVictimData["VictimRealFirstName"]);
            SendKeys(QuickBookVictimComponent.VictimRealLastName, quickBookVictimData["VictimRealLastName"]);
            SendKeys(QuickBookVictimComponent.VictimRealMiddleName, quickBookVictimData["VictimRealMiddleName"]);
            Click(QuickBookVictimComponent.Race);
            SelectOption(QuickBookVictimComponent.LstRace, quickBookVictimData["Race"]);
            Click(QuickBookVictimComponent.Sex);
            SelectOption(QuickBookVictimComponent.LstSex, quickBookVictimData["Sex"]);
            SendKeys(QuickBookVictimComponent.DateOfBirth, quickBookVictimData["DateOfBirth"]);

            Click(QuickBookVictimComponent.Save);
            Click(QuickBookVictimComponent.NoSyncConfirmation);
            Click(QuickBookVictimComponent.Next);
        }

        public void CreateQuickBookVictimRelocatingAddress(Dictionary<string, string> quickBookVictimRelocationData)
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");

            Toggle(QuickBookVictimRelocationComponent.IsVictimRelocating, quickBookVictimRelocationData["IsVictimRelocating"]);

            if (quickBookVictimRelocationData["IsVictimRelocating"].ToLower() == "yes" || quickBookVictimRelocationData["IsVictimRelocating"].ToLower() == "true" || quickBookVictimRelocationData["IsVictimRelocating"].ToLower() == "1")
            {
                Toggle(QuickBookVictimRelocationComponent.Permanent, quickBookVictimRelocationData["Permanent"]);

                if (quickBookVictimRelocationData["Permanent"].ToLower() == "yes" || quickBookVictimRelocationData["Permanent"].ToLower() == "true" || quickBookVictimRelocationData["Permanent"].ToLower() == "1")
                {
                    SendKeys(QuickBookVictimRelocationComponent.PermanentAddress1, quickBookVictimRelocationData["PermanentAddress1"]);
                    SendKeys(QuickBookVictimRelocationComponent.PermanentAddress2, quickBookVictimRelocationData["PermanentAddress2"]);
                    SendKeys(QuickBookVictimRelocationComponent.PermanentCity, quickBookVictimRelocationData["PermanentCity"]);
                    SendKeys(QuickBookVictimRelocationComponent.PermanentState, quickBookVictimRelocationData["PermanentState"]);
                    SendKeys(QuickBookVictimRelocationComponent.PermanentZipCode, quickBookVictimRelocationData["PermanentZipCode"]);
                    Click(QuickBookVictimRelocationComponent.PermanentCounty);
                    SelectOption(QuickBookVictimRelocationComponent.LstPermanentCounty, quickBookVictimRelocationData["PermanentCounty"]);
                }

                Toggle(QuickBookVictimRelocationComponent.Temporary, quickBookVictimRelocationData["Temporary"]);

                if (quickBookVictimRelocationData["Temporary"].ToLower() == "yes" || quickBookVictimRelocationData["Temporary"].ToLower() == "true" || quickBookVictimRelocationData["Temporary"].ToLower() == "1")
                {
                    SendKeys(QuickBookVictimRelocationComponent.TemporaryAddress1, quickBookVictimRelocationData["TemporaryAddress1"]);
                    SendKeys(QuickBookVictimRelocationComponent.TemporaryAddress2, quickBookVictimRelocationData["TemporaryAddress2"]);
                    SendKeys(QuickBookVictimRelocationComponent.TemporaryCity, quickBookVictimRelocationData["TemporaryCity"]);
                    SendKeys(QuickBookVictimRelocationComponent.TemporaryState, quickBookVictimRelocationData["TemporaryState"]);
                    SendKeys(QuickBookVictimRelocationComponent.TemporaryZipCode, quickBookVictimRelocationData["TemporaryZipCode"]);
                    Click(QuickBookVictimRelocationComponent.TemporaryCounty);
                    SelectOption(QuickBookVictimRelocationComponent.LstTemporaryCounty, quickBookVictimRelocationData["TemporaryCounty"]);
                    SendKeys(QuickBookVictimRelocationComponent.HowLong, quickBookVictimRelocationData["HowLong"]);
                }
                Toggle(QuickBookVictimRelocationComponent.OmitLocationFromProtectionOrder, quickBookVictimRelocationData["OmitLocationFromProtectionOrder"]);
                SendKeys(QuickBookVictimRelocationComponent.VictimsConcern, quickBookVictimRelocationData["VictimsConcern"]);
            }

            Click(QuickBookVictimRelocationComponent.SaveAndNext);
        }

        public void CreateQuickBookVictimAddress(Dictionary<string, string> quickBookVictimAddressData)
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");

            Click(QuickBookVictimAddressPhoneComponent.AddPhoneNumber);
            Click(QuickBookVictimAddressPhoneComponent.PhoneType);
            SelectOption(QuickBookVictimAddressPhoneComponent.LstPhoneType, quickBookVictimAddressData["PhoneType"]);
            SendKeys(QuickBookVictimAddressPhoneComponent.PhoneNumber, quickBookVictimAddressData["PhoneNumber"]);
            Toggle(QuickBookVictimAddressPhoneComponent.PrimaryContact, quickBookVictimAddressData["PrimaryContact"]);
            Click(QuickBookVictimAddressPhoneComponent.SavePhoneNumber);

            Click(QuickBookVictimAddressPhoneComponent.AddNewAddress);
            Click(QuickBookVictimAddressPhoneComponent.AddressGroup);
            SelectOption(QuickBookVictimAddressPhoneComponent.LstAddressGroup, quickBookVictimAddressData["AddressGroup"]);
            SendKeys(QuickBookVictimAddressPhoneComponent.Address1, quickBookVictimAddressData["Address1"]);
            SendKeys(QuickBookVictimAddressPhoneComponent.Address2, quickBookVictimAddressData["Address2"]);
            SendKeys(QuickBookVictimAddressPhoneComponent.City, quickBookVictimAddressData["City"]);
            SendKeys(QuickBookVictimAddressPhoneComponent.State, quickBookVictimAddressData["State"]);
            Click(QuickBookVictimAddressPhoneComponent.County);
            SelectOption(QuickBookVictimAddressPhoneComponent.LstCounty, quickBookVictimAddressData["County"]);
            SendKeys(QuickBookVictimAddressPhoneComponent.ZipCode, quickBookVictimAddressData["ZipCode"]);
            Click(QuickBookVictimAddressPhoneComponent.SaveAddress);

            Click(QuickBookVictimAddressPhoneComponent.Next);
        }

        public void CreateQuickBookVictimInjury(Dictionary<string, string> quickBookVictimInjuryData)
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");

            Click(QuickBookVictimInjuryComponent.InjuryArea);
            SelectOption(QuickBookVictimInjuryComponent.LstInjuryArea, quickBookVictimInjuryData["InjuryArea"]);
            Click(QuickBookVictimInjuryComponent.InjuryType);
            SelectOption(QuickBookVictimInjuryComponent.LstInjuryType, quickBookVictimInjuryData["InjuryType"]);
            Toggle(QuickBookVictimInjuryComponent.InjuryObserved, quickBookVictimInjuryData["InjuryObserved"]);
            Click(QuickBookVictimInjuryComponent.AddInjury);
            Click(QuickBookVictimInjuryComponent.SaveInjury);
            
            Click(QuickBookVictimInjuryComponent.Next);
        }

        public void CreateQuickBookVictimMedical(Dictionary<string, string> quickBookVictimMedicalEmsData)
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");

            Toggle(QuickBookVictimMedicalEmsComponent.DidPersonComplainOfInjuries, quickBookVictimMedicalEmsData["DidPersonComplainOfInjuries"]);
            Toggle(QuickBookVictimMedicalEmsComponent.DidYouObserveInjuries, quickBookVictimMedicalEmsData["DidYouObserveInjuries"]);
            Toggle(QuickBookVictimMedicalEmsComponent.IsPersonPregnant, quickBookVictimMedicalEmsData["IsPersonPregnant"]);

            if (quickBookVictimMedicalEmsData["IsPersonPregnant"].ToLower() == "true" || quickBookVictimMedicalEmsData["IsPersonPregnant"].ToLower() == "yes" || quickBookVictimMedicalEmsData["IsPersonPregnant"].ToLower() == "1")
            {
                SendKeys(QuickBookVictimMedicalEmsComponent.NumberOfWeeks, quickBookVictimMedicalEmsData["NumberOfWeeks"]);
                Toggle(QuickBookVictimMedicalEmsComponent.OfficerCouldObservePersonPregnant, quickBookVictimMedicalEmsData["OfficerCouldObservePersonPregnant"]);
            }

            Toggle(QuickBookVictimMedicalEmsComponent.MedicalTreatmentOfferedButRefused, quickBookVictimMedicalEmsData["MedicalTreatmentOfferedButRefused"]);
            Toggle(QuickBookVictimMedicalEmsComponent.PersonSeekingTheirOwnTreatment, quickBookVictimMedicalEmsData["PersonSeekingTheirOwnTreatment"]);

            if (quickBookVictimMedicalEmsData["PersonSeekingTheirOwnTreatment"].ToLower() == "true" || quickBookVictimMedicalEmsData["PersonSeekingTheirOwnTreatment"].ToLower() == "yes" || quickBookVictimMedicalEmsData["PersonSeekingTheirOwnTreatment"].ToLower() == "1")
            {
                SendKeys(QuickBookVictimMedicalEmsComponent.DrWhoWillProvideTreatment, quickBookVictimMedicalEmsData["DrWhoWillProvideTreatment"]);
            }

            Toggle(QuickBookVictimMedicalEmsComponent.FirstAidGivenAtScene, quickBookVictimMedicalEmsData["FirstAidGivenAtScene"]);

            if (quickBookVictimMedicalEmsData["FirstAidGivenAtScene"].ToLower() == "true" || quickBookVictimMedicalEmsData["FirstAidGivenAtScene"].ToLower() == "yes" || quickBookVictimMedicalEmsData["FirstAidGivenAtScene"].ToLower() == "1")
            {
                SendKeys(QuickBookVictimMedicalEmsComponent.FirstAidGivenBy, quickBookVictimMedicalEmsData["FirstAidGivenBy"]);
            }

            Toggle(QuickBookVictimMedicalEmsComponent.EmsParamedicsFire, quickBookVictimMedicalEmsData["EmsParamedicsFire"]);

            if (quickBookVictimMedicalEmsData["EmsParamedicsFire"].ToLower() == "true" || quickBookVictimMedicalEmsData["EmsParamedicsFire"].ToLower() == "yes" || quickBookVictimMedicalEmsData["EmsParamedicsFire"].ToLower() == "1")
            {
                SendKeys(QuickBookVictimMedicalEmsComponent.EmsUnit, quickBookVictimMedicalEmsData["EmsUnit"]);
            }

            Toggle(QuickBookVictimMedicalEmsComponent.EmsUnitTransportedPersonToHospital, quickBookVictimMedicalEmsData["EmsUnitTransportedPersonToHospital"]);

            if (quickBookVictimMedicalEmsData["EmsUnitTransportedPersonToHospital"].ToLower() == "true" || quickBookVictimMedicalEmsData["EmsUnitTransportedPersonToHospital"].ToLower() == "yes" || quickBookVictimMedicalEmsData["EmsUnitTransportedPersonToHospital"].ToLower() == "1")
            {
                SendKeys(QuickBookVictimMedicalEmsComponent.TransportedTo, quickBookVictimMedicalEmsData["TransportedTo"]);
            }

            Click(QuickBookVictimInjuryComponent.SaveAndNext);
        }

        public void CreateQuickBookSuspectFromMaster(Dictionary<string, string> quickBookSuspectData)
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");

            SendKeys(QuickBookSuspectComponent.FirstName, quickBookSuspectData["FirstName"]);
            Click(QuickBookSuspectComponent.LstFirstName);
            Click(QuickBookSuspectComponent.RelationshipToVictim);
            SelectOption(QuickBookSuspectComponent.LstRelationshipToVictim, quickBookSuspectData["RelationshipToVictim"]);

            Click(QuickBookSuspectComponent.SaveAndNext);
        }

        public void CreateQuickBookSuspectInfo(Dictionary<string, string> quickBookSuspectInfoData)
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");

            Toggle(QuickBookSuspectInfoComponent.SuspectWasOnScene, quickBookSuspectInfoData["SuspectWasOnScene"]);

            if (quickBookSuspectInfoData["SuspectWasOnScene"].ToLower() == "true" || quickBookSuspectInfoData["SuspectWasOnScene"].ToLower() == "yes" || quickBookSuspectInfoData["SuspectWasOnScene"].ToLower() == "1")
            {

                Toggle(QuickBookSuspectInfoComponent.SuspectWasArrested, quickBookSuspectInfoData["SuspectWasArrested"]);

                if (quickBookSuspectInfoData["SuspectWasArrested"].ToLower() == "true" || quickBookSuspectInfoData["SuspectWasArrested"].ToLower() == "yes" || quickBookSuspectInfoData["SuspectWasArrested"].ToLower() == "1")
                {
                    SendKeys(QuickBookSuspectInfoComponent.DateOfArrest, quickBookSuspectInfoData["DateOfArrest"]);
                    SendKeys(QuickBookSuspectInfoComponent.TimeOfArrest, quickBookSuspectInfoData["TimeOfArrest"]);
                    SendKeys(QuickBookSuspectInfoComponent.DateOfBooking, quickBookSuspectInfoData["DateOfBooking"]);
                    SendKeys(QuickBookSuspectInfoComponent.TimeOfBooking, quickBookSuspectInfoData["TimeOfBooking"]);
                    SendKeys(QuickBookSuspectInfoComponent.ArrestAddress1, quickBookSuspectInfoData["ArrestAddress1"]);
                    SendKeys(QuickBookSuspectInfoComponent.ArrestAddress2, quickBookSuspectInfoData["ArrestAddress2"]);
                    SendKeys(QuickBookSuspectInfoComponent.ArrestCity, quickBookSuspectInfoData["ArrestCity"]);
                    SendKeys(QuickBookSuspectInfoComponent.ArrestState, quickBookSuspectInfoData["ArrestState"]);
                    SendKeys(QuickBookSuspectInfoComponent.ArrestZipCode, quickBookSuspectInfoData["ArrestZipCode"]);
                    Click(QuickBookSuspectInfoComponent.ArrestCounty);
                    SelectOption(QuickBookSuspectInfoComponent.LstArrestCounty, quickBookSuspectInfoData["ArrestCounty"]);
                }
            }
            else
            {
                Toggle(QuickBookSuspectInfoComponent.SuspectLocatedLater, quickBookSuspectInfoData["SuspectLocatedLater"]);

                if (quickBookSuspectInfoData["SuspectLocatedLater"].ToLower() == "true" || quickBookSuspectInfoData["SuspectLocatedLater"].ToLower() == "yes" || quickBookSuspectInfoData["SuspectLocatedLater"].ToLower() == "1")
                {
                    SendKeys(QuickBookSuspectInfoComponent.LocatedDate, quickBookSuspectInfoData["LocatedDate"]);
                    SendKeys(QuickBookSuspectInfoComponent.LocatedTime, quickBookSuspectInfoData["LocatedTime"]);
                    Toggle(QuickBookSuspectInfoComponent.SuspectWasArrested, quickBookSuspectInfoData["SuspectWasArrested"]);

                    if (quickBookSuspectInfoData["SuspectWasArrested"].ToLower() == "true" || quickBookSuspectInfoData["SuspectWasArrested"].ToLower() == "yes" || quickBookSuspectInfoData["SuspectWasArrested"].ToLower() == "1")
                    {
                        SendKeys(QuickBookSuspectInfoComponent.DateOfArrest, quickBookSuspectInfoData["DateOfArrest"]);
                        SendKeys(QuickBookSuspectInfoComponent.TimeOfArrest, quickBookSuspectInfoData["TimeOfArrest"]);
                        SendKeys(QuickBookSuspectInfoComponent.DateOfBooking, quickBookSuspectInfoData["DateOfBooking"]);
                        SendKeys(QuickBookSuspectInfoComponent.TimeOfBooking, quickBookSuspectInfoData["TimeOfBooking"]);
                        SendKeys(QuickBookSuspectInfoComponent.ArrestAddress1, quickBookSuspectInfoData["ArrestAddress1"]);
                        SendKeys(QuickBookSuspectInfoComponent.ArrestAddress2, quickBookSuspectInfoData["ArrestAddress2"]);
                        SendKeys(QuickBookSuspectInfoComponent.ArrestCity, quickBookSuspectInfoData["ArrestCity"]);
                        SendKeys(QuickBookSuspectInfoComponent.ArrestState, quickBookSuspectInfoData["ArrestState"]);
                        SendKeys(QuickBookSuspectInfoComponent.ArrestZipCode, quickBookSuspectInfoData["ArrestZipCode"]);
                        Click(QuickBookSuspectInfoComponent.ArrestCounty);
                        SelectOption(QuickBookSuspectInfoComponent.LstArrestCounty, quickBookSuspectInfoData["ArrestCounty"]);
                    }
                }
            }

            Click(QuickBookSuspectInfoComponent.SaveAndNext);
        }

        public void CreateQuickBookEvidence(Dictionary<string, string> quickBookEvidenceData)
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");

            Click(QuickBookEvidenceComponent.AddEvidence);

            Click(QuickBookEvidenceComponent.EvidenceType);
            SelectOption(QuickBookEvidenceComponent.LstEvidenceType, quickBookEvidenceData["EvidenceType"]);
            Click(QuickBookEvidenceComponent.EvidenceDisposition);
            SelectOption(QuickBookEvidenceComponent.LstEvidenceDisposition, quickBookEvidenceData["EvidenceDisposition"]);
            Toggle(QuickBookEvidenceComponent.CollectedFromPerson, quickBookEvidenceData["CollectedFromPerson"]);

            if (quickBookEvidenceData["CollectedFromPerson"].ToLower() == "yes" || quickBookEvidenceData["CollectedFromPerson"].ToLower() == "true" || quickBookEvidenceData["CollectedFromPerson"].ToLower() == "1")
            {
                if (!string.IsNullOrEmpty(quickBookEvidenceData["Person"]))
                {
                    Click(QuickBookEvidenceComponent.Person);
                    SelectOption(QuickBookEvidenceComponent.LstPerson, quickBookEvidenceData["Person"]);
                }

                Toggle(QuickBookEvidenceComponent.PersonNotListed, quickBookEvidenceData["PersonNotListed"]);

                if (quickBookEvidenceData["PersonNotListed"].ToLower() == "yes" || quickBookEvidenceData["PersonNotListed"].ToLower() == "true" || quickBookEvidenceData["PersonNotListed"].ToLower() == "1")
                {
                    SendKeys(QuickBookEvidenceComponent.PersonName, quickBookEvidenceData["PersonName"]);
                }
            }

            SendKeys(QuickBookEvidenceComponent.WhereFound, quickBookEvidenceData["WhereFound"]);
            SendKeys(QuickBookEvidenceComponent.EvidenceDescription, quickBookEvidenceData["EvidenceDescription"]);
            Toggle(QuickBookEvidenceComponent.WasSeized, quickBookEvidenceData["WasSeized"]);

            if (quickBookEvidenceData["EvidenceType"].ToLower() == "weapon")
            {
                Click(QuickBookEvidenceComponent.TypeOfWeapon);
                SelectOption(QuickBookEvidenceComponent.LstTypeOfWeapon, quickBookEvidenceData["TypeOfWeapon"]);

                if (quickBookEvidenceData["TypeOfWeapon"].ToLower() == "firearm (type not stated)" || quickBookEvidenceData["TypeOfWeapon"].ToLower() == "handgun" || quickBookEvidenceData["TypeOfWeapon"].ToLower() == "rifle" || quickBookEvidenceData["TypeOfWeapon"].ToLower() == "shotgun" || quickBookEvidenceData["TypeOfWeapon"].ToLower() == "other firearm")
                {
                    Click(QuickBookEvidenceComponent.WeaponManufacturer);
                    SelectOption(QuickBookEvidenceComponent.LstWeaponManufacturer, quickBookEvidenceData["WeaponManufacturer"]);
                    Click(QuickBookEvidenceComponent.WeaponCaliber);
                    SelectOption(QuickBookEvidenceComponent.LstWeaponCaliber, quickBookEvidenceData["WeaponCaliber"]);
                }
            }

            if (string.IsNullOrEmpty(quickBookEvidenceData["EvidenceSerialNumber"]))
            {
                SendKeys(QuickBookEvidenceComponent.EvidenceSerialNumber, "N/A");
            }
            else
            {
                SendKeys(QuickBookEvidenceComponent.EvidenceSerialNumber, quickBookEvidenceData["EvidenceSerialNumber"]);
            }

            if (!string.IsNullOrEmpty(quickBookEvidenceData["EvidenceCollectedBy"]))
            {
                SendKeys(QuickBookEvidenceComponent.EvidenceCollectedBy, quickBookEvidenceData["EvidenceCollectedBy"]);
            }

            Click(QuickBookEvidenceComponent.Save);
            Click(QuickBookEvidenceComponent.Next);
        }

        public void CreateQuickBookRiskAssessment(Dictionary<string, string> quickBookRiskAssessmentData)
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");

            Radio(QuickBookRiskAssessmentComponent.FamilyViolenceLikelyToOccur, quickBookRiskAssessmentData["FamilyViolenceLikelyToOccur"]);
            Radio(QuickBookRiskAssessmentComponent.UsedOrThreatenedWithWeapon, quickBookRiskAssessmentData["UsedOrThreatenedWithWeapon"]);
            Radio(QuickBookRiskAssessmentComponent.ThreatenedToKill, quickBookRiskAssessmentData["ThreatenedToKill"]);
            Radio(QuickBookRiskAssessmentComponent.SuspectHasGun, quickBookRiskAssessmentData["SuspectHasGun"]);

            if (quickBookRiskAssessmentData["SuspectHasGun"].ToLower() == "true" || quickBookRiskAssessmentData["SuspectHasGun"].ToLower() == "yes" || quickBookRiskAssessmentData["SuspectHasGun"].ToLower() == "1")
            {
                SendKeys(QuickBookRiskAssessmentComponent.GunDetailsInfo, quickBookRiskAssessmentData["GunDetailsInfo"]);
            }

            Radio(QuickBookRiskAssessmentComponent.Strangulation, quickBookRiskAssessmentData["Strangulation"]);
            Radio(QuickBookRiskAssessmentComponent.Violence, quickBookRiskAssessmentData["Violence"]);
            Radio(QuickBookRiskAssessmentComponent.Jealousy, quickBookRiskAssessmentData["Jealousy"]);
            Radio(QuickBookRiskAssessmentComponent.Controlling, quickBookRiskAssessmentData["Controlling"]);
            Radio(QuickBookRiskAssessmentComponent.ViolenceIncreased, quickBookRiskAssessmentData["ViolenceIncreased"]);

            if (quickBookRiskAssessmentData["ViolenceIncreased"].ToLower() == "true" || quickBookRiskAssessmentData["ViolenceIncreased"].ToLower() == "yes" || quickBookRiskAssessmentData["ViolenceIncreased"].ToLower() == "1")
            {
                SendKeys(QuickBookRiskAssessmentComponent.ViolenceIncreasedDescription, quickBookRiskAssessmentData["ViolenceIncreasedDescription"]);
            }

            Radio(QuickBookRiskAssessmentComponent.DestroyedItems, quickBookRiskAssessmentData["DestroyedItems"]);
            Radio(QuickBookRiskAssessmentComponent.HurtPets, quickBookRiskAssessmentData["HurtPets"]);
            Radio(QuickBookRiskAssessmentComponent.Unemployed, quickBookRiskAssessmentData["Unemployed"]);
            Radio(QuickBookRiskAssessmentComponent.Suicidal, quickBookRiskAssessmentData["Suicidal"]);
            Radio(QuickBookRiskAssessmentComponent.Spying, quickBookRiskAssessmentData["Spying"]);
            Radio(QuickBookRiskAssessmentComponent.ThreateningMessages, quickBookRiskAssessmentData["ThreateningMessages"]);
            Radio(QuickBookRiskAssessmentComponent.AlcoholAbuse, quickBookRiskAssessmentData["AlcoholAbuse"]);
            Radio(QuickBookRiskAssessmentComponent.DrugUse, quickBookRiskAssessmentData["DrugUse"]);
            Radio(QuickBookRiskAssessmentComponent.MightKillYou, quickBookRiskAssessmentData["MightKillYou"]);
            Radio(QuickBookRiskAssessmentComponent.ForcedSex, quickBookRiskAssessmentData["ForcedSex"]);
            Radio(QuickBookRiskAssessmentComponent.Separation, quickBookRiskAssessmentData["Separation"]);
            Radio(QuickBookRiskAssessmentComponent.RecentSeparation, quickBookRiskAssessmentData["RecentSeparation"]);
            Radio(QuickBookRiskAssessmentComponent.UnrelatedChild, quickBookRiskAssessmentData["UnrelatedChild"]);
            Radio(QuickBookRiskAssessmentComponent.PriorContacts, quickBookRiskAssessmentData["PriorContacts"]);
            Radio(QuickBookRiskAssessmentComponent.CourtAction, quickBookRiskAssessmentData["CourtAction"]);
            SendKeys(QuickBookRiskAssessmentComponent.AdditionalInfo, quickBookRiskAssessmentData["AdditionalInfo"]);
            SendKeys(QuickBookRiskAssessmentComponent.PriorProtectiveOrder, quickBookRiskAssessmentData["PriorProtectiveOrder"]);
            SendKeys(QuickBookRiskAssessmentComponent.DateTimeOfAssessment, quickBookRiskAssessmentData["DateTimeOfAssessment"]);

            Click(QuickBookRiskAssessmentComponent.SaveAndNext);
        }
    }
}
                                                                                                                                                                                                                                                                                                                                      