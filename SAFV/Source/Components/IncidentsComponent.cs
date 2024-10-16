using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAFV.Source.Components
{
    internal class IncidentsComponent : HeaderComponent
    {
        // Elements
        public static IWebElement CaseNumberFilter => WaitAndFindElement(By.XPath("//*[@id=\"incident_grid_not_locked\"]/div[1]/div/table/thead/tr/th[3]/a/span"));
        public static IWebElement CaseSearchBox => WaitAndFindElement(By.XPath("/html/body/div[5]/form/div[1]/input"));
        public static IWebElement CaseSearchButton => WaitAndFindElement(By.XPath("/html/body/div[5]/form/div[1]/div[2]/button[1]"));
        public static IWebElement SearchedIncident => WaitAndFindElement(By.XPath("//*[@id=\"incident_grid_not_locked\"]/div[2]/table/tbody/tr[1]/td[3]/a"));

        public IncidentsComponent(IWebDriver driver) : base(driver)
        {
        }
    }
}
