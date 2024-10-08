using OpenQA.Selenium;
using SAFV.Drivers;
using SAFV.Source.Components;
using SAFV.Source.Components.CreateIncident;
using SAFV.Source.Components.CreateIncident.Location;
using SAFV.Source.Components.CreateIncident.People;

namespace SAFV.Source.Pages.CreateIncident
{
    public class LocationPage : IncidentsPage
    {
        private IWebDriver _driver;


        public LocationPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        public void GoToLocationPage()
        {
            Console.WriteLine("Incident -- " + MenuComponent.Incidents.Text);
            Click(IncidentMenuComponent.Locations);
        }

        public void CreateLocation(Dictionary<string, string> locationData)
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");

            Click(LocationComponent.AddLocation);

            //VerifyPageLabel(LocationComponent.AddLocation, LocationComponent.TabTitle.Text.ToLower(), "location info");

            Click(LocationComponent.LocationType);
            SelectOption(LocationComponent.LstLocationType, locationData["LocationType"]);
            Click(LocationComponent.AddressGroup);
            SelectOption(LocationComponent.LstAddressGroup, locationData["AddressGroup"]);
            SendKeys(LocationComponent.Address1, locationData["Address1"]);
            SendKeys(LocationComponent.Address2, locationData["Address2"]);
            SendKeys(LocationComponent.City, locationData["City"]);
            SendKeys(LocationComponent.State, locationData["State"]);
            Click(LocationComponent.County);
            SelectOption(LocationComponent.LstCounty, locationData["County"]);
            SendKeys(LocationComponent.ZipCode, locationData["ZipCode"]);
            Toggle(LocationComponent.DispatchedLocation, locationData["DispatchedLocation"]);

            Click(LocationComponent.SaveLoaction);
        }

        public void CreateScene(Dictionary<string, string> sceneData)
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");

            Click(LocationMenuComponent.Scene);

            VerifyPageLabel(LocationMenuComponent.Scene, LocationComponent.TabTitle.Text.ToLower(), "scene");

            Toggle(SceneComponent.DidNotVisitScene, sceneData["DidNotVisitScene"]);

            if (sceneData["DidNotVisitScene"].ToLower() == "yes" || sceneData["DidNotVisitScene"].ToLower() == "true" || sceneData["DidNotVisitScene"].ToLower() == "1")
            {
                Toggle(SceneComponent.DidNotVisitSceneReason, sceneData["DidNotVisitSceneReason"]);
            }
            else
            {
                Toggle(SceneComponent.BrokenFurniture, sceneData["BrokenFurniture"]);
                Toggle(SceneComponent.BloodAtScene, sceneData["BloodAtScene"]);
                Toggle(SceneComponent.BrokenPhone, sceneData["BrokenPhone"]);
                Toggle(SceneComponent.HoleInWall, sceneData["HoleInWall"]);
                Toggle(SceneComponent.BrokenGlass, sceneData["BrokenGlass"]);
                Toggle(SceneComponent.ChildrenCrying, sceneData["ChildrenCrying"]);
                Toggle(SceneComponent.Weapon, sceneData["Weapon"]);
                Toggle(SceneComponent.LackOfUtilites, sceneData["LackOfUtilites"]);
                Toggle(SceneComponent.ClumpOfHair, sceneData["ClumpOfHair"]);
                Toggle(SceneComponent.DamagedKickedRemovedDoor, sceneData["DamagedKickedRemovedDoor"]);

                if (sceneData["DamagedKickedRemovedDoor"].ToLower() == "yes" || sceneData["DamagedKickedRemovedDoor"].ToLower() == "true" || sceneData["DamagedKickedRemovedDoor"].ToLower() == "1")
                {
                    SendKeys(SceneComponent.DoorToWhichRoom, sceneData["DoorToWhichRoom"]);
                }

                Toggle(SceneComponent.ForcedEntry, sceneData["ForcedEntry"]);

                if (sceneData["ForcedEntry"].ToLower() == "yes" || sceneData["ForcedEntry"].ToLower() == "true" || sceneData["ForcedEntry"].ToLower() == "1")
                {
                    SendKeys(SceneComponent.WhichLocation, sceneData["WhichLocation"]);
                }

                Toggle(SceneComponent.DrugsParaphernalia, sceneData["DrugsParaphernalia"]);
                Toggle(SceneComponent.Alcohol, sceneData["Alcohol"]);
                Toggle(SceneComponent.Other, sceneData["Other"]);

                if (sceneData["Other"].ToLower() == "yes" || sceneData["Other"].ToLower() == "true" || sceneData["Other"].ToLower() == "1")
                {
                    SendKeys(SceneComponent.OtherDescription, sceneData["OtherDescription"]);
                }

                SendKeys(SceneComponent.DescribeSceneUponYourArrival, sceneData["DescribeSceneUponYourArrival"]);
            }

            Click(SceneComponent.SaveScene);
        }

        public bool AttachLocationFromMainCase()
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");

            Click(LocationComponent.SelectAllMainLocation);
            Click(PeopleComponent.AttachToSupplement);

            bool allPeoplePresent = PeopleComponent.LstAllMainPeopleNew.All(people => PeopleComponent.LstAllMainPeopleOld.Contains(people));

            return allPeoplePresent;
        }
    }
}
