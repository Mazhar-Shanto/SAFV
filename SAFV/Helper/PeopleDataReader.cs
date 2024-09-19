using OpenQA.Selenium.DevTools.V126.Network;
using SAFV.Helper.TestData;
using SAFV.Utility;

namespace SAFV.Helper
{
    class PeopleDataReader
    {
        private static ColumnList GetPeopleColumn()
        {
            var peopleColumnList = new ColumnList();
            peopleColumnList.AddColumn("FirstName", "FirstName");
            peopleColumnList.AddColumn("LastName", "LastName");
            peopleColumnList.AddColumn("MiddleName", "MiddleName");
            peopleColumnList.AddColumn("Alias", "Alias");
            peopleColumnList.AddColumn("AliasDescription", "AliasDescription");
            peopleColumnList.AddColumn("Victim", "Victim");
            peopleColumnList.AddColumn("Suspect", "Suspect");
            peopleColumnList.AddColumn("Witness", "Witness");
            peopleColumnList.AddColumn("OtherNotInvolved", "OtherNotInvolved");
            peopleColumnList.AddColumn("VictimWouldLikeToUsePseudonym", "VictimWouldLikeToUsePseudonym");
            peopleColumnList.AddColumn("VictimRealFirstName", "VictimRealFirstName");
            peopleColumnList.AddColumn("VictimRealLastName", "VictimRealLastName");
            peopleColumnList.AddColumn("VictimRealMiddleName", "VictimRealMiddleName");
            peopleColumnList.AddColumn("WasPresent", "WasPresent");
            peopleColumnList.AddColumn("IsUnknownPerson", "IsUnknownPerson");
            peopleColumnList.AddColumn("Race", "Race");
            peopleColumnList.AddColumn("Sex", "Sex");
            peopleColumnList.AddColumn("DateOfBirth", "DateOfBirth");
            peopleColumnList.AddColumn("Age", "Age");
            peopleColumnList.AddColumn("Ethnicity", "Ethnicity");
            peopleColumnList.AddColumn("EyeColor", "EyeColor");
            peopleColumnList.AddColumn("HairColor", "HairColor");
            peopleColumnList.AddColumn("HeightFeet", "HeightFeet");
            peopleColumnList.AddColumn("HeightInches", "HeightInches");
            peopleColumnList.AddColumn("Weight", "Weight");
            peopleColumnList.AddColumn("Ssn", "Ssn");
            peopleColumnList.AddColumn("PrimaryLanguage", "PrimaryLanguage");
            peopleColumnList.AddColumn("PersonIdType", "PersonIdType");
            peopleColumnList.AddColumn("IdNumber", "IdNumber");
            peopleColumnList.AddColumn("IdState", "IdState");
            peopleColumnList.AddColumn("IdExpirationDate", "IdExpirationDate");
            peopleColumnList.AddColumn("Email", "Email");
            peopleColumnList.AddColumn("SafeToContactViaEmail", "SafeToContactViaEmail");
            peopleColumnList.AddColumn("Occupation", "Occupation");
            peopleColumnList.AddColumn("PlaceOfBirth", "PlaceOfBirth");
            peopleColumnList.AddColumn("NameOfEmployer", "NameOfEmployer");
            peopleColumnList.AddColumn("ScarsMarks", "ScarsMarks");
            peopleColumnList.AddColumn("TxSid", "TxSid");
            peopleColumnList.AddColumn("SpecialNeeds", "SpecialNeeds");
            peopleColumnList.AddColumn("HandcuffedPriorToArrest", "HandcuffedPriorToArrest");
            peopleColumnList.AddColumn("HandcuffReason", "HandcuffReason");
            peopleColumnList.AddColumn("IsPersonChild", "IsPersonChild");
            peopleColumnList.AddColumn("WasThisChildPresent", "WasThisChildPresent");
            peopleColumnList.AddColumn("DidTheyAttemptToIntervene", "DidTheyAttemptToIntervene");
            peopleColumnList.AddColumn("PrimaryCaretakerOfChild", "PrimaryCaretakerOfChild");
            peopleColumnList.AddColumn("PersonGivenMirandaWarning", "PersonGivenMirandaWarning");
            peopleColumnList.AddColumn("MirandaWarningDate", "MirandaWarningDate");
            peopleColumnList.AddColumn("MirandaWarningTime", "MirandaWarningTime");
            peopleColumnList.AddColumn("StatementsMadeAfterMiranda", "StatementsMadeAfterMiranda");
            peopleColumnList.AddColumn("IsPersonElderly", "IsPersonElderly");
            peopleColumnList.AddColumn("IsPersonDisabled", "IsPersonDisabled");
            peopleColumnList.AddColumn("PhoneType", "PhoneType");
            peopleColumnList.AddColumn("PhoneNumber", "PhoneNumber");
            peopleColumnList.AddColumn("PrimaryContact", "PrimaryContact");
            peopleColumnList.AddColumn("AddressGroup", "AddressGroup");
            peopleColumnList.AddColumn("Address1", "Address1");
            peopleColumnList.AddColumn("Address2", "Address2");
            peopleColumnList.AddColumn("City", "City");
            peopleColumnList.AddColumn("State", "State");
            peopleColumnList.AddColumn("County", "County");
            peopleColumnList.AddColumn("ZipCode", "ZipCode");

            return peopleColumnList;
        }


        public static List<Dictionary<string, string>> ReadOtherPeopleData()
        {
            // Read dataset
            var peopleColumnList = GetPeopleColumn();


            var projectRoot = Utils.GetProjectRoot();
            var filePath = Path.Combine(projectRoot, "Helper/TestData/CreateIncident/People/create people data - other.xlsx");

            Console.WriteLine(filePath);
            var dataSet = new DataSet(peopleColumnList);
            var peopleData = dataSet.ReadData(filePath);

            return peopleData;
        }


        public static List<Dictionary<string, string>> ReadVictimData()
        {
            // Read dataset
            var peopleColumnList = GetPeopleColumn();


            var projectRoot = Utils.GetProjectRoot();
            var filePath = Path.Combine(projectRoot, "Helper/TestData/CreateIncident/People/create people data - victim.xlsx");

            Console.WriteLine(filePath);
            var dataSet = new DataSet(peopleColumnList);
            var peopleData = dataSet.ReadData(filePath);

            return peopleData;
        }


        public static List<Dictionary<string, string>> ReadSuspectData()
        {
            // Read dataset
            var peopleColumnList = GetPeopleColumn();


            var projectRoot = Utils.GetProjectRoot();
            var filePath = Path.Combine(projectRoot, "Helper/TestData/CreateIncident/People/create people data - suspect.xlsx");

            Console.WriteLine(filePath);
            var dataSet = new DataSet(peopleColumnList);
            var peopleData = dataSet.ReadData(filePath);

            return peopleData;
        }


        public static List<Dictionary<string, string>> ReadWitnessData()
        {
            // Read dataset
            var peopleColumnList = GetPeopleColumn();


            var projectRoot = Utils.GetProjectRoot();
            var filePath = Path.Combine(projectRoot, "Helper/TestData/CreateIncident/People/create people data - witness.xlsx");

            Console.WriteLine(filePath);
            var dataSet = new DataSet(peopleColumnList);
            var peopleData = dataSet.ReadData(filePath);

            return peopleData;
        }
    }
}
