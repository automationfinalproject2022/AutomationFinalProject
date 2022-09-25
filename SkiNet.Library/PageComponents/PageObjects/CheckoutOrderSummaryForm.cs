using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiNet.Library.PageComponents.PageObjects
{
    public class CheckoutOrderSummaryForm : OrderSummaryForm
    {
        public CheckoutOrderSummaryForm(IWebElement webElement) : base(webElement)
        {
        }
    }
}
