using SAFV.Helper.TestData;
using SAFV.Utility;

namespace SAFV.Helper
{
    internal class RiskAssessmentDataReader
    {
        public static List<Dictionary<string, string>> ReadRiskAssessmentData()
        {
            // Read dataset
            var riskAssessmentColumnList = new ColumnList();
            riskAssessmentColumnList.AddColumn("Suspect", "Suspect");
            riskAssessmentColumnList.AddColumn("Victim", "Victim");
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
            var filePath = Path.Combine(projectRoot, "Helper/TestData/CreateIncident/risk assessment data.xlsx");

            Console.WriteLine(filePath);
            var dataSet = new DataSet(riskAssessmentColumnList);
            var riskAssessmentData = dataSet.ReadData(filePath);

            return riskAssessmentData;
        }
    }
}
