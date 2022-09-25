using OpenQA.Selenium;
using SkiNet.Library.Abstract;
using SkiNet.Library.PageComponents.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiNet.Library.Pages
{
    public class BasketPage : Page
    {
        private IWebElement BasketOrderSummaryFormElement => Body.FindElement(By.CssSelector("div.p-4"));
        private IWebElement BasketProductsFormElement => Body.FindElement(By.CssSelector("div > app-basket-summary"));
        private IWebElement CheckoutButton => Body.FindElement(By.CssSelector("a[routerlink='/checkout']"));

        public BasketPage(IWebDriver webDriver) : base(webDriver)
        {
        }

        public BasketOrderSummaryForm BasketOrderSummaryForm => new BasketOrderSummaryForm(BasketOrderSummaryFormElement);
        public BasketProductsForm BasketProductsForm => new BasketProductsForm(BasketProductsFormElement);

        public void ProceedToCheckout()
        {
            Redirect(CheckoutButton);
        }
    }
}
