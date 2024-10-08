using OpenQA.Selenium;

namespace SAFV.Source.Components.CreateIncident.Offense
{
    public class PcNarrativeComponent : BaseComponent
    {
        // Elements
        public static IWebElement GeneratePcNarrative => WaitAndFindElement(By.XPath("//*[@id=\"master-container\"]/div/div[1]/button"));
        public static IWebElement CopyAndPaste => WaitAndFindElement(By.Id("copyText"));
        public static IWebElement NarrativeText => WaitAndFindElement(By.Id("narrative_text"));
        public static IWebElement SavePcNarrative => WaitAndFindElement(By.Id("off-narrative-submit-button"));
        public static IWebElement CancelPcNarrative => WaitAndFindElement(By.Id("officernarativeCancelId"));

        public PcNarrativeComponent(IWebDriver driver) : base(driver)
        {
        }
    }
}
