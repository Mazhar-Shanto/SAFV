using OpenQA.Selenium;
using SAFV.Drivers;
using SAFV.Source.Components;
using SAFV.Source.Components.CourtEpo;
using System.Linq;

namespace SAFV.Source.Pages.CourtEpo
{
    public class CourtEpoOtherInfoPage : BasePage
    {
        private IWebDriver _driver;

        public CourtEpoOtherInfoPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        public void GoToCourtEpoOtherInfoPage()
        {
            Click(CourtEpoMenuComponent.OtherInfo);
        }

        public void CreateEpoOtherInfo(Dictionary<string, string> courtEpoOtherInfoData)
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");

            Click(CourtEpoOtherInfoComponent.AddNewOtherInfo);

            SendKeys(CourtEpoOtherInfoComponent.FirstName, courtEpoOtherInfoData["FirstName"]);
            SendKeys(CourtEpoOtherInfoComponent.LastName, courtEpoOtherInfoData["LastName"]);
            SendKeys(CourtEpoOtherInfoComponent.MiddleName, courtEpoOtherInfoData["MiddleName"]);
            Click(CourtEpoOtherInfoComponent.Race);
            SelectOption(CourtEpoOtherInfoComponent.LstRace, courtEpoOtherInfoData["Race"]);
            Click(CourtEpoOtherInfoComponent.Sex);
            SelectOption(CourtEpoOtherInfoComponent.LstSex, courtEpoOtherInfoData["Sex"]);
            SendKeys(CourtEpoOtherInfoComponent.DateOfBirth, courtEpoOtherInfoData["DateOfBirth"]);
            Click(CourtEpoOtherInfoComponent.Ethnicity);
            SelectOption(CourtEpoOtherInfoComponent.LstEthnicity, courtEpoOtherInfoData["Ethnicity"]);
            Click(CourtEpoOtherInfoComponent.EyeColor);
            SelectOption(CourtEpoOtherInfoComponent.LstEyeColor, courtEpoOtherInfoData["EyeColor"]);
            Click(CourtEpoOtherInfoComponent.HairColor);
            SelectOption(CourtEpoOtherInfoComponent.LstHairColor, courtEpoOtherInfoData["HairColor"]);
            SendKeys(CourtEpoOtherInfoComponent.Weight, courtEpoOtherInfoData["Weight"]);
            SendKeys(CourtEpoOtherInfoComponent.HeightFeet, courtEpoOtherInfoData["HeightFeet"]);
            SendKeys(CourtEpoOtherInfoComponent.HeightInch, courtEpoOtherInfoData["HeightInch"]);
            Click(CourtEpoOtherInfoComponent.PrimaryLanguage);
            SelectOption(CourtEpoOtherInfoComponent.LstPrimaryLanguage, courtEpoOtherInfoData["PrimaryLanguage"]);
            Toggle(CourtEpoOtherInfoComponent.IsThisPersonChild, courtEpoOtherInfoData["IsThisPersonChild"]);
            Click(CourtEpoOtherInfoComponent.EnableSsn);
            SendKeys(CourtEpoOtherInfoComponent.SsnFeild, courtEpoOtherInfoData["SsnFeild"]);

            Click(CourtEpoOtherInfoComponent.SaveEpoOtherInfo);
        }
    }
}
