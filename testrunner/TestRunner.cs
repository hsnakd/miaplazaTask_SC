using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Miaplaza.TestRunner
{
    [SetUpFixture]
    public class TestRunner
    {
        [OneTimeSetUp]
        public void Setup()
        {
            // Setup code if needed
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            // Teardown code if needed
        }
    }
}
