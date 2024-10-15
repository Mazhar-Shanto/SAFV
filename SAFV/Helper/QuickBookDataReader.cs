using OpenQA.Selenium.DevTools.V126.Network;
using SAFV.Helper.TestData;
using SAFV.Utility;

namespace SAFV.Helper
{
    class QuickBookDataReader
    {
        public static List<Dictionary<string, string>> ReadQuickBookIncidentData()
        {
            // Read dataset
            var quickBookColumnList = new ColumnList();
            quickBookColumnList.AddColumn("ReportDate", "ReportDate");
            quickBookColumnList.AddColumn("IncidentCaseNumber", "IncidentCaseNumber");
            quickBookColumnList.AddColumn("IncidentType", "IncidentType");
            quickBookColumnList.AddColumn("ConfidentialMode", "ConfidentialMode");
            quickBookColumnList.AddColumn("CaseType", "CaseType");
            quickBookColumnList.AddColumn("MainCase", "MainCase");
            quickBookColumnList.AddColumn("DispatchedDate", "DispatchedDate");
            quickBookColumnList.AddColumn("DispatchedTime", "DispatchedTime");
            quickBookColumnList.AddColumn("HowPoliceNotified", "HowPoliceNotified");
            quickBookColumnList.AddColumn("WhatWasBeingReported", "WhatWasBeingReported");
            quickBookColumnList.AddColumn("LocationType", "LocationType");
            quickBookColumnList.AddColumn("AddressGroup", "AddressGroup");
            quickBookColumnList.AddColumn("Address1", "Address1");
            quickBookColumnList.AddColumn("Address2", "Address2");
            quickBookColumnList.AddColumn("City", "City");
            quickBookColumnList.AddColumn("State", "State");
            quickBookColumnList.AddColumn("County", "County");
            quickBookColumnList.AddColumn("ZipCode", "ZipCode");
            quickBookColumnList.AddColumn("DispatchedLocation", "DispatchedLocation");
            quickBookColumnList.AddColumn("DispatchedLocationType", "DispatchedLocationType");
            quickBookColumnList.AddColumn("DispatchedLocationAddressGroup", "DispatchedLocationAddressGroup");
            quickBookColumnList.AddColumn("DispatchedLocationAddress1", "DispatchedLocationAddress1");
            quickBookColumnList.AddColumn("DispatchedLocationAddress2", "DispatchedLocationAddress2");
            quickBookColumnList.AddColumn("DispatchedLocationCity", "DispatchedLocationCity");
            quickBookColumnList.AddColumn("DispatchedLocationState", "DispatchedLocationState");
            quickBookColumnList.AddColumn("DispatchedLocationCounty", "DispatchedLocationCounty");
            quickBookColumnList.AddColumn("DispatchedLocationZipCode", "DispatchedLocationZipCode");


            var projectRoot = Utils.GetProjectRoot();
            var filePath = Path.Combine(projectRoot, "Helper/TestData/QuickBook/create quick book incident.xlsx");

            Console.WriteLine(filePath);
            var dataSet = new DataSet(quickBookColumnList);
            var quickBookData = dataSet.ReadData(filePath);

            return quickBookData;
        }


        public static List<Dictionary<string, string>> ReadQuickBookLogData()
        {
            // Read dataset
            var quickBookColumnList = new ColumnList();
            quickBookColumnList.AddColumn("QuickBookCaseCount", "QuickBookCaseCount");
            quickBookColumnList.AddColumn("QuickBookCaseNumber", "QuickBookCaseNumber");
            quickBookColumnList.AddColumn("QuickBookSupplementCount", "QuickBookSupplementCount");
            quickBookColumnList.AddColumn("QuickBookSupplementNumber", "QuickBookSupplementNumber");
            quickBookColumnList.AddColumn("QuickBookMainCaseForSupplement", "QuickBookMainCaseForSupplement");

            var projectRoot = Utils.GetProjectRoot();
            var filePath = Path.Combine(projectRoot, "Helper/Log/quick book log.xlsx");

            Console.WriteLine(filePath);
            var dataSet = new DataSet(quickBookColumnList);
            var quickBookData = dataSet.ReadData(filePath);

            return quickBookData;
        }


        public static List<Dictionary<string, string>> ReadQuickBookOffenseData()
        {
            // Read dataset
            var quickBookOffenseColumnList = new ColumnList();
            quickBookOffenseColumnList.AddColumn("DateOfOffense", "DateOfOffense");
            quickBookOffenseColumnList.AddColumn("TimeOfOffense", "TimeOfOffense");
            quickBookOffenseColumnList.AddColumn("Location", "Location");
            quickBookOffenseColumnList.AddColumn("OffenseType", "OffenseType");


            var projectRoot = Utils.GetProjectRoot();
            var filePath = Path.Combine(projectRoot, "Helper/TestData/QuickBook/create quick book offense.xlsx");

            Console.WriteLine(filePath);
            var dataSet = new DataSet(quickBookOffenseColumnList);
            var quickBookOffenseData = dataSet.ReadData(filePath);

            return quickBookOffenseData;
        }


        public static List<Dictionary<string, string>> ReadQuickBookVictimData()
        {
            // Read dataset
            var quickBookVictimColumnList = new ColumnList();
            quickBookVictimColumnList.AddColumn("FirstName", "FirstName");
            quickBookVictimColumnList.AddColumn("LastName", "LastName");
            quickBookVictimColumnList.AddColumn("VictimWouldLikeToUsePseudonym", "VictimWouldLikeToUsePseudonym");
            quickBookVictimColumnList.AddColumn("VictimRealFirstName", "VictimRealFirstName");
            quickBookVictimColumnList.AddColumn("VictimRealLastName", "VictimRealLastName");
            quickBookVictimColumnList.AddColumn("VictimRealMiddleName", "VictimRealMiddleName");
            quickBookVictimColumnList.AddColumn("Race", "Race");
            quickBookVictimColumnList.AddColumn("Sex", "Sex");
            quickBookVictimColumnList.AddColumn("DateOfBirth", "DateOfBirth");


            var projectRoot = Utils.GetProjectRoot();
            var filePath = Path.Combine(projectRoot, "Helper/TestData/QuickBook/Victim/create quick book victim.xlsx");

            Console.WriteLine(filePath);
            var dataSet = new DataSet(quickBookVictimColumnList);
            var quickBookVictimData = dataSet.ReadData(filePath);

            return quickBookVictimData;
        }


        public static List<Dictionary<string, string>> ReadQuickBookVictimRelocationData()
        {
            // Read dataset
            var quickBookVictimRelocationColumnList = new ColumnList();
            quickBookVictimRelocationColumnList.AddColumn("IsVictimRelocating", "IsVictimRelocating");
            quickBookVictimRelocationColumnList.AddColumn("Permanent", "Permanent");
            quickBookVictimRelocationColumnList.AddColumn("PermanentAddress1", "PermanentAddress1");
            quickBookVictimRelocationColumnList.AddColumn("PermanentAddress2", "PermanentAddress2");
            quickBookVictimRelocationColumnList.AddColumn("PermanentCity", "PermanentCity");
            quickBookVictimRelocationColumnList.AddColumn("PermanentState", "PermanentState");
            quickBookVictimRelocationColumnList.AddColumn("PermanentZipCode", "PermanentZipCode");
            quickBookVictimRelocationColumnList.AddColumn("PermanentCounty", "PermanentCounty");
            quickBookVictimRelocationColumnList.AddColumn("Temporary", "Temporary");
            quickBookVictimRelocationColumnList.AddColumn("TemporaryAddress1", "TemporaryAddress1");
            quickBookVictimRelocationColumnList.AddColumn("TemporaryAddress2", "TemporaryAddress2");
            quickBookVictimRelocationColumnList.AddColumn("TemporaryCity", "TemporaryCity");
            quickBookVictimRelocationColumnList.AddColumn("TemporaryState", "TemporaryState");
            quickBookVictimRelocationColumnList.AddColumn("TemporaryZipCode", "TemporaryZipCode");
            quickBookVictimRelocationColumnList.AddColumn("TemporaryCounty", "TemporaryCounty");
            quickBookVictimRelocationColumnList.AddColumn("HowLong", "HowLong");
            quickBookVictimRelocationColumnList.AddColumn("OmitLocationFromProtectionOrder", "OmitLocationFromProtectionOrder");
            quickBookVictimRelocationColumnList.AddColumn("VictimsConcern", "VictimsConcern");


            var projectRoot = Utils.GetProjectRoot();
            var filePath = Path.Combine(projectRoot, "Helper/TestData/QuickBook/Victim/create quick book victim relocation.xlsx");

            Console.WriteLine(filePath);
            var dataSet = new DataSet(quickBookVictimRelocationColumnList);
            var quickBookVictimRelocationData = dataSet.ReadData(filePath);

            return quickBookVictimRelocationData;
        }


        public static List<Dictionary<string, string>> ReadQuickBookVictimAddressData()
        {
            // Read dataset
            var quickBookVictimAddressColumnList = new ColumnList();
            quickBookVictimAddressColumnList.AddColumn("PhoneType", "PhoneType");
            quickBookVictimAddressColumnList.AddColumn("PhoneNumber", "PhoneNumber");
            quickBookVictimAddressColumnList.AddColumn("PrimaryContact", "PrimaryContact");
            quickBookVictimAddressColumnList.AddColumn("AddressGroup", "AddressGroup");
            quickBookVictimAddressColumnList.AddColumn("Address1", "Address1");
            quickBookVictimAddressColumnList.AddColumn("Address2", "Address2");
            quickBookVictimAddressColumnList.AddColumn("City", "City");
            quickBookVictimAddressColumnList.AddColumn("State", "State");
            quickBookVictimAddressColumnList.AddColumn("County", "County");
            quickBookVictimAddressColumnList.AddColumn("ZipCode", "ZipCode");


            var projectRoot = Utils.GetProjectRoot();
            var filePath = Path.Combine(projectRoot, "Helper/TestData/QuickBook/Victim/create quick book victim address.xlsx");

            Console.WriteLine(filePath);
            var dataSet = new DataSet(quickBookVictimAddressColumnList);
            var quickBookVictimAddressData = dataSet.ReadData(filePath);

            return quickBookVictimAddressData;
        }


        public static List<Dictionary<string, string>> ReadQuickBookVictimInjuryData()
        {
            // Read dataset
            var quickBookVictimInjuryColumnList = new ColumnList();
            quickBookVictimInjuryColumnList.AddColumn("InjuryArea", "InjuryArea");
            quickBookVictimInjuryColumnList.AddColumn("InjuryType", "InjuryType");
            quickBookVictimInjuryColumnList.AddColumn("InjuryObserved", "InjuryObserved");


            var projectRoot = Utils.GetProjectRoot();
            var filePath = Path.Combine(projectRoot, "Helper/TestData/QuickBook/Victim/create quick book victim injury.xlsx");

            Console.WriteLine(filePath);
            var dataSet = new DataSet(quickBookVictimInjuryColumnList);
            var quickBookVictimInjuryData = dataSet.ReadData(filePath);

            return quickBookVictimInjuryData;
        }


        public static List<Dictionary<string, string>> ReadQuickBookVictimMedicalEmsData()
        {
            // Read dataset
            var quickBookVictimMedicalEmsColumnList = new ColumnList();
            quickBookVictimMedicalEmsColumnList.AddColumn("DidPersonComplainOfInjuries", "DidPersonComplainOfInjuries");
            quickBookVictimMedicalEmsColumnList.AddColumn("DidYouObserveInjuries", "DidYouObserveInjuries");
            quickBookVictimMedicalEmsColumnList.AddColumn("IsPersonPregnant", "IsPersonPregnant");
            quickBookVictimMedicalEmsColumnList.AddColumn("NumberOfWeeks", "NumberOfWeeks");
            quickBookVictimMedicalEmsColumnList.AddColumn("OfficerCouldObservePersonPregnant", "OfficerCouldObservePersonPregnant");
            quickBookVictimMedicalEmsColumnList.AddColumn("MedicalTreatmentOfferedButRefused", "MedicalTreatmentOfferedButRefused");
            quickBookVictimMedicalEmsColumnList.AddColumn("PersonSeekingTheirOwnTreatment", "PersonSeekingTheirOwnTreatment");
            quickBookVictimMedicalEmsColumnList.AddColumn("DrWhoWillProvideTreatment", "DrWhoWillProvideTreatment");
            quickBookVictimMedicalEmsColumnList.AddColumn("FirstAidGivenAtScene", "FirstAidGivenAtScene");
            quickBookVictimMedicalEmsColumnList.AddColumn("FirstAidGivenBy", "FirstAidGivenBy");
            quickBookVictimMedicalEmsColumnList.AddColumn("EmsParamedicsFire", "EmsParamedicsFire");
            quickBookVictimMedicalEmsColumnList.AddColumn("EmsUnit", "EmsUnit");
            quickBookVictimMedicalEmsColumnList.AddColumn("EmsUnitTransportedPersonToHospital", "EmsUnitTransportedPersonToHospital");
            quickBookVictimMedicalEmsColumnList.AddColumn("TransportedTo", "TransportedTo");


            var projectRoot = Utils.GetProjectRoot();
            var filePath = Path.Combine(projectRoot, "Helper/TestData/QuickBook/Victim/create quick book victim medical ems.xlsx");

            Console.WriteLine(filePath);
            var dataSet = new DataSet(quickBookVictimMedicalEmsColumnList);
            var quickBookVictimMedicalEmsData = dataSet.ReadData(filePath);

            return quickBookVictimMedicalEmsData;
        }


        public static List<Dictionary<string, string>> ReadQuickBookSuspectData()
        {
            // Read dataset
            var quickBookSuspectColumnList = new ColumnList();
            quickBookSuspectColumnList.AddColumn("FirstName", "FirstName");
            quickBookSuspectColumnList.AddColumn("LastName", "LastName");
            quickBookSuspectColumnList.AddColumn("RelationshipToVictim", "RelationshipToVictim");


            var projectRoot = Utils.GetProjectRoot();
            var filePath = Path.Combine(projectRoot, "Helper/TestData/QuickBook/Suspect/create quickbook suspect.xlsx");

            Console.WriteLine(filePath);
            var dataSet = new DataSet(quickBookSuspectColumnList);
            var quickBookSuspectData = dataSet.ReadData(filePath);

            return quickBookSuspectData;
        }


        public static List<Dictionary<string, string>> ReadQuickBookSuspectInfoData()
        {
            // Read dataset
            var quickBookSuspectInfoColumnList = new ColumnList();
            quickBookSuspectInfoColumnList.AddColumn("SuspectWasOnScene", "SuspectWasOnScene");
            quickBookSuspectInfoColumnList.AddColumn("SuspectLocatedLater", "SuspectLocatedLater");
            quickBookSuspectInfoColumnList.AddColumn("LocatedDate", "LocatedDate");
            quickBookSuspectInfoColumnList.AddColumn("LocatedTime", "LocatedTime");
            quickBookSuspectInfoColumnList.AddColumn("SuspectWasArrested", "SuspectWasArrested");
            quickBookSuspectInfoColumnList.AddColumn("DateOfArrest", "DateOfArrest");
            quickBookSuspectInfoColumnList.AddColumn("TimeOfArrest", "TimeOfArrest");
            quickBookSuspectInfoColumnList.AddColumn("DateOfBooking", "DateOfBooking");
            quickBookSuspectInfoColumnList.AddColumn("TimeOfBooking", "TimeOfBooking");
            quickBookSuspectInfoColumnList.AddColumn("ArrestAddress1", "ArrestAddress1");
            quickBookSuspectInfoColumnList.AddColumn("ArrestAddress2", "ArrestAddress2");
            quickBookSuspectInfoColumnList.AddColumn("ArrestCity", "ArrestCity");
            quickBookSuspectInfoColumnList.AddColumn("ArrestState", "ArrestState");
            quickBookSuspectInfoColumnList.AddColumn("ArrestZipCode", "ArrestZipCode");
            quickBookSuspectInfoColumnList.AddColumn("ArrestCounty", "ArrestCounty");


            var projectRoot = Utils.GetProjectRoot();
            var filePath = Path.Combine(projectRoot, "Helper/TestData/QuickBook/Suspect/create quickbook suspect info.xlsx");

            Console.WriteLine(filePath);
            var dataSet = new DataSet(quickBookSuspectInfoColumnList);
            var quickBookSuspectInfoData = dataSet.ReadData(filePath);

            return quickBookSuspectInfoData;
        }


        public static List<Dictionary<string, string>> ReadQuickBookEvidenceData()
        {
            // Read dataset
            var quickBookEvidenceColumnList = new ColumnList();
            quickBookEvidenceColumnList.AddColumn("EvidenceType", "EvidenceType");
            quickBookEvidenceColumnList.AddColumn("EvidenceDisposition", "EvidenceDisposition");
            quickBookEvidenceColumnList.AddColumn("CollectedFromPerson", "CollectedFromPerson");
            quickBookEvidenceColumnList.AddColumn("Person", "Person");
            quickBookEvidenceColumnList.AddColumn("PersonNotListed", "PersonNotListed");
            quickBookEvidenceColumnList.AddColumn("PersonName", "PersonName");
            quickBookEvidenceColumnList.AddColumn("WhereFound", "WhereFound");
            quickBookEvidenceColumnList.AddColumn("EvidenceDescription", "EvidenceDescription");
            quickBookEvidenceColumnList.AddColumn("WasSeized", "WasSeized");
            quickBookEvidenceColumnList.AddColumn("TypeOfWeapon", "TypeOfWeapon");
            quickBookEvidenceColumnList.AddColumn("EvidenceSerialNumber", "EvidenceSerialNumber");
            quickBookEvidenceColumnList.AddColumn("WeaponManufacturer", "WeaponManufacturer");
            quickBookEvidenceColumnList.AddColumn("WeaponCaliber", "WeaponCaliber");
            quickBookEvidenceColumnList.AddColumn("EvidenceCollectedBy", "EvidenceCollectedBy");


            var projectRoot = Utils.GetProjectRoot();
            var filePath = Path.Combine(projectRoot, "Helper/TestData/QuickBook/create quick book evidence.xlsx");

            Console.WriteLine(filePath);
            var dataSet = new DataSet(quickBookEvidenceColumnList);
            var quickBookEvidenceData = dataSet.ReadData(filePath);

            return quickBookEvidenceData;
        }


        public static List<Dictionary<string, string>> ReadQuickBookRiskAssessmentData()
        {
            // Read dataset
            var quickBookRiskAssessmentColumnList = new ColumnList();
            quickBookRiskAssessmentColumnList.AddColumn("Suspect", "Suspect");
            quickBookRiskAssessmentColumnList.AddColumn("Victim", "Victim");
            quickBookRiskAssessmentColumnList.AddColumn("FamilyViolenceLikelyToOccur", "FamilyViolenceLikelyToOccur");
            quickBookRiskAssessmentColumnList.AddColumn("UsedOrThreatenedWithWeapon", "UsedOrThreatenedWithWeapon");
            quickBookRiskAssessmentColumnList.AddColumn("ThreatenedToKill", "ThreatenedToKill");
            quickBookRiskAssessmentColumnList.AddColumn("SuspectHasGun", "SuspectHasGun");
            quickBookRiskAssessmentColumnList.AddColumn("GunDetailsInfo", "GunDetailsInfo");
            quickBookRiskAssessmentColumnList.AddColumn("Strangulation", "Strangulation");
            quickBookRiskAssessmentColumnList.AddColumn("Violence", "Violence");
            quickBookRiskAssessmentColumnList.AddColumn("Jealousy", "Jealousy");
            quickBookRiskAssessmentColumnList.AddColumn("Controlling", "Controlling");
            quickBookRiskAssessmentColumnList.AddColumn("ViolenceIncreased", "ViolenceIncreased");
            quickBookRiskAssessmentColumnList.AddColumn("ViolenceIncreasedDescription", "ViolenceIncreasedDescription");
            quickBookRiskAssessmentColumnList.AddColumn("DestroyedItems", "DestroyedItems");
            quickBookRiskAssessmentColumnList.AddColumn("HurtPets", "HurtPets");
            quickBookRiskAssessmentColumnList.AddColumn("Unemployed", "Unemployed");
            quickBookRiskAssessmentColumnList.AddColumn("Suicidal", "Suicidal");
            quickBookRiskAssessmentColumnList.AddColumn("Spying", "Spying");
            quickBookRiskAssessmentColumnList.AddColumn("ThreateningMessages", "ThreateningMessages");
            quickBookRiskAssessmentColumnList.AddColumn("AlcoholAbuse", "AlcoholAbuse");
            quickBookRiskAssessmentColumnList.AddColumn("DrugUse", "DrugUse");
            quickBookRiskAssessmentColumnList.AddColumn("MightKillYou", "MightKillYou");
            quickBookRiskAssessmentColumnList.AddColumn("ForcedSex", "ForcedSex");
            quickBookRiskAssessmentColumnList.AddColumn("Separation", "Separation");
            quickBookRiskAssessmentColumnList.AddColumn("RecentSeparation", "RecentSeparation");
            quickBookRiskAssessmentColumnList.AddColumn("UnrelatedChild", "UnrelatedChild");
            quickBookRiskAssessmentColumnList.AddColumn("PriorContacts", "PriorContacts");
            quickBookRiskAssessmentColumnList.AddColumn("CourtAction", "CourtAction");
            quickBookRiskAssessmentColumnList.AddColumn("AdditionalInfo", "AdditionalInfo");
            quickBookRiskAssessmentColumnList.AddColumn("PriorProtectiveOrder", "PriorProtectiveOrder");
            quickBookRiskAssessmentColumnList.AddColumn("DateTimeOfAssessment", "DateTimeOfAssessment");


            var projectRoot = Utils.GetProjectRoot();
            var filePath = Path.Combine(projectRoot, "Helper/TestData/QuickBook/create quick book risk assessment.xlsx");

            Console.WriteLine(filePath);
            var dataSet = new DataSet(quickBookRiskAssessmentColumnList);
            var quickBookRiskAssessmentData = dataSet.ReadData(filePath);

            return quickBookRiskAssessmentData;
        }


        public static List<Dictionary<string, string>> ReadQuickBookEpoData()
        {
            // Read dataset
            var quickBookEpoColumnList = new ColumnList();
            quickBookEpoColumnList.AddColumn("OffenseGroup", "OffenseGroup");
            quickBookEpoColumnList.AddColumn("RequestedByVictim", "RequestedByVictim");
            quickBookEpoColumnList.AddColumn("RequestedByGuardian", "RequestedByGuardian");
            quickBookEpoColumnList.AddColumn("GuardiansName", "GuardiansName");
            quickBookEpoColumnList.AddColumn("RequestedByOfficer", "RequestedByOfficer");
            quickBookEpoColumnList.AddColumn("RequestedByState", "RequestedByState");
            quickBookEpoColumnList.AddColumn("StateAttorneyName", "StateAttorneyName");
            quickBookEpoColumnList.AddColumn("RequestedByMagistrate", "RequestedByMagistrate");
            quickBookEpoColumnList.AddColumn("MagistratesName", "MagistratesName");
            quickBookEpoColumnList.AddColumn("HoldRequested", "HoldRequested");
            quickBookEpoColumnList.AddColumn("Hour24", "Hour24");
            quickBookEpoColumnList.AddColumn("Hour48", "Hour48");
            quickBookEpoColumnList.AddColumn("ExplainHold", "ExplainHold");
            quickBookEpoColumnList.AddColumn("JudicialOrganization", "JudicialOrganization");
            quickBookEpoColumnList.AddColumn("SignEpo", "SignEpo");
            quickBookEpoColumnList.AddColumn("WitnessIsLocal", "WitnessIsLocal");
            quickBookEpoColumnList.AddColumn("SignerName", "SignerName");
            quickBookEpoColumnList.AddColumn("Judge", "Judge");


            var projectRoot = Utils.GetProjectRoot();
            var filePath = Path.Combine(projectRoot, "Helper/TestData/QuickBook/create quick book epo.xlsx");

            Console.WriteLine(filePath);
            var dataSet = new DataSet(quickBookEpoColumnList);
            var quickBookEpoData = dataSet.ReadData(filePath);

            return quickBookEpoData;
        }
    }
}
