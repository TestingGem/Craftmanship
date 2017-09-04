using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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