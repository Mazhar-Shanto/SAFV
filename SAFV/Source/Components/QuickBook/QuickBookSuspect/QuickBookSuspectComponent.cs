using NUnit.Framework;
using OpenQA.Selenium;

namespace SAFV.Source.Components.QuickBook.QuickBookSuspect
{
    public class QuickBookSuspectComponent : BaseComponent
    {
        // Elements
        public static IWebElement FirstName => WaitAndFindElement(By.Id("FirstName"));
        public static IWebElement LstFirstName => WaitAndFindElement(By.XPath("//*[@id=\"FirstNameautocomplete-list\"]/div[1]"));
        public static IWebElement LastName => WaitAndFindElement(By.Id("LastName"));
        public static IWebElement Race => WaitAndFindElement(By.XPath("//*[@id=\"createbasicinfoform\"]/div/div[1]/div[3]/div/span[1]"));
        public static IList<IWebElement> LstRace => WaitAndFindElements(By.XPath("//*[@id=\"RaceId_listbox\"]/li"));
        public static IWebElement Sex => WaitAndFindElement(By.XPath("//*[@id=\"createbasicinfoform\"]/div/div[1]/div[4]/div/span[1]"));
        public static IList<IWebElement> LstSex => WaitAndFindElements(By.XPath("//*[@id=\"SexId_listbox\"]/li"));
        public static IWebElement DateOfBirth => WaitAndFindElement(By.Id("DateOfBirth"));
        public static IWebElement EyeColor => WaitAndFindElement(By.XPath("//*[@id=\"createbasicinfoform\"]/div/div[1]/div[6]/div/span"));
        public static IList<IWebElement> LstEyeColor => WaitAndFindElements(By.XPath("//*[@id=\"EyeColorId_listbox\"]/li"));
        public static IWebElement HairColor => WaitAndFindElement(By.XPath("//*[@id=\"createbasicinfoform\"]/div/div[1]/div[7]/div/span"));
        public static IList<IWebElement> LstHairColor => WaitAndFindElements(By.XPath("//*[@id=\"HairColorId_listbox\"]/li"));

        public static IWebElement HeightFeet => WaitAndFindElement(By.Id("HeightFt"));
        public static IWebElement HeightInch => WaitAndFindElement(By.Id("HeightIn"));
        public static IWebElement Weight => WaitAndFindElement(By.Id("Weight"));
        public static IWebElement PersonIdType => WaitAndFindElement(By.XPath("//*[@id=\"createbasicinfoform\"]/div/div[1]/div[10]/div/span"));
        public static IList<IWebElement> LstPersonIdType => WaitAndFindElements(By.XPath("//*[@id=\"PersonIDTypeId_listbox\"]/li"));
        public static IWebElement IdNumber => WaitAndFindElement(By.Id("IDCardNo"));
        public static IWebElement IdState => WaitAndFindElement(By.Id("IDCardNoState"));
        public static IWebElement IdExpireDate => WaitAndFindElement(By.Id("IDExpirationDate"));
        public static IWebElement PlaceOfBirth => WaitAndFindElement(By.Id("PlaceOfBirth"));
        public static IWebElement ScarsMarks => WaitAndFindElement(By.Id("ScarsMarks"));
        public static IWebElement RelationshipToVictim => WaitAndFindElement(By.XPath("//*[@id=\"createbasicinfoform\"]/div/div[1]/div[16]/div/div"));
        public static IList<IWebElement> LstRelationshipToVictim => WaitAndFindElements(By.XPath("//*[@id=\"Relation_RelationShipNames_listbox\"]/li"));

        public static IWebElement Next => WaitAndFindElement(By.Id("suspectNext"));
        public static IWebElement Back => WaitAndFindElement(By.Id("suspectBack"));

        public static IWebElement Save => WaitAndFindElement(By.Id("submit-btn"));
        public static IWebElement SaveAndNext => WaitAndFindElement(By.XPath("//*[@id=\"createbasicinfoform\"]/div/div[2]/button[2]"));
        public static IWebElement Cancel => WaitAndFindElement(By.XPath("//*[@id=\"createbasicinfoform\"]/div/div[2]/button[3]"));

        public static IWebElement SyncConfirmation => WaitAndFindElement(By.Id("btnSyncConfirmation"));
        public static IWebElement NoSyncConfirmation => WaitAndFindElement(By.Id("btnNoSyncConfirmation"));

        public QuickBookSuspectComponent(IWebDriver driver) : base(driver)
        {
        }
    }
}
