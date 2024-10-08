using OpenQA.Selenium;
using static Microsoft.AspNetCore.Razor.Language.TagHelperMetadata;
using System.Security.Cryptography;

namespace SAFV.Source.Components.CreateIncident.Offense
{
    public class AggAssaultComponent : BaseComponent
    {
        // Elements
        public static IWebElement SeriousBodilyInjury => WaitAndFindElement(By.XPath("//*[@id=\"aggri-assault-form\"]/div/div[1]/div/span[1]"));
        public static IWebElement WhoGaveOpinion => WaitAndFindElement(By.Id("SBIOpinionBy"));
        public static IWebElement SubstantialRiskOfDeath => WaitAndFindElement(By.XPath("//*[@id=\"aggri-assault-form\"]/div/div[3]/div[1]/div/span[1]"));
        public static IWebElement SubstantialRiskOfDeathDescription => WaitAndFindElement(By.Id("RiskOfDeathDesc"));
        public static IWebElement LossOrImpairment => WaitAndFindElement(By.XPath("//*[@id=\"aggri-assault-form\"]/div/div[3]/div[3]/div/span[1]"));
        public static IWebElement LossOrImpairmentDescription => WaitAndFindElement(By.Id("LossOrImpairmentDesc"));
        public static IWebElement Disfigurement => WaitAndFindElement(By.XPath("//*[@id=\"aggri-assault-form\"]/div/div[3]/div[5]/div/span[1]"));
        public static IWebElement DisfigurementDescription => WaitAndFindElement(By.Id("DisfigurementDesc"));
        public static IWebElement DeadlyWeaponUsed => WaitAndFindElement(By.XPath("//*[@id=\"aggri-assault-form\"]/div/div[4]/div/span[1]"));
        public static IWebElement DeadlyWeaponUsedDescription => WaitAndFindElement(By.Id("DescribeHowWeaponUsed"));
        public static IWebElement DeadlyWeaponExhibited => WaitAndFindElement(By.XPath("//*[@id=\"aggri-assault-form\"]/div/div[6]/div/span[1]"));
        public static IWebElement DeadlyWeaponExhibitedDescription => WaitAndFindElement(By.Id("ExhDdlyWeaponDesc"));
        public static IWebElement SuspectUseOfWeapon => WaitAndFindElement(By.Id("DescribeWeaponUse"));
        public static IWebElement SaveAggAssault => WaitAndFindElement(By.XPath("//*[@id=\"aggri-assault-form\"]/div/div[9]/div/a[1]"));
        public static IWebElement CancelAggAssault => WaitAndFindElement(By.Id("aggrivatedAssultcancelId"));

        public AggAssaultComponent(IWebDriver driver) : base(driver)
        {
        }
    }
}
