using OpenQA.Selenium;

namespace SAFV.Source.Components.CourtEpo
{
    public class CourtEpoComponent : BaseComponent
    {
        // Elements
        public static IWebElement AlertMessage => WaitAndFindElement(By.ClassName("k-notification-content"));
        public static IWebElement CreateCourtEpo => WaitAndFindElement(By.XPath("//*[@id=\"module-container\"]/div/div[1]/div/div[2]/a"));
        public static IWebElement FilterUnAssignedCourtEpo => WaitAndFindElement(By.XPath("//*[@id=\"unassigned_courte_epo\"]/div[1]/div/table/thead/tr/th[1]/a"));
        public static IWebElement UnAssignedCourtEpoSearchBox => WaitAndFindElement(By.XPath("/html/body/div[5]/form/div[1]/input"));
        public static IWebElement UnAssignedCourtEpoFilterButton => WaitAndFindElement(By.XPath("/html/body/div[5]/form/div[1]/div[2]/button[1]"));
        public static IWebElement UnAssignedCourtEpoClearButton => WaitAndFindElement(By.XPath("/html/body/div[5]/form/div[1]/div[2]/button[2]"));
        public static IWebElement UnAssignedCourtEpoGridCount => WaitAndFindElement(By.XPath("//*[@id=\"unassigned_courte_epo\"]/div[3]/span"));
        public static IWebElement UnAssignedCourtEpoAssignButton => WaitAndFindElement(By.XPath("//*[@id=\"unassigned_courte_epo\"]/div[2]/table/tbody/tr/td[7]/a"));
        public static IWebElement ConfirmAssign => WaitAndFindElement(By.XPath("//*[@id=\"court-epo-assign-form\"]/div/div[2]/div[2]/button[1]"));
        public static IWebElement CancelAssign => WaitAndFindElement(By.Id("btnCloseAssignCourtEPOModal"));

        public static IWebElement FilterAssignedCourtEpo => WaitAndFindElement(By.XPath("//*[@id=\"assigned_courte_epo\"]/div[1]/div/table/thead/tr/th[1]/a"));
        public static IWebElement AssignedCourtEpoSearchBox => WaitAndFindElement(By.XPath("/html/body/div[5]/form/div[1]/input"));
        //public static IWebElement AssignedCourtEpoSearchBox => WaitAndFindElement(By.XPath("/html/body/div[6]/form/div[1]/input"));
        public static IWebElement AssignedCourtEpoFilterButton => WaitAndFindElement(By.XPath("/html/body/div[5]/form/div[1]/div[2]/button[1]"));
        //public static IWebElement AssignedCourtEpoFilterButton => WaitAndFindElement(By.XPath("/html/body/div[6]/form/div[1]/div[2]/button[1]"));
        public static IWebElement AssignedCourtEpoClearButton => WaitAndFindElement(By.XPath("/html/body/div[6]/form/div[1]/div[2]/button[2]"));
        public static IWebElement AssignedCourtEpoGridCount => WaitAndFindElement(By.XPath("//*[@id=\"assigned_courte_epo\"]/div[3]/span"));
        public static IWebElement SelectCourtEpo => WaitAndFindElement(By.XPath("//*[@id=\"assigned_courte_epo\"]/div[2]/table/tbody/tr/td[1]/a"));

        public static IWebElement County => WaitAndFindElement(By.XPath("//*[@id=\"generate-form-main\"]/div[2]/div/span"));
        public static IWebElement LstCounty => WaitAndFindElement(By.XPath("//*[@id=\"JudisialCounty_listbox\"]/li[2]"));

        public static IWebElement GenerateDocs => WaitAndFindElement(By.Id("generate_doc_btn"));
        public static IWebElement ResetData => WaitAndFindElement(By.XPath("//*[@id=\"court-epo-form\"]/div/div[30]/div/div/a[3]"));
        public static IWebElement GenerateOrder => WaitAndFindElement(By.Id("generate-req-button"));
        public static IWebElement CancelOrder => WaitAndFindElement(By.XPath("//*[@id=\"generate-form-main\"]/div[2]/a[2]"));

        public static IWebElement CompleteEpoManually => WaitAndFindElement(By.XPath("//*[@id=\"master-container-row\"]/div[3]/div/a[1]"));
        public static IWebElement ConfirmCompleteEpoManually => WaitAndFindElement(By.XPath("/html/body/div[11]/div[3]/button[1]"));
        public static IWebElement RequestForSigning => WaitAndFindElement(By.XPath("//*[@id=\"master-container-row\"]/div[3]/div/a[2]"));
        public static IWebElement CopyEpo => WaitAndFindElement(By.Id("copy_epo"));
        public static IWebElement CancelEpo => WaitAndFindElement(By.XPath("//*[@id=\"master-container-row\"]/div[3]/div/a[4]"));
        public static IWebElement ConfirmCancelEpo => WaitAndFindElement(By.XPath("/html/body/div[11]/div[3]/button[1]"));

        public static IWebElement SigningOption => WaitAndFindElement(By.XPath("/html/body/div[1]/div[4]/div[2]/div/div[2]/div/div/form/div/div[1]/div/span"));
        public static IWebElement JudgeSigning => WaitAndFindElement(By.XPath("//*[@id=\"SigningOption_listbox\"]/li[1]"));
        public static IWebElement JudgeAndSuspectSigning => WaitAndFindElement(By.XPath("//*[@id=\"SigningOption_listbox\"]/li[2]"));

        public static IWebElement SigningRequestButton => WaitAndFindElement(By.XPath("/html/body/div[1]/div[4]/div[2]/div/div[2]/div/div/form/div/div[2]/div/div/button"));
        public static IWebElement StartSigningButton => WaitAndFindElement(By.XPath("/html/body/div[1]/div[4]/div[2]/div/div[2]/div/div/div[3]/a"));
        public static IWebElement SignAndReview => WaitAndFindElement(By.XPath("/html/body/div[1]/div[4]/div[2]/div/div[2]/div/div/table/tbody/tr[1]/td[2]/a"));
        public static IWebElement Next => WaitAndFindElement(By.Id("signatureAction"));

        public static IWebElement ContinueSuspectSigning => WaitAndFindElement(By.XPath("/html/body/div[6]/div[3]/button[1]"));
        public static IWebElement CancelSuspectSigning => WaitAndFindElement(By.XPath("/html/body/div[6]/div[3]/button[2]"));

        public static IWebElement OrganizationSearchBox => WaitAndFindElement(By.XPath("//*[@id=\"OrgSigningRequests\"]/div[1]/span/input"));
        public static IWebElement StartSigningOrganizationEpo => WaitAndFindElement(By.XPath("//*[@id=\"OrgSigningRequests\"]/div[3]/table/tbody/tr[1]/td[6]/a"));
        public static IWebElement OrganizationEpoCount => WaitAndFindElement(By.XPath("//*[@id=\"OrgSigningRequests\"]/div[4]/span"));
        public static IWebElement OtherSearchBox => WaitAndFindElement(By.XPath("//*[@id=\"assigned_courte_epo\"]/div[1]/span/input"));
        public static IWebElement StartSigningOtherEpo => WaitAndFindElement(By.XPath("//*[@id=\"assigned_courte_epo\"]/div[3]/table/tbody/tr[1]/td[6]/a"));
        public static IWebElement OtherEpoCount => WaitAndFindElement(By.XPath("//*[@id=\"assigned_courte_epo\"]/div[4]/span"));

        public static IWebElement SaveCourtEpo => WaitAndFindElement(By.XPath("//*[@id=\"court-epo-form\"]/div/div[30]/div/div/button"));
        public static IWebElement CancelCourtEpo => WaitAndFindElement(By.XPath("//*[@id=\"court-epo-form\"]/div/div[30]/div/div/a"));

        public CourtEpoComponent(IWebDriver driver) : base(driver)
        {
        }
    }
}
