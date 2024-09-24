using OpenQA.Selenium.DevTools.V126.Network;
using SAFV.Helper.TestData;
using SAFV.Utility;

namespace SAFV.Helper
{
    class PeopleDataReader
    {
        private static ColumnList GetPeopleColumn()
        {
            var peopleColumnList = new ColumnList();
            peopleColumnList.AddColumn("FirstName", "FirstName");
            peopleColumnList.AddColumn("LastName", "LastName");
            peopleColumnList.AddColumn("MiddleName", "MiddleName");
            peopleColumnList.AddColumn("Alias", "Alias");
            peopleColumnList.AddColumn("AliasDescription", "AliasDescription");
            peopleColumnList.AddColumn("Victim", "Victim");
            peopleColumnList.AddColumn("Suspect", "Suspect");
            peopleColumnList.AddColumn("Witness", "Witness");
            peopleColumnList.AddColumn("OtherNotInvolved", "OtherNotInvolved");
            peopleColumnList.AddColumn("VictimWouldLikeToUsePseudonym", "VictimWouldLikeToUsePseudonym");
            peopleColumnList.AddColumn("VictimRealFirstName", "VictimRealFirstName");
            peopleColumnList.AddColumn("VictimRealLastName", "VictimRealLastName");
            peopleColumnList.AddColumn("VictimRealMiddleName", "VictimRealMiddleName");
            peopleColumnList.AddColumn("WasPresent", "WasPresent");
            peopleColumnList.AddColumn("IsUnknownPerson", "IsUnknownPerson");
            peopleColumnList.AddColumn("Race", "Race");
            peopleColumnList.AddColumn("Sex", "Sex");
            peopleColumnList.AddColumn("DateOfBirth", "DateOfBirth");
            peopleColumnList.AddColumn("Age", "Age");
            peopleColumnList.AddColumn("Ethnicity", "Ethnicity");
            peopleColumnList.AddColumn("EyeColor", "EyeColor");
            peopleColumnList.AddColumn("HairColor", "HairColor");
            peopleColumnList.AddColumn("HeightFeet", "HeightFeet");
            peopleColumnList.AddColumn("HeightInches", "HeightInches");
            peopleColumnList.AddColumn("Weight", "Weight");
            peopleColumnList.AddColumn("Ssn", "Ssn");
            peopleColumnList.AddColumn("PrimaryLanguage", "PrimaryLanguage");
            peopleColumnList.AddColumn("PersonIdType", "PersonIdType");
            peopleColumnList.AddColumn("IdNumber", "IdNumber");
            peopleColumnList.AddColumn("IdState", "IdState");
            peopleColumnList.AddColumn("IdExpirationDate", "IdExpirationDate");
            peopleColumnList.AddColumn("Email", "Email");
            peopleColumnList.AddColumn("SafeToContactViaEmail", "SafeToContactViaEmail");
            peopleColumnList.AddColumn("Occupation", "Occupation");
            peopleColumnList.AddColumn("PlaceOfBirth", "PlaceOfBirth");
            peopleColumnList.AddColumn("NameOfEmployer", "NameOfEmployer");
            peopleColumnList.AddColumn("ScarsMarks", "ScarsMarks");
            peopleColumnList.AddColumn("TxSid", "TxSid");
            peopleColumnList.AddColumn("SpecialNeeds", "SpecialNeeds");
            peopleColumnList.AddColumn("HandcuffedPriorToArrest", "HandcuffedPriorToArrest");
            peopleColumnList.AddColumn("HandcuffReason", "HandcuffReason");
            peopleColumnList.AddColumn("IsPersonChild", "IsPersonChild");
            peopleColumnList.AddColumn("WasThisChildPresent", "WasThisChildPresent");
            peopleColumnList.AddColumn("DidTheyAttemptToIntervene", "DidTheyAttemptToIntervene");
            peopleColumnList.AddColumn("PrimaryCaretakerOfChild", "PrimaryCaretakerOfChild");
            peopleColumnList.AddColumn("PersonGivenMirandaWarning", "PersonGivenMirandaWarning");
            peopleColumnList.AddColumn("MirandaWarningDate", "MirandaWarningDate");
            peopleColumnList.AddColumn("MirandaWarningTime", "MirandaWarningTime");
            peopleColumnList.AddColumn("StatementsMadeAfterMiranda", "StatementsMadeAfterMiranda");
            peopleColumnList.AddColumn("IsPersonElderly", "IsPersonElderly");
            peopleColumnList.AddColumn("IsPersonDisabled", "IsPersonDisabled");
            peopleColumnList.AddColumn("PhoneType", "PhoneType");
            peopleColumnList.AddColumn("PhoneNumber", "PhoneNumber");
            peopleColumnList.AddColumn("PrimaryContact", "PrimaryContact");
            peopleColumnList.AddColumn("AddressGroup", "AddressGroup");
            peopleColumnList.AddColumn("Address1", "Address1");
            peopleColumnList.AddColumn("Address2", "Address2");
            peopleColumnList.AddColumn("City", "City");
            peopleColumnList.AddColumn("State", "State");
            peopleColumnList.AddColumn("County", "County");
            peopleColumnList.AddColumn("ZipCode", "ZipCode");
            peopleColumnList.AddColumn("SyncToMaster", "SyncToMaster");

            return peopleColumnList;
        }


        public static List<Dictionary<string, string>> ReadOtherPeopleData()
        {
            // Read dataset
            var peopleColumnList = GetPeopleColumn();


            var projectRoot = Utils.GetProjectRoot();
            var filePath = Path.Combine(projectRoot, "Helper/TestData/CreateIncident/People/create people data - other.xlsx");

            Console.WriteLine(filePath);
            var dataSet = new DataSet(peopleColumnList);
            var peopleData = dataSet.ReadData(filePath);

            return peopleData;
        }


        public static List<Dictionary<string, string>> ReadVictimData()
        {
            // Read dataset
            var peopleColumnList = GetPeopleColumn();


            var projectRoot = Utils.GetProjectRoot();
            var filePath = Path.Combine(projectRoot, "Helper/TestData/CreateIncident/People/create people data - victim.xlsx");

            Console.WriteLine(filePath);
            var dataSet = new DataSet(peopleColumnList);
            var peopleData = dataSet.ReadData(filePath);

            return peopleData;
        }


        public static List<Dictionary<string, string>> ReadSuspectData()
        {
            // Read dataset
            var peopleColumnList = GetPeopleColumn();


            var projectRoot = Utils.GetProjectRoot();
            var filePath = Path.Combine(projectRoot, "Helper/TestData/CreateIncident/People/create people data - suspect.xlsx");

            Console.WriteLine(filePath);
            var dataSet = new DataSet(peopleColumnList);
            var peopleData = dataSet.ReadData(filePath);

            return peopleData;
        }


        public static List<Dictionary<string, string>> ReadWitnessData()
        {
            // Read dataset
            var peopleColumnList = GetPeopleColumn();


            var projectRoot = Utils.GetProjectRoot();
            var filePath = Path.Combine(projectRoot, "Helper/TestData/CreateIncident/People/create people data - witness.xlsx");

            Console.WriteLine(filePath);
            var dataSet = new DataSet(peopleColumnList);
            var peopleData = dataSet.ReadData(filePath);

            return peopleData;
        }


        public static List<Dictionary<string, string>> ReadMasterSearchData()
        {
            // Read dataset
            var masterSearchColumnList = new ColumnList();
            masterSearchColumnList.AddColumn("SearchText", "SearchText");
            masterSearchColumnList.AddColumn("SearchField", "SearchField");
            masterSearchColumnList.AddColumn("PersonIdType", "PersonIdType");
            masterSearchColumnList.AddColumn("PersonType", "PersonType");


            var projectRoot = Utils.GetProjectRoot();
            var filePath = Path.Combine(projectRoot, "Helper/TestData/CreateIncident/People/create people - master.xlsx");

            Console.WriteLine(filePath);
            var dataSet = new DataSet(masterSearchColumnList);
            var masterSearchData = dataSet.ReadData(filePath);

            return masterSearchData;
        }


        public static List<Dictionary<string, string>> ReadSuspectInterviewData()
        {
            // Read dataset
            var suspectInterviewColumnList = new ColumnList();
            suspectInterviewColumnList.AddColumn("PersonWasInterviewed", "PersonWasInterviewed");
            suspectInterviewColumnList.AddColumn("WhyNotInterviewed", "WhyNotInterviewed");
            suspectInterviewColumnList.AddColumn("PersonInterviewedOnAudioVideo", "PersonInterviewedOnAudioVideo");
            suspectInterviewColumnList.AddColumn("PersonInterviewedOnCustody", "PersonInterviewedOnCustody");
            suspectInterviewColumnList.AddColumn("PersonInterviewedByAnotherOfficer", "PersonInterviewedByAnotherOfficer");
            suspectInterviewColumnList.AddColumn("InterviewerName", "InterviewerName");
            suspectInterviewColumnList.AddColumn("InitialContact", "InitialContact");
            suspectInterviewColumnList.AddColumn("DescribeEvents", "DescribeEvents");
            suspectInterviewColumnList.AddColumn("IntervieweeRole", "IntervieweeRole");
            suspectInterviewColumnList.AddColumn("UseOfForce", "UseOfForce");
            suspectInterviewColumnList.AddColumn("UseOfForceDescription", "UseOfForceDescription");
            suspectInterviewColumnList.AddColumn("ReportedInjuries", "ReportedInjuries");
            suspectInterviewColumnList.AddColumn("DeEscalation", "DeEscalation");
            suspectInterviewColumnList.AddColumn("DeEscalationDescription", "DeEscalationDescription");
            suspectInterviewColumnList.AddColumn("IndicationOfViolence", "IndicationOfViolence");
            suspectInterviewColumnList.AddColumn("IndicationOfViolenceDescription", "IndicationOfViolenceDescription");
            suspectInterviewColumnList.AddColumn("InjuriesToOthers", "InjuriesToOthers");
            suspectInterviewColumnList.AddColumn("Admission", "Admission");


            var projectRoot = Utils.GetProjectRoot();
            var filePath = Path.Combine(projectRoot, "Helper/TestData/CreateIncident/People/SuspectData/suspect interview data.xlsx");

            Console.WriteLine(filePath);
            var dataSet = new DataSet(suspectInterviewColumnList);
            var suspectInterviewData = dataSet.ReadData(filePath);

            return suspectInterviewData;
        }


        public static List<Dictionary<string, string>> ReadSuspectInfoData()
        {
            // Read dataset
            var suspectInfoColumnList = new ColumnList();
            suspectInfoColumnList.AddColumn("SuspectWasOnScene", "SuspectWasOnScene");
            suspectInfoColumnList.AddColumn("SuspectLocatedLater", "SuspectLocatedLater");
            suspectInfoColumnList.AddColumn("LocatedDate", "LocatedDate");
            suspectInfoColumnList.AddColumn("LocatedTime", "LocatedTime");
            suspectInfoColumnList.AddColumn("SuspectWasArrested", "SuspectWasArrested");
            suspectInfoColumnList.AddColumn("DateOfArrest", "DateOfArrest");
            suspectInfoColumnList.AddColumn("TimeOfArrest", "TimeOfArrest");
            suspectInfoColumnList.AddColumn("DateOfBooking", "DateOfBooking");
            suspectInfoColumnList.AddColumn("TimeOfBooking", "TimeOfBooking");
            suspectInfoColumnList.AddColumn("ArrestAddress1", "ArrestAddress1");
            suspectInfoColumnList.AddColumn("ArrestAddress2", "ArrestAddress2");
            suspectInfoColumnList.AddColumn("ArrestCity", "ArrestCity");
            suspectInfoColumnList.AddColumn("ArrestState", "ArrestState");
            suspectInfoColumnList.AddColumn("ArrestZipCode", "ArrestZipCode");
            suspectInfoColumnList.AddColumn("ArrestCounty", "ArrestCounty");
            suspectInfoColumnList.AddColumn("ConcealedHandgunLicenseHolder", "ConcealedHandgunLicenseHolder");
            suspectInfoColumnList.AddColumn("MentalHealthIssues", "MentalHealthIssues");
            suspectInfoColumnList.AddColumn("MentalHealthDescription", "MentalHealthDescription");
            suspectInfoColumnList.AddColumn("PriorProtectiveOrder", "PriorProtectiveOrder");
            suspectInfoColumnList.AddColumn("ProtectedPersons", "ProtectedPersons");
            suspectInfoColumnList.AddColumn("OnProbation", "OnProbation");
            suspectInfoColumnList.AddColumn("ProbationOfficer", "ProbationOfficer");
            suspectInfoColumnList.AddColumn("ProbationCounty", "ProbationCounty");
            suspectInfoColumnList.AddColumn("UnreportedIncidentsOfFv", "UnreportedIncidentsOfFv");
            suspectInfoColumnList.AddColumn("AttemptedContact", "AttemptedContact");
            suspectInfoColumnList.AddColumn("CalledSuspectCellPhone", "CalledSuspectCellPhone");
            suspectInfoColumnList.AddColumn("CalledFriendFamilyWhereSuspectFledTo", "CalledFriendFamilyWhereSuspectFledTo");
            suspectInfoColumnList.AddColumn("WentToLocationSuspectWas", "WentToLocationSuspectWas");
            suspectInfoColumnList.AddColumn("OfficerCanvassedArea", "OfficerCanvassedArea");
            suspectInfoColumnList.AddColumn("DidYouLeaveMessagesForSuspectToCallBack", "DidYouLeaveMessagesForSuspectToCallBack");
            suspectInfoColumnList.AddColumn("DidSuspectRefuseToTalk", "DidSuspectRefuseToTalk");
            suspectInfoColumnList.AddColumn("PriorToArrestPersonResisted", "PriorToArrestPersonResisted");
            suspectInfoColumnList.AddColumn("VerbalThreat", "VerbalThreat");
            suspectInfoColumnList.AddColumn("Passive", "Passive");
            suspectInfoColumnList.AddColumn("Physical", "Physical");


            var projectRoot = Utils.GetProjectRoot();
            var filePath = Path.Combine(projectRoot, "Helper/TestData/CreateIncident/People/SuspectData/suspect info data.xlsx");

            Console.WriteLine(filePath);
            var dataSet = new DataSet(suspectInfoColumnList);
            var suspectInfoData = dataSet.ReadData(filePath);

            return suspectInfoData;
        }


        public static List<Dictionary<string, string>> ReadMedicalEmsData()
        {
            // Read dataset
            var medicalEmsColumnList = new ColumnList();
            medicalEmsColumnList.AddColumn("DidPersonComplainOfInjuries", "DidPersonComplainOfInjuries");
            medicalEmsColumnList.AddColumn("DidYouObserveInjuries", "DidYouObserveInjuries");
            medicalEmsColumnList.AddColumn("IsPersonPregnant", "IsPersonPregnant");
            medicalEmsColumnList.AddColumn("NumberOfWeeks", "NumberOfWeeks");
            medicalEmsColumnList.AddColumn("OfficerCouldObservePersonPregnant", "OfficerCouldObservePersonPregnant");
            medicalEmsColumnList.AddColumn("MedicalTreatmentOfferedButRefused", "MedicalTreatmentOfferedButRefused");
            medicalEmsColumnList.AddColumn("PersonSeekingTheirOwnTreatment", "PersonSeekingTheirOwnTreatment");
            medicalEmsColumnList.AddColumn("DrWhoWillProvideTreatment", "DrWhoWillProvideTreatment");
            medicalEmsColumnList.AddColumn("FirstAidGivenAtScene", "FirstAidGivenAtScene");
            medicalEmsColumnList.AddColumn("FirstAidGivenBy", "FirstAidGivenBy");
            medicalEmsColumnList.AddColumn("EmsParamedicsFire", "EmsParamedicsFire");
            medicalEmsColumnList.AddColumn("EmsUnit", "EmsUnit");
            medicalEmsColumnList.AddColumn("EmsUnitTransportedPersonToHospital", "EmsUnitTransportedPersonToHospital");
            medicalEmsColumnList.AddColumn("TransportedTo", "TransportedTo");


            var projectRoot = Utils.GetProjectRoot();
            var filePath = Path.Combine(projectRoot, "Helper/TestData/CreateIncident/People/SuspectData/medical ems data.xlsx");

            Console.WriteLine(filePath);
            var dataSet = new DataSet(medicalEmsColumnList);
            var medicalEmsData = dataSet.ReadData(filePath);

            return medicalEmsData;
        }


        public static List<Dictionary<string, string>> ReadDemeanorData()
        {
            // Read dataset
            var demeanorColumnList = new ColumnList();
            demeanorColumnList.AddColumn("AppearanceBloody", "AppearanceBloody");
            demeanorColumnList.AddColumn("AppearanceSmearedMakeup", "AppearanceSmearedMakeup");
            demeanorColumnList.AddColumn("AppearanceSoiledSweatStained", "AppearanceSoiledSweatStained");
            demeanorColumnList.AddColumn("AppearanceTangledMessyHair", "AppearanceTangledMessyHair");
            demeanorColumnList.AddColumn("AppearanceTornPulledClothing", "AppearanceTornPulledClothing");
            demeanorColumnList.AddColumn("AppearanceOther", "AppearanceOther");
            demeanorColumnList.AddColumn("AppearanceOtherDescription", "AppearanceOtherDescription");
            demeanorColumnList.AddColumn("DemeanorAfraid", "DemeanorAfraid");
            demeanorColumnList.AddColumn("DemeanorAngry", "DemeanorAngry");
            demeanorColumnList.AddColumn("DemeanorApologetic", "DemeanorApologetic");
            demeanorColumnList.AddColumn("DemeanorBelligerent", "DemeanorBelligerent");
            demeanorColumnList.AddColumn("DemeanorCalm", "DemeanorCalm");
            demeanorColumnList.AddColumn("DemeanorCatatonic", "DemeanorCatatonic");
            demeanorColumnList.AddColumn("DemeanorCrying", "DemeanorCrying");
            demeanorColumnList.AddColumn("DemeanorDistraught", "DemeanorDistraught");
            demeanorColumnList.AddColumn("DemeanorFlatAffect", "DemeanorFlatAffect");
            demeanorColumnList.AddColumn("DemeanorHysterical", "DemeanorHysterical");
            demeanorColumnList.AddColumn("DemeanorHandsBodyShaking", "DemeanorHandsBodyShaking");
            demeanorColumnList.AddColumn("DemeanorIndifferent", "DemeanorIndifferent");
            demeanorColumnList.AddColumn("DemeanorIntoxicated", "DemeanorIntoxicated");
            demeanorColumnList.AddColumn("DemeanorIrrational", "DemeanorIrrational");
            demeanorColumnList.AddColumn("DemeanorNervous", "DemeanorNervous");
            demeanorColumnList.AddColumn("DemeanorTrembling", "DemeanorTrembling");
            demeanorColumnList.AddColumn("DemeanorOther", "DemeanorOther");
            demeanorColumnList.AddColumn("DemeanorOtherDescription", "DemeanorOtherDescription");
            demeanorColumnList.AddColumn("SpeechAngry", "SpeechAngry");
            demeanorColumnList.AddColumn("SpeechOutOfBreath", "SpeechOutOfBreath");
            demeanorColumnList.AddColumn("SpeechExcitedFast", "SpeechExcitedFast");
            demeanorColumnList.AddColumn("SpeechCryingSobbing", "SpeechCryingSobbing");
            demeanorColumnList.AddColumn("SpeechYelling", "SpeechYelling");
            demeanorColumnList.AddColumn("SpeechBelligerent", "SpeechBelligerent");
            demeanorColumnList.AddColumn("SpeechRepetitive", "SpeechRepetitive");
            demeanorColumnList.AddColumn("SpeechIncoherent", "SpeechIncoherent");
            demeanorColumnList.AddColumn("SpeechDisjointed", "SpeechDisjointed");
            demeanorColumnList.AddColumn("SpeechOther", "SpeechOther");
            demeanorColumnList.AddColumn("SpeechOtherDescription", "SpeechOtherDescription");


            var projectRoot = Utils.GetProjectRoot();
            var filePath = Path.Combine(projectRoot, "Helper/TestData/CreateIncident/People/SuspectData/demeanor data.xlsx");

            Console.WriteLine(filePath);
            var dataSet = new DataSet(demeanorColumnList);
            var demeanorData = dataSet.ReadData(filePath);

            return demeanorData;
        }


        public static List<Dictionary<string, string>> ReadEmergencyContactData()
        {
            // Read dataset
            var emergencyContactColumnList = new ColumnList();
            emergencyContactColumnList.AddColumn("ContactName", "ContactName");
            emergencyContactColumnList.AddColumn("ContactEmail", "ContactEmail");
            emergencyContactColumnList.AddColumn("Phone", "Phone");
            emergencyContactColumnList.AddColumn("Relationship", "Relationship");
            emergencyContactColumnList.AddColumn("AddressGroup", "AddressGroup");
            emergencyContactColumnList.AddColumn("Address1", "Address1");
            emergencyContactColumnList.AddColumn("Address2", "Address2");
            emergencyContactColumnList.AddColumn("City", "City");
            emergencyContactColumnList.AddColumn("State", "State");
            emergencyContactColumnList.AddColumn("County", "County");
            emergencyContactColumnList.AddColumn("ZipCode", "ZipCode");


            var projectRoot = Utils.GetProjectRoot();
            var filePath = Path.Combine(projectRoot, "Helper/TestData/CreateIncident/People/SuspectData/emergency contact data.xlsx");

            Console.WriteLine(filePath);
            var dataSet = new DataSet(emergencyContactColumnList);
            var emergencyContactData = dataSet.ReadData(filePath);

            return emergencyContactData;
        }


        public static List<Dictionary<string, string>> ReadExternalInfoData()
        {
            // Read dataset
            var externalInfoColumnList = new ColumnList();
            externalInfoColumnList.AddColumn("InTheMilitary", "InTheMilitary");
            externalInfoColumnList.AddColumn("MilitaryType", "MilitaryType");
            externalInfoColumnList.AddColumn("Branch", "Branch");
            externalInfoColumnList.AddColumn("Stationed", "Stationed");
            externalInfoColumnList.AddColumn("AlcoholInvolved", "AlcoholInvolved");
            externalInfoColumnList.AddColumn("Intoxicated", "Intoxicated");
            externalInfoColumnList.AddColumn("FrequentAlcoholUse", "FrequentAlcoholUse");
            externalInfoColumnList.AddColumn("OccasionalAlcoholUse", "OccasionalAlcoholUse");
            externalInfoColumnList.AddColumn("DoesViolenceOccurWhenAlcoholInvolved", "DoesViolenceOccurWhenAlcoholInvolved");
            externalInfoColumnList.AddColumn("DrugsInvolved", "DrugsInvolved");
            externalInfoColumnList.AddColumn("Impaired", "Impaired");
            externalInfoColumnList.AddColumn("FrequentDrugUser", "FrequentDrugUser");
            externalInfoColumnList.AddColumn("DrugUser", "DrugUser");
            externalInfoColumnList.AddColumn("DoesViolenceOccurWhenDrugInvolved", "DoesViolenceOccurWhenDrugInvolved");


            var projectRoot = Utils.GetProjectRoot();
            var filePath = Path.Combine(projectRoot, "Helper/TestData/CreateIncident/People/SuspectData/external info data.xlsx");

            Console.WriteLine(filePath);
            var dataSet = new DataSet(externalInfoColumnList);
            var externalInfoData = dataSet.ReadData(filePath);

            return externalInfoData;
        }


        public static List<Dictionary<string, string>> ReadSuspectEvidenceData()
        {
            // Read dataset
            var suspectEvidenceColumnList = new ColumnList();
            suspectEvidenceColumnList.AddColumn("EvidenceType", "EvidenceType");
            suspectEvidenceColumnList.AddColumn("EvidenceDisposition", "EvidenceDisposition");
            suspectEvidenceColumnList.AddColumn("CollectedFromPerson", "CollectedFromPerson");
            suspectEvidenceColumnList.AddColumn("Person", "Person");
            suspectEvidenceColumnList.AddColumn("PersonNotListed", "PersonNotListed");
            suspectEvidenceColumnList.AddColumn("PersonName", "PersonName");
            suspectEvidenceColumnList.AddColumn("WhereFound", "WhereFound");
            suspectEvidenceColumnList.AddColumn("EvidenceDescription", "EvidenceDescription");
            suspectEvidenceColumnList.AddColumn("WasSeized", "WasSeized");
            suspectEvidenceColumnList.AddColumn("TypeOfWeapon", "TypeOfWeapon");
            suspectEvidenceColumnList.AddColumn("EvidenceSerialNumber", "EvidenceSerialNumber");
            suspectEvidenceColumnList.AddColumn("WeaponManufacturer", "WeaponManufacturer");
            suspectEvidenceColumnList.AddColumn("WeaponCaliber", "WeaponCaliber");
            suspectEvidenceColumnList.AddColumn("EvidenceCollectedBy", "EvidenceCollectedBy");


            var projectRoot = Utils.GetProjectRoot();
            var filePath = Path.Combine(projectRoot, "Helper/TestData/CreateIncident/People/SuspectData/suspect evidence data.xlsx");

            Console.WriteLine(filePath);
            var dataSet = new DataSet(suspectEvidenceColumnList);
            var suspectEvidenceData = dataSet.ReadData(filePath);

            return suspectEvidenceData;
        }
    }
}
