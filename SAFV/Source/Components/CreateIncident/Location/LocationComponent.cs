using OpenQA.Selenium;

namespace SAFV.Source.Components.CreateIncident.Location
{
    public class LocationComponent : BaseComponent
    {
        // Elements
        public static IWebElement AddLocation => WaitAndFindElement(By.XPath("//*[@id=\"module-container\"]/div/div[1]/div/div[2]/a"));
        public static IWebElement LocationType => WaitAndFindElement(By.XPath("//*[@id=\"addressinfoform\"]/div/div[1]/div[1]/div/span[1]"));
        public static IList<IWebElement> LstLocationType => WaitAndFindElements(By.XPath("//*[@id=\"AddressTypeId_listbox\"]/li"));
        public static IWebElement AddressGroup => WaitAndFindElement(By.XPath("//*[@id=\"addressinfoform\"]/div/div[1]/div[2]/div/span[1]"));
        public static IList<IWebElement> LstAddressGroup => WaitAndFindElements(By.XPath("//*[@id=\"AddressGroupId_listbox\"]/li"));
        public static IWebElement Address1 => WaitAndFindElement(By.Id("serviceInput"));
        public static IWebElement Address2 => WaitAndFindElement(By.Id("Address2"));
        public static IWebElement City => WaitAndFindElement(By.Id("City"));
        public static IWebElement State => WaitAndFindElement(By.Id("State"));
        public static IWebElement County => WaitAndFindElement(By.XPath("//*[@id=\"addressinfoform\"]/div/div[1]/div[7]/div[2]/span[1]"));
        public static IList<IWebElement> LstCounty => WaitAndFindElements(By.XPath("//*[@id=\"County_listbox\"]/li"));
        public static IWebElement ZipCode => WaitAndFindElement(By.Id("ZipCode"));
        public static IWebElement DispatchedLocation => WaitAndFindElement(By.Id("//*[@id=\"addressinfoform\"]/div/div[1]/div[9]/div/span[1]"));
        public static IWebElement SaveLoaction => WaitAndFindElement(By.XPath("//*[@id=\"addressinfoform\"]/div/div[2]/div/div/button"));
        public static IWebElement CancelLoaction => WaitAndFindElement(By.XPath("//*[@id=\"addressinfoform\"]/div/div[2]/div/div/a"));

        public LocationComponent(IWebDriver driver) : base(driver)
        {
        }
    }
}