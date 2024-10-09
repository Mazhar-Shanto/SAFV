using AventStack.ExtentReports.Gherkin.Model;
using NUnit.Framework;
using OpenQA.Selenium;

namespace SAFV.Source.Components.QuickBook.QuickBookVictim
{
    public class QuickBookVictimAddressPhoneComponent : BaseComponent
    {
        // Elements
        public static IWebElement AddPhoneNumber => WaitAndFindElement(By.XPath("//*[@id=\"master-container\"]/div[1]/div/div[1]/button"));
        public static IWebElement PhoneType => WaitAndFindElement(By.XPath("//*[@id=\"CreateForm\"]/div[1]/div[2]/span[1]"));
        public static IList<IWebElement> LstPhoneType => WaitAndFindElements(By.XPath("//*[@id=\"PhoneTypeId_listbox\"]/li"));
        public static IWebElement PhoneNumber => WaitAndFindElement(By.Id("PhoneNumber"));
        public static IWebElement PrimaryContact => WaitAndFindElement(By.XPath("//*[@id=\"CreateForm\"]/div[3]/div[2]/span[1]"));
        public static IWebElement SavePhoneNumber => WaitAndFindElement(By.XPath("//*[@id=\"person-phone-form\"]/div[2]/button[1]"));
        public static IWebElement ClosePhoneNumber => WaitAndFindElement(By.Id("btnPhoneCloseModal"));

        public static IWebElement AddNewAddress => WaitAndFindElement(By.XPath("//*[@id=\"master-container\"]/div[2]/div/div[1]/button[1]"));
        public static IWebElement AddressGroup => WaitAndFindElement(By.XPath("//*[@id=\"CreateForm\"]/div[1]/div[2]/span[1]"));
        public static IList<IWebElement> LstAddressGroup => WaitAndFindElements(By.XPath("//*[@id=\"AddressGroupId_listbox\"]/li"));
        public static IWebElement Address1 => WaitAndFindElement(By.Id("serviceInput"));
        public static IWebElement Address2 => WaitAndFindElement(By.Id("Address2"));
        public static IWebElement City => WaitAndFindElement(By.Id("City"));
        public static IWebElement State => WaitAndFindElement(By.Id("State"));
        public static IWebElement County => WaitAndFindElement(By.XPath("//*[@id=\"CreateForm\"]/div[6]/div[2]/span[1]"));
        public static IList<IWebElement> LstCounty => WaitAndFindElements(By.XPath("//*[@id=\"County_listbox\"]/li"));
        public static IWebElement ZipCode => WaitAndFindElement(By.Id("ZipCode"));

        public static IWebElement SaveAddress => WaitAndFindElement(By.XPath("//*[@id=\"person-address-form\"]/div[2]/button[1]"));
        public static IWebElement CloseAddress => WaitAndFindElement(By.Id("btnCloseModal"));
        public static IWebElement Next => WaitAndFindElement(By.Id("victimNext"));
        public static IWebElement Back => WaitAndFindElement(By.Id("victimBack"));

        public QuickBookVictimAddressPhoneComponent(IWebDriver driver) : base(driver)
        {
        }
    }
}
