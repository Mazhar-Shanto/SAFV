using OpenQA.Selenium;

namespace SAFV.Source.Components.CourtEpo
{
    public class CourtEpoMenuComponent : BaseComponent
    {
        // Elements
        public static IWebElement EpoBasic => WaitAndFindElement(By.Id("epo_basic_tab"));
        public static IWebElement SuspectInfo => WaitAndFindElement(By.Id("suspect_tab"));
        public static IWebElement VictimInfo => WaitAndFindElement(By.Id("victim_tab"));
        public static IWebElement OtherInfo => WaitAndFindElement(By.Id("epo_other_tab"));
        public static IWebElement Conditions => WaitAndFindElement(By.Id("epo_cob_tab"));

        public CourtEpoMenuComponent(IWebDriver driver) : base(driver)
        {
        }
    }
}
