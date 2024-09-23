using OpenQA.Selenium;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SAFV.Source.Components.CreateIncident.People.Suspect
{
    internal class DemeanorComponent : BaseComponent
    {
        // Elements
        // Appearance
        public static IWebElement AppearanceBloody => WaitAndFindElement(By.XPath("//*[@id=\"appearance\"]/div/div[1]/div/span[1]"));
        public static IWebElement AppearanceSmearedMakeup => WaitAndFindElement(By.XPath("//*[@id=\"appearance\"]/div/div[2]/div/span[1]"));
        public static IWebElement AppearanceSoiledSweatStained => WaitAndFindElement(By.XPath("//*[@id=\"appearance\"]/div/div[3]/div/span[1]"));
        public static IWebElement AppearanceTangledMessyHair => WaitAndFindElement(By.XPath("//*[@id=\"appearance\"]/div/div[4]/div/span[1]"));
        public static IWebElement AppearanceTornPulledClothing => WaitAndFindElement(By.XPath("//*[@id=\"appearance\"]/div/div[5]/div/span[1]"));
        public static IWebElement AppearanceOther => WaitAndFindElement(By.XPath("//*[@id=\"appearance\"]/div/div[6]/div/span[1]"));
        public static IWebElement AppearanceOtherDescription => WaitAndFindElement(By.Id("IncidentPersonAppearance_OtherNotes"));

        // Demeanor
        public static IWebElement DemeanorAfraid => WaitAndFindElement(By.XPath("//*[@id=\"demeanor\"]/div/div[1]/div/span[1]"));
        public static IWebElement DemeanorAngry => WaitAndFindElement(By.XPath("//*[@id=\"demeanor\"]/div/div[2]/div/span[1]"));
        public static IWebElement DemeanorApologetic => WaitAndFindElement(By.XPath("//*[@id=\"demeanor\"]/div/div[3]/div/span[1]"));
        public static IWebElement DemeanorBelligerent => WaitAndFindElement(By.XPath("//*[@id=\"demeanor\"]/div/div[4]/div/span[1]"));
        public static IWebElement DemeanorCalm => WaitAndFindElement(By.XPath("//*[@id=\"demeanor\"]/div/div[5]/div/span[1]"));
        public static IWebElement DemeanorCatatonic => WaitAndFindElement(By.XPath("//*[@id=\"demeanor\"]/div/div[6]/div/span[1]"));
        public static IWebElement DemeanorCrying => WaitAndFindElement(By.XPath("//*[@id=\"demeanor\"]/div/div[7]/div/span[1]"));
        public static IWebElement DemeanorDistraught => WaitAndFindElement(By.XPath("//*[@id=\"demeanor\"]/div/div[8]/div/span[1]"));
        public static IWebElement DemeanorFlatAffect => WaitAndFindElement(By.XPath("//*[@id=\"demeanor\"]/div/div[9]/div/span[1]"));
        public static IWebElement DemeanorHysterical => WaitAndFindElement(By.XPath("//*[@id=\"demeanor\"]/div/div[10]/div/span[1]"));
        public static IWebElement DemeanorHandsBodyShaking => WaitAndFindElement(By.XPath("//*[@id=\"demeanor\"]/div/div[11]/div/span[1]"));
        public static IWebElement DemeanorIndifferent => WaitAndFindElement(By.XPath("//*[@id=\"demeanor\"]/div/div[12]/div/span[1]"));
        public static IWebElement DemeanorIntoxicated => WaitAndFindElement(By.XPath("//*[@id=\"demeanor\"]/div/div[13]/div/span[1]"));
        public static IWebElement DemeanorIrrational => WaitAndFindElement(By.XPath("//*[@id=\"demeanor\"]/div/div[14]/div/span[1]"));
        public static IWebElement DemeanorNervous => WaitAndFindElement(By.XPath("//*[@id=\"demeanor\"]/div/div[15]/div/span[1]"));
        public static IWebElement DemeanorTrembling => WaitAndFindElement(By.XPath("//*[@id=\"demeanor\"]/div/div[16]/div/span[1]"));
        public static IWebElement DemeanorOther => WaitAndFindElement(By.XPath("//*[@id=\"demeanor\"]/div/div[17]/div/span[1]"));
        public static IWebElement DemeanorOtherDescription => WaitAndFindElement(By.Id("IncidentPersonDemeanor_OtherDesc"));


        // Demeanor
        public static IWebElement SpeechAngry => WaitAndFindElement(By.XPath("//*[@id=\"speech\"]/div/div[1]/div/span[1]"));
        public static IWebElement SpeechOutOfBreath => WaitAndFindElement(By.XPath("//*[@id=\"speech\"]/div/div[2]/div/span[1]"));
        public static IWebElement SpeechExcitedFast => WaitAndFindElement(By.XPath("//*[@id=\"speech\"]/div/div[3]/div/span[1]"));
        public static IWebElement SpeechCryingSobbing => WaitAndFindElement(By.XPath("//*[@id=\"speech\"]/div/div[4]/div/span[1]"));
        public static IWebElement SpeechYelling => WaitAndFindElement(By.XPath("//*[@id=\"speech\"]/div/div[5]/div/span[1]"));
        public static IWebElement SpeechBelligerent => WaitAndFindElement(By.XPath("//*[@id=\"speech\"]/div/div[6]/div/span[1]"));
        public static IWebElement SpeechRepetitive => WaitAndFindElement(By.XPath("//*[@id=\"speech\"]/div/div[7]/div/span[1]"));
        public static IWebElement SpeechIncoherent => WaitAndFindElement(By.XPath("//*[@id=\"speech\"]/div/div[8]/div/span[1]"));
        public static IWebElement SpeechDisjointed => WaitAndFindElement(By.XPath("//*[@id=\"speech\"]/div/div[9]/div/span[1]"));
        public static IWebElement SpeechOther => WaitAndFindElement(By.XPath("//*[@id=\"speech\"]/div/div[10]/div/span[1]"));
        public static IWebElement SpeechOtherDescription => WaitAndFindElement(By.Id("IncidentPersonSpeech_OtherDesc"));

        public static IWebElement SaveDemeanorInfo => WaitAndFindElement(By.XPath("//*[@id=\"person-checkbox\"]/div[4]/div/div/button"));
        public static IWebElement CancelDemeanorInfo => WaitAndFindElement(By.XPath("//*[@id=\"person-checkbox\"]/div[4]/div/div/a"));


        public DemeanorComponent(IWebDriver driver) : base(driver)
        {
        }
    }
}