using NUnit.Framework;
using TechTalk.SpecFlow;

namespace csharp_cucumber_selenium_framework.Runner
{
    [TestFixture]
    public class TestRunner
    {
        [Test]
        public void RunAllTests()
        {
            var testRunner = TestRunnerManager.GetTestRunner();
            testRunner.OnTestRunStart();
            testRunner.OnTestRunEnd();
        }
    }
}



