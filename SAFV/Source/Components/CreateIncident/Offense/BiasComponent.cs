using OpenQA.Selenium;

namespace SAFV.Source.Components.CreateIncident.Offense
{
    public class BiasComponent : BaseComponent
    {
        // Elements
        public static IWebElement ByGender => WaitAndFindElement(By.XPath("//*[@id=\"off-bias-submit-form\"]/div/div[1]/div/span[1]"));
        public static IWebElement GenderBias => WaitAndFindElement(By.XPath("//*[@id=\"off-bias-submit-form\"]/div/div[2]/div/span[1]"));
        public static IList<IWebElement> LstGenderBias => WaitAndFindElements(By.XPath("//*[@id=\"GenderBiasId_listbox\"]/li"));
        public static IWebElement ByGenderIdentity => WaitAndFindElement(By.XPath("//*[@id=\"off-bias-submit-form\"]/div/div[3]/div/span[1]"));
        public static IWebElement GenderIdentityBias => WaitAndFindElement(By.XPath("//*[@id=\"off-bias-submit-form\"]/div/div[4]/div/span[1]"));
        public static IList<IWebElement> LstGenderIdentityBias => WaitAndFindElements(By.XPath("//*[@id=\"GenderIdentityBiasId_listbox\"]/li"));
        public static IWebElement ByRace => WaitAndFindElement(By.XPath("//*[@id=\"off-bias-submit-form\"]/div/div[5]/div/span[1]"));
        public static IWebElement RaceBias => WaitAndFindElement(By.XPath("//*[@id=\"off-bias-submit-form\"]/div/div[6]/div/span[1]"));
        public static IList<IWebElement> LstRaceBias => WaitAndFindElements(By.XPath("//*[@id=\"RaceBiasId_listbox\"]/li"));
        public static IWebElement ByReligion => WaitAndFindElement(By.XPath("//*[@id=\"off-bias-submit-form\"]/div/div[7]/div/span[1]"));
        public static IWebElement ReligionBias => WaitAndFindElement(By.XPath("//*[@id=\"off-bias-submit-form\"]/div/div[8]/div/span[1]"));
        public static IList<IWebElement> LstReligionBias => WaitAndFindElements(By.XPath("//*[@id=\"ReligionBiasId_listbox\"]/li"));
        public static IWebElement BySexualOrientation => WaitAndFindElement(By.XPath("//*[@id=\"off-bias-submit-form\"]/div/div[9]/div/span[1]"));
        public static IWebElement SexualOrientationBias => WaitAndFindElement(By.XPath("//*[@id=\"off-bias-submit-form\"]/div/div[10]/div/span[1]"));
        public static IList<IWebElement> LstSexualOrientation => WaitAndFindElements(By.XPath("//*[@id=\"SexualOrBiasId_listbox\"]/li"));
        public static IWebElement ByDisability => WaitAndFindElement(By.XPath("//*[@id=\"off-bias-submit-form\"]/div/div[11]/div/span[1]"));
        public static IWebElement DisabilityBias => WaitAndFindElement(By.XPath("//*[@id=\"off-bias-submit-form\"]/div/div[12]/div/span[1]"));
        public static IList<IWebElement> LstDisabilityBias => WaitAndFindElements(By.XPath("//*[@id=\"DisabilityBiasId_listbox\"]/li"));
        public static IWebElement NoBias => WaitAndFindElement(By.XPath("//*[@id=\"off-bias-submit-form\"]/div/div[13]/div/span[1]"));
        public static IWebElement UnknownBias => WaitAndFindElement(By.XPath("//*[@id=\"off-bias-submit-form\"]/div/div[14]/div/span[1]"));
        public static IList<IWebElement> LstUnknownBias => WaitAndFindElements(By.XPath("//*[@id=\"UnknownBiasId_listbox\"]/li"));
        public static IWebElement SaveBias => WaitAndFindElement(By.Id("off-bias-submit-button"));
        public static IWebElement CancelBias => WaitAndFindElement(By.Id("OffGrpBiasCancelId"));

        public BiasComponent(IWebDriver driver) : base(driver)
        {
        }
    }
}
