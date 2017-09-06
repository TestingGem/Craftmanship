using FluentAutomation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Craftmanship_automationpractice.Tests
{
    [TestClass]
    public class BaseTest : FluentTest
    {
        [TestInitialize]
        public void TextFixtureSetUp()
        {
            WbTstr.Configure()
                .UseWebDriver(SeleniumWebDriver.Browser.Chrome)
                .BootstrapInstance();
        }
    }
}

