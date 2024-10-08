using SAFV.Helper.TestData;
using SAFV.Utility;

namespace SAFV.Helper
{
    internal class EpoDataReader
    {
        public static List<Dictionary<string, string>> ReadEpoData()
        {
            // Read dataset
            var epoColumnList = new ColumnList();
            epoColumnList.AddColumn("OffenseGroup", "OffenseGroup");
            epoColumnList.AddColumn("RequestedByVictim", "RequestedByVictim");
            epoColumnList.AddColumn("RequestedByGuardian", "RequestedByGuardian");
            epoColumnList.AddColumn("GuardiansName", "GuardiansName");
            epoColumnList.AddColumn("RequestedByOfficer", "RequestedByOfficer");
            epoColumnList.AddColumn("RequestedByState", "RequestedByState");
            epoColumnList.AddColumn("StateAttorneyName", "StateAttorneyName");
            epoColumnList.AddColumn("RequestedByMagistrate", "RequestedByMagistrate");
            epoColumnList.AddColumn("MagistratesName", "MagistratesName");
            epoColumnList.AddColumn("HoldRequested", "HoldRequested");
            epoColumnList.AddColumn("Hour24", "Hour24");
            epoColumnList.AddColumn("Hour48", "Hour48");
            epoColumnList.AddColumn("ExplainHold", "ExplainHold");
            epoColumnList.AddColumn("JudicialOrganization", "JudicialOrganization");
            epoColumnList.AddColumn("SignEpo", "SignEpo");
            epoColumnList.AddColumn("WitnessIsLocal", "WitnessIsLocal");
            epoColumnList.AddColumn("SignerName", "SignerName");
            epoColumnList.AddColumn("Judge", "Judge");

            var projectRoot = Utils.GetProjectRoot();
            var filePath = Path.Combine(projectRoot, "Helper/TestData/CreateIncident/epo data.xlsx");

            Console.WriteLine(filePath);
            var dataSet = new DataSet(epoColumnList);
            var epoData = dataSet.ReadData(filePath);

            return epoData;
        }


        public static List<Dictionary<string, string>> ReadEpoLogData()
        {
            // Read dataset
            var epoColumnList = new ColumnList();
            epoColumnList.AddColumn("EpoCaseNumber", "EpoCaseNumber");

            var projectRoot = Utils.GetProjectRoot();
            var filePath = Path.Combine(projectRoot, "Helper/Log/epo log.xlsx");

            Console.WriteLine(filePath);
            var dataSet = new DataSet(epoColumnList);
            var epoData = dataSet.ReadData(filePath);

            return epoData;
        }
    }
}
