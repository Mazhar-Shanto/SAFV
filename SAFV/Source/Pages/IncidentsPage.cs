using OpenQA.Selenium;
using SAFV.Drivers;
using SAFV.Source.Components;
using SAFV.Source.Components.CreateIncident;

namespace SAFV.Source.Pages
{
    public class IncidentsPage : BasePage
    {
        private IWebDriver _driver;


        public IncidentsPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;

        }

        public void GoToIncidentPage()
        {
            Console.WriteLine("Incident -- " + MenuComponent.Incidents.Text);
            Click(MenuComponent.Incidents);
            Click(MenuComponent.CreateNewIncident);
        }

        public void GoToPeoplePage()
        {
            Console.WriteLine("Incident -- " + MenuComponent.Incidents.Text);
            Click(IncidentMenuComponent.People);
        }

        public void CreateIncident(Dictionary<string, string> incidentData)
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");

            SendKeys(CreateIncidentComponent.ReportDate, incidentData["ReportDate"]);
            SendKeys(CreateIncidentComponent.IncidentCaseNumber, incidentData["IncidentCaseNumber"]);
            Select(CreateIncidentComponent.IncidentType, incidentData["IncidentType"]);
            Toggle(CreateIncidentComponent.ConfidentialMode, incidentData["ConfidentialMode"]);
            Click(CreateIncidentComponent.CaseType);
            SelectOption(CreateIncidentComponent.LstCaseType, incidentData["CaseType"]);

            Click(CreateIncidentComponent.CreateButton);
        }

        public void CreateIncidentInfo(Dictionary<string, string> incidentInfoData)
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");

            Click(IncidentMenuComponent.Incident);
            SendKeys(IncidentInfoComponent.District, incidentInfoData["District"]);
            Toggle(IncidentInfoComponent.ChildrenInvolved, incidentInfoData["ChildrenInvolved"]);

            if (incidentInfoData["ChildrenInvolved"].ToLower() == "yes" || incidentInfoData["ChildrenInvolved"].ToLower() == "true" || incidentInfoData["ChildrenInvolved"].ToLower() == "1")
            {
                Toggle(IncidentInfoComponent.RequiresCpsNotification, incidentInfoData["RequiresCpsNotification"]);
                Toggle(IncidentInfoComponent.CpsHaveBeenCalled, incidentInfoData["CpsHaveBeenCalled"]);
                SendKeys(IncidentInfoComponent.CpsNumber, incidentInfoData["CpsNumber"]);
                SendKeys(IncidentInfoComponent.CpsNotifedDate, incidentInfoData["CpsNotifedAt"]);
                SendKeys(IncidentInfoComponent.CpsSafetyIssues, incidentInfoData["CpsSafetyIssues"]);
            }

            SendKeys(IncidentInfoComponent.OfficerPrimaryConcern, incidentInfoData["OfficerPrimaryConcern"]);
            SendKeys(IncidentInfoComponent.SuspectedMethManufacture, incidentInfoData["SuspectedMethManufacture"]);
            SendKeys(IncidentInfoComponent.SensitiveIssues, incidentInfoData["SensitiveIssues"]);
            Toggle(IncidentInfoComponent.Covid19Exposure, incidentInfoData["Covid19Exposure"]);
            Click(IncidentInfoComponent.HowPoliceContacted);
            SelectOption(IncidentInfoComponent.LstHowPoliceContacted, incidentInfoData["HowPoliceContacted"]);
            Click(IncidentInfoComponent.WhatWasBeingReported);
            SelectOption(IncidentInfoComponent.LstWhatWasBeingReported, incidentInfoData["WhatWasBeingReported"]);
            SendKeys(IncidentInfoComponent.DispatchedDate, incidentInfoData["DispatchedDate"]);
            SendKeys(IncidentInfoComponent.DispatchedTime, incidentInfoData["DispatchedTime"]);
        }

        public void CreatePeople(Dictionary<string, string> peopleData)
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");

            Click(IncidentMenuComponent.People);
            Click(PeopleComponent.AddPerson);
            SendKeys(PeopleComponent.FirstName, peopleData["FirstName"]);
            SendKeys(PeopleComponent.LastName, peopleData["LastName"]);
            SendKeys(PeopleComponent.MiddleName, peopleData["MiddleName"]);
            Toggle(PeopleComponent.Alias, peopleData["Alias"]);
            if (peopleData["Alias"].ToLower() == "true" || peopleData["Alias"].ToLower() == "yes" || peopleData["Alias"].ToLower() == "1")
            {
                SendKeys(PeopleComponent.AliasDescription, peopleData["AliasDescription"]);
            }

            Toggle(PeopleComponent.Victim, peopleData["Victim"]);
            Toggle(PeopleComponent.Suspect, peopleData["Suspect"]);
            Toggle(PeopleComponent.Witness, peopleData["Witness"]);
            Toggle(PeopleComponent.OtherNotInvolved, peopleData["OtherNotInvolved"]);

            if (peopleData["Victim"].ToLower() == "true" || peopleData["Victim"].ToLower() == "yes" || peopleData["Victim"].ToLower() == "1")
            {
                Toggle(PeopleComponent.VictimWouldLikeToUsePseudonym, peopleData["VictimWouldLikeToUsePseudonym"]);

                if (peopleData["VictimWouldLikeToUsePseudonym"].ToLower() == "true" || peopleData["VictimWouldLikeToUsePseudonym"].ToLower() == "yes" || peopleData["VictimWouldLikeToUsePseudonym"].ToLower() == "1")
                {
                    Click(PeopleComponent.ConfirmPseudonym);

                    SendKeys(PeopleComponent.VictimRealFirstName, peopleData["VictimRealFirstName"]);
                    SendKeys(PeopleComponent.VictimRealLastName, peopleData["VictimRealLastName"]);
                    SendKeys(PeopleComponent.VictimRealMiddleName, peopleData["VictimRealMiddleName"]);
                }
            }

            if (peopleData["OtherNotInvolved"].ToLower() == "true" || peopleData["OtherNotInvolved"].ToLower() == "yes" || peopleData["OtherNotInvolved"].ToLower() == "1")
            {
                Toggle(PeopleComponent.WasPresent, peopleData["WasPresent"]);
            }

            Toggle(PeopleComponent.IsUnknownPerson, peopleData["IsUnknownPerson"]);
            Click(PeopleComponent.Race);
            SelectOption(PeopleComponent.LstRace, peopleData["Race"]);
            Click(PeopleComponent.Sex);
            SelectOption(PeopleComponent.LstSex, peopleData["Sex"]);

            if (peopleData["IsUnknownPerson"].ToLower() == "true" || peopleData["IsUnknownPerson"].ToLower() == "yes" || peopleData["IsUnknownPerson"].ToLower() == "1")
            {
                SendKeys(PeopleComponent.Age, peopleData["Age"]);
            }
            else
            {
                SendKeys(PeopleComponent.DateOfBirth, peopleData["DateOfBirth"]);
            }

            Click(PeopleComponent.Save);

            // more info
            Click(PeopleComponent.Ethnicity);
            SelectOption(PeopleComponent.LstEthnicity, peopleData["Ethnicity"]);
            Click(PeopleComponent.EyeColor);
            SelectOption(PeopleComponent.LstEyeColor, peopleData["EyeColor"]);
            Click(PeopleComponent.HairColor);
            SelectOption(PeopleComponent.LstHairColor, peopleData["HairColor"]);
            SendKeys(PeopleComponent.HeightFeet, peopleData["HeightFeet"]);
            SendKeys(PeopleComponent.HeightInches, peopleData["HeightInches"]);
            SendKeys(PeopleComponent.Weight, peopleData["Weight"]);

            if (!String.IsNullOrEmpty(peopleData["Ssn"]))
            {
                Click(PeopleComponent.EnableSsnField);
                SendKeys(PeopleComponent.SsnField, peopleData["Ssn"]);
                Click(PeopleComponent.SaveSsn);
            }

            Click(PeopleComponent.PrimaryLanguage);
            SelectOption(PeopleComponent.LstPrimaryLanguage, peopleData["PrimaryLanguage"]);
            Click(PeopleComponent.PersonIdType);
            SelectOption(PeopleComponent.LstPersonIdType, peopleData["PersonIdType"]);
            SendKeys(PeopleComponent.IdNumber, peopleData["IdNumber"]);
            SendKeys(PeopleComponent.IdState, peopleData["IdState"]);
            SendKeys(PeopleComponent.IdExpirationDate, peopleData["IdExpirationDate"]);
            SendKeys(PeopleComponent.Email, peopleData["Email"]);

            if (peopleData["Victim"].ToLower() == "true" || peopleData["Victim"].ToLower() == "yes" || peopleData["Victim"].ToLower() == "1")
            {
                Toggle(PeopleComponent.SafeToContactViaEmail, peopleData["SafeToContactViaEmail"]);
            }

            SendKeys(PeopleComponent.Occupation, peopleData["Occupation"]);
            SendKeys(PeopleComponent.PlaceOfBirth, peopleData["PlaceOfBirth"]);
            SendKeys(PeopleComponent.NameOfEmployer, peopleData["NameOfEmployer"]);
            SendKeys(PeopleComponent.ScarsMarks, peopleData["ScarsMarks"]);
            SendKeys(PeopleComponent.TxSid, peopleData["TxSid"]);
            SendKeys(PeopleComponent.SpecialNeeds, peopleData["SpecialNeeds"]);
            Toggle(PeopleComponent.HandcuffedPriorToArrest, peopleData["HandcuffedPriorToArrest"]);

            if (peopleData["HandcuffedPriorToArrest"].ToLower() == "true" || peopleData["HandcuffedPriorToArrest"].ToLower() == "yes" || peopleData["HandcuffedPriorToArrest"].ToLower() == "1")
            {
                SendKeys(PeopleComponent.HandcuffReason, peopleData["HandcuffReason"]);
            }

            Toggle(PeopleComponent.IsPersonChild, peopleData["IsPersonChild"]);

            if (peopleData["IsPersonChild"].ToLower() == "true" || peopleData["IsPersonChild"].ToLower() == "yes" || peopleData["IsPersonChild"].ToLower() == "1")
            {
                Toggle(PeopleComponent.WasThisChildPresent, peopleData["WasThisChildPresent"]);
                Toggle(PeopleComponent.DidTheyAttemptToIntervene, peopleData["DidTheyAttemptToIntervene"]);
                Click(PeopleComponent.PrimaryCaretakerOfChild);
                Click(PeopleComponent.LstPrimaryCaretakerOfChild);
                //Click(PeopleComponent.LstPrimaryCaretakerOfChild, peopleData["PrimaryCaretakerOfChild"]);
            }

            Toggle(PeopleComponent.PersonGivenMirandaWarning, peopleData["PersonGivenMirandaWarning"]);

            if (peopleData["PersonGivenMirandaWarning"].ToLower() == "true" || peopleData["PersonGivenMirandaWarning"].ToLower() == "yes" || peopleData["PersonGivenMirandaWarning"].ToLower() == "1")
            {
                SendKeys(PeopleComponent.MirandaWarningDate, peopleData["MirandaWarningDate"]);
                SendKeys(PeopleComponent.MirandaWarningTime, peopleData["MirandaWarningTime"]);
                SendKeys(PeopleComponent.StatementsMadeAfterMiranda, peopleData["StatementsMadeAfterMiranda"]);
            }

            Toggle(PeopleComponent.IsPersonElderly, peopleData["IsPersonElderly"]);
            Toggle(PeopleComponent.IsPersonDisabled, peopleData["IsPersonDisabled"]);

            if (!String.IsNullOrEmpty(peopleData["PhoneNumber"]))
            {
                Click(PeopleComponent.AddNewPhoneNumber);
                Click(PeopleComponent.PhoneType);
                SelectOption(PeopleComponent.LstPhoneType, peopleData["PhoneType"]);
                SendKeys(PeopleComponent.PhoneNumber, peopleData["PhoneNumber"]);
                Toggle(PeopleComponent.PrimaryContact, peopleData["PrimaryContact"]);
                Click(PeopleComponent.SavePhoneNumber);
            }

            if (!String.IsNullOrEmpty(peopleData["Address1"]))
            {
                Click(PeopleComponent.AddNewAddress);
                Click(PeopleComponent.AddressGroup);
                SelectOption(PeopleComponent.LstAddressGroup, peopleData["AddressGroup"]);
                SendKeys(PeopleComponent.Address1, peopleData["Address1"]);
                SendKeys(PeopleComponent.Address2, peopleData["Address2"]);
                SendKeys(PeopleComponent.City, peopleData["City"]);
                SendKeys(PeopleComponent.State, peopleData["State"]);
                Click(PeopleComponent.County);
                SelectOption(PeopleComponent.LstCounty, peopleData["County"]);
                SendKeys(PeopleComponent.ZipCode, peopleData["ZipCode"]);
            }

            Click(PeopleComponent.SavePeople);
        }
    }
}
