using SAFV.Helper.TestData;
using SAFV.Utility;

namespace SAFV.Helper
{
    internal class LocationDataReader
    {
        public static List<Dictionary<string, string>> ReadLocationData()
        {
            // Read dataset
            var locationColumnList = new ColumnList();
            locationColumnList.AddColumn("LocationType", "LocationType");
            locationColumnList.AddColumn("AddressGroup", "AddressGroup");
            locationColumnList.AddColumn("Address1", "Address1");
            locationColumnList.AddColumn("Address2", "Address2");
            locationColumnList.AddColumn("City", "City");
            locationColumnList.AddColumn("State", "State");
            locationColumnList.AddColumn("County", "County");
            locationColumnList.AddColumn("ZipCode", "ZipCode");
            locationColumnList.AddColumn("DispatchedLocation", "DispatchedLocation");

            var projectRoot = Utils.GetProjectRoot();
            var filePath = Path.Combine(projectRoot, "Helper/TestData/CreateIncident/Location/location data.xlsx");

            Console.WriteLine(filePath);
            var dataSet = new DataSet(locationColumnList);
            var locationData = dataSet.ReadData(filePath);

            return locationData;
        }


        public static List<Dictionary<string, string>> ReadSceneData()
        {
            // Read dataset
            var sceneColumnList = new ColumnList();
            sceneColumnList.AddColumn("DidNotVisitScene", "DidNotVisitScene");
            sceneColumnList.AddColumn("DidNotVisitSceneReason", "DidNotVisitSceneReason");
            sceneColumnList.AddColumn("BrokenFurniture", "BrokenFurniture");
            sceneColumnList.AddColumn("BloodAtScene", "BloodAtScene");
            sceneColumnList.AddColumn("BrokenPhone", "BrokenPhone");
            sceneColumnList.AddColumn("HoleInWall", "HoleInWall");
            sceneColumnList.AddColumn("BrokenGlass", "BrokenGlass");
            sceneColumnList.AddColumn("ChildrenCrying", "ChildrenCrying");
            sceneColumnList.AddColumn("Weapon", "Weapon");
            sceneColumnList.AddColumn("LackOfUtilites", "LackOfUtilites");
            sceneColumnList.AddColumn("ClumpOfHair", "ClumpOfHair");
            sceneColumnList.AddColumn("DamagedKickedRemovedDoor", "DamagedKickedRemovedDoor");
            sceneColumnList.AddColumn("DoorToWhichRoom", "DoorToWhichRoom");
            sceneColumnList.AddColumn("ForcedEntry", "ForcedEntry");
            sceneColumnList.AddColumn("WhichLocation", "WhichLocation");
            sceneColumnList.AddColumn("DrugsParaphernalia", "DrugsParaphernalia");
            sceneColumnList.AddColumn("Alcohol", "Alcohol");
            sceneColumnList.AddColumn("Other", "Other");
            sceneColumnList.AddColumn("OtherDescription", "OtherDescription");
            sceneColumnList.AddColumn("DescribeSceneUponYourArrival", "DescribeSceneUponYourArrival");

            var projectRoot = Utils.GetProjectRoot();
            var filePath = Path.Combine(projectRoot, "Helper/TestData/CreateIncident/Location/scene data.xlsx");

            Console.WriteLine(filePath);
            var dataSet = new DataSet(sceneColumnList);
            var sceneData = dataSet.ReadData(filePath);

            return sceneData;
        }
    }
}
