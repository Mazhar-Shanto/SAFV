using AventStack.ExtentReports.Gherkin.Model;
using OpenQA.Selenium;

namespace SAFV.Source.Components.CreateIncident.Location
{
    public class SceneComponent : BaseComponent
    {
        // Elements
        public static IWebElement DidNotVisitScene => WaitAndFindElement(By.XPath("//*[@id=\"off-scene-cond-submit-form\"]/div/div[1]/div/span[1]"));
        public static IWebElement DidNotVisitSceneReason => WaitAndFindElement(By.Id("DidNotVisitSceneReason"));
        public static IWebElement BrokenFurniture => WaitAndFindElement(By.XPath("//*[@id=\"off-scene-cond-submit-form\"]/div/div[2]/div[1]/div/span[1]"));
        public static IWebElement BloodAtScene => WaitAndFindElement(By.XPath("//*[@id=\"off-scene-cond-submit-form\"]/div/div[2]/div[2]/div/span[1]"));
        public static IWebElement BrokenPhone => WaitAndFindElement(By.XPath("//*[@id=\"off-scene-cond-submit-form\"]/div/div[2]/div[3]/div/span[1]"));
        public static IWebElement HoleInWall => WaitAndFindElement(By.XPath("//*[@id=\"off-scene-cond-submit-form\"]/div/div[2]/div[4]/div/span[1]"));
        public static IWebElement BrokenGlass => WaitAndFindElement(By.XPath("//*[@id=\"off-scene-cond-submit-form\"]/div/div[2]/div[5]/div/span[1]"));
        public static IWebElement ChildrenCrying => WaitAndFindElement(By.XPath("//*[@id=\"off-scene-cond-submit-form\"]/div/div[2]/div[6]/div/span[1]"));
        public static IWebElement Weapon => WaitAndFindElement(By.XPath("//*[@id=\"off-scene-cond-submit-form\"]/div/div[2]/div[7]/div/span[1]"));
        public static IWebElement LackOfUtilites => WaitAndFindElement(By.XPath("//*[@id=\"off-scene-cond-submit-form\"]/div/div[2]/div[8]/div/span[1]"));
        public static IWebElement ClumpOfHair => WaitAndFindElement(By.XPath("//*[@id=\"off-scene-cond-submit-form\"]/div/div[2]/div[9]/div/span[1]"));
        public static IWebElement DamagedKickedRemovedDoor => WaitAndFindElement(By.XPath("//*[@id=\"off-scene-cond-submit-form\"]/div/div[2]/div[10]/div/span[1]"));
        public static IWebElement DoorToWhichRoom => WaitAndFindElement(By.Id("DamagedDoorDesc"));
        public static IWebElement ForcedEntry => WaitAndFindElement(By.XPath("//*[@id=\"off-scene-cond-submit-form\"]/div/div[2]/div[12]/div/span[1]"));
        public static IWebElement WhichLocation => WaitAndFindElement(By.Id("ForcedEntryDesc"));
        public static IWebElement DrugsParaphernalia => WaitAndFindElement(By.XPath("//*[@id=\"off-scene-cond-submit-form\"]/div/div[2]/div[14]/div/span[1]"));
        public static IWebElement Alcohol => WaitAndFindElement(By.XPath("//*[@id=\"off-scene-cond-submit-form\"]/div/div[2]/div[15]/div/span[1]"));
        public static IWebElement Other => WaitAndFindElement(By.XPath("//*[@id=\"off-scene-cond-submit-form\"]/div/div[2]/div[16]/div/span[1]"));
        public static IWebElement OtherDescription => WaitAndFindElement(By.Id("OtherDesc"));
        public static IWebElement DescribeSceneUponYourArrival => WaitAndFindElement(By.Id("Description"));
        public static IWebElement SaveScene => WaitAndFindElement(By.Id("off-scene-cond-submit-button"));
        public static IWebElement CancelScene => WaitAndFindElement(By.XPath("//*[@id=\"off-scene-cond-submit-form\"]/div/div[4]/div/div/a[2]"));

        public SceneComponent(IWebDriver driver) : base(driver)
        {
        }
    }
}