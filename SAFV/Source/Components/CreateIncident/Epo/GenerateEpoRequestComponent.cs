using OpenQA.Selenium;

namespace SAFV.Source.Components.CreateIncident.Epo
{
    public class GenerateEpoRequestComponent : BaseComponent
    {
        // Elements
        public static IWebElement SelectAllforms => WaitAndFindElement(By.XPath("//*[@id=\"PrintFormGroup\"]/table/thead/tr/th[1]/input"));
        public static IWebElement GenerateRequestButton => WaitAndFindElement(By.Id("generate-req-button"));
        public static IWebElement CancelRequestButton => WaitAndFindElement(By.Id("cancel-button"));

        public GenerateEpoRequestComponent(IWebDriver driver) : base(driver)
        {
        }
    }
}