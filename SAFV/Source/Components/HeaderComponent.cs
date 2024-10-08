using OpenQA.Selenium;

namespace SAFV.Source.Components
{
    public class HeaderComponent : BaseComponent
    {
        // Elements
        public static IWebElement AlertMessage => WaitAndFindElement(By.ClassName("k-notification-content"));
        public static IWebElement TabTitle => WaitAndFindElement(By.Id("seletedTabTitle"));
        public static IWebElement LogoutButton => WaitAndFindElement(By.Id("logout"));
        public static IWebElement ProfileButton => WaitAndFindElement(By.Id("headerSettingButton"));

        public HeaderComponent(IWebDriver driver) : base(driver)
        {
        }
    }
}
