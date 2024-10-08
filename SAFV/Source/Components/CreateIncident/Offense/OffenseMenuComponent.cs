using OpenQA.Selenium;

namespace SAFV.Source.Components.CreateIncident.Offense
{
    public class OffenseMenuComponent : BaseComponent
    {
        // Elements
        public static IWebElement Offense => WaitAndFindElement(By.Id("of fense_tab"));
        public static IWebElement Scene => WaitAndFindElement(By.Id("scene_tab"));
        public static IWebElement Bias => WaitAndFindElement(By.Id("bias_tab"));
        public static IWebElement Manner => WaitAndFindElement(By.Id("manner_means_tab"));
        public static IWebElement RiskAssessment => WaitAndFindElement(By.Id("risk_assessment_tab"));
        public static IWebElement UseOfWeapon => WaitAndFindElement(By.Id("weapon_tab"));
        public static IWebElement AggAssault => WaitAndFindElement(By.Id("agg_assault_tab"));
        public static IWebElement PcNarrative => WaitAndFindElement(By.Id("officernarrative_tab"));

        public OffenseMenuComponent(IWebDriver driver) : base(driver)
        {
        }
    }
}
