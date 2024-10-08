using OpenQA.Selenium;

namespace SAFV.Source.Components.CreateIncident
{
    public class IncidentMenuComponent : BaseComponent
    {
        // Elements
        public static IWebElement Overview => WaitAndFindElement(By.XPath("//*[@id=\"remove-scroll\"]/div/ul/li[5]/ul/li[1]/a"));
        public static IWebElement Incident => WaitAndFindElement(By.XPath("//*[@id=\"remove-scroll\"]/div/ul/li[5]/ul/li[2]/a"));
        public static IWebElement People => WaitAndFindElement(By.XPath("//*[@id=\"remove-scroll\"]/div/ul/li[5]/ul/li[3]/a"));
        public static IWebElement Locations => WaitAndFindElement(By.XPath("//*[@id=\"remove-scroll\"]/div/ul/li[5]/ul/li[4]/a"));
        public static IWebElement Offenses => WaitAndFindElement(By.XPath("//*[@id=\"remove-scroll\"]/div/ul/li[5]/ul/li[5]/a"));
        public static IWebElement RiskAssesment => WaitAndFindElement(By.XPath("//*[@id=\"remove-scroll\"]/div/ul/li[5]/ul/li[6]/a"));
        public static IWebElement Vehicles => WaitAndFindElement(By.XPath("//*[@id=\"remove-scroll\"]/div/ul/li[5]/ul/li[7]/a"));
        public static IWebElement EpoBooking => WaitAndFindElement(By.XPath("//*[@id=\"remove-scroll\"]/div/ul/li[5]/ul/li[8]/a"));
        public static IWebElement Relationships => WaitAndFindElement(By.XPath("//*[@id=\"remove-scroll\"]/div/ul/li[5]/ul/li[10]/a"));
        public static IWebElement Evidence => WaitAndFindElement(By.XPath("//*[@id=\"remove-scroll\"]/div/ul/li[5]/ul/li[11]/a"));
        public static IWebElement DigitalEvidence => WaitAndFindElement(By.XPath("//*[@id=\"remove-scroll\"]/div/ul/li[5]/ul/li[12]/a"));
        public static IWebElement Reports => WaitAndFindElement(By.XPath("//*[@id=\"remove-scroll\"]/div/ul/li[5]/ul/li[13]/a"));
        public static IWebElement IncidentReview => WaitAndFindElement(By.XPath("//*[@id=\"remove-scroll\"]/div/ul/li[5]/ul/li[14]/a"));
        public static IWebElement StatusHistory => WaitAndFindElement(By.XPath("//*[@id=\"remove-scroll\"]/div/ul/li[5]/ul/li[15]/a"));

        public IncidentMenuComponent(IWebDriver driver) : base(driver)
        {
        }
    }
}
