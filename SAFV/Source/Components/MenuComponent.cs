using OpenQA.Selenium;

namespace SAFV.Source.Components
{
    public class MenuComponent : BaseComponent
    {
        // Elements
        public static IWebElement Home => WaitAndFindElement(By.XPath("//*[@id=\"remove-scroll\"]/div/ul/li[3]/a"));
        public static IWebElement Incidents => WaitAndFindElement(By.XPath("//*[@id=\"remove-scroll\"]/div/ul/li[4]/a"));
        public static IWebElement IncidentsPage => WaitAndFindElement(By.XPath("//*[@id=\"remove-scroll\"]/div/ul/li[4]/ul/li[1]/a"));
        public static IWebElement CreateNewIncidentButton => WaitAndFindElement(By.XPath("//*[@id=\"remove-scroll\"]/div/ul/li[4]/ul/li[2]/a"));
        public static IWebElement CreateQuickBook => WaitAndFindElement(By.XPath("//*[@id=\"remove-scroll\"]/div/ul/li[4]/ul/li[3]/a"));
        //public static IWebElement Courts => WaitAndFindElement(By.XPath("//*[@id=\"remove-scroll\"]/div/ul/li[6]/a"));
        public static IWebElement Signing => WaitAndFindElement(By.XPath("//*[@id=\"remove-scroll\"]/div/ul/li[4]/a"));
        public static IWebElement Courts => WaitAndFindElement(By.XPath("//*[@id=\"remove-scroll\"]/div/ul/li[5]/a"));
        //public static IWebElement Epo => WaitAndFindElement(By.XPath("//*[@id=\"remove-scroll\"]/div/ul/li[6]/ul/li[1]/a"));
        public static IWebElement Epo => WaitAndFindElement(By.XPath("//*[@id=\"remove-scroll\"]/div/ul/li[5]/ul/li[1]/a"));
        //public static IWebElement CompletedEpo => WaitAndFindElement(By.XPath("//*[@id=\"remove-scroll\"]/div/ul/li[6]/ul/li[2]/a"));
        public static IWebElement CompletedEpo => WaitAndFindElement(By.XPath("//*[@id=\"remove-scroll\"]/div/ul/li[5]/ul/li[2]/a"));
        //public static IWebElement CancelledEpo => WaitAndFindElement(By.XPath("//*[@id=\"remove-scroll\"]/div/ul/li[6]/ul/li[3]/a"));
        public static IWebElement CancelledEpo => WaitAndFindElement(By.XPath("//*[@id=\"remove-scroll\"]/div/ul/li[5]/ul/li[3]/a"));
        //public static IWebElement CreateNewEpo => WaitAndFindElement(By.XPath("//*[@id=\"remove-scroll\"]/div/ul/li[6]/ul/li[4]/a"));
        public static IWebElement CreateNewEpo => WaitAndFindElement(By.XPath("//*[@id=\"remove-scroll\"]/div/ul/li[5]/ul/li[4]/a"));
        //public static IWebElement SearchCase => WaitAndFindElement(By.XPath("//*[@id=\"remove-scroll\"]/div/ul/li[6]/ul/li[7]/a"));
        public static IWebElement SearchCase => WaitAndFindElement(By.XPath("//*[@id=\"remove-scroll\"]/div/ul/li[5]/ul/li[7]/a"));

        public MenuComponent(IWebDriver driver) : base(driver)
        {
        }
    }
}
