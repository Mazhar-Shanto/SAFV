using OpenQA.Selenium;

namespace SAFV.Source.Components.CreateIncident.Epo
{
    public class EpoComponent : BaseComponent
    {
        // Elements
        public static IWebElement Header => WaitAndFindElement(By.Id("form-header"));
        public static IWebElement CreateEpoRequest => WaitAndFindElement(By.XPath("//*[@id=\"module-container\"]/div/div[1]/div/div[2]/a"));
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
        public static IWebElement CancelEpoRequest => WaitAndFindElement(By.XPath("//*[@id=\"booking-form\"]/div[2]/div/div/a[2]"));
        public static IWebElement SendRequest => WaitAndFindElement(By.XPath("//*[@id=\"master-container\"]/div/a"));
        public static IWebElement SuspectArrestCheck => WaitAndFindElement(By.Id("IsSuspectArrested"));
        public static IWebElement ArrestMessage => WaitAndFindElement(By.XPath("//*[@id=\"master-container\"]/div/p[1]")); // if not arrested, go to suspect > suspect > arrest the suspect
        public static IWebElement DownloadAllDocs => WaitAndFindElement(By.XPath("//*[@id=\"master-container\"]/div/div/div[1]/a"));
        public static IWebElement DeleteAllDocs => WaitAndFindElement(By.XPath("//*[@id=\"master-container\"]/div/div/div[2]/a"));
        public static IWebElement ConfirmDeleteAllDocs => WaitAndFindElement(By.XPath("/html/body/div[7]/div[3]/button[2]"));
        public static IWebElement CancelDeleteAllDocs => WaitAndFindElement(By.XPath("/html/body/div[7]/div[3]/button[1]"));
        public static IWebElement SendEpoRequest => WaitAndFindElement(By.XPath("//*[@id=\"master-container\"]/div/a"));

        public EpoComponent(IWebDriver driver) : base(driver)
        {
        }
    }
}