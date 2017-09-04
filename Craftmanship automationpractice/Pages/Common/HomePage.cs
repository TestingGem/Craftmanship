using System;
using System.Collections.Generic;
using System.Linq;
using FluentAutomation;
using Craftmanship_automationpractice.Pages;
using Craftmanship_automationpractice.Tests;

namespace Craftmanship_automationpractice.Pages.Common
{
    public class HomePage : BasePage<HomePage>
    {
        private const string Navigation = "#nav";
        private const string NavContactLink = "#nav > li:nth-child(4)";

        public HomePage(FluentTest test) : base(test)
        {
            Url = ConfigurationManager.AppSettings["HomePage"];
            At = () => I.Assert.Visible(Navigation);
        }

        public HomePage ClickNavContactLink()
        {
            I.Click(NavContactLink);
            return this;
        }
    }
}