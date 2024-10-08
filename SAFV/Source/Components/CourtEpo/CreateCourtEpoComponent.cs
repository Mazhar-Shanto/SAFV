using OpenQA.Selenium;

namespace SAFV.Source.Components.CourtEpo
{
    public class CreateCourtEpoComponent : BaseComponent
    {
        // Elements
        public static IWebElement CourtName => WaitAndFindElement(By.XPath("//*[@id=\"court-epo-form\"]/div/div[1]/div/span[1]"));
        public static IList<IWebElement> LstCourtName => WaitAndFindElements(By.XPath("//*[@id=\"CourtTypeId_listbox\"]/li"));
        public static IWebElement TypeOfIncident => WaitAndFindElement(By.XPath("//*[@id=\"court-epo-form\"]/div/div[2]/div/span[1]"));
        public static IList<IWebElement> LstTypeOfIncident => WaitAndFindElements(By.XPath("//*[@id=\"IncidentTypeId_listbox\"]/li"));
        public static IWebElement CourtCaseNo => WaitAndFindElement(By.Id("CourtNo"));
        public static IWebElement IncidentCaseNo => WaitAndFindElement(By.Id("AgencyIdentifier"));
        public static IWebElement Ori => WaitAndFindElement(By.Id("ORI"));
        public static IWebElement CountyOfArrest => WaitAndFindElement(By.XPath("//*[@id=\"court-epo-form\"]/div/div[7]/div/span[1]"));
        public static IList<IWebElement> LstCountyOfArrest => WaitAndFindElements(By.XPath("//*[@id=\"CountyOfArrest_listbox\"]/li"));
        public static IWebElement CountyOfOffense => WaitAndFindElement(By.XPath("//*[@id=\"court-epo-form\"]/div/div[8]/div/span[1]"));
        public static IList<IWebElement> LstCountyOfOffense => WaitAndFindElements(By.XPath("//*[@id=\"CountyOfOffense_listbox\"]/li"));
        public static IWebElement RequestedDate => WaitAndFindElement(By.Id("DateRequested"));
        public static IWebElement OrderEffectiveUntil => WaitAndFindElement(By.Id("OrderEffectiveUntil"));
        public static IList<IWebElement> LstOrderEffectiveUntil => WaitAndFindElements(By.XPath("//*[@id=\"effective-date\"]/div/label"));
        public static IWebElement RequestedByCourt => WaitAndFindElement(By.XPath("//*[@id=\"court-epo-form\"]/div/div[11]/div/span[1]"));
        public static IWebElement RequestedByVictim => WaitAndFindElement(By.XPath("//*[@id=\"court-epo-form\"]/div/div[12]/div/span[1]"));
        public static IWebElement RequestedByGuardian => WaitAndFindElement(By.XPath("//*[@id=\"court-epo-form\"]/div/div[13]/div/span[1]"));
        public static IWebElement GuardianName => WaitAndFindElement(By.Id("EPORequesterGName"));
        public static IWebElement RequestedByOfficer => WaitAndFindElement(By.XPath("//*[@id=\"court-epo-form\"]/div/div[15]/div/span[1]"));
        public static IWebElement OfficerName => WaitAndFindElement(By.Id("OfficerName"));
        public static IWebElement OfficerAgency => WaitAndFindElement(By.Id("OfficerAgency"));
        public static IWebElement OfficerPhone => WaitAndFindElement(By.Id("OfficerPhone"));
        public static IWebElement RequestedByState => WaitAndFindElement(By.XPath("//*[@id=\"court-epo-form\"]/div/div[17]/div/span[1]"));
        public static IWebElement StateAttorneyName => WaitAndFindElement(By.Id("EPORequesterSName"));
        public static IWebElement SeriousBodilyInjuryOccurred => WaitAndFindElement(By.XPath("//*[@id=\"court-epo-form\"]/div/div[19]/div/span[1]"));
        public static IWebElement UseOfWeaponOccurred => WaitAndFindElement(By.XPath("//*[@id=\"court-epo-form\"]/div/div[20]/div/span[1]"));
        public static IWebElement IssueFamilyViolenceHold => WaitAndFindElement(By.XPath("//*[@id=\"court-epo-form\"]/div/div[21]/div/span[1]"));
        public static IWebElement HoldForPeriod => WaitAndFindElement(By.XPath("//*[@id=\"court-epo-form\"]/div/div[22]/div/span[1]"));
        public static IWebElement NotLessThanHours => WaitAndFindElement(By.Id("FVPeriodNotLess"));
        public static IWebElement NotMoreThanHours => WaitAndFindElement(By.Id("FVPeriodNoMoreThan"));
        public static IWebElement HoldUntilSpecifiedDate => WaitAndFindElement(By.XPath("//*[@id=\"court-epo-form\"]/div/div[25]/div/span[1]"));
        public static IWebElement DateToRelease => WaitAndFindElement(By.Id("FVHoldEndDate"));
        public static IWebElement ProduceConditionOfBond => WaitAndFindElement(By.XPath("//*[@id=\"court-epo-form\"]/div/div[27]/div/span[1]"));
        public static IWebElement ProduceMagistrateProtectiveOrder => WaitAndFindElement(By.XPath("//*[@id=\"court-epo-form\"]/div/div[28]/div/span[1]"));
        public static IWebElement VictimAddressInformationConfidential => WaitAndFindElement(By.XPath("//*[@id=\"court-epo-form\"]/div/div[29]/div/span[1]"));
        public static IWebElement SaveCourtEpo => WaitAndFindElement(By.XPath("//*[@id=\"court-epo-form\"]/div/div[30]/div/div/button"));
        public static IWebElement CancelCourtEpo => WaitAndFindElement(By.XPath("//*[@id=\"court-epo-form\"]/div/div[30]/div/div/a"));

        public CreateCourtEpoComponent(IWebDriver driver) : base(driver)
        {
        }
    }
}
