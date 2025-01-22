using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAFV.Source.Components.Detective
{
    internal class CasesComponent : HeaderComponent
    {
        // Elements
        public static IWebElement CaseNumberFilter => WaitAndFindElement(By.XPath("//*[@id=\"detective_grid_not_locked\"]/div[1]/div/table/thead/tr/th[3]/a/span"));
        public static IWebElement CaseSearchBox => WaitAndFindElement(By.XPath("/html/body/div[5]/form/div[1]/input"));
        public static IWebElement CaseSearchButton => WaitAndFindElement(By.XPath("/html/body/div[5]/form/div[1]/div[2]/button[1]"));
        public static IWebElement LockedCaseNumberFilter => WaitAndFindElement(By.XPath("//*[@id=\"detective_grid_locked\"]/div[1]/div/table/thead/tr/th[3]/a/span"));
        public static IWebElement LockedCaseSearchBox => WaitAndFindElement(By.XPath("/html/body/div[5]/form/div[1]/input"));
        public static IWebElement LockedCaseSearchButton => WaitAndFindElement(By.XPath("/html/body/div[5]/form/div[1]/div[2]/button[1]"));
        public static IWebElement SearchedCase => WaitAndFindElement(By.XPath("//*[@id=\"detective_grid_not_locked\"]/div[2]/table/tbody/tr[1]/td[3]/a"));
        public static IWebElement ShowOtherOfficerCasesButton => WaitAndFindElement(By.XPath("/html/body/div[1]/div[4]/div[2]/div/div[2]/div[2]/div[1]/div/div[1]/span/span"));
        public static IWebElement ShowOtherOfficerLockedCasesButton => WaitAndFindElement(By.XPath("/html/body/div[1]/div[4]/div[2]/div/div[2]/div[2]/div[2]/div/div[1]/span/span"));

        public CasesComponent(IWebDriver driver) : base(driver)
        {
        }
    }
}
