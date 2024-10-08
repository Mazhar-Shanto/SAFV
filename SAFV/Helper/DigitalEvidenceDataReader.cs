using SAFV.Helper.TestData;
using SAFV.Utility;

namespace SAFV.Helper
{
    internal class DigitalEvidenceDataReader
    {
        public static List<Dictionary<string, string>> ReadDigitalEvidenceData()
        {
            // Read dataset
            var digitalEvidencetColumnList = new ColumnList();
            digitalEvidencetColumnList.AddColumn("WasDigitalEvidenceCollected", "WasDigitalEvidenceCollected");
            digitalEvidencetColumnList.AddColumn("VideoBodyCamera", "VideoBodyCamera");
            digitalEvidencetColumnList.AddColumn("VideoInCar", "VideoInCar");
            digitalEvidencetColumnList.AddColumn("VideoOther", "VideoOther");
            digitalEvidencetColumnList.AddColumn("VideoOtherDescription", "VideoOtherDescription");
            digitalEvidencetColumnList.AddColumn("Photographs", "Photographs");
            digitalEvidencetColumnList.AddColumn("PhotographsDescription", "PhotographsDescription");
            digitalEvidencetColumnList.AddColumn("Audiocall", "Audiocall");
            digitalEvidencetColumnList.AddColumn("Audio", "Audio");
            digitalEvidencetColumnList.AddColumn("AudioDescription", "AudioDescription");
            digitalEvidencetColumnList.AddColumn("ExplainWhyNotCollected", "ExplainWhyNotCollected");

            var projectRoot = Utils.GetProjectRoot();
            var filePath = Path.Combine(projectRoot, "Helper/TestData/CreateIncident/digital evidence data.xlsx");

            Console.WriteLine(filePath);
            var dataSet = new DataSet(digitalEvidencetColumnList);
            var digitalEvidencetData = dataSet.ReadData(filePath);

            return digitalEvidencetData;
        }
    }
}
