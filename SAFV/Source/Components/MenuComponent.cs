using OpenQA.Selenium;

namespace SAFV.Source.Components
{
    public class MenuComponent : BaseComponent
    {
        // Elements
        public static IWebElement Home => WaitAndFindElement(By.XPath("//*[@id='remove-scroll']/div/ul/li[3]/a"));
        public static IWebElement Incidents => WaitAndFindElement(By.XPath("//*[@id='remove-scroll']/div/ul/li[4]/a"));
        public static IWebElement IncidentsPage => WaitAndFindElement(By.XPath("//*[@id='remove-scroll']/div/ul/li[4]/ul/li[1]/a"));
        public static IWebElement CreateNewIncident => WaitAndFindElement(By.XPath("//*[@id='remove-scroll']/div/ul/li[4]/ul/li[2]/a"));
        public static IWebElement CreateQuickBook => WaitAndFindElement(By.XPath("//*[@id='remove-scroll']/div/ul/li[4]/ul/li[3]/a"));

        public MenuComponent(IWebDriver driver) : base(driver)
        {
        }
    }
}
