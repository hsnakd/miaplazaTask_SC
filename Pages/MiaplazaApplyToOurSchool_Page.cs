using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace csharp_cucumber_selenium_framework.Pages
{
    public class MiaplazaApplyToOurSchool_Page
    {
        private readonly IWebDriver _driver;

        public MiaplazaApplyToOurSchool_Page(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }

        // Apply to Our School
        [FindsBy(How = How.XPath, Using = "(//em[normalize-space()='MOHS Initial Application'])[1]")]
        public IWebElement MOHSInitialApplicationTitle { get; set; }
    }
}