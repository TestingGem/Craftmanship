﻿using FluentAutomation;

namespace Craftmanship_automationpractice.Pages.Common
{
    public class HomePage : BasePage<HomePage>
    {
        private string AlertBar=".alert";
        private string NewsletterInput="#newsletter-input";
        private string SubmitButtonNewsletter = "#newsletter_block_left .button";

        public HomePage(FluentTest test) : base(test)
        {
            //Url = ConfigurationManager.AppSettings["Homepage"];
            Url = "http://www.mirabeau.nl";
            //At = () => I.Assert.Visible(NewsletterInput);
        }

        public HomePage InsertNewsletter()
        {
            I.Enter("@.nl").In(NewsletterInput);
            I.Click(SubmitButtonNewsletter);
            return this;
        }

        public HomePage Assert()
        {
            I.Assert.Visible(AlertBar);
            return this;
        }

    }
}