using OpenQA.Selenium;

namespace SAFV.Source.Components.CreateIncident.Offense
{
    public class RiskAssessmentComponent : BaseComponent
    {
        // Elements
        public static IWebElement CreateNewRA => WaitAndFindElement(By.XPath("//*[@id=\"module-container\"]/div/div[1]/div/div[2]/a"));
        public static IWebElement Suspect => WaitAndFindElement(By.XPath("//*[@id=\"risk-assessment-form\"]/div/div[1]/div/span[1]"));
        public static IWebElement LstSuspect => WaitAndFindElement(By.XPath("//*[@id=\"IncidentPersonId_listbox\"]/li[1]"));
        public static IWebElement Victim => WaitAndFindElement(By.XPath("//*[@id=\"risk-assessment-form\"]/div/div[2]/div/span[1]"));
        public static IWebElement LstVictim => WaitAndFindElement(By.XPath("//*[@id=\"VictimId_listbox\"]/li[1]"));
        public static IList<IWebElement> FamilyViolenceLikelyToOccur => WaitAndFindElements(By.XPath("//*[@id=\"risk-assessment-form\"]/div/div[3]/div/label"));
        public static IList<IWebElement> UsedOrThreatenedWithWeapon => WaitAndFindElements(By.XPath("//*[@id=\"risk-assessment-form\"]/div/div[4]/div/label"));
        public static IList<IWebElement> ThreatenedToKill => WaitAndFindElements(By.XPath("//*[@id=\"risk-assessment-form\"]/div/div[5]/div/label"));
        public static IList<IWebElement> SuspectHasGun => WaitAndFindElements(By.XPath("//*[@id=\"risk-assessment-form\"]/div/div[6]/div/label"));
        public static IWebElement GunDetailsInfo => WaitAndFindElement(By.Id("GunDetails"));
        public static IList<IWebElement> Strangulation => WaitAndFindElements(By.XPath("//*[@id=\"risk-assessment-form\"]/div/div[8]/div/label"));
        public static IList<IWebElement> Violence => WaitAndFindElements(By.XPath("//*[@id=\"risk-assessment-form\"]/div/div[9]/div/label"));
        public static IList<IWebElement> Jealousy => WaitAndFindElements(By.XPath("//*[@id=\"risk-assessment-form\"]/div/div[10]/div/label"));
        public static IList<IWebElement> Controlling => WaitAndFindElements(By.XPath("//*[@id=\"risk-assessment-form\"]/div/div[11]/div/label"));
        public static IList<IWebElement> ViolenceIncreased => WaitAndFindElements(By.XPath("//*[@id=\"risk-assessment-form\"]/div/div[12]/div/label"));
        public static IWebElement ViolenceIncreasedDescription => WaitAndFindElement(By.Id("IncreaseInViolenceDesc"));
        public static IList<IWebElement> DestroyedItems => WaitAndFindElements(By.XPath("//*[@id=\"risk-assessment-form\"]/div/div[14]/div/label"));
        public static IList<IWebElement> HurtPets => WaitAndFindElements(By.XPath("//*[@id=\"risk-assessment-form\"]/div/div[15]/div/label"));
        public static IList<IWebElement> Unemployed => WaitAndFindElements(By.XPath("//*[@id=\"risk-assessment-form\"]/div/div[16]/div/label"));
        public static IList<IWebElement> Suicidal => WaitAndFindElements(By.XPath("//*[@id=\"risk-assessment-form\"]/div/div[17]/div/label"));
        public static IList<IWebElement> Spying => WaitAndFindElements(By.XPath("//*[@id=\"risk-assessment-form\"]/div/div[18]/div/label"));
        public static IList<IWebElement> ThreateningMessages => WaitAndFindElements(By.XPath("//*[@id=\"risk-assessment-form\"]/div/div[19]/div/label"));
        public static IList<IWebElement> AlcoholAbuse => WaitAndFindElements(By.XPath("//*[@id=\"risk-assessment-form\"]/div/div[20]/div/label"));
        public static IList<IWebElement> DrugUse => WaitAndFindElements(By.XPath("//*[@id=\"risk-assessment-form\"]/div/div[21]/div/label"));
        public static IList<IWebElement> MightKillYou => WaitAndFindElements(By.XPath("//*[@id=\"risk-assessment-form\"]/div/div[22]/div/label"));
        public static IList<IWebElement> ForcedSex => WaitAndFindElements(By.XPath("//*[@id=\"risk-assessment-form\"]/div/div[23]/div/label"));
        public static IList<IWebElement> Separation => WaitAndFindElements(By.XPath("//*[@id=\"risk-assessment-form\"]/div/div[24]/div/label"));
        public static IList<IWebElement> RecentSeparation => WaitAndFindElements(By.XPath("//*[@id=\"risk-assessment-form\"]/div/div[25]/div/label"));
        public static IList<IWebElement> UnrelatedChild => WaitAndFindElements(By.XPath("//*[@id=\"risk-assessment-form\"]/div/div[26]/div/label"));
        public static IList<IWebElement> PriorContacts => WaitAndFindElements(By.XPath("//*[@id=\"risk-assessment-form\"]/div/div[27]/div/label"));
        public static IList<IWebElement> CourtAction => WaitAndFindElements(By.XPath("//*[@id=\"risk-assessment-form\"]/div/div[28]/div/label"));
        public static IWebElement AdditionalInfo => WaitAndFindElement(By.Id("AdditionalInformation"));
        public static IWebElement PriorProtectiveOrder => WaitAndFindElement(By.Id("PriorProtectiveOrder"));
        public static IWebElement DateTimeOfAssessment => WaitAndFindElement(By.Id("AssessmentDate"));
        public static IWebElement SaveRiskAssessment => WaitAndFindElement(By.XPath("//*[@id=\"risk-assessment-form\"]/div/div[32]/div/button"));
        public static IWebElement CancelRiskAssessment => WaitAndFindElement(By.XPath("//*[@id=\"risk-assessment-form\"]/div/div[32]/div/a"));

        public RiskAssessmentComponent(IWebDriver driver) : base(driver)
        {
        }
    }
}