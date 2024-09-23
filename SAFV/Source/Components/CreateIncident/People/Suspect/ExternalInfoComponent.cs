
using AventStack.ExtentReports.Gherkin.Model;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Reactive.Subjects;

namespace SAFV.Source.Components.CreateIncident.People.Suspect
{
    public class ExternalInfoComponent : BaseComponent
    {
        // Elements
        public static IWebElement InTheMilitary => WaitAndFindElement(By.XPath("//*[@id=\"extended-info-form\"]/div[1]/div[1]/div/span[1]"));
        public static IWebElement MilitaryType => WaitAndFindElement(By.XPath("//*[@id=\"extended-info-form\"]/div[1]/div[2]/div/span[1]"));
        public static IList<IWebElement> LstMilitaryType => WaitAndFindElements(By.XPath("//*[@id=\"MilitaryTypeId_listbox\"]/li"));
        public static IWebElement Branch => WaitAndFindElement(By.XPath("//*[@id=\"extended-info-form\"]/div[1]/div[3]/div/span[1]"));
        public static IList<IWebElement> LstBranch => WaitAndFindElements(By.XPath("//*[@id=\"MilitaryBranchId_listbox\"]/li"));
        public static IWebElement Stationed => WaitAndFindElement(By.Id("MilitaryStationed"));
        public static IWebElement AlcoholInvolved => WaitAndFindElement(By.XPath("//*[@id=\"extended-info-form\"]/div[1]/div[5]/div/span[1]"));
        public static IWebElement Intoxicated => WaitAndFindElement(By.XPath("//*[@id=\"extended-info-form\"]/div[1]/div[6]/div/span[1]"));
        public static IWebElement FrequentAlcoholUse => WaitAndFindElement(By.XPath("//*[@id=\"extended-info-form\"]/div[1]/div[7]/div/span[1]"));
        public static IWebElement OccasionalAlcoholUse => WaitAndFindElement(By.XPath("//*[@id=\"extended-info-form\"]/div[1]/div[8]/div/span[1]"));
        public static IWebElement DoesViolenceOccurWhenAlcoholInvolved => WaitAndFindElement(By.XPath("//*[@id=\"extended-info-form\"]/div[1]/div[9]/div/span[1]"));
        public static IWebElement DrugsInvolved => WaitAndFindElement(By.XPath("//*[@id=\"extended-info-form\"]/div[1]/div[10]/div/span[1]"));
        public static IWebElement Impaired => WaitAndFindElement(By.XPath("//*[@id=\"extended-info-form\"]/div[1]/div[11]/div/span[1]"));
        public static IWebElement FrequentDrugUser => WaitAndFindElement(By.XPath("//*[@id=\"extended-info-form\"]/div[1]/div[12]/div/span[1]"));
        public static IWebElement DrugUser => WaitAndFindElement(By.XPath("//*[@id=\"extended-info-form\"]/div[1]/div[13]/div/span[1]"));
        public static IWebElement DoesViolenceOccurWhenDrugInvolved => WaitAndFindElement(By.XPath("//*[@id=\"extended-info-form\"]/div[1]/div[14]/div/span[1]"));
        public static IWebElement SaveExternalInfo => WaitAndFindElement(By.XPath("//*[@id=\"extended-info-form\"]/div[2]/div/div/button"));
        public static IWebElement CancelExternalInfo => WaitAndFindElement(By.XPath("//*[@id=\"extended-info-form\"]/div[2]/div/div/a"));


        public ExternalInfoComponent(IWebDriver driver) : base(driver)
        {
        }
    }
}