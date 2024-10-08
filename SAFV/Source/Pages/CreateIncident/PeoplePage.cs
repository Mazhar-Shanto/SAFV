using OpenQA.Selenium;
using SAFV.Drivers;
using SAFV.Source.Components;
using SAFV.Source.Components.CreateIncident;
using SAFV.Source.Components.CreateIncident.People;
using SAFV.Source.Components.CreateIncident.People.Suspect;

namespace SAFV.Source.Pages.CreateIncident
{
    public class PeoplePage : IncidentsPage
    {
        private IWebDriver _driver;


        public PeoplePage(IWebDriver driver) : base(driver)
        {
            _driver = driver;

        }

        public void GoToPeoplePage()
        {
            Console.WriteLine("Incident -- " + MenuComponent.Incidents.Text);
            Click(IncidentMenuComponent.People);
        }

        public void CreatePeopleFromMaster(Dictionary<string, string> searchData)
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");

            Click(IncidentMenuComponent.People);
            Click(PeopleComponent.AddPerson);

            //VerifyPageLabel(PeopleComponent.AddPerson, PeopleComponent.TabTitle.Text.ToLower(), "basic info");

            Click(PeopleComponent.SearchFromMaster);

            if (searchData["SearchField"].ToLower() == "first name")
            {
                SendKeys(PeopleComponent.SearchFirstName, searchData["SearchText"]);
            }
            else if (searchData["SearchField"].ToLower() == "last name")
            {
                SendKeys(PeopleComponent.SearchLastName, searchData["SearchText"]);
            }
            else if (searchData["SearchField"].ToLower() == "middle name")
            {
                SendKeys(PeopleComponent.SearchMiddleName, searchData["SearchText"]);
            }
            else if (searchData["SearchField"].ToLower() == "palce of birth")
            {
                SendKeys(PeopleComponent.SearchPlaceOfBirth, searchData["SearchText"]);
            }
            else if (searchData["SearchField"].ToLower() == "place of employment")
            {
                SendKeys(PeopleComponent.SearchPlaceOfEmployment, searchData["SearchText"]);
            }
            else if (searchData["SearchField"].ToLower() == "ssn")
            {
                SendKeys(PeopleComponent.SearchSsn, searchData["SearchText"]);
            }
            else if (searchData["SearchField"].ToLower() == "id")
            {
                Click(PeopleComponent.SearchPersonIdType);
                SelectOption(PeopleComponent.LstSearchPersonIdType, searchData["PersonIdType"]);
                SendKeys(PeopleComponent.SearchId, searchData["SearchText"]);
            }

            Click(PeopleComponent.SearchButton);
            Click(PeopleComponent.LoadFromMaster);

            if (searchData["PersonType"].ToLower() == "witness")
            {
                Toggle(PeopleComponent.Witness, "1");
            }
            else if (searchData["PersonType"].ToLower() == "victim")
            {
                Toggle(PeopleComponent.Victim, "1");
            }
            else if (searchData["PersonType"].ToLower() == "suspect")
            {
                Toggle(PeopleComponent.Suspect, "1");
            }
            else if (searchData["PersonType"].ToLower() == "other")
            {
                Toggle(PeopleComponent.OtherNotInvolved, "1");
            }

            Click(PeopleComponent.SaveAndShowMore);
        }

        public void CreatePeople(Dictionary<string, string> peopleData)
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");

            Click(IncidentMenuComponent.People);
            Click(PeopleComponent.AddPerson);

            //VerifyPageLabel(PeopleComponent.AddPerson, PeopleComponent.TabTitle.Text.ToLower(), "basic info");

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

            Click(PeopleComponent.SaveAndShowMore);
        }

        public void CreatePeopleMoreInfo(Dictionary<string, string> peopleData)
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");

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

            /*if (!String.IsNullOrEmpty(peopleData["Address1"]))
            {
                Click(PeopleComponent.AddNewAddress);
                //Click(PeopleComponent.AddressGroup);
                SelectOption(PeopleComponent.LstAddressGroup, peopleData["AddressGroup"]);
                SendKeys(PeopleComponent.Address1, peopleData["Address1"]);
                SendKeys(PeopleComponent.Address2, peopleData["Address2"]);
                SendKeys(PeopleComponent.City, peopleData["City"]);
                SendKeys(PeopleComponent.State, peopleData["State"]);
                Click(PeopleComponent.County);
                SelectOption(PeopleComponent.LstCounty, peopleData["County"]);
                SendKeys(PeopleComponent.ZipCode, peopleData["ZipCode"]);
                Click(PeopleComponent.SaveAddress);
            }*/

            if (peopleData["SyncToMaster"].ToLower() == "true" || peopleData["SyncToMaster"].ToLower() == "yes" || peopleData["SyncToMaster"].ToLower() == "1")
            {
                Click(PeopleComponent.SyncToMaster);
            }
            else
            {
                Click(PeopleComponent.NoSyncToMaster);
            }

            Click(PeopleComponent.SavePeople);
        }

        public void CreatePeopleInterview(Dictionary<string, string> peopleInterviewData)
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");

            Click(PeopleMenuComponent.Interview);

            VerifyPageLabel(PeopleMenuComponent.Interview, PeopleComponent.TabTitle.Text.ToLower(), "interview");

            Toggle(InterviewComponent.PersonWasInterviewed, peopleInterviewData["PersonWasInterviewed"]);

            if (peopleInterviewData["PersonWasInterviewed"].ToLower() == "true" || peopleInterviewData["PersonWasInterviewed"].ToLower() == "yes" || peopleInterviewData["PersonWasInterviewed"].ToLower() == "1")
            {
                Toggle(InterviewComponent.PersonInterviewedOnAudioVideo, peopleInterviewData["PersonInterviewedOnAudioVideo"]);
                Toggle(InterviewComponent.PersonInterviewedOnCustody, peopleInterviewData["PersonInterviewedOnCustody"]);
                Toggle(InterviewComponent.PersonInterviewedByAnotherOfficer, peopleInterviewData["PersonInterviewedByAnotherOfficer"]);
                SendKeys(InterviewComponent.InterviewerName, peopleInterviewData["InterviewerName"]);
                SendKeys(InterviewComponent.InitialContact, peopleInterviewData["InitialContact"]);
                SendKeys(InterviewComponent.DescribeEvents, peopleInterviewData["DescribeEvents"]);
                SendKeys(InterviewComponent.IntervieweeRole, peopleInterviewData["IntervieweeRole"]);
                Toggle(InterviewComponent.UseOfForce, peopleInterviewData["UseOfForce"]);

                if (peopleInterviewData["UseOfForce"].ToLower() == "true" || peopleInterviewData["UseOfForce"].ToLower() == "yes" || peopleInterviewData["UseOfForce"].ToLower() == "1")
                {
                    SendKeys(InterviewComponent.UseOfForceDescription, peopleInterviewData["UseOfForceDescription"]);
                }

                SendKeys(InterviewComponent.ReportedInjuries, peopleInterviewData["ReportedInjuries"]);
                Toggle(InterviewComponent.DeEscalation, peopleInterviewData["DeEscalation"]);

                if (peopleInterviewData["DeEscalation"].ToLower() == "true" || peopleInterviewData["DeEscalation"].ToLower() == "yes" || peopleInterviewData["DeEscalation"].ToLower() == "1")
                {
                    SendKeys(InterviewComponent.DeEscalationDescription, peopleInterviewData["DeEscalationDescription"]);
                }

                Toggle(InterviewComponent.IndicationOfViolence, peopleInterviewData["IndicationOfViolence"]);

                if (peopleInterviewData["IndicationOfViolence"].ToLower() == "true" || peopleInterviewData["IndicationOfViolence"].ToLower() == "yes" || peopleInterviewData["IndicationOfViolence"].ToLower() == "1")
                {
                    SendKeys(InterviewComponent.IndicationOfViolenceDescription, peopleInterviewData["IndicationOfViolenceDescription"]);
                }

                SendKeys(InterviewComponent.InjuriesToOthers, peopleInterviewData["InjuriesToOthers"]);
                Toggle(InterviewComponent.Admission, peopleInterviewData["Admission"]);
            }
            else
            {
                SendKeys(InterviewComponent.WhyNotInterviewed, peopleInterviewData["WhyNotInterviewed"]);
            }

            Click(InterviewComponent.SaveInterview);
        }

        public void CreateSuspectInfo(Dictionary<string, string> suspectData)
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");

            Click(PeopleMenuComponent.Suspect);

            VerifyPageLabel(PeopleMenuComponent.Suspect, PeopleComponent.TabTitle.Text.ToLower(), "suspect");

            Toggle(SuspectComponent.SuspectWasOnScene, suspectData["SuspectWasOnScene"]);

            if (suspectData["SuspectWasOnScene"].ToLower() == "true" || suspectData["SuspectWasOnScene"].ToLower() == "yes" || suspectData["SuspectWasOnScene"].ToLower() == "1")
            {

                Toggle(SuspectComponent.SuspectWasArrested, suspectData["SuspectWasArrested"]);

                if (suspectData["SuspectWasArrested"].ToLower() == "true" || suspectData["SuspectWasArrested"].ToLower() == "yes" || suspectData["SuspectWasArrested"].ToLower() == "1")
                {
                    SendKeys(SuspectComponent.DateOfArrest, suspectData["DateOfArrest"]);
                    SendKeys(SuspectComponent.TimeOfArrest, suspectData["TimeOfArrest"]);
                    SendKeys(SuspectComponent.DateOfBooking, suspectData["DateOfBooking"]);
                    SendKeys(SuspectComponent.TimeOfBooking, suspectData["TimeOfBooking"]);
                    SendKeys(SuspectComponent.ArrestAddress1, suspectData["ArrestAddress1"]);
                    SendKeys(SuspectComponent.ArrestAddress2, suspectData["ArrestAddress2"]);
                    SendKeys(SuspectComponent.ArrestCity, suspectData["ArrestCity"]);
                    SendKeys(SuspectComponent.ArrestState, suspectData["ArrestState"]);
                    SendKeys(SuspectComponent.ArrestZipCode, suspectData["ArrestZipCode"]);
                    Click(SuspectComponent.ArrestCounty);
                    SelectOption(SuspectComponent.LstArrestCounty, suspectData["ArrestCounty"]);
                }
            }
            else
            {
                Toggle(SuspectComponent.SuspectLocatedLater, suspectData["SuspectLocatedLater"]);

                if (suspectData["SuspectLocatedLater"].ToLower() == "true" || suspectData["SuspectLocatedLater"].ToLower() == "yes" || suspectData["SuspectLocatedLater"].ToLower() == "1")
                {
                    SendKeys(SuspectComponent.LocatedDate, suspectData["LocatedDate"]);
                    SendKeys(SuspectComponent.LocatedTime, suspectData["LocatedTime"]);
                    Toggle(SuspectComponent.SuspectWasArrested, suspectData["SuspectWasArrested"]);

                    if (suspectData["SuspectWasArrested"].ToLower() == "true" || suspectData["SuspectWasArrested"].ToLower() == "yes" || suspectData["SuspectWasArrested"].ToLower() == "1")
                    {
                        SendKeys(SuspectComponent.DateOfArrest, suspectData["DateOfArrest"]);
                        SendKeys(SuspectComponent.TimeOfArrest, suspectData["TimeOfArrest"]);
                        SendKeys(SuspectComponent.DateOfBooking, suspectData["DateOfBooking"]);
                        SendKeys(SuspectComponent.TimeOfBooking, suspectData["TimeOfBooking"]);
                        SendKeys(SuspectComponent.ArrestAddress1, suspectData["ArrestAddress1"]);
                        SendKeys(SuspectComponent.ArrestAddress2, suspectData["ArrestAddress2"]);
                        SendKeys(SuspectComponent.ArrestCity, suspectData["ArrestCity"]);
                        SendKeys(SuspectComponent.ArrestState, suspectData["ArrestState"]);
                        SendKeys(SuspectComponent.ArrestZipCode, suspectData["ArrestZipCode"]);
                        Click(SuspectComponent.ArrestCounty);
                        SelectOption(SuspectComponent.LstArrestCounty, suspectData["ArrestCounty"]);
                    }
                }
            }

            Toggle(SuspectComponent.ConcealedHandgunLicenseHolder, suspectData["ConcealedHandgunLicenseHolder"]);
            Toggle(SuspectComponent.MentalHealthIssues, suspectData["MentalHealthIssues"]);

            if (suspectData["MentalHealthIssues"].ToLower() == "true" || suspectData["MentalHealthIssues"].ToLower() == "yes" || suspectData["MentalHealthIssues"].ToLower() == "1")
            {
                SendKeys(SuspectComponent.MentalHealthDescription, suspectData["MentalHealthDescription"]);
            }

            Toggle(SuspectComponent.PriorProtectiveOrder, suspectData["PriorProtectiveOrder"]);

            if (suspectData["PriorProtectiveOrder"].ToLower() == "true" || suspectData["PriorProtectiveOrder"].ToLower() == "yes" || suspectData["PriorProtectiveOrder"].ToLower() == "1")
            {
                SendKeys(SuspectComponent.ProtectedPersons, suspectData["ProtectedPersons"]);
            }

            Toggle(SuspectComponent.OnProbation, suspectData["OnProbation"]);

            if (suspectData["OnProbation"].ToLower() == "true" || suspectData["OnProbation"].ToLower() == "yes" || suspectData["OnProbation"].ToLower() == "1")
            {
                SendKeys(SuspectComponent.ProbationOfficer, suspectData["ProbationOfficer"]);
                Click(SuspectComponent.ProbationCounty);
                SelectOption(SuspectComponent.LstProbationCounty, suspectData["ProbationCounty"]);
            }

            Toggle(SuspectComponent.UnreportedIncidentsOfFv, suspectData["UnreportedIncidentsOfFv"]);
            Toggle(SuspectComponent.AttemptedContact, suspectData["AttemptedContact"]);

            if (suspectData["AttemptedContact"].ToLower() == "true" || suspectData["AttemptedContact"].ToLower() == "yes" || suspectData["AttemptedContact"].ToLower() == "1")
            {
                Toggle(SuspectComponent.CalledSuspectCellPhone, suspectData["CalledSuspectCellPhone"]);
                Toggle(SuspectComponent.CalledFriendFamilyWhereSuspectFledTo, suspectData["CalledFriendFamilyWhereSuspectFledTo"]);
                Toggle(SuspectComponent.WentToLocationSuspectWas, suspectData["WentToLocationSuspectWas"]);
                Toggle(SuspectComponent.OfficerCanvassedArea, suspectData["OfficerCanvassedArea"]);
                Toggle(SuspectComponent.DidYouLeaveMessagesForSuspectToCallBack, suspectData["DidYouLeaveMessagesForSuspectToCallBack"]);
                Toggle(SuspectComponent.DidSuspectRefuseToTalk, suspectData["DidSuspectRefuseToTalk"]);
            }

            Toggle(SuspectComponent.PriorToArrestPersonResisted, suspectData["PriorToArrestPersonResisted"]);

            if (suspectData["PriorToArrestPersonResisted"].ToLower() == "true" || suspectData["PriorToArrestPersonResisted"].ToLower() == "yes" || suspectData["PriorToArrestPersonResisted"].ToLower() == "1")
            {
                Toggle(SuspectComponent.VerbalThreat, suspectData["VerbalThreat"]);
                Toggle(SuspectComponent.Passive, suspectData["Passive"]);
                Toggle(SuspectComponent.Physical, suspectData["Physical"]);
            }

            Click(SuspectComponent.SaveSuspectInfo);
        }

        public void CreateMedicalEms(Dictionary<string, string> medicalData)
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");
            Thread.Sleep(10000);
            Click(PeopleMenuComponent.MedicalEms);

            VerifyPageLabel(PeopleMenuComponent.MedicalEms, PeopleComponent.TabTitle.Text.ToLower(), "medical");

            Toggle(MedicalEmsComponent.DidPersonComplainOfInjuries, medicalData["DidPersonComplainOfInjuries"]);
            Toggle(MedicalEmsComponent.DidYouObserveInjuries, medicalData["DidYouObserveInjuries"]);
            Toggle(MedicalEmsComponent.IsPersonPregnant, medicalData["IsPersonPregnant"]);

            if (medicalData["IsPersonPregnant"].ToLower() == "true" || medicalData["IsPersonPregnant"].ToLower() == "yes" || medicalData["IsPersonPregnant"].ToLower() == "1")
            {
                SendKeys(MedicalEmsComponent.NumberOfWeeks, medicalData["NumberOfWeeks"]);
                Toggle(MedicalEmsComponent.OfficerCouldObservePersonPregnant, medicalData["OfficerCouldObservePersonPregnant"]);
            }

            Toggle(MedicalEmsComponent.MedicalTreatmentOfferedButRefused, medicalData["MedicalTreatmentOfferedButRefused"]);
            Toggle(MedicalEmsComponent.PersonSeekingTheirOwnTreatment, medicalData["PersonSeekingTheirOwnTreatment"]);

            if (medicalData["PersonSeekingTheirOwnTreatment"].ToLower() == "true" || medicalData["PersonSeekingTheirOwnTreatment"].ToLower() == "yes" || medicalData["PersonSeekingTheirOwnTreatment"].ToLower() == "1")
            {
                SendKeys(MedicalEmsComponent.DrWhoWillProvideTreatment, medicalData["DrWhoWillProvideTreatment"]);
            }

            Toggle(MedicalEmsComponent.FirstAidGivenAtScene, medicalData["FirstAidGivenAtScene"]);

            if (medicalData["FirstAidGivenAtScene"].ToLower() == "true" || medicalData["FirstAidGivenAtScene"].ToLower() == "yes" || medicalData["FirstAidGivenAtScene"].ToLower() == "1")
            {
                SendKeys(MedicalEmsComponent.FirstAidGivenBy, medicalData["FirstAidGivenBy"]);
            }

            Toggle(MedicalEmsComponent.EmsParamedicsFire, medicalData["EmsParamedicsFire"]);

            if (medicalData["EmsParamedicsFire"].ToLower() == "true" || medicalData["EmsParamedicsFire"].ToLower() == "yes" || medicalData["EmsParamedicsFire"].ToLower() == "1")
            {
                SendKeys(MedicalEmsComponent.EmsUnit, medicalData["EmsUnit"]);
            }

            Toggle(MedicalEmsComponent.EmsUnitTransportedPersonToHospital, medicalData["EmsUnitTransportedPersonToHospital"]);

            if (medicalData["EmsUnitTransportedPersonToHospital"].ToLower() == "true" || medicalData["EmsUnitTransportedPersonToHospital"].ToLower() == "yes" || medicalData["EmsUnitTransportedPersonToHospital"].ToLower() == "1")
            {
                SendKeys(MedicalEmsComponent.TransportedTo, medicalData["TransportedTo"]);
            }

            Click(MedicalEmsComponent.SaveMedicalEms);
        }

        public void CreateDemeanorInfo(Dictionary<string, string> demeanorData)
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");

            Click(PeopleMenuComponent.Demeanor);

            VerifyPageLabel(PeopleMenuComponent.Demeanor, PeopleComponent.TabTitle.Text.ToLower(), "demeanor");

            // Appearance
            Toggle(DemeanorComponent.AppearanceBloody, demeanorData["AppearanceBloody"]);
            Toggle(DemeanorComponent.AppearanceSmearedMakeup, demeanorData["AppearanceSmearedMakeup"]);
            Toggle(DemeanorComponent.AppearanceSoiledSweatStained, demeanorData["AppearanceSoiledSweatStained"]);
            Toggle(DemeanorComponent.AppearanceTangledMessyHair, demeanorData["AppearanceTangledMessyHair"]);
            Toggle(DemeanorComponent.AppearanceTornPulledClothing, demeanorData["AppearanceTornPulledClothing"]);
            Toggle(DemeanorComponent.AppearanceOther, demeanorData["AppearanceOther"]);

            if (demeanorData["AppearanceOther"].ToLower() == "yes" || demeanorData["AppearanceOther"].ToLower() == "true" || demeanorData["AppearanceOther"].ToLower() == "1")
            {
                //SendKeys(DemeanorComponent.AppearanceOtherDescription, demeanorData["AppearanceOtherDescription"]);
            }

            // Demeanor
            Toggle(DemeanorComponent.DemeanorAfraid, demeanorData["DemeanorAfraid"]);
            Toggle(DemeanorComponent.DemeanorAngry, demeanorData["DemeanorAngry"]);
            Toggle(DemeanorComponent.DemeanorApologetic, demeanorData["DemeanorApologetic"]);
            Toggle(DemeanorComponent.DemeanorBelligerent, demeanorData["DemeanorBelligerent"]);
            Toggle(DemeanorComponent.DemeanorCalm, demeanorData["DemeanorCalm"]);
            Toggle(DemeanorComponent.DemeanorCatatonic, demeanorData["DemeanorCatatonic"]);
            Toggle(DemeanorComponent.DemeanorCrying, demeanorData["DemeanorCrying"]);
            Toggle(DemeanorComponent.DemeanorDistraught, demeanorData["DemeanorDistraught"]);
            Toggle(DemeanorComponent.DemeanorFlatAffect, demeanorData["DemeanorFlatAffect"]);
            Toggle(DemeanorComponent.DemeanorHysterical, demeanorData["DemeanorHysterical"]);
            Toggle(DemeanorComponent.DemeanorHandsBodyShaking, demeanorData["DemeanorHandsBodyShaking"]);
            Toggle(DemeanorComponent.DemeanorIndifferent, demeanorData["DemeanorIndifferent"]);
            Toggle(DemeanorComponent.DemeanorIntoxicated, demeanorData["DemeanorIntoxicated"]);
            Toggle(DemeanorComponent.DemeanorIrrational, demeanorData["DemeanorIrrational"]);
            Toggle(DemeanorComponent.DemeanorNervous, demeanorData["DemeanorNervous"]);
            Toggle(DemeanorComponent.DemeanorTrembling, demeanorData["DemeanorTrembling"]);
            Toggle(DemeanorComponent.DemeanorOther, demeanorData["DemeanorOther"]);

            if (demeanorData["DemeanorOther"].ToLower() == "yes" || demeanorData["DemeanorOther"].ToLower() == "true" || demeanorData["DemeanorOther"].ToLower() == "1")
            {
                //SendKeys(DemeanorComponent.DemeanorOtherDescription, demeanorData["DemeanorOtherDescription"]);
            }

            // Speech
            Toggle(DemeanorComponent.SpeechAngry, demeanorData["SpeechAngry"]);
            Toggle(DemeanorComponent.SpeechOutOfBreath, demeanorData["SpeechOutOfBreath"]);
            Toggle(DemeanorComponent.SpeechExcitedFast, demeanorData["SpeechExcitedFast"]);
            Toggle(DemeanorComponent.SpeechCryingSobbing, demeanorData["SpeechCryingSobbing"]);
            Toggle(DemeanorComponent.SpeechYelling, demeanorData["SpeechYelling"]);
            Toggle(DemeanorComponent.SpeechBelligerent, demeanorData["SpeechBelligerent"]);
            Toggle(DemeanorComponent.SpeechRepetitive, demeanorData["SpeechRepetitive"]);
            Toggle(DemeanorComponent.SpeechIncoherent, demeanorData["SpeechIncoherent"]);
            Toggle(DemeanorComponent.SpeechDisjointed, demeanorData["SpeechDisjointed"]);
            Toggle(DemeanorComponent.SpeechOther, demeanorData["SpeechOther"]);

            if (demeanorData["SpeechOther"].ToLower() == "yes" || demeanorData["SpeechOther"].ToLower() == "true" || demeanorData["SpeechOther"].ToLower() == "1")
            {
                //SendKeys(DemeanorComponent.SpeechOtherDescription, demeanorData["SpeechOtherDescription"]);
            }

            Click(DemeanorComponent.SaveDemeanorInfo);
        }

        public void CreateEmergencyContact(Dictionary<string, string> emergencyContactData)
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");

            Click(PeopleMenuComponent.EmergencyContacts);

            VerifyPageLabel(PeopleMenuComponent.EmergencyContacts, PeopleComponent.TabTitle.Text.ToLower(), "em. contacts");

            Click(EmergencyContactComponent.AddNewContact);

            SendKeys(EmergencyContactComponent.ContactName, emergencyContactData["ContactName"]);
            SendKeys(EmergencyContactComponent.ContactEmail, emergencyContactData["ContactEmail"]);
            SendKeys(EmergencyContactComponent.Phone, emergencyContactData["Phone"]);
            SendKeys(EmergencyContactComponent.Relationship, emergencyContactData["Relationship"]);
            Click(EmergencyContactComponent.AddressGroup);
            SelectOption(EmergencyContactComponent.LstAddressGroup, emergencyContactData["AddressGroup"]);
            SendKeys(EmergencyContactComponent.Address1, emergencyContactData["Address1"]);
            SendKeys(EmergencyContactComponent.Address2, emergencyContactData["Address2"]);
            SendKeys(EmergencyContactComponent.City, emergencyContactData["City"]);
            SendKeys(EmergencyContactComponent.State, emergencyContactData["State"]);
            Click(EmergencyContactComponent.County);
            SelectOption(EmergencyContactComponent.LstCounty, emergencyContactData["County"]);
            SendKeys(EmergencyContactComponent.ZipCode, emergencyContactData["ZipCode"]);

            Click(EmergencyContactComponent.SaveContact);
        }

        public void CreateExternalInfo(Dictionary<string, string> externalInfoData)
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");

            Click(PeopleMenuComponent.ExternalInfo);

            VerifyPageLabel(PeopleMenuComponent.ExternalInfo, PeopleComponent.TabTitle.Text.ToLower(), "em. contacts");

            Toggle(ExternalInfoComponent.InTheMilitary, externalInfoData["InTheMilitary"]);

            if (externalInfoData["InTheMilitary"].ToLower() == "yes" || externalInfoData["InTheMilitary"].ToLower() == "true" || externalInfoData["InTheMilitary"].ToLower() == "1")
            {
                Click(ExternalInfoComponent.MilitaryType);
                SelectOption(ExternalInfoComponent.LstMilitaryType, externalInfoData["MilitaryType"]);
                Click(ExternalInfoComponent.Branch);
                SelectOption(ExternalInfoComponent.LstBranch, externalInfoData["Branch"]);
                SendKeys(ExternalInfoComponent.Stationed, externalInfoData["Stationed"]);
            }

            Toggle(ExternalInfoComponent.AlcoholInvolved, externalInfoData["AlcoholInvolved"]);

            if (externalInfoData["AlcoholInvolved"].ToLower() == "yes" || externalInfoData["AlcoholInvolved"].ToLower() == "true" || externalInfoData["AlcoholInvolved"].ToLower() == "1")
            {
                Toggle(ExternalInfoComponent.Intoxicated, externalInfoData["Intoxicated"]);
                Toggle(ExternalInfoComponent.FrequentAlcoholUse, externalInfoData["FrequentAlcoholUse"]);
                Toggle(ExternalInfoComponent.OccasionalAlcoholUse, externalInfoData["OccasionalAlcoholUse"]);
                Toggle(ExternalInfoComponent.DoesViolenceOccurWhenAlcoholInvolved, externalInfoData["DoesViolenceOccurWhenAlcoholInvolved"]);
            }

            Toggle(ExternalInfoComponent.DrugsInvolved, externalInfoData["DrugsInvolved"]);

            if (externalInfoData["DrugsInvolved"].ToLower() == "yes" || externalInfoData["DrugsInvolved"].ToLower() == "true" || externalInfoData["DrugsInvolved"].ToLower() == "1")
            {
                Toggle(ExternalInfoComponent.Impaired, externalInfoData["Impaired"]);
                Toggle(ExternalInfoComponent.FrequentDrugUser, externalInfoData["FrequentDrugUser"]);
                Toggle(ExternalInfoComponent.DrugUser, externalInfoData["DrugUser"]);
                Toggle(ExternalInfoComponent.DoesViolenceOccurWhenDrugInvolved, externalInfoData["DoesViolenceOccurWhenDrugInvolved"]);
            }

            Click(ExternalInfoComponent.SaveExternalInfo);
        }

        public void CreateSuspectEvidence(Dictionary<string, string> suspectEvidenceData)
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");

            Click(PeopleMenuComponent.Evidence);

            VerifyPageLabel(PeopleMenuComponent.Evidence, PeopleComponent.TabTitle.Text.ToLower(), "evidence");

            Click(SuspectEvidenceComponent.AddSuspectEvidence);

            Click(SuspectEvidenceComponent.EvidenceType);
            SelectOption(SuspectEvidenceComponent.LstEvidenceType, suspectEvidenceData["EvidenceType"]);
            Click(SuspectEvidenceComponent.EvidenceDisposition);
            SelectOption(SuspectEvidenceComponent.LstEvidenceDisposition, suspectEvidenceData["EvidenceDisposition"]);
            Toggle(SuspectEvidenceComponent.CollectedFromPerson, suspectEvidenceData["CollectedFromPerson"]);

            if (suspectEvidenceData["CollectedFromPerson"].ToLower() == "yes" || suspectEvidenceData["CollectedFromPerson"].ToLower() == "true" || suspectEvidenceData["CollectedFromPerson"].ToLower() == "1")
            {
                if (!string.IsNullOrEmpty(suspectEvidenceData["Person"]))
                {
                    Click(SuspectEvidenceComponent.Person);
                    SelectOption(SuspectEvidenceComponent.LstPerson, suspectEvidenceData["Person"]);
                }

                Toggle(SuspectEvidenceComponent.PersonNotListed, suspectEvidenceData["PersonNotListed"]);

                if (suspectEvidenceData["PersonNotListed"].ToLower() == "yes" || suspectEvidenceData["PersonNotListed"].ToLower() == "true" || suspectEvidenceData["PersonNotListed"].ToLower() == "1")
                {
                    SendKeys(SuspectEvidenceComponent.PersonName, suspectEvidenceData["PersonName"]);
                }
            }

            SendKeys(SuspectEvidenceComponent.WhereFound, suspectEvidenceData["WhereFound"]);
            SendKeys(SuspectEvidenceComponent.EvidenceDescription, suspectEvidenceData["EvidenceDescription"]);
            Toggle(SuspectEvidenceComponent.WasSeized, suspectEvidenceData["WasSeized"]);

            if (suspectEvidenceData["EvidenceType"].ToLower() == "weapon")
            {
                Click(SuspectEvidenceComponent.TypeOfWeapon);
                SelectOption(SuspectEvidenceComponent.LstTypeOfWeapon, suspectEvidenceData["TypeOfWeapon"]);

                if (suspectEvidenceData["TypeOfWeapon"].ToLower() == "firearm (type not stated)" || suspectEvidenceData["TypeOfWeapon"].ToLower() == "handgun" || suspectEvidenceData["TypeOfWeapon"].ToLower() == "rifle" || suspectEvidenceData["TypeOfWeapon"].ToLower() == "shotgun" || suspectEvidenceData["TypeOfWeapon"].ToLower() == "other firearm")
                {
                    Click(SuspectEvidenceComponent.WeaponManufacturer);
                    SelectOption(SuspectEvidenceComponent.LstWeaponManufacturer, suspectEvidenceData["WeaponManufacturer"]);
                    Click(SuspectEvidenceComponent.WeaponCaliber);
                    SelectOption(SuspectEvidenceComponent.LstWeaponCaliber, suspectEvidenceData["WeaponCaliber"]);
                }
            }

            if (string.IsNullOrEmpty(suspectEvidenceData["EvidenceSerialNumber"]))
            {
                SendKeys(SuspectEvidenceComponent.EvidenceSerialNumber, "N/A");
            }
            else
            {
                SendKeys(SuspectEvidenceComponent.EvidenceSerialNumber, suspectEvidenceData["EvidenceSerialNumber"]);
            }

            if (!string.IsNullOrEmpty(suspectEvidenceData["EvidenceCollectedBy"]))
            {
                SendKeys(SuspectEvidenceComponent.EvidenceCollectedBy, suspectEvidenceData["EvidenceCollectedBy"]);
            }

            Click(SuspectEvidenceComponent.SaveEvidence);
        }

        public bool VerifyMasterDataSync(Dictionary<string, string> peopleData)
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");

            string masterFirstName;
            string masterLastName;
            string masterMiddletName;

            Click(PeopleComponent.SeeMaster);

            masterFirstName = PeopleComponent.FirstName.Text;
            masterLastName = PeopleComponent.LastName.Text;
            masterMiddletName = PeopleComponent.MiddleName.Text;

            if (peopleData["FirstName"] == masterFirstName && peopleData["LastName"] == masterLastName && peopleData["MiddleName"] == masterMiddletName)
            {
                Reporting.SetStepStatusPass("Master data synced", _driver);

                return true;
            }
            else
            {
                Reporting.SetStepStatusFail("Master data sync failed", _driver);

                return false;
            }
        }

        public void UpdatePeople(string updateData)
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");

            SendKeys(PeopleComponent.LastName, updateData);
            Click(PeopleComponent.SavePeople);
            Click(PeopleComponent.SyncToMaster);
        }

        public bool VerifyMasterDataLog(string oldData, string updateData)
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");

            Click(PeopleComponent.SeeMaster);
            Click(PeopleComponent.SeeLog);
            Click(PeopleComponent.ViewLogHistory);

            if (oldData == PeopleComponent.PreviousDataLastName.Text && updateData == PeopleComponent.ChangedDataLastName.Text)
            {
                Reporting.SetStepStatusPass("Master data log successful", _driver);

                return true;
            }
            else
            {
                Reporting.SetStepStatusFail("Master data log failed", _driver);

                return false;
            }
        }

        public bool AttachPeopleFromMainCase()
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");

            Click(PeopleComponent.SelectAllMainPeople);
            Click(PeopleComponent.AttachToSupplement);

            bool allPeoplePresent = PeopleComponent.LstAllMainPeopleNew.All(people => PeopleComponent.LstAllMainPeopleOld.Contains(people));

            return allPeoplePresent;
        }
    }
}
