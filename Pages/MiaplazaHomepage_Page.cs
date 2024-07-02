using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace csharp_cucumber_selenium_framework.Pages
{
    public class MiaplazaHomepage_Page
    {
        private readonly IWebDriver driver;

        public MiaplazaHomepage_Page(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        /** Homepage Logo */
        [FindsBy(How = How.XPath, Using = "//div[@class='mia-img']//*[name()='svg']")]
        public IWebElement assertPage { get; set; }

        /** Online High School */
        [FindsBy(How = How.XPath, Using = "//*[.='Online High School']")]
        public IWebElement onlineHighSchool { get; set; }
    }
}