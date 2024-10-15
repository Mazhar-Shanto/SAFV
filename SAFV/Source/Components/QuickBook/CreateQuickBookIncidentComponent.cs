using NUnit.Framework;
using OpenQA.Selenium;

namespace SAFV.Source.Components.QuickBook
{
    public class CreateQuickBookIncidentComponent : BaseComponent
    {
        // Elements
        public static IWebElement ReportDate => WaitAndFindElement(By.Id("IncidentDate"));
        public static IWebElement IncidentCaseNumber => WaitAndFindElement(By.Id("AgencyIdentifier"));
        public static IWebElement IncidentType => WaitAndFindElement(By.Id("IncidentTypeId"));
        public static IList<IWebElement> LstIncidentType => WaitAndFindElements(By.XPath("//*[@id=\"IncidentTypeId\"]/option"));
        public static IWebElement ConfidentialMode => WaitAndFindElement(By.XPath("//*[@id=\"incident-quickbook-form\"]/div[4]/div/span[1]"));
        public static IWebElement CaseType => WaitAndFindElement(By.XPath("//*[@id=\"incident-quickbook-form\"]/div[5]/div/span[1]"));
        public static IList<IWebElement> LstCaseType => WaitAndFindElements(By.XPath("//*[@id=\"CaseTypeId_listbox\"]/li"));
        public static IWebElement MainCase => WaitAndFindElement(By.XPath("//*[@id=\"masterCaseField\"]/div/span[1]"));
        public static IWebElement SearchMainCase => WaitAndFindElement(By.XPath("//*[@id=\"MasterIncidentId-list\"]/span/input"));
        public static IList<IWebElement> LstMainCase => WaitAndFindElements(By.XPath("//*[@id=\"MasterIncidentId_listbox\"]/li"));
        public static IWebElement DispatchedDate => WaitAndFindElement(By.Id("DispatchedDate"));
        public static IWebElement DispatchedTime => WaitAndFindElement(By.Id("DispatchedTime"));
        public static IWebElement HowPoliceNotified => WaitAndFindElement(By.XPath("//*[@id=\"incident-quickbook-form\"]/div[9]/div/span[1]"));
        public static IList<IWebElement> LstHowPoliceNotified => WaitAndFindElements(By.XPath("//*[@id=\"ReasonForContactId_listbox\"]/li"));
        public static IWebElement WhatWasBeingReported => WaitAndFindElement(By.XPath("//*[@id=\"incident-quickbook-form\"]/div[10]/div/span"));
        public static IList<IWebElement> LstWhatWasBeingReported => WaitAndFindElements(By.XPath("//*[@id=\"ReportedId_listbox\"]/li"));
        public static IWebElement LocationType => WaitAndFindElement(By.XPath("//*[@id=\"incident-quickbook-form\"]/div[12]/div/span[1]"));
        public static IList<IWebElement> LstLocationType => WaitAndFindElements(By.XPath("//*[@id=\"AddressTypeId_listbox\"]/li"));
        public static IWebElement AddressGroup => WaitAndFindElement(By.XPath("//*[@id=\"incident-quickbook-form\"]/div[13]/div/span[1]"));
        public static IList<IWebElement> LstAddressGroup => WaitAndFindElements(By.XPath("//*[@id=\"AddressGroupId_listbox\"]/li"));
        public static IWebElement Address1 => WaitAndFindElement(By.Id("serviceInput"));
        public static IWebElement Address2 => WaitAndFindElement(By.Id("Address2"));
        public static IWebElement City => WaitAndFindElement(By.Id("City"));
        public static IWebElement State => WaitAndFindElement(By.Id("State"));
        public static IWebElement County => WaitAndFindElement(By.XPath("//*[@id=\"incident-quickbook-form\"]/div[18]/div[2]/span[1]"));
        public static IList<IWebElement> LstCounty => WaitAndFindElements(By.XPath("//*[@id=\"County_listbox\"]/li"));
        public static IWebElement ZipCode => WaitAndFindElement(By.Id("ZipCode"));
        public static IWebElement DispatchedLocation => WaitAndFindElement(By.XPath("//*[@id=\"incident-quickbook-form\"]/div[21]/div/span[1]"));

        public static IWebElement ConfirmDispatchedLocationAdd => WaitAndFindElement(By.XPath("/html/body/div[19]/div[3]/button[1]"));
        public static IWebElement ConfirmDispatchedLocationCancel => WaitAndFindElement(By.XPath("/html/body/div[19]/div[3]/button[2]"));

        public static IWebElement DispatchedLocationType => WaitAndFindElement(By.XPath("//*[@id=\"incident-quickbook-form\"]/div[23]/div/span[1]"));
        public static IList<IWebElement> LstDispatchedLocationType => WaitAndFindElements(By.XPath("//*[@id=\"DispatchAddressTypeId_listbox\"]/li"));
        public static IWebElement DispatchedLocationAddressGroup => WaitAndFindElement(By.XPath("//*[@id=\"incident-quickbook-form\"]/div[24]/div/span[1]"));
        public static IList<IWebElement> LstDispatchedLocationAddressGroup => WaitAndFindElements(By.XPath("//*[@id=\"DispatchAddressGroupId_listbox\"]/li"));
        public static IWebElement DispatchedLocationAddress1 => WaitAndFindElement(By.Id("DispatchAddress"));
        public static IWebElement DispatchedLocationAddress2 => WaitAndFindElement(By.Id("DispatchAddress2"));
        public static IWebElement DispatchedLocationCity => WaitAndFindElement(By.Id("DispatchCity"));
        public static IWebElement DispatchedLocationState => WaitAndFindElement(By.Id("DispatchState"));
        public static IWebElement DispatchedLocationCounty => WaitAndFindElement(By.XPath("//*[@id=\"incident-quickbook-form\"]/div[29]/div[2]/span[1]"));
        public static IList<IWebElement> LstDispatchedLocationCounty => WaitAndFindElements(By.XPath("//*[@id=\"DispatchCounty_listbox\"]/li"));
        public static IWebElement DispatchedLocationZipCode => WaitAndFindElement(By.Id("DispatchZipCode"));

        public static IWebElement Next => WaitAndFindElement(By.XPath("//*[@id=\"incident-quickbook-form\"]/div[33]/button[1]"));
        public static IWebElement SaveAndNext => WaitAndFindElement(By.XPath("//*[@id=\"incident-quickbook-form\"]/div[33]/button[2]"));
        public static IWebElement Cancel => WaitAndFindElement(By.XPath("//*[@id=\"incident-quickbook-form\"]/div[33]/button[3]"));

        public CreateQuickBookIncidentComponent(IWebDriver driver) : base(driver)
        {
        }
    }
}
