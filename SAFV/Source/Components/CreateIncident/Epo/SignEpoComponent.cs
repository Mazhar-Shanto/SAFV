using OpenQA.Selenium;

namespace SAFV.Source.Components.CreateIncident.Epo
{
    public class SignEpoComponent : BaseComponent
    {
        // Elements
        public static IWebElement EpoRequestHeader => WaitAndFindElement(By.XPath("/html/body/div[1]/div[4]/div[2]/div/div[2]/div/div/div[1]/header"));
        public static IWebElement ReviewEpoRequest => WaitAndFindElement(By.XPath("/html/body/div[1]/div[4]/div[2]/div/div[2]/div/div/table/tbody/tr[1]/td[2]/a"));
        public static IWebElement ApproveEpoRequest => WaitAndFindElement(By.XPath("/html/body/div/div[1]/div[1]/div/div/div[2]/div/div[1]/a[1]"));
        public static IWebElement RejectEpoRequest => WaitAndFindElement(By.XPath("/html/body/div/div[1]/div[1]/div/div/div[2]/div/div[1]/a[2]"));
        public static IWebElement ReviewPcAffidavit => WaitAndFindElement(By.XPath("/html/body/div[1]/div[4]/div[2]/div/div[2]/div/div/table/tbody/tr[2]/td[2]/a"));
        public static IWebElement GoToSignature => WaitAndFindElement(By.Id("signatureAction"));
        public static IWebElement PlaceSignature => WaitAndFindElement(By.Id("signatureDiv_1"));
        public static IWebElement SignatureCanvas => WaitAndFindElement(By.Id("softpad"));
        public static IWebElement ClearSign => WaitAndFindElement(By.Id("tx-sign-setup-clear"));
        public static IWebElement RestoreSign => WaitAndFindElement(By.Id("tx-sign-setup-retrieve"));
        public static IWebElement UploadSign => WaitAndFindElement(By.Id("tx_signature_upload"));
        public static IWebElement SetupAndSign => WaitAndFindElement(By.Id("tx_signature_sign"));
        public static IWebElement CancelSigning => WaitAndFindElement(By.Id("tx_signature_cancel"));
        public static IWebElement SubmitSignature => WaitAndFindElement(By.Id("//*[@id=\"signatureModal\"]/div/div/div[2]/div[1]/button[1]"));
        public static IWebElement ReSign => WaitAndFindElement(By.Id("//*[@id=\"signatureModal\"]/div/div/div[2]/div[1]/button[2]"));
        public static IWebElement Approve => WaitAndFindElement(By.Id("/html/body/div/div[1]/div[1]/div/div/div[2]/div/div[1]/a[1]"));
        public static IWebElement SignAgain => WaitAndFindElement(By.Id("/html/body/div/div[1]/div[1]/div/div/div[2]/div/div[1]/a[2]"));
        public static IWebElement Reject => WaitAndFindElement(By.Id("/html/body/div/div[1]/div[1]/div/div/div[2]/div/div[1]/a[3]"));

        public SignEpoComponent(IWebDriver driver) : base(driver)
        {
        }
    }
}