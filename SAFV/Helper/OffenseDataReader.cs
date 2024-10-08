using SAFV.Helper.TestData;
using SAFV.Utility;
using System.Reactive.Subjects;

namespace SAFV.Helper
{
    internal class OffenseDataReader
    {
        public static List<Dictionary<string, string>> ReadOffenseData()
        {
            // Read dataset
            var offenseColumnList = new ColumnList();
            offenseColumnList.AddColumn("Suspect", "Suspect");
            offenseColumnList.AddColumn("Victim", "Victim");
            offenseColumnList.AddColumn("DateOfOffense", "DateOfOffense");
            offenseColumnList.AddColumn("TimeOfOffense", "TimeOfOffense");
            offenseColumnList.AddColumn("OffenseLocation", "OffenseLocation");
            offenseColumnList.AddColumn("OffenseType", "OffenseType");         

            var projectRoot = Utils.GetProjectRoot();
            var filePath = Path.Combine(projectRoot, "Helper/TestData/CreateIncident/Offense/offense data.xlsx");

            Console.WriteLine(filePath);
            var dataSet = new DataSet(offenseColumnList);
            var offenseData = dataSet.ReadData(filePath);

            return offenseData;
        }

        public static List<Dictionary<string, string>> ReadSceneData()
        {
            // Read dataset
            var sceneColumnList = new ColumnList();
            sceneColumnList.AddColumn("DidNotVisitScene", "DidNotVisitScene");
            sceneColumnList.AddColumn("DidNotVisitSceneReason", "DidNotVisitSceneReason");
            sceneColumnList.AddColumn("BrokenFurniture", "BrokenFurniture");
            sceneColumnList.AddColumn("BloodAtScene", "BloodAtScene");
            sceneColumnList.AddColumn("BrokenPhone", "BrokenPhone");
            sceneColumnList.AddColumn("HoleInWall", "HoleInWall");
            sceneColumnList.AddColumn("BrokenGlass", "BrokenGlass");
            sceneColumnList.AddColumn("ChildrenCrying", "ChildrenCrying");
            sceneColumnList.AddColumn("Weapon", "Weapon");
            sceneColumnList.AddColumn("LackOfUtilites", "LackOfUtilites");
            sceneColumnList.AddColumn("ClumpOfHair", "ClumpOfHair");
            sceneColumnList.AddColumn("DamagedKickedRemovedDoor", "DamagedKickedRemovedDoor");
            sceneColumnList.AddColumn("DoorToWhichRoom", "DoorToWhichRoom");
            sceneColumnList.AddColumn("ForcedEntry", "ForcedEntry");
            sceneColumnList.AddColumn("WhichLocation", "WhichLocation");
            sceneColumnList.AddColumn("DrugsParaphernalia", "DrugsParaphernalia");
            sceneColumnList.AddColumn("Alcohol", "Alcohol");
            sceneColumnList.AddColumn("Other", "Other");
            sceneColumnList.AddColumn("OtherDescription", "OtherDescription");
            sceneColumnList.AddColumn("DescribeSceneUponYourArrival", "DescribeSceneUponYourArrival");

            var projectRoot = Utils.GetProjectRoot();
            var filePath = Path.Combine(projectRoot, "Helper/TestData/CreateIncident/Offense/scene data.xlsx");

            Console.WriteLine(filePath);
            var dataSet = new DataSet(sceneColumnList);
            var sceneData = dataSet.ReadData(filePath);

            return sceneData;
        }

        public static List<Dictionary<string, string>> ReadBiasData()
        {
            // Read dataset
            var biasColumnList = new ColumnList();
            biasColumnList.AddColumn("ByGender", "ByGender");
            biasColumnList.AddColumn("GenderBias", "GenderBias");
            biasColumnList.AddColumn("ByGenderIdentity", "ByGenderIdentity");
            biasColumnList.AddColumn("GenderIdentityBias", "GenderIdentityBias");
            biasColumnList.AddColumn("ByRace", "ByRace");
            biasColumnList.AddColumn("RaceBias", "RaceBias");
            biasColumnList.AddColumn("ByReligion", "ByReligion");
            biasColumnList.AddColumn("ReligionBias", "ReligionBias");
            biasColumnList.AddColumn("BySexualOrientation", "BySexualOrientation");
            biasColumnList.AddColumn("SexualOrientationBias", "SexualOrientationBias");
            biasColumnList.AddColumn("ByDisability", "ByDisability");
            biasColumnList.AddColumn("DisabilityBias", "DisabilityBias");
            biasColumnList.AddColumn("NoBias", "NoBias");
            biasColumnList.AddColumn("UnknownBias", "UnknownBias");

            var projectRoot = Utils.GetProjectRoot();
            var filePath = Path.Combine(projectRoot, "Helper/TestData/CreateIncident/Offense/bias data.xlsx");

            Console.WriteLine(filePath);
            var dataSet = new DataSet(biasColumnList);
            var biasData = dataSet.ReadData(filePath);

            return biasData;
        }

        public static List<Dictionary<string, string>> ReadMannerData()
        {
            // Read dataset
            var mannerColumnList = new ColumnList();
            mannerColumnList.AddColumn("ActionOfSuspect", "ActionOfSuspect");
            mannerColumnList.AddColumn("ActionDescription", "ActionDescription");
            mannerColumnList.AddColumn("HowSuspectCommitAction", "HowSuspectCommitAction");
            mannerColumnList.AddColumn("DescribeObject", "DescribeObject");
            mannerColumnList.AddColumn("Face", "Face");
            mannerColumnList.AddColumn("Upperbody", "Upperbody");
            mannerColumnList.AddColumn("LowerBody", "LowerBody");
            mannerColumnList.AddColumn("EntireBody", "EntireBody");
            mannerColumnList.AddColumn("Head", "Head");
            mannerColumnList.AddColumn("StomachAbdomen", "StomachAbdomen");
            mannerColumnList.AddColumn("Genitals", "Genitals");
            mannerColumnList.AddColumn("Neck", "Neck");
            mannerColumnList.AddColumn("Throat", "Throat");
            mannerColumnList.AddColumn("Extremities", "Extremities");

            var projectRoot = Utils.GetProjectRoot();
            var filePath = Path.Combine(projectRoot, "Helper/TestData/CreateIncident/Offense/manner data.xlsx");

            Console.WriteLine(filePath);
            var dataSet = new DataSet(mannerColumnList);
            var mannerData = dataSet.ReadData(filePath);

            return mannerData;
        }

        public static List<Dictionary<string, string>> ReadOffenseRiskAssessmentData()
        {
            // Read dataset
            var riskAssessmentColumnList = new ColumnList();
            riskAssessmentColumnList.AddColumn("FamilyViolenceLikelyToOccur", "FamilyViolenceLikelyToOccur");
            riskAssessmentColumnList.AddColumn("UsedOrThreatenedWithWeapon", "UsedOrThreatenedWithWeapon");
            riskAssessmentColumnList.AddColumn("ThreatenedToKill", "ThreatenedToKill");
            riskAssessmentColumnList.AddColumn("SuspectHasGun", "SuspectHasGun");
            riskAssessmentColumnList.AddColumn("GunDetailsInfo", "GunDetailsInfo");
            riskAssessmentColumnList.AddColumn("Strangulation", "Strangulation");
            riskAssessmentColumnList.AddColumn("Violence", "Violence");
            riskAssessmentColumnList.AddColumn("Jealousy", "Jealousy");
            riskAssessmentColumnList.AddColumn("Controlling", "Controlling");
            riskAssessmentColumnList.AddColumn("ViolenceIncreased", "ViolenceIncreased");
            riskAssessmentColumnList.AddColumn("ViolenceIncreasedDescription", "ViolenceIncreasedDescription");
            riskAssessmentColumnList.AddColumn("DestroyedItems", "DestroyedItems");
            riskAssessmentColumnList.AddColumn("HurtPets", "HurtPets");
            riskAssessmentColumnList.AddColumn("Unemployed", "Unemployed");
            riskAssessmentColumnList.AddColumn("Suicidal", "Suicidal");
            riskAssessmentColumnList.AddColumn("Spying", "Spying");
            riskAssessmentColumnList.AddColumn("ThreateningMessages", "ThreateningMessages");
            riskAssessmentColumnList.AddColumn("AlcoholAbuse", "AlcoholAbuse");
            riskAssessmentColumnList.AddColumn("DrugUse", "DrugUse");
            riskAssessmentColumnList.AddColumn("MightKillYou", "MightKillYou");
            riskAssessmentColumnList.AddColumn("ForcedSex", "ForcedSex");
            riskAssessmentColumnList.AddColumn("Separation", "Separation");
            riskAssessmentColumnList.AddColumn("RecentSeparation", "RecentSeparation");
            riskAssessmentColumnList.AddColumn("UnrelatedChild", "UnrelatedChild");
            riskAssessmentColumnList.AddColumn("PriorContacts", "PriorContacts");
            riskAssessmentColumnList.AddColumn("CourtAction", "CourtAction");
            riskAssessmentColumnList.AddColumn("AdditionalInfo", "AdditionalInfo");
            riskAssessmentColumnList.AddColumn("PriorProtectiveOrder", "PriorProtectiveOrder");
            riskAssessmentColumnList.AddColumn("DateTimeOfAssessment", "DateTimeOfAssessment");

            var projectRoot = Utils.GetProjectRoot();
            var filePath = Path.Combine(projectRoot, "Helper/TestData/CreateIncident/Offense/risk assessment data.xlsx");

            Console.WriteLine(filePath);
            var dataSet = new DataSet(riskAssessmentColumnList);
            var riskAssessmentData = dataSet.ReadData(filePath);

            return riskAssessmentData;
        }

        public static List<Dictionary<string, string>> ReadAggAssaultData()
        {
            // Read dataset
            var aggAssaultColumnList = new ColumnList();
            aggAssaultColumnList.AddColumn("SeriousBodilyInjury", "SeriousBodilyInjury");
            aggAssaultColumnList.AddColumn("WhoGaveOpinion", "WhoGaveOpinion");
            aggAssaultColumnList.AddColumn("SubstantialRiskOfDeath", "SubstantialRiskOfDeath");
            aggAssaultColumnList.AddColumn("SubstantialRiskOfDeathDescription", "SubstantialRiskOfDeathDescription");
            aggAssaultColumnList.AddColumn("LossOrImpairment", "LossOrImpairment");
            aggAssaultColumnList.AddColumn("LossOrImpairmentDescription", "LossOrImpairmentDescription");
            aggAssaultColumnList.AddColumn("Disfigurement", "Disfigurement");
            aggAssaultColumnList.AddColumn("DisfigurementDescription", "DisfigurementDescription");
            aggAssaultColumnList.AddColumn("DeadlyWeaponUsed", "DeadlyWeaponUsed");
            aggAssaultColumnList.AddColumn("DeadlyWeaponUsedDescription", "DeadlyWeaponUsedDescription");
            aggAssaultColumnList.AddColumn("DeadlyWeaponExhibited", "DeadlyWeaponExhibited");
            aggAssaultColumnList.AddColumn("DeadlyWeaponExhibitedDescription", "DeadlyWeaponExhibitedDescription");
            aggAssaultColumnList.AddColumn("SuspectUseOfWeapon", "SuspectUseOfWeapon");

            var projectRoot = Utils.GetProjectRoot();
            var filePath = Path.Combine(projectRoot, "Helper/TestData/CreateIncident/Offense/agg assault data.xlsx");

            Console.WriteLine(filePath);
            var dataSet = new DataSet(aggAssaultColumnList);
            var aggAssaultData = dataSet.ReadData(filePath);

            return aggAssaultData;
        }

        public static List<Dictionary<string, string>> ReadUseOfWeaponData()
        {
            // Read dataset
            var useOfWeaponColumnList = new ColumnList();
            useOfWeaponColumnList.AddColumn("Person", "Person");
            useOfWeaponColumnList.AddColumn("WeaponType", "WeaponType");
            useOfWeaponColumnList.AddColumn("OtherDescription", "OtherDescription");
            useOfWeaponColumnList.AddColumn("NoEvidence", "NoEvidence");
            useOfWeaponColumnList.AddColumn("NoEvidenceReason", "NoEvidenceReason");
            useOfWeaponColumnList.AddColumn("Evidence", "Evidence");
            useOfWeaponColumnList.AddColumn("SelfDefence", "SelfDefence");
            useOfWeaponColumnList.AddColumn("ThirdParty", "ThirdParty");
            useOfWeaponColumnList.AddColumn("DisplayedOnly", "DisplayedOnly");

            var projectRoot = Utils.GetProjectRoot();
            var filePath = Path.Combine(projectRoot, "Helper/TestData/CreateIncident/Offense/use of weapon data.xlsx");

            Console.WriteLine(filePath);
            var dataSet = new DataSet(useOfWeaponColumnList);
            var useOfWeaponData = dataSet.ReadData(filePath);

            return useOfWeaponData;
        }
    }
}
