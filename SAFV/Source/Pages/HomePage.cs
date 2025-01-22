using OpenQA.Selenium;
using SAFV.Source.Components;

namespace SAFV.Source.Pages
{
    public class HomePage : BasePage
    {
        private IWebDriver _driver;

        public HomePage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        public bool VerifyUserName(string username)
        {
            Click(MenuComponent.Home);
            // Ensure the logged-in user element is available
            IWebElement loggedInUserElement = HomeComponent.LoggedInUser;
            if (loggedInUserElement != null && loggedInUserElement.Text.Trim() == username)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckMenuItems(string name)
        {
            bool menuFound = false;
            foreach (var menuItem in MenuComponent.LstMenu)
            {
                 if (menuItem.Text.Contains(name))
                {
                    menuFound = true;
                }
            }

            return menuFound;
        }

        public void VisitAllCasesGrid()
        {
            // Placeholder for navigating to the cases grid
            // Uncomment and update the following lines as needed:
            // Click(MenuComponent.DreMainMenu);
            // Click(MenuComponent.DreAllCases);
        }

        public void Logout()
        {
            Click(HeaderComponent.ProfileButton); // Adjust method name if necessary
            Click(HeaderComponent.LogoutButton);  // Adjust method name if necessary
        }
    }
}
