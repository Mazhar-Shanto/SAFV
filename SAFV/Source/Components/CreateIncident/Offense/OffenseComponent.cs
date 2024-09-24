using OpenQA.Selenium;

namespace SAFV.Source.Components.CreateIncident.Offense
{
    public class OffenseComponent : BaseComponent
    {
        // Elements
        public static IWebElement AddOffense => WaitAndFindElement(By.XPath("//*[@id=\"module-container\"]/div/div[1]/div/div[2]/a"));
        public static IWebElement Suspect => WaitAndFindElement(By.XPath("//*[@id=\"collapse_3_1\"]/div/div/div[1]/div/span[1]"));
        public static IWebElement LstSuspect => WaitAndFindElement(By.XPath("//*[@id=\"IncidentPersonId_listbox\"]/li[1]"));
        public static IWebElement Victim => WaitAndFindElement(By.XPath("//*[@id=\"collapse_3_1\"]/div/div/div[2]/div/span[1]"));
        public static IWebElement LstVictim => WaitAndFindElement(By.XPath("//*[@id=\"VictimId_listbox\"]/li[1]"));
        public static IWebElement DateOfOffense => WaitAndFindElement(By.Id("DateOfOff"));
        public static IWebElement TimeOfOffense => WaitAndFindElement(By.Id("TimeOfOff"));
        public static IWebElement OffenseLocation => WaitAndFindElement(By.XPath("//*[@id=\"collapse_3_1\"]/div/div/div[5]/div/span[1]"));
        public static IWebElement LstOffenseLocation => WaitAndFindElement(By.XPath("//*[@id=\"IncidentLocationId_listbox\"]/li[1]"));
        public static IWebElement OffenseType => WaitAndFindElement(By.XPath("//*[@id=\"collapse_3_1\"]/div/div/div[6]/div/span[1]"));
        public static IWebElement LstOffenseType => WaitAndFindElement(By.XPath("//*[@id=\"offenseType_listbox\"]/li[1]"));
        public static IWebElement SaveOffense => WaitAndFindElement(By.XPath("//*[@id=\"offenceinformationcreateform\"]/div[2]/div/div/button"));
        public static IWebElement CancelOffense => WaitAndFindElement(By.XPath("//*[@id=\"offenceinformationcreateform\"]/div[2]/div/div/a"));

        public OffenseComponent(IWebDriver driver) : base(driver)
        {
        }
    }
}
