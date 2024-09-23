using OpenQA.Selenium;

namespace SAFV.Source.Components.CreateIncident.People.Suspect
{
    public class SuspectEvidenceComponent : BaseComponent
    {
        // Elements
        public static IWebElement AddEvidence => WaitAndFindElement(By.XPath("//*[@id=\"master-container\"]/div[1]/div/a"));
        public static IWebElement EvidenceType => WaitAndFindElement(By.XPath("//*[@id=\"person-evidance-form\"]/div/div[1]/div/span[1]"));
        public static IList<IWebElement> LstEvidenceType => WaitAndFindElements(By.XPath("//*[@id=\"EvidenceTypeId_listbox\"]/li"));
        public static IWebElement EvidenceDisposition => WaitAndFindElement(By.XPath("//*[@id=\"person-evidance-form\"]/div/div[2]/div/span[1]"));
        public static IList<IWebElement> LstEvidenceDisposition => WaitAndFindElements(By.XPath("//*[@id=\"EvidenceDispositionId_listbox\"]/li"));
        public static IWebElement CollectedFromPerson => WaitAndFindElement(By.XPath("//*[@id=\"person-evidance-form\"]/div/div[3]/div[1]/div/span[1]"));
        public static IWebElement Person => WaitAndFindElement(By.XPath("//*[@id=\"person-evidance-form\"]/div/div[3]/div[2]/div/span[1]"));
        public static IList<IWebElement> LstPerson => WaitAndFindElements(By.XPath("//*[@id=\"IncidentPersonId_listbox\"]/li"));
        public static IWebElement PersonNotListed => WaitAndFindElement(By.XPath("//*[@id=\"person-evidance-form\"]/div/div[3]/div[3]/div/span[1]"));
        public static IWebElement PersonName => WaitAndFindElement(By.Id("NameofEntity"));
        public static IWebElement WhereFound => WaitAndFindElement(By.Id("Location"));
        public static IWebElement EvidenceDescription => WaitAndFindElement(By.Id("PhysicalDesc"));
        public static IWebElement WasSeized => WaitAndFindElement(By.XPath("//*[@id=\"person-evidance-form\"]/div/div[6]/div/span[1]"));
        public static IWebElement TypeOfWeapon => WaitAndFindElement(By.XPath("//*[@id=\"person-evidance-form\"]/div/div[7]/div[1]/div/span[1]"));
        public static IList<IWebElement> LstTypeOfWeapon => WaitAndFindElements(By.XPath("//*[@id=\"IncidentWeaponTypeId_listbox\"]/li"));
        public static IWebElement EvidenceSerialNumber => WaitAndFindElement(By.Id("SerialNumber"));
        public static IWebElement WeaponManufacturer => WaitAndFindElement(By.XPath("//*[@id=\"person-evidance-form\"]/div/div[7]/div[3]/div[1]/div/span[1]"));
        public static IList<IWebElement> LstWeaponManufacturer => WaitAndFindElements(By.XPath("//*[@id=\"WeaponManufacturerId_listbox\"]/li"));
        public static IWebElement WeaponCaliber => WaitAndFindElement(By.XPath("//*[@id=\"person-evidance-form\"]/div/div[7]/div[3]/div[3]/div/span[1]"));
        public static IList<IWebElement> LstWeaponCaliber => WaitAndFindElements(By.XPath("//*[@id=\"WeaponCaliberId_listbox\"]/li"));
        public static IWebElement EvidenceCollectedBy => WaitAndFindElement(By.Id("CollectedBy"));
        public static IWebElement SaveEvidence => WaitAndFindElement(By.XPath("//*[@id=\"extended-info-form\"]/div[2]/div/div/button"));
        public static IWebElement CancelEvidence => WaitAndFindElement(By.XPath("//*[@id=\"extended-info-form\"]/div[2]/div/div/a"));


        public SuspectEvidenceComponent(IWebDriver driver) : base(driver)
        {
        }
    }
}