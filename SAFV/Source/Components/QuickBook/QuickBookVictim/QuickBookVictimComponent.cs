using NUnit.Framework;
using OpenQA.Selenium;

namespace SAFV.Source.Components.QuickBook.QuickBookVictim
{
    public class QuickBookVictimComponent : BaseComponent
    {
        // Elements
        public static IWebElement FirstName => WaitAndFindElement(By.Id("FirstName"));
        public static IList<IWebElement> LstFirstName => WaitAndFindElements(By.XPath("//*[@id=\"FirstNameautocomplete-list\"]/div"));
        public static IWebElement LastName => WaitAndFindElement(By.Id("LastName"));
        public static IWebElement VictimWouldLikeToUsePseudonym => WaitAndFindElement(By.XPath("//*[@id=\"createbasicinfoform\"]/div/div[1]/div[3]/div[1]/div/span[1]"));
        public static IWebElement ConfirmPseudonym => WaitAndFindElement(By.XPath("//*[@id=\"warningForPrivateData\"]/div[2]/div[2]/button"));
        public static IWebElement VictimRealFirstName => WaitAndFindElement(By.Id("VictimRealFirstName"));
        public static IWebElement VictimRealLastName => WaitAndFindElement(By.Id("VictimRealLastName"));
        public static IWebElement VictimRealMiddleName => WaitAndFindElement(By.Id("VictimRealMiddleName"));
        public static IWebElement ClosePseudonym => WaitAndFindElement(By.XPath("//*[@id=\"createVictimAliasForm\"]/div[4]/button"));
        public static IWebElement Race => WaitAndFindElement(By.XPath("//*[@id=\"createbasicinfoform\"]/div/div[1]/div[4]/div/span[1]"));
        public static IList<IWebElement> LstRace => WaitAndFindElements(By.XPath("//*[@id=\"RaceId_listbox\"]/li"));
        public static IWebElement Sex => WaitAndFindElement(By.XPath("//*[@id=\"createbasicinfoform\"]/div/div[1]/div[5]/div/span[1]"));
        public static IList<IWebElement> LstSex => WaitAndFindElements(By.XPath("//*[@id=\"SexId_listbox\"]/li"));
        public static IWebElement DateOfBirth => WaitAndFindElement(By.Id("DateOfBirth"));

        public static IWebElement Save => WaitAndFindElement(By.Id("btn-submit-victim"));
        public static IWebElement Cancel => WaitAndFindElement(By.XPath("//*[@id=\"createbasicinfoform\"]/div/div[2]/button[2]"));
        public static IWebElement Next => WaitAndFindElement(By.Id("victimNext"));
        public static IWebElement Back => WaitAndFindElement(By.Id("victimBack"));

        public static IWebElement SyncConfirmation => WaitAndFindElement(By.Id("btnSyncConfirmation"));
        public static IWebElement NoSyncConfirmation => WaitAndFindElement(By.Id("btnNoSyncConfirmation"));

        public QuickBookVictimComponent(IWebDriver driver) : base(driver)
        {
        }
    }
}
