using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace csharp_cucumber_selenium_framework.Pages
{
    public class MiaplazaParentInformation_Page
    {
        private readonly IWebDriver driver;

        public MiaplazaParentInformation_Page(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        /** Parent Information */

        [FindsBy(How = How.XPath, Using = "//input[@name='Name' and @type='text']")]
        public IWebElement parent1FirstName { get; set; }

        [FindsBy(How = How.Name, Using = "Name1")]
        public IWebElement parent2FirstName { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@elname='Last' and @name='Name']")]
        public IWebElement parent1LastName { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@elname='Last' and @name='Name1']")]
        public IWebElement parent2LastName { get; set; }

        [FindsBy(How = How.Id, Using = "Email-arialabel")]
        public IWebElement parent1Email { get; set; }

        [FindsBy(How = How.Id, Using = "Email1-arialabel")]
        public IWebElement parent2Email { get; set; }

        [FindsBy(How = How.Id, Using = "PhoneNumber")]
        public IWebElement parent1PhoneNumber { get; set; }

        [FindsBy(How = How.Id, Using = "PhoneNumber1")]
        public IWebElement parent2PhoneNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Dropdown-arialabel']")]
        public IWebElement secondParentDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = "(//label[@for='Checkbox_1'])[1]")]
        public IWebElement searchEngine { get; set; }

        [FindsBy(How = How.XPath, Using = "(//label[@for='Checkbox_10'])[1]")]
        public IWebElement otherSocialMedia { get; set; }

        [FindsBy(How = How.Id, Using = "Date-date")]
        public IWebElement startDate { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@title='2024']")]
        public IWebElement year { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@class='select2-search__field']")]
        public IWebElement yearField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[.='Aug']")]
        public IWebElement month { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[.='26']")]
        public IWebElement day { get; set; }

        [FindsBy(How = How.XPath, Using = "(//button[@type='button' and @elname='next'])[1]")]
        public IWebElement nextButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//ul[3]//li[1]//div[1]//div[2]//div[1]//button[1]")]
        public IWebElement nextButton2 { get; set; }
        
        
        [FindsBy(How = How.XPath, Using = "(//input[@id='Date-date'])[1]")]
        public IWebElement preferredDate { get; set; }


    }
}