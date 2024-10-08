using SAFV.Helper.TestData;
using SAFV.Utility;

namespace SAFV.Helper
{
    internal class EvidenceDataReader
    {
        public static List<Dictionary<string, string>> ReadEvidenceData()
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
            var filePath = Path.Combine(projectRoot, "Helper/TestData/CreateIncident/evidence data.xlsx");

            Console.WriteLine(filePath);
            var dataSet = new DataSet(suspectEvidenceColumnList);
            var suspectEvidenceData = dataSet.ReadData(filePath);

            return suspectEvidenceData;
        }
    }
}
