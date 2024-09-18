using SAFV.Helper.TestData;
using SAFV.Utility;

namespace SAFV.Helper
{
    internal class IncidentInfoDataReader
    {
        public static List<Dictionary<string, string>> ReadIncidentInfoData()
        {
            // Read dataset
            var incidentInfoColumnList = new ColumnList();
            incidentInfoColumnList.AddColumn("OfficerBadgeNumber", "OfficerBadgeNumber");
            incidentInfoColumnList.AddColumn("OfficerRank", "OfficerRank");
            incidentInfoColumnList.AddColumn("District", "District");
            incidentInfoColumnList.AddColumn("ChildrenInvolved", "ChildrenInvolved");
            incidentInfoColumnList.AddColumn("RequiresCpsNotification", "RequiresCpsNotification");
            incidentInfoColumnList.AddColumn("CpsHaveBeenCalled", "CpsHaveBeenCalled");
            incidentInfoColumnList.AddColumn("CpsNumber", "CpsNumber");
            incidentInfoColumnList.AddColumn("CpsNotifedAt", "CpsNotifedAt");
            incidentInfoColumnList.AddColumn("CpsSafetyIssues", "CpsSafetyIssues");
            incidentInfoColumnList.AddColumn("OfficerPrimaryConcern", "OfficerPrimaryConcern");
            incidentInfoColumnList.AddColumn("SuspectedMethManufacture", "SuspectedMethManufacture");
            incidentInfoColumnList.AddColumn("SensitiveIssues", "SensitiveIssues");
            incidentInfoColumnList.AddColumn("Covid19Exposure", "Covid19Exposure");
            incidentInfoColumnList.AddColumn("HowPoliceContacted", "HowPoliceContacted");
            incidentInfoColumnList.AddColumn("WhatWasBeingReported", "WhatWasBeingReported");
            incidentInfoColumnList.AddColumn("DispatchedDate", "DispatchedDate");
            incidentInfoColumnList.AddColumn("DispatchedTime", "DispatchedTime");

            var projectRoot = Utils.GetProjectRoot();
            var filePath = Path.Combine(projectRoot, "Helper/TestData/CreateIncident/incident info data.xlsx");

            Console.WriteLine(filePath);
            var dataSet = new DataSet(incidentInfoColumnList);
            var incidentInfoData = dataSet.ReadData(filePath);

            return incidentInfoData;
        }
    }
}
