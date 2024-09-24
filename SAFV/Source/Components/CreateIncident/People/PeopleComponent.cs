using OpenQA.Selenium;

namespace SAFV.Source.Components.CreateIncident.People
{
    public class PeopleComponent : BaseComponent
    {
        // Elements
        public static IWebElement AddPerson => WaitAndFindElement(By.XPath("//*[@id=\"module-container\"]/div/div[1]/div/div[2]/a"));
        public static IWebElement FirstName => WaitAndFindElement(By.Id("FirstName"));
        public static IWebElement LastName => WaitAndFindElement(By.Id("LastName"));
        public static IWebElement MiddleName => WaitAndFindElement(By.Id("MiddleName"));
        public static IWebElement Alias => WaitAndFindElement(By.XPath("//*[@id=\"createbasicinfoform\"]/div/div[1]/div[4]/div/span[1]"));
        public static IWebElement AliasDescription => WaitAndFindElement(By.Id("AliasDesc"));
        public static IWebElement Victim => WaitAndFindElement(By.XPath("//*[@id=\"createbasicinfoform\"]/div/div[1]/div[6]/div/div[1]/span"));
        public static IWebElement Suspect => WaitAndFindElement(By.XPath("//*[@id=\"createbasicinfoform\"]/div/div[1]/div[6]/div/div[2]/span"));
        public static IWebElement Witness => WaitAndFindElement(By.XPath("//*[@id=\"createbasicinfoform\"]/div/div[1]/div[6]/div/div[3]/span"));
        public static IWebElement OtherNotInvolved => WaitAndFindElement(By.XPath("//*[@id=\"createbasicinfoform\"]/div/div[1]/div[6]/div/div[4]/span"));
        public static IWebElement VictimWouldLikeToUsePseudonym => WaitAndFindElement(By.XPath("//*[@id=\"createbasicinfoform\"]/div/div[1]/div[8]/div[1]/div/span[1]"));
        public static IWebElement EditRealName => WaitAndFindElement(By.XPath("//*[@id=\"displayoreditrealname\"]/div[2]/button"));
        public static IWebElement ConfirmPseudonym => WaitAndFindElement(By.XPath("//*[@id=\"warningForPrivateData\"]/div[2]/div[2]/button"));
        public static IWebElement VictimRealFirstName => WaitAndFindElement(By.Id("VictimRealFirstName"));
        public static IWebElement VictimRealLastName => WaitAndFindElement(By.Id("VictimRealLastName"));
        public static IWebElement VictimRealMiddleName => WaitAndFindElement(By.Id("VictimRealMiddleName"));
        public static IWebElement WasPresent => WaitAndFindElement(By.XPath("//*[@id=\"createbasicinfoform\"]/div/div[1]/div[7]/div/span[1]"));
        public static IWebElement IsUnknownPerson => WaitAndFindElement(By.XPath("//*[@id=\"createbasicinfoform\"]/div/div[1]/div[9]/div/span[1]"));
        public static IWebElement Race => WaitAndFindElement(By.XPath("//*[@id=\"createbasicinfoform\"]/div/div[1]/div[10]/div/span[1]"));
        public static IList<IWebElement> LstRace => WaitAndFindElements(By.XPath("//*[@id=\"RaceId_listbox\"]/li"));
        public static IWebElement Sex => WaitAndFindElement(By.XPath("//*[@id=\"createbasicinfoform\"]/div/div[1]/div[11]/div/span[1]"));
        public static IList<IWebElement> LstSex => WaitAndFindElements(By.XPath("//*[@id=\"SexId_listbox\"]/li"));
        public static IWebElement DateOfBirth => WaitAndFindElement(By.Id("DateOfBirth"));
        public static IWebElement Age => WaitAndFindElement(By.Id("Age"));
        public static IWebElement SaveAndShowMore => WaitAndFindElement(By.XPath("//*[@id=\"createbasicinfoform\"]/div/div[2]/div/div/button[1]"));
        public static IWebElement Cancel => WaitAndFindElement(By.XPath("//*[@id=\"createbasicinfoform\"]/div/div[2]/div/div/a"));


        // more info
        public static IWebElement Ethnicity => WaitAndFindElement(By.XPath("//*[@id=\"createbasicinfoform\"]/div/div[2]/div/span"));
        public static IList<IWebElement> LstEthnicity => WaitAndFindElements(By.XPath("//*[@id=\"EthnicityId_listbox\"]/li"));
        public static IWebElement EyeColor => WaitAndFindElement(By.XPath("//*[@id=\"createbasicinfoform\"]/div/div[3]/div/span"));
        public static IList<IWebElement> LstEyeColor => WaitAndFindElements(By.XPath("//*[@id=\"EyeColorId_listbox\"]/li"));
        public static IWebElement HairColor => WaitAndFindElement(By.XPath("//*[@id=\"createbasicinfoform\"]/div/div[4]/div/span"));
        public static IList<IWebElement> LstHairColor => WaitAndFindElements(By.XPath("//*[@id=\"HairColorId_listbox\"]/li"));
        public static IWebElement HeightFeet => WaitAndFindElement(By.Id("HeightFt"));
        public static IWebElement HeightInches => WaitAndFindElement(By.Id("HeightIn"));
        public static IWebElement Weight => WaitAndFindElement(By.Id("Weight"));
        public static IWebElement EnableSsnField => WaitAndFindElement(By.XPath("//*[@id=\"createbasicinfoform\"]/div/div[7]/div[2]/button"));
        public static IWebElement SsnField => WaitAndFindElement(By.Id("SSNAlias"));
        public static IWebElement SaveSsn => WaitAndFindElement(By.XPath("//*[@id=\"createbasicinfoform\"]/div/div[7]/div[3]/button[1]"));
        public static IWebElement PrimaryLanguage => WaitAndFindElement(By.XPath("//*[@id=\"createbasicinfoform\"]/div/div[8]/div/span"));
        public static IList<IWebElement> LstPrimaryLanguage => WaitAndFindElements(By.XPath("//*[@id=\"PrimaryLanguage_listbox\"]/li"));
        public static IWebElement PersonIdType => WaitAndFindElement(By.XPath("//*[@id=\"createbasicinfoform\"]/div/div[9]/div/span"));
        public static IList<IWebElement> LstPersonIdType => WaitAndFindElements(By.XPath("//*[@id=\"PersonIDTypeId_listbox\"]/li"));
        public static IWebElement IdNumber => WaitAndFindElement(By.Id("IDCardNo"));
        public static IWebElement IdState => WaitAndFindElement(By.Id("IDCardNoState"));
        public static IWebElement IdExpirationDate => WaitAndFindElement(By.Id("IDExpirationDate"));
        public static IWebElement Email => WaitAndFindElement(By.Id("EmailAddress"));
        public static IWebElement SafeToContactViaEmail => WaitAndFindElement(By.XPath("//*[@id=\"createbasicinfoform\"]/div/div[14]/div/span"));
        public static IWebElement Occupation => WaitAndFindElement(By.Id("Occupation"));
        public static IWebElement PlaceOfBirth => WaitAndFindElement(By.Id("PlaceOfBirth"));
        public static IWebElement NameOfEmployer => WaitAndFindElement(By.Id("PlaceOfEmployment"));
        public static IWebElement ScarsMarks => WaitAndFindElement(By.Id("ScarsMarks"));
        public static IWebElement TxSid => WaitAndFindElement(By.Id("TxSID"));
        public static IWebElement SpecialNeeds => WaitAndFindElement(By.Id("SpecialNeeds"));
        public static IWebElement HandcuffedPriorToArrest => WaitAndFindElement(By.XPath("//*[@id=\"createbasicinfoform\"]/div/div[19]/div[1]/div[3]/div/span[1]"));
        public static IWebElement HandcuffReason => WaitAndFindElement(By.Id("RestraintPriorToArrestDesc"));
        public static IWebElement IsPersonChild => WaitAndFindElement(By.XPath("//*[@id=\"createbasicinfoform\"]/div/div[19]/div[1]/div[5]/div/span[1]"));
        public static IWebElement WasThisChildPresent => WaitAndFindElement(By.XPath("//*[@id=\"createbasicinfoform\"]/div/div[19]/div[1]/div[6]/div/span[1]"));
        public static IWebElement DidTheyAttemptToIntervene => WaitAndFindElement(By.XPath("//*[@id=\"createbasicinfoform\"]/div/div[19]/div[1]/div[7]/div[1]/div/span[1]"));
        public static IWebElement PrimaryCaretakerOfChild => WaitAndFindElement(By.XPath("//*[@id=\"createbasicinfoform\"]/div/div[19]/div[1]/div[7]/div[2]/div/span[1]"));
        public static IWebElement LstPrimaryCaretakerOfChild => WaitAndFindElement(By.XPath("//*[@id=\"PrimaryCareGiverId_listbox\"]/li[1]"));
        public static IWebElement PersonGivenMirandaWarning => WaitAndFindElement(By.XPath("//*[@id=\"createbasicinfoform\"]/div/div[19]/div[1]/div[9]/div/span[1]"));
        public static IWebElement MirandaWarningDate => WaitAndFindElement(By.Id("MirandaWhenDate"));
        public static IWebElement MirandaWarningTime => WaitAndFindElement(By.Id("MirandaWhenTime"));
        public static IWebElement StatementsMadeAfterMiranda => WaitAndFindElement(By.Id("StatementsAfter"));
        public static IWebElement IsPersonElderly => WaitAndFindElement(By.XPath("//*[@id=\"createbasicinfoform\"]/div/div[19]/div[1]/div[11]/div/span[1]"));
        public static IWebElement IsPersonDisabled => WaitAndFindElement(By.XPath("//*[@id=\"createbasicinfoform\"]/div/div[19]/div[1]/div[12]/div/span[1]"));


        // add phone number
        public static IWebElement AddNewPhoneNumber => WaitAndFindElement(By.XPath("//*[@id=\"createbasicinfoform\"]/div/div[19]/div[2]/div/div[1]/button"));
        public static IWebElement PhoneType => WaitAndFindElement(By.XPath("//*[@id=\"CreateForm\"]/div[1]/div[2]/span[1]"));
        public static IList<IWebElement> LstPhoneType => WaitAndFindElements(By.XPath("//*[@id=\"PhoneTypeId_listbox\"]/li"));
        public static IWebElement PhoneNumber => WaitAndFindElement(By.Id("PhoneNumber"));
        public static IWebElement PrimaryContact => WaitAndFindElement(By.XPath("//*[@id=\"CreateForm\"]/div[3]/div[2]/span[1]"));
        public static IWebElement SavePhoneNumber => WaitAndFindElement(By.XPath("//*[@id=\"person-phone-form\"]/div[2]/button[1]"));
        public static IWebElement CancelPhoneNumber => WaitAndFindElement(By.Id("btnPhoneCloseModal"));


        // add address
        public static IWebElement AddNewAddress => WaitAndFindElement(By.XPath("//*[@id=\"createbasicinfoform\"]/div/div[19]/div[3]/div/div[1]/button[1]"));
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
        public static IWebElement CancelAddress => WaitAndFindElement(By.Id("btnCloseModal"));


        // search people from master
        public static IWebElement SearchFromMaster => WaitAndFindElement(By.XPath("//*[@id=\"person-page\"]/div/div[1]/div/div/div/div[1]/header/button"));
        public static IWebElement SearchFirstName => WaitAndFindElement(By.Id("sFirstName"));
        public static IWebElement SearchLastName => WaitAndFindElement(By.Id("sLastName"));
        public static IWebElement SearchMiddleName => WaitAndFindElement(By.Id("sMiddleName"));
        public static IWebElement SearchPlaceOfBirth => WaitAndFindElement(By.Id("PlaceOfBirth"));
        public static IWebElement SearchPlaceOfEmployment => WaitAndFindElement(By.Id("PlaceOfEmployment"));
        public static IWebElement SearchSsn => WaitAndFindElement(By.Id("SSN"));
        public static IWebElement SearchPersonIdType => WaitAndFindElement(By.Id("//*[@id=\"masterPeopleSearch-form\"]/div[3]/div[1]/span[1]"));
        public static IList<IWebElement> LstSearchPersonIdType => WaitAndFindElements(By.Id("//*[@id=\"PersonIdType_listbox\"]/li"));
        public static IWebElement SearchId => WaitAndFindElement(By.Id("IdCardNo"));
        public static IWebElement SearchButton => WaitAndFindElement(By.Id("searchbtn"));
        public static IWebElement ClearButton => WaitAndFindElement(By.XPath("//*[@id=\"masterPeopleSearch-form\"]/div[4]/div/div[3]/button[2]"));
        public static IWebElement CloseButton => WaitAndFindElement(By.XPath("//*[@id=\"masterPeopleSearch-form\"]/div[4]/div/div[3]/button[3]"));
        public static IWebElement LoadFromMaster => WaitAndFindElement(By.XPath("//*[@id=\"master_people-grid\"]/table/tbody/tr/td[7]/a"));



        public static IWebElement SyncToMaster => WaitAndFindElement(By.Id("btnSyncConfirmation"));
        public static IWebElement NoSyncToMaster => WaitAndFindElement(By.Id("btnNoSyncConfirmation"));
        public static IWebElement SavePeople => WaitAndFindElement(By.XPath("//*[@id=\"createbasicinfoform\"]/div/div[20]/div/div/button"));
        public static IWebElement CancelPeople => WaitAndFindElement(By.XPath("//*[@id=\"createbasicinfoform\"]/div/div[20]/div/div/a"));


        public PeopleComponent(IWebDriver driver) : base(driver)
        {
        }
    }
}
