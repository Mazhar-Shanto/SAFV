using NUnit.Framework;
using OpenQA.Selenium;

namespace SAFV.Source.Components.QuickBook
{
    public class QuickBookEpoComponent : BaseComponent
    {
        // Elements
        public static IWebElement ReviewQuickBook => WaitAndFindElement(By.XPath("//*[@id=\"person-page\"]/div/div[2]/div/div/div[2]/div/button[1]"));
        public static IWebElement CreateEpoRequest => WaitAndFindElement(By.XPath("//*[@id=\"person-page\"]/div/div[2]/div/div/div[2]/div/button[2]"));
        public static IWebElement BackToIncident => WaitAndFindElement(By.XPath("//*[@id=\"person-page\"]/div/div[2]/div/div/div[2]/div/button[3]"));

        public static IWebElement OffenseGroup => WaitAndFindElement(By.XPath("//*[@id=\"booking-form\"]/div[1]/div[1]/div/span[1]"));
        public static IWebElement LstOffenseGroup => WaitAndFindElement(By.XPath("//*[@id=\"IncidentOffGrpId_listbox\"]/li[1]"));
        public static IWebElement RequestedByVictim => WaitAndFindElement(By.XPath("//*[@id=\"booking-form\"]/div[1]/div[5]/div/span[1]"));
        public static IWebElement RequestedByGuardian => WaitAndFindElement(By.XPath("//*[@id=\"booking-form\"]/div[1]/div[6]/div/span[1]"));
        public static IWebElement GuardiansName => WaitAndFindElement(By.Id("RequesterGNameId"));
        public static IWebElement RequestedByOfficer => WaitAndFindElement(By.XPath("//*[@id=\"booking-form\"]/div[1]/div[8]/div/span[1]"));
        public static IWebElement RequestedByState => WaitAndFindElement(By.XPath("//*[@id=\"booking-form\"]/div[1]/div[9]/div/span[1]"));
        public static IWebElement StateAttorneyName => WaitAndFindElement(By.Id("RequesterSNameId"));
        public static IWebElement RequestedByMagistrate => WaitAndFindElement(By.XPath("//*[@id=\"booking-form\"]/div[1]/div[11]/div/span[1]"));
        public static IWebElement MagistratesName => WaitAndFindElement(By.Id("RequesterMagistrateNameId"));
        public static IWebElement HoldRequested => WaitAndFindElement(By.XPath("//*[@id=\"booking-form\"]/div[1]/div[13]/div/span[1]"));
        public static IWebElement Hour24 => WaitAndFindElement(By.XPath("//*[@id=\"hold\"]/div[1]/div/span[1]"));
        public static IWebElement Hour48 => WaitAndFindElement(By.XPath("//*[@id=\"hold\"]/div[2]/div/span[1]"));
        public static IWebElement ExplainHold => WaitAndFindElement(By.Id("ExplainHold"));

        public static IWebElement SaveEpo => WaitAndFindElement(By.XPath("//*[@id=\"booking-form\"]/div[2]/div/div/button"));
        public static IWebElement CancelEpo => WaitAndFindElement(By.XPath("//*[@id=\"booking-form\"]/div[2]/div/div/a"));

        public static IWebElement EpoRequestDocuments => WaitAndFindElement(By.XPath("//*[@id=\"booking-form\"]/div[2]/div/div/a[1]"));
        public static IWebElement SelectAllForms => WaitAndFindElement(By.XPath("//*[@id=\"PrintFormGroup\"]/table/thead/tr/th[1]/input"));
        public static IWebElement GenerateRequest => WaitAndFindElement(By.Id("generate-req-button"));
        public static IWebElement CancelRequest => WaitAndFindElement(By.Id("cancel-button"));
        public static IWebElement SendEpoRequest => WaitAndFindElement(By.XPath("//*[@id=\"master-container\"]/div/a"));
        public static IWebElement JudicialOrganization => WaitAndFindElement(By.XPath("//*[@id=\"epo-request\"]/div/div[1]/div[2]/span"));
        public static IList<IWebElement> LstJudicialOrganization => WaitAndFindElements(By.XPath("//*[@id=\"organizationId_listbox\"]/li"));
        public static IWebElement SendWithoutSigning => WaitAndFindElement(By.XPath("//*[@id=\"epo-request\"]/div/div[2]/div/div/button"));
        public static IWebElement SendWithSigning => WaitAndFindElement(By.XPath("//*[@id=\"epo-request\"]/div/div[2]/div/div/a"));

        public QuickBookEpoComponent(IWebDriver driver) : base(driver)
        {
        }
    }
}
