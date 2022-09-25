using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiNet.Library.PageComponents.PageObjects
{
    public class BasketOrderSummaryForm : OrderSummaryForm
    {
        public BasketOrderSummaryForm(IWebElement webElement) : base(webElement)
        {
        }
    }
}
