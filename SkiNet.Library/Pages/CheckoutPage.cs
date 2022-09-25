using OpenQA.Selenium;
//using OpenQA.Selenium.DevTools.V102.Fetch;
using SkiNet.Library.Abstract;
using SkiNet.Library.PageComponents.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiNet.Library.Pages
{
    public class CheckoutPage : Page
    {
        private IWebElement ShippingAddressFormElement => Body.FindElement(By.CssSelector("div app-checkout-address"));
        private IWebElement DeliveryFormElement => Body.FindElement(By.CssSelector("div app-checkout-delivery"));
        private IWebElement ReviewFormElement => Body.FindElement(By.CssSelector("div app-checkout-review"));
        private IWebElement PaymentFormElement => Body.FindElement(By.CssSelector("div app-checkout-payment"));
        private IWebElement CheckoutOrderSummaryFormElement => Body.FindElement(By.CssSelector("div.p-4"));

        public CheckoutPage(IWebDriver webDriver) : base(webDriver)
        {
        }

        public CheckoutShippingAddressForm ShippingAddressForm => new CheckoutShippingAddressForm(ShippingAddressFormElement);
        public CheckoutDeliveryForm DeliveryForm => new CheckoutDeliveryForm(DeliveryFormElement);
        public CheckoutReviewForm ReviewForm => new CheckoutReviewForm(ReviewFormElement);
        public CheckoutPaymentForm PaymentForm => new CheckoutPaymentForm(PaymentFormElement);
        public CheckoutOrderSummaryForm CheckoutOrderSummaryForm => new CheckoutOrderSummaryForm(CheckoutOrderSummaryFormElement);
    }
}
