using NUnit.Framework;
using OpenQA.Selenium;

namespace SAFV.Source.Components.QuickBook.QuickBookVictim
{
    public class QuickBookSuspectInfoComponent : BaseComponent
    {
        // Elements
        public static IWebElement SuspectWasOnScene => WaitAndFindElement(By.XPath("//*[@id=\"suspect-form\"]/div/div[1]/div/span[1]"));
        public static IWebElement SuspectWasArrested => WaitAndFindElement(By.XPath("//*[@id=\"suspect-form\"]/div/div[3]/div/div/span[1]"));
        public static IWebElement SuspectLocatedLater => WaitAndFindElement(By.XPath("//*[@id=\"suspect-form\"]/div/div[2]/div[1]/div/span[1]"));
        public static IWebElement LocatedDate => WaitAndFindElement(By.Id("LocatedDate"));
        public static IWebElement LocatedTime => WaitAndFindElement(By.Id("LocatedTime"));

        public static IWebElement DateOfArrest => WaitAndFindElement(By.Id("DateOfArr"));
        public static IWebElement TimeOfArrest => WaitAndFindElement(By.Id("TimeOfArr"));
        public static IWebElement DateOfBooking => WaitAndFindElement(By.Id("DateOfBook"));
        public static IWebElement TimeOfBooking => WaitAndFindElement(By.Id("TimeOfBook"));

        public static IWebElement ArrestAddress1 => WaitAndFindElement(By.Id("serviceInput"));
        public static IWebElement ArrestAddress2 => WaitAndFindElement(By.Id("ArrestAddress2"));
        public static IWebElement ArrestCity => WaitAndFindElement(By.Id("ArrestCity"));
        public static IWebElement ArrestState => WaitAndFindElement(By.Id("ArrestState"));
        public static IWebElement ArrestZipCode => WaitAndFindElement(By.Id("ArrestZipCode"));
        public static IWebElement ArrestCounty => WaitAndFindElement(By.XPath("//*[@id=\"suspect_arrest_div\"]/div[11]/div/span[1]"));
        public static IList<IWebElement> LstArrestCounty => WaitAndFindElements(By.XPath("//*[@id=\"ArrestCounty_listbox\"]/li"));

        public static IWebElement Save => WaitAndFindElement(By.XPath("//*[@id=\"suspect-form\"]/div/div[6]/div/button[1]"));
        public static IWebElement SaveAndNext => WaitAndFindElement(By.XPath("//*[@id=\"suspect-form\"]/div/div[6]/div/button[2]/i"));
        public static IWebElement Cancel => WaitAndFindElement(By.XPath("//*[@id=\"suspect-form\"]/div/div[6]/div/button[3]"));

        public QuickBookSuspectInfoComponent(IWebDriver driver) : base(driver)
        {
        }
    }
}
