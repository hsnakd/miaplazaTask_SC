using System;
using csharp_cucumber_selenium_framework.utilities;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace csharp_cucumber_selenium_framework.StepDefinitions
{
    [Binding]
    public class Hooks
    {
        private readonly ScenarioContext _scenarioContext;

        public Hooks(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            // Setup browser or any scenario-specific initialization
            Console.WriteLine("====Setting up browser using SpecFlow [BeforeScenario]");
        }

        [BeforeScenario("login")]
        public void BeforeLoginScenario()
        {
            Console.WriteLine("====This will only apply to scenarios with @login tag");
        }

        [BeforeScenario("db")]
        public void BeforeDatabaseScenario()
        {
            Console.WriteLine("====This will only apply to scenarios with @db tag");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            if (_scenarioContext.TestError != null)
            {
                // Take screenshot on failure
                byte[] screenshot = ((ITakesScreenshot)Driver.GetDriver()).GetScreenshot().AsByteArray;
                _scenarioContext.Add("screenshot", screenshot);
            }

            // Close browser or clean up
            Driver.CloseDriver();
        }

        [AfterStep]
        public void AfterStep()
        {
            Console.WriteLine("--------> applying tearDown using [AfterStep]");
        }
    }
}