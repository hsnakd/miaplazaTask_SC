using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace csharp_cucumber_selenium_framework.Pages
{
    public class MiaplazaFinancialAid_Page
    {
        private readonly IWebDriver driver;

        public MiaplazaFinancialAid_Page(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        /** Financial Aid Application */
        [FindsBy(How = How.Id, Using = "Dropdown12-arialabel")]
        public IWebElement requireFinancialAid { get; set; }

        [FindsBy(How = How.Id, Using = "SingleLine-arialabel")]
        public IWebElement householdSize { get; set; }

        [FindsBy(How = How.Id, Using = "SingleLine1-arialabel")]
        public IWebElement householdIncome { get; set; }

        [FindsBy(How = How.Id, Using = "SingleLine2-arialabel")]
        public IWebElement householdCost { get; set; }

        [FindsBy(How = How.Id, Using = "MultiLine4-arialabel")]
        public IWebElement householdBenefit { get; set; }

        [FindsBy(How = How.Id, Using = "MultiLine5-arialabel")]
        public IWebElement householdEvidence { get; set; }

        /** Submit the application */
        [FindsBy(How = How.XPath, Using = "//button[.//em[text()='Submit']]")]
        public IWebElement submitButton { get; set; }
    }
}