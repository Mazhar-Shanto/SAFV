using OpenQA.Selenium;

namespace SAFV.Source.Components
{
    public class LoginComponent : BaseComponent
    {
        // Elements
        public static IWebElement UsernameField => WaitAndFindElement(By.Id("Email"));
        public static IWebElement PasswordField => WaitAndFindElement(By.Id("Password"));
        public static IWebElement LoginButton => WaitAndFindElement(By.XPath("//*[@id='LoginForm']/div[5]/div/button"));

        public LoginComponent(IWebDriver driver) : base(driver)
        {
        }
    }
}
