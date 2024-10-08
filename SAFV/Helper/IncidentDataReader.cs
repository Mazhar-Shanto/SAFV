using SAFV.Helper.TestData;
using SAFV.Utility;

namespace SAFV.Helper
{
    internal class IncidentDataReader
    {
        public static List<Dictionary<string, string>> ReadIncidentData(string incidentType)
        {
            // Read dataset
            var incidentColumnList = new ColumnList();
            incidentColumnList.AddColumn("ReportDate", "ReportDate");
            incidentColumnList.AddColumn("IncidentCaseNumber", "IncidentCaseNumber");
            incidentColumnList.AddColumn("IncidentType", "IncidentType");
            incidentColumnList.AddColumn("ConfidentialMode", "ConfidentialMode");
            incidentColumnList.AddColumn("CaseType", "CaseType");

            var projectRoot = Utils.GetProjectRoot();
            var filePath = "";
            if (incidentType == "Main")
            {
                filePath = Path.Combine(projectRoot, "Helper/TestData/CreateIncident/create incident data - main.xlsx");
            }
            else if (incidentType == "Supplement")
            {
                incidentColumnList.AddColumn("MainCase", "MainCase");
                filePath = Path.Combine(projectRoot, "Helper/TestData/CreateIncident/create incident data - supplement.xlsx");
            }
            else if (incidentType == "Confidential")
            {
                filePath = Path.Combine(projectRoot, "Helper/TestData/CreateIncident/create incident data - confidential.xlsx");
            }

            Console.WriteLine(filePath);
            var dataSet = new DataSet(incidentColumnList);
            var incidentData = dataSet.ReadData(filePath);

            return incidentData;
        }

        public static List<Dictionary<string, string>> ReadIncidentCount()
        {
            // Read dataset
            var logColumnList = new ColumnList();
            logColumnList.AddColumn("CaseCount", "CaseCount");
            logColumnList.AddColumn("CaseNumber", "CaseNumber");
            logColumnList.AddColumn("SupplementCount", "SupplementCount");
            logColumnList.AddColumn("SupplementNumber", "SupplementNumber");
            logColumnList.AddColumn("MainCaseForSupplement", "MainCaseForSupplement");

            var projectRoot = Utils.GetProjectRoot();
            var filePath = Path.Combine(projectRoot, "Helper/Log/test log.xlsx");

            Console.WriteLine(filePath);
            var dataSet = new DataSet(logColumnList);
            var logData = dataSet.ReadData(filePath);

            return logData;
        }
    }
}
