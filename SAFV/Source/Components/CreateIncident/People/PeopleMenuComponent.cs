using OpenQA.Selenium;

namespace SAFV.Source.Components.CreateIncident.People
{
    public class PeopleMenuComponent : BaseComponent
    {
        // Elements
        public static IWebElement BasicInfo => WaitAndFindElement(By.XPath("//*[@id=\"incident-info-side-bar\"]/li[1]/a"));
        public static IWebElement Interview => WaitAndFindElement(By.Id("interview-nav-item"));
        public static IWebElement Suspect => WaitAndFindElement(By.Id("suspect-nav-item"));
        public static IWebElement Relationships => WaitAndFindElement(By.Id("relationship_tab"));
        public static IWebElement Injuries => WaitAndFindElement(By.Id("injuries-nav-item"));
        public static IWebElement MedicalEms => WaitAndFindElement(By.Id("medical-nav-item"));
        public static IWebElement Demeanor => WaitAndFindElement(By.Id("checkbox_tab"));
        public static IWebElement EmergencyContacts => WaitAndFindElement(By.Id("contact_tab"));
        public static IWebElement ExternalInfo => WaitAndFindElement(By.Id("extInfo_tab"));
        public static IWebElement Evidence => WaitAndFindElement(By.Id("evidence_tab"));


        public PeopleMenuComponent(IWebDriver driver) : base(driver)
        {
        }
    }
}
