using OpenQA.Selenium;

namespace SAFV.Source.Components.CourtEpo
{
    public class CourtEpoSuspectInfoComponent : BaseComponent
    {
        // Elements
        public static IWebElement FirstName => WaitAndFindElement(By.Id("FirstName"));
        public static IWebElement LastName => WaitAndFindElement(By.Id("LastName"));
        public static IWebElement MiddleName => WaitAndFindElement(By.Id("MiddleName"));
        public static IWebElement Race => WaitAndFindElement(By.XPath("//*[@id=\"court-epo-suspect-submit-form\"]/div/div[4]/div/span[1]"));
        public static IList<IWebElement> LstRace => WaitAndFindElements(By.XPath("//*[@id=\"RaceId_listbox\"]/li"));
        public static IWebElement Sex => WaitAndFindElement(By.XPath("//*[@id=\"court-epo-suspect-submit-form\"]/div/div[5]/div/span[1]"));
        public static IList<IWebElement> LstSex => WaitAndFindElements(By.XPath("//*[@id=\"SexId_listbox\"]/li"));
        public static IWebElement DateOfBirth => WaitAndFindElement(By.Id("DateOfBirth"));
        public static IWebElement Ethnicity => WaitAndFindElement(By.XPath("//*[@id=\"court-epo-suspect-submit-form\"]/div/div[7]/div/span"));
        public static IList<IWebElement> LstEthnicity => WaitAndFindElements(By.XPath("//*[@id=\"EthnicityId_listbox\"]/li"));
        public static IWebElement EyeColor => WaitAndFindElement(By.XPath("//*[@id=\"court-epo-suspect-submit-form\"]/div/div[8]/div/span"));
        public static IList<IWebElement> LstEyeColor => WaitAndFindElements(By.XPath("//*[@id=\"EyeColorId_listbox\"]/li"));
        public static IWebElement HairColor => WaitAndFindElement(By.XPath("//*[@id=\"court-epo-suspect-submit-form\"]/div/div[9]/div/span"));
        public static IList<IWebElement> LstHairColor => WaitAndFindElements(By.XPath("//*[@id=\"HairColorId_listbox\"]/li"));
        public static IWebElement SkinColor => WaitAndFindElement(By.XPath("//*[@id=\"court-epo-suspect-submit-form\"]/div/div[10]/div/span"));
        public static IList<IWebElement> LstSkinColor => WaitAndFindElements(By.XPath("//*[@id=\"SkinColorId_listbox\"]/li"));
        public static IWebElement PrimaryLanguage => WaitAndFindElement(By.XPath("//*[@id=\"court-epo-suspect-submit-form\"]/div/div[11]/div/span"));
        public static IList<IWebElement> LstPrimaryLanguage => WaitAndFindElements(By.XPath("//*[@id=\"PrimaryLanguage_listbox\"]/li"));
        public static IWebElement MedicalConditions => WaitAndFindElement(By.XPath("//*[@id=\"court-epo-suspect-submit-form\"]/div/div[12]/div"));
        public static IList<IWebElement> LstMedicalConditions => WaitAndFindElements(By.XPath("//*[@id=\"MedicalConditionIds_listbox\"]/li"));
        public static IWebElement MarksOrTattoos => WaitAndFindElement(By.Id("IdentificationMarks"));
        public static IWebElement PlaceOfBirth => WaitAndFindElement(By.Id("PlaceOfBirth"));
        public static IWebElement Weight => WaitAndFindElement(By.Id("Weight"));
        public static IWebElement HeightFeet => WaitAndFindElement(By.Id("HeightFt"));
        public static IWebElement HeightInch => WaitAndFindElement(By.Id("HeightIn"));
        public static IWebElement IsThisPersonChild => WaitAndFindElement(By.Id("//*[@id=\"court-epo-suspect-submit-form\"]/div/div[17]/div/span[1]"));
        public static IWebElement UsCitizen => WaitAndFindElement(By.XPath("//*[@id=\"court-epo-suspect-submit-form\"]/div/div[18]/div/span"));
        public static IWebElement EnableSsn => WaitAndFindElement(By.XPath("//*[@id=\"court-epo-suspect-submit-form\"]/div/div[19]/div[2]/button"));
        public static IWebElement SsnFeild => WaitAndFindElement(By.Id("SSN"));
        public static IWebElement IdType => WaitAndFindElement(By.XPath("//*[@id=\"court-epo-suspect-submit-form\"]/div/div[20]/div/span[1]"));
        public static IList<IWebElement> LstIdType => WaitAndFindElements(By.XPath("//*[@id=\"PersonIDTypeId_listbox\"]/li"));
        public static IWebElement IdNumber => WaitAndFindElement(By.Id("IDCardNo"));
        public static IWebElement IdState => WaitAndFindElement(By.Id("IDCardNoState"));
        public static IWebElement IdExpires => WaitAndFindElement(By.Id("IDExpires"));
        public static IWebElement TxSid => WaitAndFindElement(By.Id("TxSID"));
        public static IWebElement Fbi => WaitAndFindElement(By.Id("FBI"));
        public static IWebElement Fpc => WaitAndFindElement(By.Id("FPC"));
        public static IWebElement Mnu => WaitAndFindElement(By.Id("MNU"));
        public static IWebElement ConcealedHandgunLicenseHolder => WaitAndFindElement(By.XPath("//*[@id=\"court-epo-suspect-submit-form\"]/div/div[28]/div/span[1]"));
        public static IWebElement SaveCourtEpoSuspectInfo => WaitAndFindElement(By.XPath("//*[@id=\"court-epo-suspect-submit-form\"]/div/div[31]/div/div/button"));
        public static IWebElement CancelCourtEpoSuspectInfo => WaitAndFindElement(By.XPath("//*[@id=\"court-epo-suspect-submit-form\"]/div/div[31]/div/div/a"));

        public CourtEpoSuspectInfoComponent(IWebDriver driver) : base(driver)
        {
        }
    }
}
