using OpenQA.Selenium;

namespace SAFV.Source.Components.CreateIncident
{
    public class CreateIncidentComponent : BaseComponent
    {
        // Elements
        public static IWebElement ReportDate => WaitAndFindElement(By.Id("IncidentDate"));
        public static IWebElement IncidentCaseNumber => WaitAndFindElement(By.Id("AgencyIdentifier"));
        public static IWebElement IncidentType => WaitAndFindElement(By.Id("IncidentTypeId"));
        public static IList<IWebElement> LstIncidentType => WaitAndFindElements(By.XPath("//*[@id=\"IncidentTypeId\"]/option"));
        public static IWebElement ConfidentialMode => WaitAndFindElement(By.XPath("//*[@id=\"incident-creation-form\"]/div[5]/span[1]"));
        public static IWebElement CaseType => WaitAndFindElement(By.XPath("//*[@id=\"incident-creation-form\"]/div[6]/span[1]"));
        public static IList<IWebElement> LstCaseType => WaitAndFindElements(By.XPath("//*[@id=\"CaseTypeId_listbox\"]/li"));
        public static IWebElement MainCase => WaitAndFindElement(By.XPath("//*[@id=\"masterIncidentField\"]/span[1]"));
        public static IWebElement SearchMainCase => WaitAndFindElement(By.XPath("//*[@id=\"MasterIncidentId-list\"]/span/input"));
        public static IList<IWebElement> LstMainCase => WaitAndFindElements(By.XPath("//*[@id=\"MasterIncidentId_listbox\"]/li"));
        public static IWebElement CreateButton => WaitAndFindElement(By.XPath("//*[@id=\"incident-creation-form\"]/div[8]/input"));

        public CreateIncidentComponent(IWebDriver driver) : base(driver)
        {
        }
    }
}
