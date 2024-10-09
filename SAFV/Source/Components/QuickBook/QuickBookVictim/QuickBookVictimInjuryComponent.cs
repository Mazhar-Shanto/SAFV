using AventStack.ExtentReports.Gherkin.Model;
using NUnit.Framework;
using OpenQA.Selenium;

namespace SAFV.Source.Components.QuickBook.QuickBookVictim
{
    public class QuickBookVictimInjuryComponent : BaseComponent
    {
        // Elements
        public static IWebElement InjuryArea => WaitAndFindElement(By.XPath("//*[@id=\"injury-info-submit-form\"]/div[1]/div/span"));
        public static IList<IWebElement> LstInjuryArea => WaitAndFindElements(By.XPath("//*[@id=\"IncidentInjuryLocationId_listbox\"]/li"));
        public static IWebElement InjuryType => WaitAndFindElement(By.XPath("//*[@id=\"injury_type\"]/div[1]/div/span"));
        public static IList<IWebElement> LstInjuryType => WaitAndFindElements(By.XPath("//*[@id=\"IncidentInjuryTypeId_listbox\"]/li"));
        public static IWebElement InjuryObserved => WaitAndFindElement(By.XPath("//*[@id=\"injury_type\"]/div[2]/div/span"));
        public static IWebElement AddInjury => WaitAndFindElement(By.XPath("//*[@id=\"injury_type\"]/div[3]/div/button"));
        public static IWebElement SaveInjury => WaitAndFindElement(By.Id("injury-form-submit-button"));

        public static IWebElement Save => WaitAndFindElement(By.Id("//*[@id=\"ems-info-form\"]/div[2]/div/button[1]"));
        public static IWebElement SaveAndNext => WaitAndFindElement(By.Id("//*[@id=\"ems-info-form\"]/div[2]/div/button[2]"));
        public static IWebElement Cancel => WaitAndFindElement(By.Id("//*[@id=\"ems-info-form\"]/div[2]/div/button[3]"));

        public static IWebElement Next => WaitAndFindElement(By.Id("victimNext"));
        public static IWebElement Back => WaitAndFindElement(By.Id("victimBack"));

        public QuickBookVictimInjuryComponent(IWebDriver driver) : base(driver)
        {
        }
    }
}
