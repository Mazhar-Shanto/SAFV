using NUnit.Framework;
using OpenQA.Selenium;

namespace SAFV.Source.Components.QuickBook
{
    public class QuickBookMenuComponent : BaseComponent
    {
        // Elements
        public static IWebElement Incident => WaitAndFindElement(By.XPath("//*[@id=\"quickbook-nav-bar\"]/li[1]"));
        public static IWebElement Offense => WaitAndFindElement(By.XPath("//*[@id=\"quickbook-nav-bar\"]/li[2]"));
        public static IWebElement Victim => WaitAndFindElement(By.XPath("//*[@id=\"quickbook-nav-bar\"]/li[3]"));
        public static IWebElement Suspect => WaitAndFindElement(By.XPath("//*[@id=\"quickbook-nav-bar\"]/li[4]"));
        public static IWebElement Evidence => WaitAndFindElement(By.XPath("//*[@id=\"quickbook-nav-bar\"]/li[5]"));

        public QuickBookMenuComponent(IWebDriver driver) : base(driver)
        {
        }
    }
}
