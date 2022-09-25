using OpenQA.Selenium;
using SkiNet.Library.Abstract;
using SkiNet.Library.PageComponents.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiNet.Library.PageComponents.PageObjects
{
    public class CheckoutPaymentForm : PageObject
    {
        private IWebElement CardNameElement => SearchContext.FindElement(By.CssSelector("app-text-input[formcontrolname='nameOnCard']"));
        private IWebElement CardNumberElement => SearchContext.FindElement(By.Id("cardNumber"));
        private IWebElement CardExpirationElement => SearchContext.FindElement(By.CssSelector("input[name='exp-date']"));
        private IWebElement CardCVCElement => SearchContext.FindElement(By.CssSelector("input[name='cvc']"));
        private IWebElement BackToReviewElement => SearchContext.FindElement(By.CssSelector("button[cdkstepperprevious]"));
        private IWebElement SubmitOrderElement => SearchContext.FindElement(By.ClassName("btn-primary"));

        public CheckoutPaymentForm(IWebElement webElement) : base(webElement)
        {
        }

        public TextInputControl CardName => new TextInputControl(CardNameElement);
        public TextInputControl CardNumber => new TextInputControl(CardNumberElement);
        public TextInputControl CardExpiration => new TextInputControl(CardExpirationElement);
        public TextInputControl CardCVC => new TextInputControl(CardCVCElement);

        public void BackToReview()
        {
            BackToReviewElement.Click();
        }

        public void SubmitOrder()
        {
            if (SubmitOrderElement.Enabled)
            {
                SubmitOrderElement.Click();
            }
        }
    }
}
