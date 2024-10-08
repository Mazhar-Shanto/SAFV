using OpenQA.Selenium;

namespace SAFV.Source.Components.CreateIncident.Offense
{
    public class UseOfWeaponComponent : BaseComponent
    {
        // Elements
        public static IWebElement CreateNewUseOfWeapon => WaitAndFindElement(By.XPath("//*[@id=\"weapon-information\"]/div[1]/div/div[2]/span/a"));
        public static IWebElement Person => WaitAndFindElement(By.XPath("//*[@id=\"weapon-info-submit-form\"]/div/div[1]/div/span[1]"));
        //public static IWebElement LstPerson => WaitAndFindElement(By.XPath("//*[@id=\"IncidentPersonId_listbox\"]/li[1]"));
        public static IWebElement LstPerson => WaitAndFindElement(By.XPath("/html/body/div[10]/div/div[3]/ul/li[1]"));
        public static IWebElement WeaponType => WaitAndFindElement(By.XPath("//*[@id=\"weapon-info-submit-form\"]/div/div[1]/div/span[1]"));
        public static IList<IWebElement> LstWeaponType => WaitAndFindElements(By.XPath("//*[@id=\"IncidentWeaponTypeId_listbox\"]/li"));
        public static IWebElement OtherDescription => WaitAndFindElement(By.Id("OtherDesc"));
        public static IWebElement NoEvidence => WaitAndFindElement(By.XPath("//*[@id=\"weapon-info-submit-form\"]/div/div[3]/div[1]/div/span[1]"));
        public static IWebElement NoEvidenceReason => WaitAndFindElement(By.Id("ReasonNoEvidence"));
        public static IWebElement Evidence => WaitAndFindElement(By.XPath("//*[@id=\"weapon-info-submit-form\"]/div/div[3]/div[2]/div/div/span[1]"));
        public static IWebElement LstEvidence => WaitAndFindElement(By.XPath("//*[@id=\"IncidentEvidenceId_listbox\"]/li[1]"));
        public static IWebElement SelfDefence => WaitAndFindElement(By.XPath("//*[@id=\"weapon-info-submit-form\"]/div/div[5]/div/span[1]"));
        public static IWebElement ThirdParty => WaitAndFindElement(By.XPath("//*[@id=\"weapon-info-submit-form\"]/div/div[6]/div/span[1]"));
        public static IWebElement DisplayedOnly => WaitAndFindElement(By.XPath("//*[@id=\"weapon-info-submit-form\"]/div/div[7]/div/span[1]"));
        public static IWebElement SaveUseOfWeapon => WaitAndFindElement(By.Id("weapon-form-submit-button"));
        public static IWebElement CancelUseOfWeapon => WaitAndFindElement(By.XPath("//*[@id=\"weapon-info-submit-form\"]/div/div[9]/div/div/a[2]"));

        public UseOfWeaponComponent(IWebDriver driver) : base(driver)
        {
        }
    }
}
