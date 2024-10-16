using OpenQA.Selenium;
using SAFV.Drivers;
using SAFV.Source.Components;
using SAFV.Source.Components.CourtEpo;
using SAFV.Source.Components.CreateIncident.Epo;
using System.Linq;

namespace SAFV.Source.Pages.CourtEpo
{
    public class CourtEpoSuspectInfoPage : BasePage
    {
        private IWebDriver _driver;

        public CourtEpoSuspectInfoPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        public void GoToCourtEpoSuspectInfoPage()
        {
            ScrollToTop();
            Click(CourtEpoMenuComponent.SuspectInfo);
        }

        public void CreateEpoSuspectInfo(Dictionary<string, string> courtEpoSuspectInfoData)
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");

            SendKeys(CourtEpoSuspectInfoComponent.FirstName, courtEpoSuspectInfoData["FirstName"]);
            SendKeys(CourtEpoSuspectInfoComponent.LastName, courtEpoSuspectInfoData["LastName"]);
            SendKeys(CourtEpoSuspectInfoComponent.MiddleName, courtEpoSuspectInfoData["MiddleName"]);
            Click(CourtEpoSuspectInfoComponent.Race);
            SelectOption(CourtEpoSuspectInfoComponent.LstRace, courtEpoSuspectInfoData["Race"]);
            Click(CourtEpoSuspectInfoComponent.Sex);
            SelectOption(CourtEpoSuspectInfoComponent.LstSex, courtEpoSuspectInfoData["Sex"]);
            SendKeys(CourtEpoSuspectInfoComponent.DateOfBirth, courtEpoSuspectInfoData["DateOfBirth"]);
            Click(CourtEpoSuspectInfoComponent.Ethnicity);
            SelectOption(CourtEpoSuspectInfoComponent.LstEthnicity, courtEpoSuspectInfoData["Ethnicity"]);
            Click(CourtEpoSuspectInfoComponent.EyeColor);
            SelectOption(CourtEpoSuspectInfoComponent.LstEyeColor, courtEpoSuspectInfoData["EyeColor"]);
            Click(CourtEpoSuspectInfoComponent.HairColor);
            SelectOption(CourtEpoSuspectInfoComponent.LstHairColor, courtEpoSuspectInfoData["HairColor"]);
            Click(CourtEpoSuspectInfoComponent.SkinColor);
            SelectOption(CourtEpoSuspectInfoComponent.LstSkinColor, courtEpoSuspectInfoData["SkinColor"]);
            Click(CourtEpoSuspectInfoComponent.MedicalConditions);
            SelectOption(CourtEpoSuspectInfoComponent.LstMedicalConditions, courtEpoSuspectInfoData["MedicalConditions"]);
            SendKeys(CourtEpoSuspectInfoComponent.MarksOrTattoos, courtEpoSuspectInfoData["MarksOrTattoos"]);
            Click(CourtEpoSuspectInfoComponent.PrimaryLanguage);
            SelectOption(CourtEpoSuspectInfoComponent.LstPrimaryLanguage, courtEpoSuspectInfoData["PrimaryLanguage"]);
            SendKeys(CourtEpoSuspectInfoComponent.PlaceOfBirth, courtEpoSuspectInfoData["PlaceOfBirth"]);
            SendKeys(CourtEpoSuspectInfoComponent.Weight, courtEpoSuspectInfoData["Weight"]);
            SendKeys(CourtEpoSuspectInfoComponent.HeightFeet, courtEpoSuspectInfoData["HeightFeet"]);
            SendKeys(CourtEpoSuspectInfoComponent.HeightInch, courtEpoSuspectInfoData["HeightInch"]);
            Toggle(CourtEpoSuspectInfoComponent.IsThisPersonChild, courtEpoSuspectInfoData["IsThisPersonChild"]);
            Toggle(CourtEpoSuspectInfoComponent.UsCitizen, courtEpoSuspectInfoData["UsCitizen"]);
            Click(CourtEpoSuspectInfoComponent.EnableSsn);
            SendKeys(CourtEpoSuspectInfoComponent.SsnFeild, courtEpoSuspectInfoData["SsnFeild"]);
            Click(CourtEpoSuspectInfoComponent.IdType);
            SelectOption(CourtEpoSuspectInfoComponent.LstIdType, courtEpoSuspectInfoData["IdType"]);
            SendKeys(CourtEpoSuspectInfoComponent.IdNumber, courtEpoSuspectInfoData["IdNumber"]);
            SendKeys(CourtEpoSuspectInfoComponent.IdState, courtEpoSuspectInfoData["IdState"]);
            SendKeys(CourtEpoSuspectInfoComponent.IdExpires, courtEpoSuspectInfoData["IdExpires"]);
            SendKeys(CourtEpoSuspectInfoComponent.TxSid, courtEpoSuspectInfoData["TxSid"]);
            SendKeys(CourtEpoSuspectInfoComponent.Fbi, courtEpoSuspectInfoData["Fbi"]);
            SendKeys(CourtEpoSuspectInfoComponent.Fpc, courtEpoSuspectInfoData["Fpc"]);
            SendKeys(CourtEpoSuspectInfoComponent.Mnu, courtEpoSuspectInfoData["Mnu"]);
            Toggle(CourtEpoSuspectInfoComponent.ConcealedHandgunLicenseHolder, courtEpoSuspectInfoData["ConcealedHandgunLicenseHolder"]);

            Click(CourtEpoSuspectInfoComponent.SaveCourtEpoSuspectInfo);
        }
    }
}
