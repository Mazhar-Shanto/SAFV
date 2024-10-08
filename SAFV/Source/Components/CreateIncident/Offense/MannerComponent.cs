using OpenQA.Selenium;
using static Microsoft.AspNetCore.Razor.Language.TagHelperMetadata;
using System.Security.Cryptography;

namespace SAFV.Source.Components.CreateIncident.Offense
{
    public class MannerComponent : BaseComponent
    {
        // Elements
        public static IWebElement AddNewManner => WaitAndFindElement(By.XPath("//*[@id=\"master-container\"]/div[1]/div/div/div/div[2]/span/a"));
        public static IWebElement ActionOfSuspect => WaitAndFindElement(By.XPath("//*[@id=\"collapse_1\"]/div/div[1]/div/span[1]"));
        public static IList<IWebElement> LstActionOfSuspect => WaitAndFindElements(By.XPath("//*[@id=\"IncidentMMActionId_listbox\"]/li"));
        public static IWebElement ActionDescription => WaitAndFindElement(By.Id("ActionDesc"));
        public static IWebElement HowSuspectCommitAction => WaitAndFindElement(By.XPath("//*[@id=\"collapse_1\"]/div/div[3]/div/span[1]"));
        public static IList<IWebElement> LstHowSuspectCommitAction => WaitAndFindElements(By.XPath("//*[@id=\"IncidentMMUseId_listbox\"]/li"));
        public static IWebElement DescribeObject => WaitAndFindElement(By.Id("ObjectDesc"));
        public static IWebElement Face => WaitAndFindElement(By.XPath("//*[@id=\"collapse_1\"]/div/div[5]/div/ul/li[1]/span"));
        public static IWebElement Upperbody => WaitAndFindElement(By.XPath("//*[@id=\"collapse_1\"]/div/div[5]/div/ul/li[2]/span"));
        public static IWebElement LowerBody => WaitAndFindElement(By.XPath("//*[@id=\"collapse_1\"]/div/div[5]/div/ul/li[3]/span"));
        public static IWebElement EntireBody => WaitAndFindElement(By.XPath("//*[@id=\"collapse_1\"]/div/div[5]/div/ul/li[4]/span"));
        public static IWebElement Head => WaitAndFindElement(By.XPath("//*[@id=\"collapse_1\"]/div/div[5]/div/ul/li[5]/span"));
        public static IWebElement StomachAbdomen => WaitAndFindElement(By.XPath("//*[@id=\"collapse_1\"]/div/div[5]/div/ul/li[6]/span"));
        public static IWebElement Genitals => WaitAndFindElement(By.XPath("//*[@id=\"collapse_1\"]/div/div[5]/div/ul/li[7]/span"));
        public static IWebElement Neck => WaitAndFindElement(By.XPath("//*[@id=\"collapse_1\"]/div/div[5]/div/ul/li[8]/span"));
        public static IWebElement Throat => WaitAndFindElement(By.XPath("//*[@id=\"collapse_1\"]/div/div[5]/div/ul/li[9]/span"));
        public static IWebElement Extremities => WaitAndFindElement(By.XPath("//*[@id=\"collapse_1\"]/div/div[5]/div/ul/li[10]/span"));
        public static IWebElement SaveManner => WaitAndFindElement(By.Id("strangulation-submit-button"));
        public static IWebElement CancelManner => WaitAndFindElement(By.Id("back"));

        public MannerComponent(IWebDriver driver) : base(driver)
        {
        }
    }
}
