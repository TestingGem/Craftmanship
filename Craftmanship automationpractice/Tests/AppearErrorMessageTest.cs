using Craftmanship_automationpractice.Pages.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Craftmanship_automationpractice.Tests
{
    [TestClass]
    public class AppearErrorMessage : BaseTest
    {
        [TestMethod]
        public void NewsletterSubscription_InvalidEmail_ErrorBar()
        {
            new HomePage(this)
            .Go()
            .InsertNewsletter()
            .Assert();
        }
    }
}