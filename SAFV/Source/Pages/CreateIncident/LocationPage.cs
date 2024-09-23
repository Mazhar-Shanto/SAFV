using OpenQA.Selenium;
using SAFV.Drivers;
using SAFV.Source.Components;
using SAFV.Source.Components.CreateIncident;
using SAFV.Source.Components.CreateIncident.Location;

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
            Click(IncidentMenuComponent.Incident);
        }

        public void CreateLocation(Dictionary<string, string> locationData)
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");

            Click(IncidentMenuComponent.Locations);
            Click(LocationComponent.AddLocation);

            Click(LocationComponent.LocationType);
            SelectOption(LocationComponent.LstLocationType, locationData[""]);
            Click(LocationComponent.AddressGroup);
            SelectOption(LocationComponent.LstAddressGroup, locationData[""]);
            SendKeys(LocationComponent.Address1, locationData[""]);
            SendKeys(LocationComponent.Address2, locationData[""]);
            SendKeys(LocationComponent.City, locationData[""]);
            SendKeys(LocationComponent.State, locationData[""]);
            Click(LocationComponent.County);
            SelectOption(LocationComponent.LstCounty, locationData[""]);
            SendKeys(LocationComponent.ZipCode, locationData[""]);
            Toggle(LocationComponent.DispatchedLocation, locationData[""]);

            Click(LocationComponent.SaveLoaction);
        }

        public void CreateScene(Dictionary<string, string> sceneData)
        {
            Reporting.AddTestScreenshot(_driver, "Incident Test");

            Click(LocationMenuComponent.Scene);

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
                    Toggle(SceneComponent.DoorToWhichRoom, sceneData["DoorToWhichRoom"]);
                }

                Toggle(SceneComponent.ForcedEntry, sceneData["ForcedEntry"]);

                if (sceneData["ForcedEntry"].ToLower() == "yes" || sceneData["ForcedEntry"].ToLower() == "true" || sceneData["ForcedEntry"].ToLower() == "1")
                {
                    Toggle(SceneComponent.WhichLocation, sceneData["WhichLocation"]);
                }

                Toggle(SceneComponent.DrugsParaphernalia, sceneData["DrugsParaphernalia"]);
                Toggle(SceneComponent.Alcohol, sceneData["Alcohol"]);
                Toggle(SceneComponent.Other, sceneData["Other"]);

                if (sceneData["Other"].ToLower() == "yes" || sceneData["Other"].ToLower() == "true" || sceneData["Other"].ToLower() == "1")
                {
                    Toggle(SceneComponent.OtherDescription, sceneData["OtherDescription"]);
                }

                Toggle(SceneComponent.DescribeSceneUponYourArrival, sceneData["DescribeSceneUponYourArrival"]);
            }

            Click(SceneComponent.SaveScene);
        }
    }
}
