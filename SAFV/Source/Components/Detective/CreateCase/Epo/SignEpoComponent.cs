using OpenQA.Selenium;

namespace SAFV.Source.Components.Detective.CreateCase.Epo
{
    public class SignEpoComponent : BaseComponent
    {
        // Elements
        public static IWebElement DocumentViewer => WaitAndFindElement(By.CssSelector("tx-document-viewer"));
        public static string Next => "#signatureAction";
        /*public static IWebElement ReviewEpoRequest => WaitAndFindElement(By.XPath("/html/body/div[1]/div[4]/div[2]/div/div[2]/div/div/table/tbody/tr[1]/td[2]/a"));
        public static IWebElement ApproveEpoRequest => WaitAndFindElement(By.XPath("/html/body/div/div[1]/div[1]/div/div/div[2]/div/div[1]/a[1]"));
        public static IWebElement RejectEpoRequest => WaitAndFindElement(By.XPath("/html/body/div/div[1]/div[1]/div/div/div[2]/div/div[1]/a[2]"));
        public static IWebElement ReviewPcAffidavit => WaitAndFindElement(By.XPath("/html/body/div[1]/div[4]/div[2]/div/div[2]/div/div/table/tbody/tr[2]/td[2]/a"));*/
        public static string EpoRequestHeader => "body > div:nth-of-type(1) > div:nth-of-type(4) > div:nth-of-type(2) > div > div:nth-of-type(2) > div > div > div:nth-of-type(1) > header";
        public static string ReviewEpoRequest => "body > div:nth-of-type(1) > div:nth-of-type(4) > div:nth-of-type(2) > div > div:nth-of-type(2) > div > div > table > tbody > tr:nth-of-type(1) > td:nth-of-type(2) > a";
        public static string ApproveEpoRequest => "body > div > div:nth-of-type(1) > div:nth-of-type(1) > div > div > div:nth-of-type(2) > div > div:nth-of-type(1) > a:nth-of-type(1)";
        public static string RejectEpoRequest => "body > div > div:nth-of-type(1) > div:nth-of-type(1) > div > div > div:nth-of-type(2) > div > div:nth-of-type(1) > a:nth-of-type(2)";
        public static string ReviewPcAffidavit => "body > div:nth-of-type(1) > div:nth-of-type(4) > div:nth-of-type(2) > div > div:nth-of-type(2) > div > div > table > tbody > tr:nth-of-type(2) > td:nth-of-type(2) > a";
        public static string GoToSignature => "#signatureAction";
        public static string PlaceSignature => "#signatureDiv_1";
        public static string SignatureCanvas => "#softpad";
        public static string ClearSign => "#tx-sign-setup-clear";
        public static string RestoreSign => "#tx-sign-setup-retrieve";
        public static string UploadSign => "#tx_signature_upload";
        public static string SetupAndSign => "#tx_signature_sign";
        public static string CancelSigning => "#tx_signature_cancel";
        public static IWebElement SubmitSignature => WaitAndFindElement(By.XPath("//*[@id=\"signatureModal\"]/div/div/div[2]/div[1]/button[1]"));
        public static IWebElement ReSign => WaitAndFindElement(By.XPath("//*[@id=\"signatureModal\"]/div/div/div[2]/div[1]/button[2]"));
        public static IWebElement Approve => WaitAndFindElement(By.XPath("/html/body/div/div[1]/div[1]/div/div/div[2]/div/div[1]/a[1]"));
        public static IWebElement SignAgain => WaitAndFindElement(By.XPath("/html/body/div/div[1]/div[1]/div/div/div[2]/div/div[1]/a[2]"));
        public static IWebElement Reject => WaitAndFindElement(By.XPath("/html/body/div/div[1]/div[1]/div/div/div[2]/div/div[1]/a[3]"));
        //public static string SubmitSignature => "#signatureModal > div > div > div:nth-of-type(2) > div:nth-of-type(1) > button:nth-of-type(1)";
        //public static string ReSign => "#signatureModal > div > div > div:nth-of-type(2) > div:nth-of-type(1) > button:nth-of-type(2)";
        //public static string Approve => "body > div > div:nth-of-type(1) > div:nth-of-type(1) > div > div > div:nth-of-type(2) > div > div:nth-of-type(1) > a:nth-of-type(1)";
        //public static string SignAgain => "body > div > div:nth-of-type(1) > div:nth-of-type(1) > div > div > div:nth-of-type(2) > div > div:nth-of-type(1) > a:nth-of-type(2)";
        //public static string Reject => "body > div > div:nth-of-type(1) > div:nth-of-type(1) > div > div > div:nth-of-type(2) > div > div:nth-of-type(1) > a:nth-of-type(3)";

        public SignEpoComponent(IWebDriver driver) : base(driver)
        {
        }
    }
}