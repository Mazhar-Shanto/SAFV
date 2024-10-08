using OpenQA.Selenium;

namespace SAFV.Source.Components.CreateIncident
{
    internal class DigitalEvidenceComponent : BaseComponent
    {
        public static IWebElement WasDigitalEvidenceCollected => WaitAndFindElement(By.XPath("//*[@id=\"createincidentevidenceform\"]/div/div[1]/div/span[1]"));
        public static IWebElement VideoBodyCamera => WaitAndFindElement(By.XPath("//*[@id=\"createincidentevidenceform\"]/div/div[3]/div[1]/div/span[1]"));
        public static IWebElement VideoInCar => WaitAndFindElement(By.XPath("//*[@id=\"createincidentevidenceform\"]/div/div[3]/div[2]/div/span[1]"));
        public static IWebElement VideoOther => WaitAndFindElement(By.XPath("//*[@id=\"createincidentevidenceform\"]/div/div[3]/div[3]/div/span[1]"));
        public static IWebElement VideoOtherDescription => WaitAndFindElement(By.Id("VideoOtherDesc"));
        public static IWebElement Photographs => WaitAndFindElement(By.XPath("//*[@id=\"createincidentevidenceform\"]/div/div[3]/div[5]/div/span[1]"));
        public static IWebElement PhotographsDescription => WaitAndFindElement(By.Id("PhotoDesc"));
        public static IWebElement Audiocall => WaitAndFindElement(By.XPath("//*[@id=\"createincidentevidenceform\"]/div/div[3]/div[7]/div/span[1]"));
        public static IWebElement Audio => WaitAndFindElement(By.XPath("//*[@id=\"createincidentevidenceform\"]/div/div[3]/div[8]/div/span[1]"));
        public static IWebElement AudioDescription => WaitAndFindElement(By.Id("AudioOtherDesc"));
        public static IWebElement ExplainWhyNotCollected => WaitAndFindElement(By.Id("NoDigitalEvidence"));
        public static IWebElement SaveDigitalEvidence => WaitAndFindElement(By.XPath("//*[@id=\"createincidentevidenceform\"]/div/div[5]/div/div/button"));
        public static IWebElement CancleDigitalEvidence => WaitAndFindElement(By.XPath("//*[@id=\"createincidentevidenceform\"]/div/div[5]/div/div/a"));

        public DigitalEvidenceComponent(IWebDriver driver) : base(driver)
        {
        }
    }
}
