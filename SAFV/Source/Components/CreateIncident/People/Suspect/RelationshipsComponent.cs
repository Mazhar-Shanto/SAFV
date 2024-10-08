using OpenQA.Selenium;

namespace SAFV.Source.Components.CreateIncident.People.Suspect
{
    public class RelationshipsComponent : BaseComponent
    {
        // Elements
        public static IWebElement SuspectWasOnScene => WaitAndFindElement(By.XPath("//*[@id=\"suspect-form\"]/div/div[1]/div/span[1]"));
        public static IWebElement SuspectLocatedLater => WaitAndFindElement(By.XPath("//*[@id=\"suspect-form\"]/div/div[2]/div[1]/div/span[1]"));
        public static IWebElement SaveSuspectInfo => WaitAndFindElement(By.XPath("//*[@id=\"suspect-form\"]/div/div[23]/div/div/button"));
        public static IWebElement CancelSuspectInfo => WaitAndFindElement(By.Id("suspectcancelId"));


        public RelationshipsComponent(IWebDriver driver) : base(driver)
        {
        }
    }
}
