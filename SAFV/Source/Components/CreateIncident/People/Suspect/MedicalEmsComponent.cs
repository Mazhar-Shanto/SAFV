using AventStack.ExtentReports.Gherkin.Model;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Reactive;
using System.Reactive.Subjects;
using System.Security.Cryptography;

namespace SAFV.Source.Components.CreateIncident.People.Suspect
{
    public class MedicalEmsComponent : BaseComponent
    {
        // Elements
        public static IWebElement DidPersonComplainOfInjuries => WaitAndFindElement(By.XPath("//*[@id=\"ems-info-form\"]/div[1]/div[1]/div/span[1]"));
        public static IWebElement DidYouObserveInjuries => WaitAndFindElement(By.XPath("//*[@id=\"ems-info-form\"]/div[1]/div[2]/div/span[1]"));
        public static IWebElement IsPersonPregnant => WaitAndFindElement(By.XPath("//*[@id=\"ems-info-form\"]/div[1]/div[3]/div/span[1]"));
        public static IWebElement NumberOfWeeks => WaitAndFindElement(By.Id("NoOfWeeks"));
        public static IWebElement OfficerCouldObservePersonPregnant => WaitAndFindElement(By.XPath("//*[@id=\"ems-info-form\"]/div[1]/div[5]/div/span[1]"));
        public static IWebElement MedicalTreatmentOfferedButRefused => WaitAndFindElement(By.XPath("//*[@id=\"ems-info-form\"]/div[1]/div[6]/div/span[1]"));
        public static IWebElement PersonSeekingTheirOwnTreatment => WaitAndFindElement(By.XPath("//*[@id=\"ems-info-form\"]/div[1]/div[7]/div/span[1]"));
        public static IWebElement DrWhoWillProvideTreatment => WaitAndFindElement(By.Id("TreatmentDrName"));
        public static IWebElement FirstAidGivenAtScene => WaitAndFindElement(By.XPath("//*[@id=\"ems-info-form\"]/div[1]/div[9]/div/span[1]"));
        public static IWebElement FirstAidGivenBy => WaitAndFindElement(By.Id("FirstAidGivenBy"));
        public static IWebElement EmsParamedicsFire => WaitAndFindElement(By.XPath("//*[@id=\"ems-info-form\"]/div[1]/div[11]/div/span[1]"));
        public static IWebElement EmsUnit => WaitAndFindElement(By.Id("EMSUnit"));
        public static IWebElement EmsUnitTransportedPersonToHospital => WaitAndFindElement(By.XPath("//*[@id=\"ems-info-form\"]/div[1]/div[13]/div/span[1]"));
        public static IWebElement TransportedTo => WaitAndFindElement(By.Id("TransportedTo"));
        public static IWebElement SaveMedicalEms => WaitAndFindElement(By.XPath("//*[@id=\"ems-info-form\"]/div[2]/div/div/button"));
        public static IWebElement CancelMedicalEms => WaitAndFindElement(By.XPath("//*[@id=\"ems-info-form\"]/div[2]/div/div/a"));


        public MedicalEmsComponent(IWebDriver driver) : base(driver)
        {
        }
    }
}
