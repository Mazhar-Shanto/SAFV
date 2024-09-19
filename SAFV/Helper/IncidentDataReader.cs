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
    }
}
