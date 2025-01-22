using OpenQA.Selenium;

namespace SAFV.Source.Components.Detective.CreateCase
{
    public class LocationMenuComponent : BaseComponent
    {
        // Elements
        public static IWebElement LocationInfo => WaitAndFindElement(By.XPath("//*[@id=\"detective-info-side-bar\"]/li[1]"));
        public static IWebElement Scene => WaitAndFindElement(By.XPath("//*[@id=\"detective-info-side-bar\"]/li[2]"));
        //public static IWebElement Scene => WaitAndFindElement(By.Id("scene_tab"));

        public LocationMenuComponent(IWebDriver driver) : base(driver)
        {
        }
    }
}