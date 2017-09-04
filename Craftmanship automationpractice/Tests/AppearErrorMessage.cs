using NUnit.Framework;

namespace Craftmanship_automationpractice.Tests
{
    public class AppearErrorMessage : BaseTest
    {
        [TestCase]
        public void NewsletterSubscription_InvalidEmail_ErrorBar()
        {
            new Pages.Common.HomePage(this)
             .Go();
        }
    }
}