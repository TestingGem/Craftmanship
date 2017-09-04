using FluentAutomation;

namespace Craftmanship_automationpractice.Pages
{
    public class BasePage<T> : PageObject<T> where T : PageObject
    {
        public BasePage(FluentTest test) : base(test)
        {

        }
    }
}