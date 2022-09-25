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
    public class CheckoutDeliveryForm : PageObject
    {
        private IWebElement UPS1DeliveryElement => SearchContext.FindElement(By.CssSelector("label[for='1']"));
        private IWebElement UPS2DeliveryElement => SearchContext.FindElement(By.CssSelector("label[for='2']"));
        private IWebElement UPS3DeliveryElement => SearchContext.FindElement(By.CssSelector("label[for='3']"));
        private IWebElement FreeDeliveryElement => SearchContext.FindElement(By.CssSelector("label[for='4']"));
        private IWebElement BackToAddressElement => SearchContext.FindElement(By.CssSelector("button[cdkstepperprevious]"));
        //private IWebElement GoToReviewElement => SearchContext.FindElement(By.CssSelector("button[cdksteppernext]"));
        private IWebElement GoToReviewElement => SearchContext.FindElement(By.CssSelector("button[type='submit']")); 

        public CheckoutDeliveryForm(IWebElement webElement) : base(webElement)
        {
        }

        public RadioControl UPS1Delivery => new RadioControl(UPS1DeliveryElement);
        public RadioControl UPS2Delivery => new RadioControl(UPS2DeliveryElement);
        public RadioControl UPS3Delivery => new RadioControl(UPS3DeliveryElement);
        public RadioControl FreeDelivery => new RadioControl(FreeDeliveryElement);

        public void BackToAddress()
        {
            BackToAddressElement.Click();
        }

        public void GoToReview()
        {
            if (GoToReviewElement.Enabled)
            {
                GoToReviewElement.Click();
            }
        }
    }
}
