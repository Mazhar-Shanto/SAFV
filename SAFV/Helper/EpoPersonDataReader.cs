using OpenQA.Selenium.DevTools.V126.Network;
using SAFV.Helper.TestData;
using SAFV.Utility;

namespace SAFV.Helper
{
    class EpoPersonDataReader
    {
        public static List<Dictionary<string, string>> ReadCourtEpoSuspectData()
        {
            // Read dataset
            var courtEpoSuspectColumnList = new ColumnList();
            courtEpoSuspectColumnList.AddColumn("FirstName", "FirstName");
            courtEpoSuspectColumnList.AddColumn("LastName", "LastName");
            courtEpoSuspectColumnList.AddColumn("MiddleName", "MiddleName");
            courtEpoSuspectColumnList.AddColumn("Race", "Race");
            courtEpoSuspectColumnList.AddColumn("Sex", "Sex");
            courtEpoSuspectColumnList.AddColumn("DateOfBirth", "DateOfBirth");
            courtEpoSuspectColumnList.AddColumn("Ethnicity", "Ethnicity");
            courtEpoSuspectColumnList.AddColumn("EyeColor", "EyeColor");
            courtEpoSuspectColumnList.AddColumn("HairColor", "HairColor");
            courtEpoSuspectColumnList.AddColumn("SkinColor", "SkinColor");
            courtEpoSuspectColumnList.AddColumn("PrimaryLanguage", "PrimaryLanguage");
            courtEpoSuspectColumnList.AddColumn("MedicalConditions", "MedicalConditions");
            courtEpoSuspectColumnList.AddColumn("MarksOrTattoos", "MarksOrTattoos");
            courtEpoSuspectColumnList.AddColumn("PlaceOfBirth", "PlaceOfBirth");
            courtEpoSuspectColumnList.AddColumn("Weight", "Weight");
            courtEpoSuspectColumnList.AddColumn("HeightFeet", "HeightFeet");
            courtEpoSuspectColumnList.AddColumn("HeightInch", "HeightInch");
            courtEpoSuspectColumnList.AddColumn("IsThisPersonChild", "IsThisPersonChild");
            courtEpoSuspectColumnList.AddColumn("UsCitizen", "UsCitizen");
            courtEpoSuspectColumnList.AddColumn("SsnFeild", "SsnFeild");
            courtEpoSuspectColumnList.AddColumn("IdType", "IdType");
            courtEpoSuspectColumnList.AddColumn("IdNumber", "IdNumber");
            courtEpoSuspectColumnList.AddColumn("IdState", "IdState");
            courtEpoSuspectColumnList.AddColumn("IdExpires", "IdExpires");
            courtEpoSuspectColumnList.AddColumn("TxSid", "TxSid");
            courtEpoSuspectColumnList.AddColumn("Fbi", "Fbi");
            courtEpoSuspectColumnList.AddColumn("Fpc", "Fpc");
            courtEpoSuspectColumnList.AddColumn("Mnu", "Mnu");
            courtEpoSuspectColumnList.AddColumn("ConcealedHandgunLicenseHolder", "ConcealedHandgunLicenseHolder");


            var projectRoot = Utils.GetProjectRoot();
            var filePath = Path.Combine(projectRoot, "Helper/TestData/CourtEpo/court epo suspect data.xlsx");

            Console.WriteLine(filePath);
            var dataSet = new DataSet(courtEpoSuspectColumnList);
            var courtEpoSuspectData = dataSet.ReadData(filePath);

            return courtEpoSuspectData;
        }

        public static List<Dictionary<string, string>> ReadCourtEpoVictimData()
        {
            // Read dataset
            var courtEpoVictimColumnList = new ColumnList();
            courtEpoVictimColumnList.AddColumn("FirstName", "FirstName");
            courtEpoVictimColumnList.AddColumn("LastName", "LastName");
            courtEpoVictimColumnList.AddColumn("MiddleName", "MiddleName");
            courtEpoVictimColumnList.AddColumn("Race", "Race");
            courtEpoVictimColumnList.AddColumn("Sex", "Sex");
            courtEpoVictimColumnList.AddColumn("DateOfBirth", "DateOfBirth");
            courtEpoVictimColumnList.AddColumn("Ethnicity", "Ethnicity");
            courtEpoVictimColumnList.AddColumn("EyeColor", "EyeColor");
            courtEpoVictimColumnList.AddColumn("HairColor", "HairColor");
            courtEpoVictimColumnList.AddColumn("Weight", "Weight");
            courtEpoVictimColumnList.AddColumn("HeightFeet", "HeightFeet");
            courtEpoVictimColumnList.AddColumn("HeightInch", "HeightInch");
            courtEpoVictimColumnList.AddColumn("PrimaryLanguage", "PrimaryLanguage");
            courtEpoVictimColumnList.AddColumn("IsThisPersonChild", "IsThisPersonChild");
            courtEpoVictimColumnList.AddColumn("SsnFeild", "SsnFeild");
            courtEpoVictimColumnList.AddColumn("NameOfemployer", "NameOfemployer");
            courtEpoVictimColumnList.AddColumn("VictimRelationshipToSuspect", "VictimRelationshipToSuspect");


            var projectRoot = Utils.GetProjectRoot();
            var filePath = Path.Combine(projectRoot, "Helper/TestData/CourtEpo/court epo victim data.xlsx");

            Console.WriteLine(filePath);
            var dataSet = new DataSet(courtEpoVictimColumnList);
            var courtEpoVictimData = dataSet.ReadData(filePath);

            return courtEpoVictimData;
        }

        public static List<Dictionary<string, string>> ReadCourtEpoOtherData()
        {
            // Read dataset
            var courtEpoOtherColumnList = new ColumnList();
            courtEpoOtherColumnList.AddColumn("FirstName", "FirstName");
            courtEpoOtherColumnList.AddColumn("LastName", "LastName");
            courtEpoOtherColumnList.AddColumn("MiddleName", "MiddleName");
            courtEpoOtherColumnList.AddColumn("Race", "Race");
            courtEpoOtherColumnList.AddColumn("Sex", "Sex");
            courtEpoOtherColumnList.AddColumn("DateOfBirth", "DateOfBirth");
            courtEpoOtherColumnList.AddColumn("Ethnicity", "Ethnicity");
            courtEpoOtherColumnList.AddColumn("EyeColor", "EyeColor");
            courtEpoOtherColumnList.AddColumn("HairColor", "HairColor");
            courtEpoOtherColumnList.AddColumn("Weight", "Weight");
            courtEpoOtherColumnList.AddColumn("HeightFeet", "HeightFeet");
            courtEpoOtherColumnList.AddColumn("HeightInch", "HeightInch");
            courtEpoOtherColumnList.AddColumn("PrimaryLanguage", "PrimaryLanguage");
            courtEpoOtherColumnList.AddColumn("IsThisPersonChild", "IsThisPersonChild");
            courtEpoOtherColumnList.AddColumn("SsnFeild", "SsnFeild");


            var projectRoot = Utils.GetProjectRoot();
            var filePath = Path.Combine(projectRoot, "Helper/TestData/CourtEpo/court epo other data.xlsx");

            Console.WriteLine(filePath);
            var dataSet = new DataSet(courtEpoOtherColumnList);
            var courtEpoOtherData = dataSet.ReadData(filePath);

            return courtEpoOtherData;
        }
    }
}
