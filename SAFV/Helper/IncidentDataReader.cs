using SAFV.Helper.TestData;
using SAFV.Utility;

namespace SAFV.Helper
{
    internal class IncidentDataReader
    {
        public static List<Dictionary<string, string>> ReadIncidentData()
        {
            // Read dataset
            var incidentColumnList = new ColumnList();
            incidentColumnList.AddColumn("ReportDate", "ReportDate");
            incidentColumnList.AddColumn("IncidentCaseNumber", "IncidentCaseNumber");
            incidentColumnList.AddColumn("IncidentType", "IncidentType");
            incidentColumnList.AddColumn("ConfidentialMode", "ConfidentialMode");
            incidentColumnList.AddColumn("CaseType", "CaseType");

            var projectRoot = Utils.GetProjectRoot();
            var filePath = Path.Combine(projectRoot, "Helper/TestData/CreteIncident/create incident data.xlsx");

            Console.WriteLine(filePath);
            var dataSet = new DataSet(incidentColumnList);
            var incidentData = dataSet.ReadData(filePath);

            return incidentData;
        }
    }
}
