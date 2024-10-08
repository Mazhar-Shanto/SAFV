using OpenQA.Selenium.DevTools.V126.Network;
using SAFV.Helper.TestData;
using SAFV.Utility;

namespace SAFV.Helper
{
    class CourtEpoDataReader
    {
        public static List<Dictionary<string, string>> ReadCourtEpoData()
        {
            // Read dataset
            var courtEpoColumnList = new ColumnList();
            courtEpoColumnList.AddColumn("CourtName", "CourtName");
            courtEpoColumnList.AddColumn("TypeOfIncident", "TypeOfIncident");
            courtEpoColumnList.AddColumn("CourtCaseNo", "CourtCaseNo");
            courtEpoColumnList.AddColumn("IncidentCaseNo", "IncidentCaseNo");
            courtEpoColumnList.AddColumn("Ori", "Ori");
            courtEpoColumnList.AddColumn("CountyOfArrest", "CountyOfArrest");
            courtEpoColumnList.AddColumn("CountyOfOffense", "CountyOfOffense");
            courtEpoColumnList.AddColumn("RequestedDate", "RequestedDate");
            courtEpoColumnList.AddColumn("OrderEffectiveUntil", "OrderEffectiveUntil");
            courtEpoColumnList.AddColumn("RequestedByCourt", "RequestedByCourt");
            courtEpoColumnList.AddColumn("RequestedByVictim", "RequestedByVictim");
            courtEpoColumnList.AddColumn("RequestedByGuardian", "RequestedByGuardian");
            courtEpoColumnList.AddColumn("GuardianName", "GuardianName");
            courtEpoColumnList.AddColumn("RequestedByOfficer", "RequestedByOfficer");
            courtEpoColumnList.AddColumn("OfficerName", "OfficerName");
            courtEpoColumnList.AddColumn("OfficerAgency", "OfficerAgency");
            courtEpoColumnList.AddColumn("OfficerPhone", "OfficerPhone");
            courtEpoColumnList.AddColumn("RequestedByState", "RequestedByState");
            courtEpoColumnList.AddColumn("StateAttorneyName", "StateAttorneyName");
            courtEpoColumnList.AddColumn("SeriousBodilyInjuryOccurred", "SeriousBodilyInjuryOccurred");
            courtEpoColumnList.AddColumn("UseOfWeaponOccurred", "UseOfWeaponOccurred");
            courtEpoColumnList.AddColumn("IssueFamilyViolenceHold", "IssueFamilyViolenceHold");
            courtEpoColumnList.AddColumn("HoldForPeriod", "HoldForPeriod");
            courtEpoColumnList.AddColumn("NotLessThanHours", "NotLessThanHours");
            courtEpoColumnList.AddColumn("NotMoreThanHours", "NotMoreThanHours");
            courtEpoColumnList.AddColumn("HoldUntilSpecifiedDate", "HoldUntilSpecifiedDate");
            courtEpoColumnList.AddColumn("DateToRelease", "DateToRelease");
            courtEpoColumnList.AddColumn("ProduceConditionOfBond", "ProduceConditionOfBond");
            courtEpoColumnList.AddColumn("ProduceMagistrateProtectiveOrder", "ProduceMagistrateProtectiveOrder");
            courtEpoColumnList.AddColumn("VictimAddressInformationConfidential", "VictimAddressInformationConfidential");


            var projectRoot = Utils.GetProjectRoot();
            var filePath = Path.Combine(projectRoot, "Helper/TestData/CourtEpo/create court epo.xlsx");

            Console.WriteLine(filePath);
            var dataSet = new DataSet(courtEpoColumnList);
            var courtEpoData = dataSet.ReadData(filePath);

            return courtEpoData;
        }


        public static List<Dictionary<string, string>> ReadCourtEpoConditionsData()
        {
            // Read dataset
            var courtEpoConditionsColumnList = new ColumnList();
            courtEpoConditionsColumnList.AddColumn("ActsOfFamilyViolence", "ActsOfFamilyViolence");
            courtEpoConditionsColumnList.AddColumn("Stalking", "Stalking");
            courtEpoConditionsColumnList.AddColumn("DirectCommunication", "DirectCommunication");
            courtEpoConditionsColumnList.AddColumn("ThreatCommunication", "ThreatCommunication");
            courtEpoConditionsColumnList.AddColumn("AnyCommunication", "AnyCommunication");
            courtEpoConditionsColumnList.AddColumn("PhysicalDistance", "PhysicalDistance");
            courtEpoConditionsColumnList.AddColumn("Yards", "Yards");
            courtEpoConditionsColumnList.AddColumn("NearResidence", "NearResidence");
            courtEpoConditionsColumnList.AddColumn("NearPlaceOfEmployment", "NearPlaceOfEmployment");
            courtEpoConditionsColumnList.AddColumn("NearSchool", "NearSchool");
            courtEpoConditionsColumnList.AddColumn("PossessFirearm", "PossessFirearm");
            courtEpoConditionsColumnList.AddColumn("Tracking", "Tracking");
            courtEpoConditionsColumnList.AddColumn("GpsMonitoring", "GpsMonitoring");
            courtEpoConditionsColumnList.AddColumn("GpsMonitoringDescription", "GpsMonitoringDescription");
            courtEpoConditionsColumnList.AddColumn("HumanTrafficking", "HumanTrafficking");
            courtEpoConditionsColumnList.AddColumn("VictimNotification", "VictimNotification");
            courtEpoConditionsColumnList.AddColumn("CourtAppearance", "CourtAppearance");
            courtEpoConditionsColumnList.AddColumn("VictimContact", "VictimContact");
            courtEpoConditionsColumnList.AddColumn("ApproachResidence", "ApproachResidence");
            courtEpoConditionsColumnList.AddColumn("SchoolDaycare", "SchoolDaycare");
            courtEpoConditionsColumnList.AddColumn("Weapons", "Weapons");
            courtEpoConditionsColumnList.AddColumn("AlcoholDrugs", "AlcoholDrugs");
            courtEpoConditionsColumnList.AddColumn("PrescriptionMedications", "PrescriptionMedications");
            courtEpoConditionsColumnList.AddColumn("DrugTest", "DrugTest");
            courtEpoConditionsColumnList.AddColumn("CourtOrder", "CourtOrder");
            courtEpoConditionsColumnList.AddColumn("Offense", "Offense");
            courtEpoConditionsColumnList.AddColumn("OtherConditions", "OtherConditions");
            courtEpoConditionsColumnList.AddColumn("OtherConditionsDescription", "OtherConditionsDescription");


            var projectRoot = Utils.GetProjectRoot();
            var filePath = Path.Combine(projectRoot, "Helper/TestData/CourtEpo/court epo conditions data.xlsx");

            Console.WriteLine(filePath);
            var dataSet = new DataSet(courtEpoConditionsColumnList);
            var courtEpoConditionsData = dataSet.ReadData(filePath);

            return courtEpoConditionsData;
        }


        public static List<Dictionary<string, string>> ReadCourtEpoLogData()
        {
            // Read dataset
            var epoColumnList = new ColumnList();
            epoColumnList.AddColumn("EpoCaseNumber", "EpoCaseNumber");
            epoColumnList.AddColumn("EpoCaseCount", "EpoCaseCount");

            var projectRoot = Utils.GetProjectRoot();
            var filePath = Path.Combine(projectRoot, "Helper/Log/epo log from court.xlsx");

            Console.WriteLine(filePath);
            var dataSet = new DataSet(epoColumnList);
            var epoData = dataSet.ReadData(filePath);

            return epoData;
        }
    }
}
