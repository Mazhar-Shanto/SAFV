using NUnit.Framework;
using OpenQA.Selenium;
using System;
using static NUnit.Framework.Constraints.Tolerance;

namespace SAFV.Source.Components
{
    public class IncidentInfoComponent : BaseComponent
    {
        // Elements
        public static IWebElement OfficerBadgeNumber => WaitAndFindElement(By.Id("BadgeNumber"));
        public static IWebElement OfficerRank => WaitAndFindElement(By.Id("OfficerRank"));
        public static IWebElement District => WaitAndFindElement(By.Id("District"));
        public static IWebElement ChildrenInvolved => WaitAndFindElement(By.XPath("//*[@id=\"incident-form\"]/div/div[1]/div[9]/div/span[1]"));
        public static IWebElement RequiresCpsNotification => WaitAndFindElement(By.XPath("//*[@id=\"incident-form\"]/div/div[1]/div[10]/div/span[1]"));
        public static IWebElement CpsHaveBeenCalled => WaitAndFindElement(By.XPath("//*[@id=\"incident-form\"]/div/div[1]/div[11]/div/span[1]"));
        public static IWebElement CpsNumber => WaitAndFindElement(By.Id("CPSNumber"));
        public static IWebElement CpsNotifedAt => WaitAndFindElement(By.Id("CPSNotifedAt"));
        public static IWebElement CpsSafetyIssues => WaitAndFindElement(By.Id("CPSSafetyIssues"));
        public static IWebElement OfficerPrimaryConcern => WaitAndFindElement(By.Id("OfficerPrimaryConcern"));
        public static IWebElement SuspectedMethManufacture => WaitAndFindElement(By.Id("SuspectedMethManufacture"));
        public static IWebElement SensitiveIssues => WaitAndFindElement(By.Id("SensitiveIssues"));
        public static IWebElement Covid19Exposure => WaitAndFindElement(By.XPath("//*[@id=\"incident-form\"]/div/div[1]/div[18]/div/span[1]"));
        public static IWebElement HowPoliceContacted => WaitAndFindElement(By.XPath("//*[@id=\"incident-form\"]/div/div[1]/div[19]/div/span[1]"));
        public static IWebElement WhatWasBeingReported => WaitAndFindElement(By.XPath("//*[@id=\"incident-form\"]/div/div[1]/div[20]/div/span"));
        public static IWebElement DispatchedDate => WaitAndFindElement(By.Id("DispatchedDate"));
        public static IWebElement DispatchedTime => WaitAndFindElement(By.Id("DispatchedTime"));
        public static IWebElement Save => WaitAndFindElement(By.XPath("//*[@id=\"incident-form\"]/div/div[2]/div/div/button"));
        public static IWebElement Cancel => WaitAndFindElement(By.XPath("//*[@id=\"incident-form\"]/div/div[2]/div/div/a"));

        public IncidentInfoComponent(IWebDriver driver) : base(driver)
        {
        }
    }
}
