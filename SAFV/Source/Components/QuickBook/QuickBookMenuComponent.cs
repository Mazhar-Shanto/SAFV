using NUnit.Framework;
using OpenQA.Selenium;

namespace SAFV.Source.Components.QuickBook
{
    public class QuickBookMenuComponent : BaseComponent
    {
        // Elements
        public static IWebElement Incident => WaitAndFindElement(By.Id("incident-tab"));
        public static IWebElement Offense => WaitAndFindElement(By.Id("offense-selection-tab"));
        public static IWebElement Victim => WaitAndFindElement(By.Id("victim-tab"));
        public static IWebElement Suspect => WaitAndFindElement(By.Id("suspect-tab"));
        public static IWebElement Evidence => WaitAndFindElement(By.Id("evidence-tab"));
        public static IWebElement RiskAssessment => WaitAndFindElement(By.Id("risk-assessment-tab"));
        public static IWebElement Epo => WaitAndFindElement(By.Id("epo-tab"));

        public QuickBookMenuComponent(IWebDriver driver) : base(driver)
        {
        }
    }
}
