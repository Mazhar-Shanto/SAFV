using AventStack.ExtentReports.Gherkin.Model;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAFV.Source.Components.CourtEpo
{
    internal class CourtEpoConditionsComponent : BaseComponent
    {
        // Elements
        public static IWebElement ActsOfFamilyViolence => WaitAndFindElement(By.XPath("//*[@id=\"epo-cob-submit-form\"]/div/div[1]/div[2]/div[1]/div/span[1]"));
        public static IWebElement Stalking => WaitAndFindElement(By.XPath("//*[@id=\"epo-cob-submit-form\"]/div/div[1]/div[2]/div[2]/div/span[1]"));
        public static IWebElement DirectCommunication => WaitAndFindElement(By.XPath("//*[@id=\"epo-cob-submit-form\"]/div/div[1]/div[2]/div[3]/div/span[1]"));
        public static IWebElement ThreatCommunication => WaitAndFindElement(By.XPath("//*[@id=\"epo-cob-submit-form\"]/div/div[1]/div[2]/div[4]/div/span[1]"));
        public static IWebElement AnyCommunication => WaitAndFindElement(By.XPath("//*[@id=\"epo-cob-submit-form\"]/div/div[1]/div[2]/div[5]/div/span[1]"));
        public static IWebElement PhysicalDistance => WaitAndFindElement(By.XPath("//*[@id=\"epo-cob-submit-form\"]/div/div[1]/div[2]/div[6]/div/span[1]"));
        public static IWebElement Yards => WaitAndFindElement(By.Id("PhysicalDistanceYards"));
        public static IWebElement NearResidence => WaitAndFindElement(By.XPath("//*[@id=\"epo-cob-submit-form\"]/div/div[1]/div[2]/div[7]/div[2]/div/span[1]"));
        public static IWebElement NearPlaceOfEmployment => WaitAndFindElement(By.XPath("//*[@id=\"epo-cob-submit-form\"]/div/div[1]/div[2]/div[7]/div[3]/div/span[1]"));
        public static IWebElement NearSchool => WaitAndFindElement(By.XPath("//*[@id=\"epo-cob-submit-form\"]/div/div[1]/div[2]/div[7]/div[4]/div/span[1]"));
        public static IWebElement PossessFirearm => WaitAndFindElement(By.XPath("//*[@id=\"epo-cob-submit-form\"]/div/div[1]/div[2]/div[8]/div/span[1]"));
        public static IWebElement Tracking => WaitAndFindElement(By.XPath("//*[@id=\"epo-cob-submit-form\"]/div/div[1]/div[2]/div[9]/div/span[1]"));
        public static IWebElement GpsMonitoring => WaitAndFindElement(By.XPath("//*[@id=\"epo-cob-submit-form\"]/div/div[1]/div[2]/div[10]/div/span[1]"));
        public static IWebElement GpsMonitoringDescription => WaitAndFindElement(By.Id("GPSMonitoringDesc"));
        public static IWebElement HumanTrafficking => WaitAndFindElement(By.XPath("//*[@id=\"epo-cob-submit-form\"]/div/div[1]/div[2]/div[12]/div/span[1]"));
        public static IWebElement VictimNotification => WaitAndFindElement(By.XPath("//*[@id=\"epo-cob-submit-form\"]/div/div[2]/div[2]/div/div/span[1]"));
        public static IWebElement CourtAppearance => WaitAndFindElement(By.XPath("//*[@id=\"epo-cob-submit-form\"]/div/div[3]/div[2]/div[1]/div/span[1]"));
        public static IWebElement VictimContact => WaitAndFindElement(By.XPath("//*[@id=\"epo-cob-submit-form\"]/div/div[3]/div[2]/div[2]/div/span[1]"));
        public static IWebElement ApproachResidence => WaitAndFindElement(By.XPath("//*[@id=\"epo-cob-submit-form\"]/div/div[3]/div[2]/div[3]/div/span[1]"));
        public static IWebElement SchoolDaycare => WaitAndFindElement(By.XPath("//*[@id=\"epo-cob-submit-form\"]/div/div[3]/div[2]/div[4]/div/span[1]"));
        public static IWebElement Weapons => WaitAndFindElement(By.XPath("//*[@id=\"epo-cob-submit-form\"]/div/div[3]/div[2]/div[5]/div/span[1]"));
        public static IWebElement AlcoholDrugs => WaitAndFindElement(By.XPath("//*[@id=\"epo-cob-submit-form\"]/div/div[3]/div[2]/div[6]/div/span[1]"));
        public static IWebElement PrescriptionMedications => WaitAndFindElement(By.XPath("//*[@id=\"epo-cob-submit-form\"]/div/div[3]/div[2]/div[7]/div/span[1]"));
        public static IWebElement DrugTest => WaitAndFindElement(By.XPath("//*[@id=\"epo-cob-submit-form\"]/div/div[3]/div[2]/div[8]/div/span[1]"));
        public static IWebElement CourtOrder => WaitAndFindElement(By.XPath("//*[@id=\"epo-cob-submit-form\"]/div/div[3]/div[2]/div[9]/div/span[1]"));
        public static IWebElement Offense => WaitAndFindElement(By.XPath("//*[@id=\"epo-cob-submit-form\"]/div/div[3]/div[2]/div[10]/div/span[1]"));
        public static IWebElement OtherConditions => WaitAndFindElement(By.XPath("//*[@id=\"epo-cob-submit-form\"]/div/div[3]/div[2]/div[11]/div/span[1]"));
        public static IWebElement OtherConditionsDescription => WaitAndFindElement(By.Id("OtherConditions"));
        public static IWebElement SaveCourtEpoConditions => WaitAndFindElement(By.Id("submit-button"));


        public CourtEpoConditionsComponent
            (IWebDriver driver) : base(driver)
        {
        }
    }
}