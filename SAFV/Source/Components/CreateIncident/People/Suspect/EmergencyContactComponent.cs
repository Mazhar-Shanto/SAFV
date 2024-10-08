using AventStack.ExtentReports.Gherkin.Model;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Reactive.Subjects;

namespace SAFV.Source.Components.CreateIncident.People.Suspect
{
    public class EmergencyContactComponent : BaseComponent
    {
        // Elements
        public static IWebElement AddNewContact => WaitAndFindElement(By.XPath("//*[@id=\"master-container\"]/div/div[1]/button"));
        public static IWebElement ContactName => WaitAndFindElement(By.Id("ContactName"));
        public static IWebElement ContactEmail => WaitAndFindElement(By.Id("ContactEMail"));
        public static IWebElement Phone => WaitAndFindElement(By.Id("Phone"));
        public static IWebElement Relationship => WaitAndFindElement(By.Id("Relationship"));
        public static IWebElement AddressGroup => WaitAndFindElement(By.XPath("//*[@id=\"contact_form\"]/div[1]/div[6]/div[2]/span[1]"));
        public static IList<IWebElement> LstAddressGroup => WaitAndFindElements(By.XPath("//*[@id=\"AddressGroupId_listbox\"]/li"));
        public static IWebElement Address1 => WaitAndFindElement(By.Id("serviceInput"));
        public static IWebElement Address2 => WaitAndFindElement(By.Id("Address2"));
        public static IWebElement City => WaitAndFindElement(By.Id("City"));
        public static IWebElement State => WaitAndFindElement(By.Id("State"));
        public static IWebElement County => WaitAndFindElement(By.XPath("//*[@id=\"contact_form\"]/div[1]/div[11]/div[2]/span[1]"));
        public static IList<IWebElement> LstCounty => WaitAndFindElements(By.XPath("//*[@id=\"County_listbox\"]/li"));
        public static IWebElement ZipCode => WaitAndFindElement(By.Id("ZipCode"));
        public static IWebElement SaveContact => WaitAndFindElement(By.XPath("//*[@id=\"contact_form\"]/div[2]/div/div/button"));
        public static IWebElement CancelContact => WaitAndFindElement(By.XPath("//*[@id=\"contact_form\"]/div[2]/div/div/a"));


        public EmergencyContactComponent(IWebDriver driver) : base(driver)
        {
        }
    }
}