using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace csharp_cucumber_selenium_framework.Pages
{
    public class MiaplazaStudentInformation_Page
    {
        private readonly IWebDriver driver;

        public MiaplazaStudentInformation_Page(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        /** Student Information */

        [FindsBy(How = How.Id, Using = "Dropdown1-arialabel")]
        public IWebElement selectStudentNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@autocomplete='given-name' and @complink='Name2_First']")]
        public IWebElement student1FirstName { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@autocomplete='given-name' and @complink='Name3_First']")]
        public IWebElement student2FirstName { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='Name2' and @elname='Last']")]
        public IWebElement student1LastName { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@elname='Last' and @name='Name3']")]
        public IWebElement student2LastName { get; set; }

        [FindsBy(How = How.Id, Using = "Email2-arialabel")]
        public IWebElement student1Email { get; set; }
        [FindsBy(How = How.Id, Using = "Email3-arialabel")]
        public IWebElement student2Email { get; set; }

        [FindsBy(How = How.Id, Using = "PhoneNumber2")]
        public IWebElement student1PhoneNumber { get; set; }
        [FindsBy(How = How.Id, Using = "PhoneNumber3")]
        public IWebElement student2PhoneNumber { get; set; }

        [FindsBy(How = How.Id, Using = "SingleLine3-arialabel")]
        public IWebElement student1DateOfBirth { get; set; }
        [FindsBy(How = How.Id, Using = "SingleLine4-arialabel")]
        public IWebElement student2DateOfBirth { get; set; }

        [FindsBy(How = How.Id, Using = "Dropdown2-arialabel")]
        public IWebElement student1Consent { get; set; }
        [FindsBy(How = How.Id, Using = "Dropdown6-arialabel")]
        public IWebElement student2Consent { get; set; }

        [FindsBy(How = How.Id, Using = "Dropdown3-arialabel")]
        public IWebElement student1Gender { get; set; }
        [FindsBy(How = How.Id, Using = "Dropdown7-arialabel")]
        public IWebElement student2Gender { get; set; }

        [FindsBy(How = How.Id, Using = "Dropdown4-arialabel")]
        public IWebElement student1Account { get; set; }
        [FindsBy(How = How.Id, Using = "Dropdown8-arialabel")]
        public IWebElement student2Account { get; set; }

        [FindsBy(How = How.Id, Using = "Dropdown10-arialabel")]
        public IWebElement student1Membership { get; set; }
        [FindsBy(How = How.Id, Using = "Dropdown8-arialabel")]
        public IWebElement student2Membership { get; set; }

        [FindsBy(How = How.Id, Using = "Dropdown5-arialabel")]
        public IWebElement student1Schooling { get; set; }
        [FindsBy(How = How.Id, Using = "Dropdown9-arialabel")]
        public IWebElement student2Schooling { get; set; }

        [FindsBy(How = How.XPath, Using = "(//label[@for='Checkbox1_2'])[1]")]
        public IWebElement student1Math1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//label[@for='Checkbox1_5']")]
        public IWebElement student1Math2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[@for='Checkbox2_1']")]
        public IWebElement student1English1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//label[@for='Checkbox2_2']")]
        public IWebElement student1English2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[@for='Checkbox3_1']")]
        public IWebElement student1Science1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//label[@for='Checkbox3_3']")]
        public IWebElement student1Science2 { get; set; }



        [FindsBy(How = How.XPath, Using = "//label[@for='Checkbox4_1']")]
        public IWebElement student2Math1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//label[@for='Checkbox4_4']")]
        public IWebElement student2Math2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[@for='Checkbox5_3']")]
        public IWebElement student2English1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//label[@for='Checkbox5_4']")]
        public IWebElement student2English2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[@for='Checkbox6_2']")]
        public IWebElement student2Science1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//label[@for='Checkbox6_3']")]
        public IWebElement student2Science2 { get; set; }

        [FindsBy(How = How.Id, Using = "MultiLine-arialabel")]
        public IWebElement student1List { get; set; }
        [FindsBy(How = How.Id, Using = "MultiLine2-arialabel")]
        public IWebElement student2List { get; set; }

        [FindsBy(How = How.Id, Using = "Dropdown13-arialabel")]
        public IWebElement student1Needs { get; set; }
        [FindsBy(How = How.Id, Using = "Dropdown14-arialabel")]
        public IWebElement student2Needs { get; set; }

        [FindsBy(How = How.Id, Using = "MultiLine1-arialabel")]
        public IWebElement student1Describe { get; set; }

        [FindsBy(How = How.XPath, Using = "//ul[3]//li[1]//div[1]//div[2]//div[1]//button[1]")]
        public IWebElement nextButton2 { get; set; }
    }
}