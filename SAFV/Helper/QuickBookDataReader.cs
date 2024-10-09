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


        public static List<Dictionary<string, string>> ReadQuickBookOffenseData()
        {
            // Read dataset
            var quickBookOffenseColumnList = new ColumnList();
            quickBookOffenseColumnList.AddColumn("ReportDate", "ReportDate");
            quickBookOffenseColumnList.AddColumn("IncidentCaseNumber", "IncidentCaseNumber");
            quickBookOffenseColumnList.AddColumn("IncidentType", "IncidentType");
            quickBookOffenseColumnList.AddColumn("ConfidentialMode", "ConfidentialMode");


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
            quickBookVictimMedicalEmsColumnList.AddColumn("DidPersonComplainInjuries", "DidPersonComplainInjuries");
            quickBookVictimMedicalEmsColumnList.AddColumn("DidYouObserveInjuries", "DidYouObserveInjuries");
            quickBookVictimMedicalEmsColumnList.AddColumn("IsPersonPregnant", "IsPersonPregnant");
            quickBookVictimMedicalEmsColumnList.AddColumn("NumberOfWeeks", "NumberOfWeeks");
            quickBookVictimMedicalEmsColumnList.AddColumn("OfficerCouldObservePersonPregnant", "OfficerCouldObservePersonPregnant");
            quickBookVictimMedicalEmsColumnList.AddColumn("MedicalTreatmentOfferedButRefused", "MedicalTreatmentOfferedButRefused");
            quickBookVictimMedicalEmsColumnList.AddColumn("PersonSeekingOwnTreatment", "PersonSeekingOwnTreatment");
            quickBookVictimMedicalEmsColumnList.AddColumn("DrWhoWillProvideTreatment", "DrWhoWillProvideTreatment");
            quickBookVictimMedicalEmsColumnList.AddColumn("FirstAidGivenAtScene", "FirstAidGivenAtScene");
            quickBookVictimMedicalEmsColumnList.AddColumn("FirstAidGivenBy", "FirstAidGivenBy");
            quickBookVictimMedicalEmsColumnList.AddColumn("EMSParamedicsFire", "EMSParamedicsFire");
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
    }
}
