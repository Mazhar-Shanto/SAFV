using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAFV.Source.Components.CourtEpo
{
    internal class CourtEpoOtherInfoComponent : BaseComponent
    {
        // Elements
        public static IWebElement AddNewOtherInfo => WaitAndFindElement(By.XPath("//*[@id=\"module-container\"]/div/div[1]/div[1]/div/a"));
        public static IWebElement FirstName => WaitAndFindElement(By.Id("FirstName"));
        public static IWebElement LastName => WaitAndFindElement(By.Id("LastName"));
        public static IWebElement MiddleName => WaitAndFindElement(By.Id("MiddleName"));
        public static IWebElement Race => WaitAndFindElement(By.XPath("//*[@id=\"epo-other-submit-form\"]/div/div[4]/div/span[1]"));
        public static IList<IWebElement> LstRace => WaitAndFindElements(By.XPath("//*[@id=\"RaceId_listbox\"]/li"));
        public static IWebElement Sex => WaitAndFindElement(By.XPath("//*[@id=\"epo-other-submit-form\"]/div/div[5]/div/span[1]"));
        public static IList<IWebElement> LstSex => WaitAndFindElements(By.XPath("//*[@id=\"SexId_listbox\"]/li"));
        public static IWebElement DateOfBirth => WaitAndFindElement(By.Id("DateOfBirth"));
        public static IWebElement Ethnicity => WaitAndFindElement(By.XPath("//*[@id=\"epo-other-submit-form\"]/div/div[7]/div/span"));
        public static IList<IWebElement> LstEthnicity => WaitAndFindElements(By.XPath("//*[@id=\"EthnicityId_listbox\"]/li"));
        public static IWebElement EyeColor => WaitAndFindElement(By.XPath("//*[@id=\"epo-other-submit-form\"]/div/div[8]/div/span"));
        public static IList<IWebElement> LstEyeColor => WaitAndFindElements(By.XPath("//*[@id=\"EyeColorId_listbox\"]/li"));
        public static IWebElement HairColor => WaitAndFindElement(By.XPath("//*[@id=\"epo-other-submit-form\"]/div/div[9]/div/span"));
        public static IList<IWebElement> LstHairColor => WaitAndFindElements(By.XPath("//*[@id=\"HairColorId_listbox\"]/li"));
        public static IWebElement PrimaryLanguage => WaitAndFindElement(By.XPath("//*[@id=\"epo-other-submit-form\"]/div/div[12]/div/span"));
        public static IList<IWebElement> LstPrimaryLanguage => WaitAndFindElements(By.XPath("//*[@id=\"PrimaryLanguage_listbox\"]/li"));
        public static IWebElement MedicalConditions => WaitAndFindElement(By.XPath("//*[@id=\"epo-other-submit-form\"]/div/div[12]/div"));
        public static IList<IWebElement> LstMedicalConditions => WaitAndFindElements(By.XPath("//*[@id=\"MedicalConditionIds_listbox\"]/li"));
        public static IWebElement MarksOrTattoos => WaitAndFindElement(By.Id("IdentificationMarks"));
        public static IWebElement PlaceOfBirth => WaitAndFindElement(By.Id("PlaceOfBirth"));
        public static IWebElement Weight => WaitAndFindElement(By.Id("Weight"));
        public static IWebElement HeightFeet => WaitAndFindElement(By.Id("HeightFt"));
        public static IWebElement HeightInch => WaitAndFindElement(By.Id("HeightIn"));
        public static IWebElement IsThisPersonChild => WaitAndFindElement(By.XPath("//*[@id=\"epo-other-submit-form\"]/div/div[13]/div/span[1]"));
        public static IWebElement EnableSsn => WaitAndFindElement(By.XPath("//*[@id=\"epo-other-submit-form\"]/div/div[14]/div[2]/button"));
        public static IWebElement SsnFeild => WaitAndFindElement(By.Id("SSN"));
        public static IList<IWebElement> LstVictimRelationshipToSuspect => WaitAndFindElements(By.XPath("//*[@id=\"VictimRelationshipArrayFormat_listbox\"]/li"));
        public static IWebElement SaveEpoOtherInfo => WaitAndFindElement(By.XPath("//*[@id=\"epo-other-submit-form\"]/div/div[17]/div/div/button"));
        public static IWebElement CancelEpoOtherInfo => WaitAndFindElement(By.XPath("//*[@id=\"epo-other-submit-form\"]/div/div[17]/div/div/a"));


        public CourtEpoOtherInfoComponent(IWebDriver driver) : base(driver)
        {
        }
    }
}
