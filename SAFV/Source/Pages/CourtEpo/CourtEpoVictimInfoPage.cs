using OpenQA.Selenium;
using SAFV.Drivers;
using SAFV.Source.Components;
using SAFV.Source.Components.CourtEpo;
using System.Linq;

namespace SAFV.Source.Pages.CourtEpo
{
    public class CourtEpoVictimInfoPage : BasePage
    {
        private IWebDriver _driver;

        public CourtEpoVictimInfoPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        public void GoToCourtEpoVictimInfoPage()
        {
            Click(CourtEpoMenuComponent.VictimInfo);
        }

        public void CreateEpoVictimInfo(Dictionary<string, string> courtEpoVictimInfoData)
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");

            SendKeys(CourtEpoVictimInfoComponent.FirstName, courtEpoVictimInfoData["FirstName"]);
            SendKeys(CourtEpoVictimInfoComponent.LastName, courtEpoVictimInfoData["LastName"]);
            SendKeys(CourtEpoVictimInfoComponent.MiddleName, courtEpoVictimInfoData["MiddleName"]);
            Click(CourtEpoVictimInfoComponent.Race);
            SelectOption(CourtEpoVictimInfoComponent.LstRace, courtEpoVictimInfoData["Race"]);
            Click(CourtEpoVictimInfoComponent.Sex);
            SelectOption(CourtEpoVictimInfoComponent.LstSex, courtEpoVictimInfoData["Sex"]);
            SendKeys(CourtEpoVictimInfoComponent.DateOfBirth, courtEpoVictimInfoData["DateOfBirth"]);
            Click(CourtEpoVictimInfoComponent.Ethnicity);
            SelectOption(CourtEpoVictimInfoComponent.LstEthnicity, courtEpoVictimInfoData["Ethnicity"]);
            Click(CourtEpoVictimInfoComponent.EyeColor);
            SelectOption(CourtEpoVictimInfoComponent.LstEyeColor, courtEpoVictimInfoData["EyeColor"]);
            Click(CourtEpoVictimInfoComponent.HairColor);
            SelectOption(CourtEpoVictimInfoComponent.LstHairColor, courtEpoVictimInfoData["HairColor"]);
            SendKeys(CourtEpoVictimInfoComponent.Weight, courtEpoVictimInfoData["Weight"]);
            SendKeys(CourtEpoVictimInfoComponent.HeightFeet, courtEpoVictimInfoData["HeightFeet"]);
            SendKeys(CourtEpoVictimInfoComponent.HeightInch, courtEpoVictimInfoData["HeightInch"]);
            Click(CourtEpoVictimInfoComponent.PrimaryLanguage);
            SelectOption(CourtEpoVictimInfoComponent.LstPrimaryLanguage, courtEpoVictimInfoData["PrimaryLanguage"]);
            Toggle(CourtEpoVictimInfoComponent.IsThisPersonChild, courtEpoVictimInfoData["IsThisPersonChild"]);
            Click(CourtEpoVictimInfoComponent.EnableSsn);
            SendKeys(CourtEpoVictimInfoComponent.SsnFeild, courtEpoVictimInfoData["SsnFeild"]);
            SendKeys(CourtEpoVictimInfoComponent.NameOfemployer, courtEpoVictimInfoData["NameOfemployer"]);
            Click(CourtEpoVictimInfoComponent.VictimRelationshipToSuspect);
            SelectOption(CourtEpoVictimInfoComponent.LstVictimRelationshipToSuspect, courtEpoVictimInfoData["VictimRelationshipToSuspect"]);

            Click(CourtEpoVictimInfoComponent.SaveCourtEpoVictimInfo);
        }
    }
}
