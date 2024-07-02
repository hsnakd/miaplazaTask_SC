using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace csharp_cucumber_selenium_framework.Pages
{
    public class MiaplazaOnlineHighSchool_Page
    {
        private readonly IWebDriver driver;

        public MiaplazaOnlineHighSchool_Page(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        /** Assert Page */
        [FindsBy(How = How.XPath, Using = "//img[@class='custom-logo svg-logo-image' and @alt='MiaPrep']")]
        public IWebElement assertPage { get; set; }

        /** Apply to Our School */
        [FindsBy(How = How.XPath, Using = "//*[.='Apply to Our School']")]
        public IWebElement applyToOurSchool { get; set; }
    }
}