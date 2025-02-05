using SAFV.Helper.TestData;
using SAFV.Utility;

namespace SAFV.Helper.Detective
{
    internal class CaseDataReader
    {
        public static List<Dictionary<string, string>> ReadCaseData(string caseType)
        {
            // Read dataset
            var caseColumnList = new ColumnList();
            caseColumnList.AddColumn("ReportDate", "ReportDate");
            caseColumnList.AddColumn("DetectiveCaseNumber", "DetectiveCaseNumber");
            caseColumnList.AddColumn("IncidentType", "IncidentType");
            caseColumnList.AddColumn("ConfidentialMode", "ConfidentialMode");
            caseColumnList.AddColumn("CaseType", "CaseType");

            var projectRoot = Utils.GetProjectRoot();
            var filePath = "";
            if (caseType == "Main")
            {
                filePath = Path.Combine(projectRoot, "Helper/TestData/CreateCase/create case data - main.xlsx");
            }
            else if (caseType == "Supplement")
            {
                caseColumnList.AddColumn("MainCase", "MainCase");
                filePath = Path.Combine(projectRoot, "Helper/TestData/CreateCase/create case data - supplement.xlsx");
            }
            else if (caseType == "Confidential")
            {
                filePath = Path.Combine(projectRoot, "Helper/TestData/CreateCase/create case data - confidential.xlsx");
            }

            Console.WriteLine(filePath);
            var dataSet = new DataSet(caseColumnList);
            var caseData = dataSet.ReadData(filePath);

            return caseData;
        }

        public static List<Dictionary<string, string>> ReadCaseCount()
        {
            // Read dataset
            var logColumnList = new ColumnList();
            logColumnList.AddColumn("CaseCount", "CaseCount");
            logColumnList.AddColumn("CaseNumber", "CaseNumber");
            logColumnList.AddColumn("SupplementCount", "SupplementCount");
            logColumnList.AddColumn("SupplementNumber", "SupplementNumber");
            logColumnList.AddColumn("MainCaseForSupplement", "MainCaseForSupplement");

            var projectRoot = Utils.GetProjectRoot();
            var filePath = Path.Combine(projectRoot, "Helper/Log/detective case log.xlsx");

            Console.WriteLine(filePath);
            var dataSet = new DataSet(logColumnList);
            var logData = dataSet.ReadData(filePath);

            return logData;
        }

        public static List<Dictionary<string, string>> ReadLinkedCaseData(string caseType)
        {
            // Read dataset
            var caseColumnList = new ColumnList();
            caseColumnList.AddColumn("ReportDate", "ReportDate");
            caseColumnList.AddColumn("DetectiveCaseNumber", "DetectiveCaseNumber");
            caseColumnList.AddColumn("IncidentType", "IncidentType");
            caseColumnList.AddColumn("ConfidentialMode", "ConfidentialMode");
            caseColumnList.AddColumn("CaseType", "CaseType");
            caseColumnList.AddColumn("Incidents", "Incidents");

            var projectRoot = Utils.GetProjectRoot();
            var filePath = "";
            if (caseType == "Main")
            {
                filePath = Path.Combine(projectRoot, "Helper/TestData/LinkedIncident/create case from incidents data - main.xlsx");
            }
            else if (caseType == "Supplement")
            {
                caseColumnList.AddColumn("MainCase", "MainCase");
                filePath = Path.Combine(projectRoot, "Helper/TestData/LinkedIncident/create case data - supplement.xlsx");
            }
            else if (caseType == "Confidential")
            {
                filePath = Path.Combine(projectRoot, "Helper/TestData/LinkedIncident/create case data - confidential.xlsx");
            }

            Console.WriteLine(filePath);
            var dataSet = new DataSet(caseColumnList);
            var caseData = dataSet.ReadData(filePath);

            return caseData;
        }
    }
}
