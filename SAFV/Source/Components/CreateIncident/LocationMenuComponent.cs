using OpenQA.Selenium;

namespace SAFV.Source.Components.CreateIncident
{
    public class LocationMenuComponent : BaseComponent
    {
        // Elements
        public static IWebElement LocationInfo => WaitAndFindElement(By.XPath("//*[@id=\"incident-info-side-bar\"]/li[1]"));
        public static IWebElement Scene => WaitAndFindElement(By.XPath("//*[@id=\"incident-info-side-bar\"]/li[2]"));

        public LocationMenuComponent(IWebDriver driver) : base(driver)
        {
        }
    }
}
