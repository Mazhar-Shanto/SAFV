using OpenQA.Selenium;

namespace SAFV.Source.Components.CreateIncident.Epo
{
    public class EpoMenuComponent : BaseComponent
    {
        // Elements
        public static IWebElement EpoRequest => WaitAndFindElement(By.Id("epo_basic_tab"));
        public static IWebElement Prohibitions => WaitAndFindElement(By.Id("epo_cob_tab"));

        public EpoMenuComponent(IWebDriver driver) : base(driver)
        {
        }
    }
}