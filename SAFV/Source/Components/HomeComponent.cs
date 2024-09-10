using OpenQA.Selenium;

namespace SAFV.Source.Components
{
    public class HomeComponent : BaseComponent
    {
        // Elements
        public static IWebElement LoggedInUser => WaitAndFindElement(By.XPath("/html/body/div[1]/div[4]/div[2]/div/div[3]/div/div[1]/div/div/div/div/span[1]/span"));

        public HomeComponent(IWebDriver driver) : base(driver)
        {
        }
    }
}
