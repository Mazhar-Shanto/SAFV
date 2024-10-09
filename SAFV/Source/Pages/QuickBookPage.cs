
using OpenQA.Selenium;
using SAFV.Drivers;
using SAFV.Source.Components;
using SAFV.Source.Components.CreateIncident;
using SAFV.Source.Components.CreateIncident.People.Suspect;
using SAFV.Source.Components.QuickBook;
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

        public string CreateNewQuickBookIncident(Dictionary<string, string> quickBookData, string count, string mainCase)
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");

            string quickBookCaseNumber = quickBookData["IncidentCaseNumber"] + count;

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
    }
}
