using AventStack.ExtentReports.Gherkin.Model;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Reactive.Subjects;

namespace SAFV.Source.Components.CreateIncident.People.Suspect
{
    public class SuspectComponent : BaseComponent
    {
        // Elements
        public static IWebElement SuspectWasOnScene => WaitAndFindElement(By.XPath("//*[@id=\"suspect-form\"]/div/div[1]/div/span[1]"));
        public static IWebElement SuspectLocatedLater => WaitAndFindElement(By.XPath("//*[@id=\"suspect-form\"]/div/div[2]/div[1]/div/span[1]"));
        public static IWebElement LocatedDate => WaitAndFindElement(By.Id("LocatedDate"));
        public static IWebElement LocatedTime => WaitAndFindElement(By.Id("LocatedTime"));
        public static IWebElement SuspectWasArrested => WaitAndFindElement(By.XPath("//*[@id=\"suspect-form\"]/div/div[3]/div/div/span[1]"));
        public static IWebElement DateOfArrest => WaitAndFindElement(By.Id("DateOfArr"));
        public static IWebElement TimeOfArrest => WaitAndFindElement(By.Id("TimeOfArr"));
        public static IWebElement DateOfBooking => WaitAndFindElement(By.Id("DateOfBook"));
        public static IWebElement TimeOfBooking => WaitAndFindElement(By.Id("TimeOfBook"));
        public static IWebElement ArrestAddress1 => WaitAndFindElement(By.Id("serviceInput"));
        public static IWebElement ArrestAddress2 => WaitAndFindElement(By.Id("ArrestAddress2"));
        public static IWebElement ArrestCity => WaitAndFindElement(By.Id("ArrestCity"));
        public static IWebElement ArrestState => WaitAndFindElement(By.Id("ArrestState"));
        public static IWebElement ArrestZipCode => WaitAndFindElement(By.Id("ArrestZipCode"));
        public static IWebElement ArrestCounty => WaitAndFindElement(By.XPath("//*[@id=\"suspect_arrest_div\"]/div[11]/div/span[1]"));
        public static IList<IWebElement> LstArrestCounty => WaitAndFindElements(By.XPath("//*[@id=\"ArrestCounty_listbox\"]/li"));
        public static IWebElement ConcealedHandgunLicenseHolder => WaitAndFindElement(By.XPath("//*[@id=\"suspect-form\"]/div/div[5]/div/span[1]"));
        public static IWebElement MentalHealthIssues => WaitAndFindElement(By.XPath("//*[@id=\"suspect-form\"]/div/div[7]/div/span[1]"));
        public static IWebElement MentalHealthDescription => WaitAndFindElement(By.Id("MentalHealthDesc"));
        public static IWebElement PriorProtectiveOrder => WaitAndFindElement(By.XPath("//*[@id=\"suspect-form\"]/div/div[9]/div/span[1]"));
        public static IWebElement ProtectedPersons => WaitAndFindElement(By.Id("ProtectedPersons"));
        public static IWebElement OnProbation => WaitAndFindElement(By.XPath("//*[@id=\"suspect-form\"]/div/div[12]/div/span[1]"));
        public static IWebElement ProbationOfficer => WaitAndFindElement(By.Id("ProbationOfficer"));
        public static IWebElement ProbationCounty => WaitAndFindElement(By.XPath("//*[@id=\"suspect-form\"]/div/div[14]/div/span[1]"));
        public static IList<IWebElement> LstProbationCounty => WaitAndFindElements(By.XPath("//*[@id=\"ProbationCounty_listbox\"]/li"));
        public static IWebElement UnreportedIncidentsOfFv => WaitAndFindElement(By.XPath("//*[@id=\"suspect-form\"]/div/div[15]/div/span[1]"));
        public static IWebElement AttemptedContact => WaitAndFindElement(By.XPath("//*[@id=\"suspect-form\"]/div/div[17]/div/span[1]"));
        public static IWebElement CalledSuspectCellPhone => WaitAndFindElement(By.XPath("//*[@id=\"suspect-on-scene-rest\"]/div[1]/div/span[1]"));
        public static IWebElement CalledFriendFamilyWhereSuspectFledTo => WaitAndFindElement(By.XPath("//*[@id=\"suspect-on-scene-rest\"]/div[2]/div/span[1]"));
        public static IWebElement WentToLocationSuspectWas => WaitAndFindElement(By.XPath("//*[@id=\"suspect-on-scene-rest\"]/div[3]/div/span[1]"));
        public static IWebElement OfficerCanvassedArea => WaitAndFindElement(By.XPath("//*[@id=\"suspect-on-scene-rest\"]/div[4]/div/span[1]"));
        public static IWebElement DidYouLeaveMessagesForSuspectToCallBack => WaitAndFindElement(By.XPath("//*[@id=\"suspect-on-scene-rest\"]/div[5]/div/span[1]"));
        public static IWebElement DidSuspectRefuseToTalk => WaitAndFindElement(By.XPath("//*[@id=\"suspect-on-scene-rest\"]/div[6]/div/span[1]"));
        public static IWebElement PriorToArrestPersonResisted => WaitAndFindElement(By.XPath("//*[@id=\"suspect-form\"]/div/div[19]/div/span[1]"));
        public static IWebElement VerbalThreat => WaitAndFindElement(By.XPath("//*[@id=\"suspect-form\"]/div/div[20]/div/span[1]"));
        public static IWebElement Passive => WaitAndFindElement(By.XPath("//*[@id=\"suspect-form\"]/div/div[21]/div/span[1]"));
        public static IWebElement Physical => WaitAndFindElement(By.XPath("//*[@id=\"suspect-form\"]/div/div[22]/div/span[1]"));
        public static IWebElement SaveSuspectInfo => WaitAndFindElement(By.XPath("//*[@id=\"suspect-form\"]/div/div[23]/div/div/button"));
        public static IWebElement CancelSuspectInfo => WaitAndFindElement(By.Id("suspectcancelId"));


        public SuspectComponent(IWebDriver driver) : base(driver)
        {
        }
    }
}
