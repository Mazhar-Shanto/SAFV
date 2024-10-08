using OpenQA.Selenium;
using SAFV.Source.Components.CreateIncident.People.Suspect;

namespace SAFV.Source.Components.CreateIncident
{
    internal class ReportComponent : BaseComponent
    {
        public static IWebElement AlertMessage => WaitAndFindElement(By.ClassName("k-notification-content"));
        public static IWebElement SelectAllReport => WaitAndFindElement(By.XPath("//*[@id=\"grdPrintForms\"]/table/thead/tr/th[1]/input"));
        public static IWebElement FormCount => WaitAndFindElement(By.XPath("//*[@id=\"grdPrintForms\"]/div/span"));
        public static IWebElement GenerateForms => WaitAndFindElement(By.Id("pdf"));
        public static IWebElement SendToDfps => WaitAndFindElement(By.Id("emailToDFPS"));
        public static IWebElement HandOverDocumentsToAnyone => WaitAndFindElement(By.XPath("//*[@id=\"report-produce-form\"]/div/div[1]/div[2]/div/span[1]"));
        public static IWebElement HandOverTo => WaitAndFindElement(By.Id("ProducedFor"));
        public static IWebElement Generate => WaitAndFindElement(By.Id("nextBtn"));
        public static IWebElement Close => WaitAndFindElement(By.XPath("//*[@id=\"report-produce-form\"]/div/div[3]/div/div[3]/button"));
        public static IWebElement GeneratePseudonymFormForVictimsForm => WaitAndFindElement(By.XPath("//*[@id=\"pseudonymForm\"]/div/div/div/div[5]/input"));
        public static IWebElement GenerateBookingForm => WaitAndFindElement(By.XPath("//*[@id=\"bookingForm\"]/div/div/div/div[3]/input"));
        public static IWebElement GenerateIncidentCaseReportForm => WaitAndFindElement(By.XPath("/html/body/div/div[1]/form/div/div/div/div[2]/div/input"));
        public static IWebElement SelectChild => WaitAndFindElement(By.Id("Childs_0__Selected"));
        public static IWebElement GenerateLawEnforcementNotificationForm => WaitAndFindElement(By.XPath("//*[@id=\"lawInforcementForm\"]/div[3]/div/div/div[2]/div[3]/input"));
        public static IWebElement GenerateRiskAssessmentForm => WaitAndFindElement(By.XPath("//*[@id=\"riskAssessmentForm\"]/div/div/div/div[4]/input"));
        public static IWebElement GenerateVictimNotificationForm => WaitAndFindElement(By.XPath("//*[@id=\"victim-Notification-Form\"]/div/div/div/div[4]/input"));
        public static IWebElement GeneratePcAffidavitForm => WaitAndFindElement(By.XPath("//*[@id=\"pc-affidavit-form\"]/div/div/div/div[4]/input"));
        public static IWebElement GeneratedFormHeader => WaitAndFindElement(By.XPath("//*[@id=\"person-page\"]/div/div[1]/div/div[1]/header"));
        public static IWebElement GeneratedFormCount => WaitAndFindElement(By.XPath("//*[@id=\"grdIncidentForm\"]/div/span"));

        public ReportComponent(IWebDriver driver) : base(driver)
        {
        }
    }
}
