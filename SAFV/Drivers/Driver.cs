using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager;
using System;
using NUnit.Framework;

namespace SAFV.Drivers
{
    public class Driver
    {
        public IWebDriver _driver;

        [SetUp]
        public void InitDriver()
        {
            var options = new ChromeOptions();
            options.AddArgument("no-sandbox");

            new DriverManager().SetUpDriver(new ChromeConfig());
            _driver = new ChromeDriver(ChromeDriverService.CreateDefaultService(), options, TimeSpan.FromMinutes(3));
            _driver.Manage().Window.Maximize();
            // Configure implicit wait
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(.3);
        }

        [TearDown]
        public void TearDown()
        {
            // Dispose of the driver after each test
            if (_driver != null)
            {
                if (TestContext.CurrentContext.Result.Outcome.Status.ToString() == "Failed")
                {
                    Reporting.SetTestStatusFail();
                }
                else if (TestContext.CurrentContext.Result.Outcome.Status.ToString() == "Passed")
                {
                    Reporting.SetTestStatusPass();
                }
                Reporting.Close();
                _driver.Quit();
                _driver.Dispose();
                _driver = null;
            }
        }
    }
}
