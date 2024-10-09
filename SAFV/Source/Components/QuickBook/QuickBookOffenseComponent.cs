using NUnit.Framework;
using OpenQA.Selenium;

namespace SAFV.Source.Components.QuickBook
{
    public class QuickBookOffenseComponent : BaseComponent
    {
        // Elements
        public static IWebElement DateOfOffense => WaitAndFindElement(By.Id("DateOfOffense"));
        public static IWebElement TimeOfOffense => WaitAndFindElement(By.Id("TimeOfOffense"));
        public static IWebElement Location => WaitAndFindElement(By.XPath("//*[@id=\"offenseArea\"]/div/div/div[4]/div/span[1]"));
        public static IList<IWebElement> LstLocation => WaitAndFindElements(By.XPath("//*[@id=\"location-items_listbox\"]/li"));
        public static IWebElement OffenseType => WaitAndFindElement(By.XPath("//*[@id=\"offenseArea\"]/div/div/div[5]/div/span[1]"));
        public static IList<IWebElement> LstOffenseType => WaitAndFindElements(By.XPath("//*[@id=\"OffenseId_listbox\"]/li"));
        public static IWebElement AddOffenseButton => WaitAndFindElement(By.Id("addOffenseButton"));

        public static IWebElement Next => WaitAndFindElement(By.XPath("//*[@id=\"person-page\"]/div/div[1]/div/div/div/div[2]/button[2]/i"));
        public static IWebElement Back => WaitAndFindElement(By.XPath("//*[@id=\"person-page\"]/div/div[1]/div/div/div/div[2]/button[1]"));

        public QuickBookOffenseComponent(IWebDriver driver) : base(driver)
        {
        }
    }
}
