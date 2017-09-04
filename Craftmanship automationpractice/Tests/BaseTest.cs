using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using FluentAutomation;
using NUnit.Framework;

namespace Craftmanship_automationpractice.Tests
{
    [TestFixture]
    public class BaseTest : FluentTest
    {
        [TestFixtureSetUp]
        public void TextFixtureSetUp()
        {
            WbTstr.Configure()
                .UseWebDriver(SeleniumWebDriver.Browser.PhantomJs)
                .BootstrapInstance();
        }
    }
}