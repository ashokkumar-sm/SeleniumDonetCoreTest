using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace SeleniumDonetCoreTest
{
    [Binding]
    public sealed class Hooks1:DriverHelpler
    {

        [BeforeScenario]
        public void BeforeScenario()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");
            driver.Manage().Window.Maximize();

        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
        }
    }
}
