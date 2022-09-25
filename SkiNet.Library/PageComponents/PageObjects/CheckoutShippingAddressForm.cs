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
    public class CheckoutShippingAddressForm : PageObject
    {
        private IWebElement FirstNameElement => SearchContext.FindElement(By.CssSelector("app-text-input[formcontrolname='firstName']"));
        private IWebElement LastNameElement => SearchContext.FindElement(By.CssSelector("app-text-input[formcontrolname='lastName']"));
        private IWebElement StreetElement => SearchContext.FindElement(By.CssSelector("app-text-input[formcontrolname='street']"));
        private IWebElement CityElement => SearchContext.FindElement(By.CssSelector("app-text-input[formcontrolname='city']"));
        private IWebElement StateElement => SearchContext.FindElement(By.CssSelector("app-text-input[formcontrolname='state']"));
        private IWebElement ZipCodeElement => SearchContext.FindElement(By.CssSelector("app-text-input[formcontrolname='zipcode']"));
        private IWebElement BackToBasketElement => SearchContext.FindElement(By.CssSelector("button[routerlink]"));
        private IWebElement GoToDeliveryElement => SearchContext.FindElement(By.CssSelector("button[cdksteppernext]")); 

        public CheckoutShippingAddressForm(IWebElement webElement) : base(webElement)
        {
        }

        public TextInputControl FirstName => new TextInputControl(FirstNameElement);
        public TextInputControl LastName => new TextInputControl(LastNameElement);
        public TextInputControl Street => new TextInputControl(StreetElement);
        public TextInputControl City => new TextInputControl(CityElement);
        public TextInputControl State => new TextInputControl(StateElement);
        public TextInputControl ZipCode => new TextInputControl(ZipCodeElement);

        public void BackToBasket()
        {
            BackToBasketElement.Click();
        }

        public void GoToDelivery()
        {
            if (GoToDeliveryElement.Enabled)
            {
                GoToDeliveryElement.Click();
            }            
        }
    }
}
