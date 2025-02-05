using OpenQA.Selenium;

namespace SAFV.Source.Components.Detective.CreateCase
{
    public class VehicleComponent : BaseComponent
    {
        // Elements
        public static IList<IWebElement> LstViewOrigin => WaitAndFindElements(By.XPath("(//a[contains(text(),'View Origin')])"));

        public VehicleComponent(IWebDriver driver) : base(driver)
        {
        }
    }
}