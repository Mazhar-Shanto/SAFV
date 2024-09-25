using OpenQA.Selenium;

namespace SAFV.Source.Components.CreateIncident.Epo
{
    public class SendEpoRequestComponent : BaseComponent
    {
        // Elements
        public static IWebElement JudicialOrganization => WaitAndFindElement(By.XPath("//*[@id=\"epo-request\"]/div/div[1]/div[2]/span"));
        public static IList<IWebElement> LstJudicialOrganization => WaitAndFindElements(By.XPath("//*[@id=\"organizationId_listbox\"]/li"));
        public static IWebElement SendWithoutSigning => WaitAndFindElement(By.XPath("//*[@id=\"epo-request\"]/div/div[2]/div/div/button"));
        public static IWebElement SendWithSigning => WaitAndFindElement(By.XPath("//*[@id=\"epo-request\"]/div/div[2]/div/div/a"));
        public static IWebElement WitnessIsLocal => WaitAndFindElement(By.XPath("//*[@id=\"send-epo-req\"]/div/div/table/tbody/tr[2]/td[2]/div/span"));
        public static IWebElement SignerName => WaitAndFindElement(By.XPath("//*[@id=\"send-epo-req\"]/div/div/table/tbody/tr[2]/td[3]/input"));
        public static IWebElement Judge => WaitAndFindElement(By.XPath("//*[@id=\"send-epo-req\"]/div/div/table/tbody/tr[3]/td[3]/span[2]"));
        public static IList<IWebElement> LstJudge => WaitAndFindElements(By.XPath("/html/body/div[17]/div/div[3]/ul/li"));
        public static IWebElement Witness => WaitAndFindElement(By.XPath("//*[@id=\"send-epo-req\"]/div/div/table/tbody/tr[2]/td[3]/span[1]"));
        public static IList<IWebElement> LstWitness => WaitAndFindElements(By.XPath("/html/body/div[7]/div/div[2]/ul/li"));
        public static IWebElement OtherOrganization => WaitAndFindElement(By.XPath("//*[@id=\"send-epo-req\"]/div/div/table/thead/tr/th[3]/div/span[2]"));
        public static IWebElement WitnessOrganization => WaitAndFindElement(By.XPath("//*[@id=\"send-epo-req\"]/div/div/table/tbody/tr[2]/td[4]/span[1]"));
        public static IWebElement SearchWitnessOrganization => WaitAndFindElement(By.XPath("/html/body/div[13]/div/span/input"));
        public static IList<IWebElement> LstWitnessOrganization => WaitAndFindElements(By.XPath("/html/body/div[13]/div/div[3]/ul/li"));
        public static IWebElement OtherOrganizationWitness => WaitAndFindElement(By.XPath("//*[@id=\"send-epo-req\"]/div/div/table/tbody/tr[2]/td[4]/span[2]"));
        public static IWebElement SearchOtherOrganizationWitness => WaitAndFindElement(By.XPath("/html/body/div[10]/div/span/input"));
        public static IList<IWebElement> LstOtherOrganizationWitness => WaitAndFindElements(By.XPath("/html/body/div[10]/div/div[3]/ul/li"));
        public static IWebElement JudgeOrganization => WaitAndFindElement(By.XPath("//*[@id=\"send-epo-req\"]/div/div/table/tbody/tr[3]/td[4]/span[1]"));
        public static IWebElement SearchJudgeOrganization => WaitAndFindElement(By.XPath("/html/body/div[14]/div/span/input"));
        public static IList<IWebElement> LstJudgeOrganization => WaitAndFindElements(By.XPath("/html/body/div[14]/div/div[3]/ul/li"));
        public static IWebElement OtherOrganizationJudge => WaitAndFindElement(By.XPath("//*[@id=\"send-epo-req\"]/div/div/table/tbody/tr[3]/td[4]/span[2]"));
        public static IWebElement SearchOtherOrganizationJudge => WaitAndFindElement(By.XPath("/html/body/div[11]/div/span/input"));
        public static IList<IWebElement> LstOtherOrganizationJudge => WaitAndFindElements(By.XPath("/html/body/div[11]/div/div[3]/ul/li[1]"));
        public static IWebElement CreateSigningRequest => WaitAndFindElement(By.Id("create-signing-request"));

        public SendEpoRequestComponent(IWebDriver driver) : base(driver)
        {
        }
    }
}