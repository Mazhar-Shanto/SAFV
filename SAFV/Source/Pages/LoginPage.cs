using OpenQA.Selenium;
using SAFV.Drivers;
using SAFV.Source.Components;

namespace SAFV.Source.Pages
{
    public class LoginPage : BasePage
    {
        private IWebDriver _driver;

        public LoginPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        public void GoToLoginPage()
        {
            _driver.Navigate().GoToUrl(BaseUrl);
        }

        public void Login(string userEmail, string userPass)
        {
            Reporting.AddTestScreenshot(_driver, "Login Test");
            SendKeys(LoginComponent.UsernameField, userEmail);
            SendKeys(LoginComponent.PasswordField, userPass);
            Reporting.AddTestScreenshot(_driver, "Login Test");

            Console.WriteLine("Login -- " + LoginComponent.LoginButton.Text);
            Click(LoginComponent.LoginButton);
        }
    }
}
