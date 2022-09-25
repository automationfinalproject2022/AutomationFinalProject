using OpenQA.Selenium;
using SkiNet.Library.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiNet.Library.PageComponents.PageObjects
{
    public class CheckoutReviewForm : PageObject
    {
        private IWebElement BackToDeliveryElement => SearchContext.FindElement(By.CssSelector("button[cdkstepperprevious]"));
        private IWebElement GoToPaymentElement => SearchContext.FindElement(By.ClassName("btn-primary"));

        public CheckoutReviewForm(IWebElement webElement) : base(webElement)
        {
        }

        public void BackToDelivery()
        {
            BackToDeliveryElement.Click();
        }

        public void GoToPayment()
        {
            GoToPaymentElement.Click();
        }
    }
}
