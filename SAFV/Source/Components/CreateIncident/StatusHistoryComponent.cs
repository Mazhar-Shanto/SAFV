using OpenQA.Selenium;
using SAFV.Source.Components.CreateIncident.People.Suspect;

namespace SAFV.Source.Components.CreateIncident
{
    internal class StatusHistoryComponent : BaseComponent
    {
        public static IWebElement SubmitForReview => WaitAndFindElement(By.Id("submitforReview"));
        public static IWebElement ConfirmSubmitForReview => WaitAndFindElement(By.XPath("//*[@id=\"review-dialog\"]/div/div/div[3]/button[1]"));
        public static IWebElement CancelSubmitForReview => WaitAndFindElement(By.XPath("//*[@id=\"review-dialog\"]/div/div/div[3]/button[2]"));
        public static IWebElement ReportGenerateYes => WaitAndFindElement(By.XPath("/html/body/div[6]/div[3]/button[1]"));
        public static IWebElement ReportGenerateNo => WaitAndFindElement(By.XPath("/html/body/div[6]/div[3]/button[2]"));
        public static IWebElement LockIncident => WaitAndFindElement(By.XPath("/html/body/div[1]/div[4]/div[2]/div/div[2]/div/div/div[3]/div/div/div[1]/div/div[2]/div/div[1]/button[1]"));
        public static IWebElement UnLockIncident => WaitAndFindElement(By.XPath("/html/body/div[1]/div[4]/div[2]/div/div[2]/div/div/div[3]/div/div/div[1]/div/div[2]/div/div[1]/button"));
        public static IWebElement RejectIncident => WaitAndFindElement(By.XPath("/html/body/div[1]/div[4]/div[2]/div/div[2]/div/div/div[3]/div/div/div[1]/div/div[2]/div/div[1]/button[2]"));
        public static IWebElement ConfirmReject => WaitAndFindElement(By.XPath("//*[@id=\"reject-dialog\"]/div/div/div[3]/button[1]"));
        public static IWebElement CancelReject => WaitAndFindElement(By.XPath("//*[@id=\"reject-dialog\"]/div/div/div[3]/button[2]"));
        public static IWebElement ConfirmLock => WaitAndFindElement(By.XPath("//*[@id=\"lock-dialog\"]/div/div/div[3]/button[1]"));
        public static IWebElement CancelLock => WaitAndFindElement(By.XPath("//*[@id=\"lock-dialog\"]/div/div/div[3]/button[2]"));
        public static IWebElement ConfirmUnLock => WaitAndFindElement(By.XPath("//*[@id=\"unlock-dialog\"]/div/div/div[3]/button[1]"));
        public static IWebElement CancelUnLock => WaitAndFindElement(By.XPath("//*[@id=\"unlock-dialog\"]/div/div/div[3]/button[2]"));
        public static IWebElement Status => WaitAndFindElement(By.XPath("//*[@id=\"StatusHisotrGrid\"]/table/tbody/tr[1]/td[2]"));

        public StatusHistoryComponent(IWebDriver driver) : base(driver)
        {
        }
    }
}
