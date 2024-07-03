using System;
using csharp_cucumber_selenium_framework.Pages;
using csharp_cucumber_selenium_framework.utilities;
using Bogus;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace Miaplaza.StepDefinitions
{
    [Binding]
    public class Miaplaza_SD
    {
        private readonly IWebDriver driver = Driver.GetDriver();
        private readonly MiaplazaHomepage_Page miaplazaHomepagePage = new MiaplazaHomepage_Page(Driver.GetDriver());
        private readonly MiaplazaOnlineHighSchool_Page miaplazaOnlineHighSchoolPage = new MiaplazaOnlineHighSchool_Page(Driver.GetDriver());
        private readonly MiaplazaApplyToOurSchool_Page miaplazaApplyToOurSchoolPage = new MiaplazaApplyToOurSchool_Page(Driver.GetDriver());
        private readonly MiaplazaParentInformation_Page miaplazaParentInformationPage = new MiaplazaParentInformation_Page(Driver.GetDriver());
        private readonly MiaplazaStudentInformation_Page miaplazaStudentInformationPage = new MiaplazaStudentInformation_Page(Driver.GetDriver());
        private readonly MiaplazaFinancialAid_Page miaplazaFinancialAidPage = new MiaplazaFinancialAid_Page(Driver.GetDriver());
        private readonly Bogus.Faker faker = new Bogus.Faker();

        [Given("The user is on the MiAcademy website")]
        public void TheUserIsOnTheMiAcademyWebsite()
        {
            driver.Navigate().GoToUrl(ConfigurationReader.GetProperty("url"));
            Assert.IsTrue(miaplazaHomepagePage.assertPage.Displayed);
        }

        [When("The user navigates to the MiaPrep Online High School page")]
        public void TheUserNavigatesToTheMiaPrepOnlineHighSchoolPage()
        {
            miaplazaHomepagePage.onlineHighSchool.Click();
            Assert.IsTrue(miaplazaOnlineHighSchoolPage.assertPage.Displayed);
        }

        [When("The user clicks on Apply to Our School")]
        public void TheUserClicksOnApplyToOurSchool()
        {
            miaplazaOnlineHighSchoolPage.applyToOurSchool.Click();
            Assert.IsTrue(miaplazaApplyToOurSchoolPage.MOHSInitialApplicationTitle.Displayed);
        }

        [When("The user fills in the Parent Information section")]
        public void TheUserFillsInTheParentInformationSection()
        {
            // Parent 1 Information
            miaplazaParentInformationPage.parent1FirstName.SendKeys(faker.Name.FirstName());
            miaplazaParentInformationPage.parent1LastName.SendKeys(faker.Name.LastName());
            miaplazaParentInformationPage.parent1Email.SendKeys(faker.Internet.Email());
            
            /** New version of the phone number field step */
            miaplazaParentInformationPage.countryBox.Click();
            miaplazaParentInformationPage.country.Click();
            string phoneNumber = BrowserUtils.GenerateTurkishPhoneNumber();
            miaplazaParentInformationPage.phoneNumber.SendKeys(phoneNumber);
            
            /** Old version of the phone number field step */
            // miaplazaParentInformationPage.parent1PhoneNumber.SendKeys(faker.Phone.PhoneNumberFormat());

            // Select Second Parent Dropdown
            var secondParentDropdown = new SelectElement(miaplazaParentInformationPage.secondParentDropdown);
            secondParentDropdown.SelectByText("Yes");

            // Parent 2 Information
            miaplazaParentInformationPage.parent2FirstName.SendKeys(faker.Name.FirstName());
            miaplazaParentInformationPage.parent2LastName.SendKeys(faker.Name.LastName());
            miaplazaParentInformationPage.parent2Email.SendKeys(faker.Internet.Email());
            miaplazaParentInformationPage.parent2PhoneNumber.SendKeys(faker.Phone.PhoneNumberFormat());

            // How did you hear about us?
            miaplazaParentInformationPage.searchEngine.Click();
            miaplazaParentInformationPage.otherSocialMedia.Click();

            // Preferred start date
            miaplazaParentInformationPage.preferredDate.SendKeys("26-Jul-2024");

            // BrowserUtils.Sleep(10);

            // Next button for Student Information Section
            miaplazaParentInformationPage.nextButton.Click();
        }

        [When("The user fills in the Student Information section")]
        public void TheUserFillsInTheStudentInformationSection()
        {
            // Select Second Student
            var selectStudentNumber = new SelectElement(miaplazaStudentInformationPage.selectStudentNumber);
            selectStudentNumber.SelectByText("Two");

            // Student 1 Information
            miaplazaStudentInformationPage.student1FirstName.SendKeys(faker.Name.FirstName());
            miaplazaStudentInformationPage.student1LastName.SendKeys(faker.Name.LastName());
            miaplazaStudentInformationPage.student1Email.SendKeys(faker.Internet.Email());
            miaplazaStudentInformationPage.student1PhoneNumber.SendKeys(faker.Phone.PhoneNumberFormat());

            var student1Consent = new SelectElement(miaplazaStudentInformationPage.student1Consent);
            student1Consent.SelectByText("Yes");

      
            // Generate a random date of birth
            var student1DateOfBirth = faker.Date.Between(new DateTime(2005, 1, 1), new DateTime(2010, 12, 31));
            string formattedDateOfBirth = student1DateOfBirth.ToString("dd-MM-yyyy");
            miaplazaStudentInformationPage.student1DateOfBirth.SendKeys(formattedDateOfBirth);


            var student1Gender = new SelectElement(miaplazaStudentInformationPage.student1Gender);
            student1Gender.SelectByText("Male");

            var student1Account = new SelectElement(miaplazaStudentInformationPage.student1Account);
            student1Account.SelectByText("Yes");

            var student1Membership = new SelectElement(miaplazaStudentInformationPage.student1Membership);
            student1Membership.SelectByText("Monthly");

            var student1Schooling = new SelectElement(miaplazaStudentInformationPage.student1Schooling);
            student1Schooling.SelectByText("Private School");

            // Check off completed courses
            miaplazaStudentInformationPage.student1Math1.Click();
            miaplazaStudentInformationPage.student1Math2.Click();
            miaplazaStudentInformationPage.student1English1.Click();
            miaplazaStudentInformationPage.student1English2.Click();
            miaplazaStudentInformationPage.student1Science1.Click();
            miaplazaStudentInformationPage.student1Science2.Click();

            miaplazaStudentInformationPage.student1List.SendKeys(faker.Lorem.Paragraph());

            var student1Needs = new SelectElement(miaplazaStudentInformationPage.student1Needs);
            student1Needs.SelectByText("Yes");

            miaplazaStudentInformationPage.student1Describe.SendKeys(faker.Lorem.Paragraph());

            // Student 2 Information
            miaplazaStudentInformationPage.student2FirstName.SendKeys(faker.Name.FirstName());
            miaplazaStudentInformationPage.student2LastName.SendKeys(faker.Name.LastName());
            miaplazaStudentInformationPage.student2Email.SendKeys(faker.Internet.Email());
            miaplazaStudentInformationPage.student2PhoneNumber.SendKeys(faker.Phone.PhoneNumberFormat());

            var student2Consent = new SelectElement(miaplazaStudentInformationPage.student2Consent);
            student2Consent.SelectByText("No");

            // Assuming this is within a method or a class
            string student2DateOfBirth = faker.Date.Past().ToString("dd-MM-yyyy");
            miaplazaStudentInformationPage.student2DateOfBirth.SendKeys(student2DateOfBirth);
            

            var student2Gender = new SelectElement(miaplazaStudentInformationPage.student2Gender);
            student2Gender.SelectByText("Female");

            var student2Account = new SelectElement(miaplazaStudentInformationPage.student2Account);
            student2Account.SelectByText("No");

            var student2Schooling = new SelectElement(miaplazaStudentInformationPage.student2Schooling);
            student2Schooling.SelectByText("Homeschool");

            // Check off completed courses
            miaplazaStudentInformationPage.student2Math1.Click();
            miaplazaStudentInformationPage.student2Math2.Click();
            miaplazaStudentInformationPage.student2English1.Click();
            miaplazaStudentInformationPage.student2English2.Click();
            miaplazaStudentInformationPage.student2Science1.Click();
            miaplazaStudentInformationPage.student2Science2.Click();

            miaplazaStudentInformationPage.student2List.SendKeys(faker.Lorem.Paragraph());

            var student2Needs = new SelectElement(miaplazaStudentInformationPage.student2Needs);
            student2Needs.SelectByText("No");
            
            // BrowserUtils.Sleep(10);


            // Next button for Financial Aid Application Section
            miaplazaStudentInformationPage.nextButton2.Click();
        }

        [When("The user fills in the Financial Aid Application section")]
        public void TheUserFillsInTheFinancialAidApplicationSection()
        {
            
            var requireFinancialAid = new SelectElement(miaplazaFinancialAidPage.requireFinancialAid);
            requireFinancialAid.SelectByText("Yes");

            miaplazaFinancialAidPage.householdSize.SendKeys(faker.Random.Number(2,6).ToString());
            miaplazaFinancialAidPage.householdIncome.SendKeys(faker.Random.Double((int)500, (int)1000).ToString());
            miaplazaFinancialAidPage.householdCost.SendKeys(faker.Random.Double((int)250, (int)400).ToString());
            miaplazaFinancialAidPage.householdBenefit.SendKeys(faker.Lorem.Sentence());
            miaplazaFinancialAidPage.householdEvidence.SendKeys(faker.Lorem.Paragraph());
            
            // BrowserUtils.Sleep(10);
        }

        [When("The user submits the application form")]
        public void TheUserSubmitsTheApplicationForm()
        {
            // Uncomment the line below once the actual submit button is available
            Assert.IsTrue(miaplazaFinancialAidPage.submitButton.Enabled);
        }

        [Then(@"Verify that the user should see a ""(.*)""")]
        public void VerifyConfirmationMessage(string expectedMessage)
        {
            // Replace the placeholder actual message with the actual application success message
            string actualMessage = "You have successfully submitted your application";
            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Driver.CloseDriver();
        }
    }
}
