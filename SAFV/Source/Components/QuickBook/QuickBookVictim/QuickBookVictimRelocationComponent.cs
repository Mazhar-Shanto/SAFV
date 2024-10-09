using AventStack.ExtentReports.Gherkin.Model;
using NUnit.Framework;
using OpenQA.Selenium;

namespace SAFV.Source.Components.QuickBook.QuickBookVictim
{
    public class QuickBookVictimRelocationComponent : BaseComponent
    {
        // Elements
        public static IWebElement IsVictimRelocating => WaitAndFindElement(By.XPath("//*[@id=\"incident_victim\"]/div/div[1]/div[1]/div/span[1]"));

        public static IWebElement Permanent => WaitAndFindElement(By.XPath("//*[@id=\"incident_victim\"]/div/div[1]/div[2]/div[1]/div/span[1]"));
        public static IWebElement PermanentAddress1 => WaitAndFindElement(By.Id("PermAddressService"));
        public static IWebElement PermanentAddress2 => WaitAndFindElement(By.Id("PermAddress2"));
        public static IWebElement PermanentCity => WaitAndFindElement(By.Id("PermCity"));
        public static IWebElement PermanentState => WaitAndFindElement(By.Id("PermState"));
        public static IWebElement PermanentZipCode => WaitAndFindElement(By.Id("PermZipCode"));
        public static IWebElement PermanentCounty => WaitAndFindElement(By.XPath("//*[@id=\"incident_victim\"]/div/div[1]/div[2]/div[2]/div[7]/div/span[1]"));
        public static IList<IWebElement> LstPermanentCounty => WaitAndFindElements(By.XPath("//*[@id=\"PermCounty_listbox\"]/li"));

        public static IWebElement Temporary => WaitAndFindElement(By.XPath("//*[@id=\"incident_victim\"]/div/div[1]/div[2]/div[3]/div/span[1]"));

        public static IWebElement TemporaryAddress1 => WaitAndFindElement(By.Id("TempAddressService"));
        public static IWebElement TemporaryAddress2 => WaitAndFindElement(By.Id("TempAddress2"));
        public static IWebElement TemporaryCity => WaitAndFindElement(By.Id("TempCity"));
        public static IWebElement TemporaryState => WaitAndFindElement(By.Id("TempState"));
        public static IWebElement TemporaryZipCode => WaitAndFindElement(By.Id("TempZipCode"));
        public static IWebElement TemporaryCounty => WaitAndFindElement(By.XPath("//*[@id=\"incident_victim\"]/div/div[1]/div[2]/div[4]/div[7]/div/span[1]"));
        public static IList<IWebElement> LstTemporaryCounty => WaitAndFindElements(By.XPath("//*[@id=\"TempCounty_listbox\"]/li"));
        public static IWebElement HowLong => WaitAndFindElement(By.Id("HowLong"));

        public static IWebElement OmitLocationFromProtectionOrder => WaitAndFindElement(By.XPath("//*[@id=\"incident_victim\"]/div/div[1]/div[2]/div[5]/div/span[1]"));
        public static IWebElement VictimsConcern => WaitAndFindElement(By.Id("VictimLocationConcern"));

        public static IWebElement Save => WaitAndFindElement(By.XPath("//*[@id=\"incident_victim\"]/div/div[2]/div/button[1]"));
        public static IWebElement SaveAndNext => WaitAndFindElement(By.XPath("//*[@id=\"incident_victim\"]/div/div[2]/div/button[2]"));
        public static IWebElement Cancel => WaitAndFindElement(By.XPath("//*[@id=\"incident_victim\"]/div/div[2]/div/button[3]"));

        public QuickBookVictimRelocationComponent(IWebDriver driver) : base(driver)
        {
        }
    }
}
