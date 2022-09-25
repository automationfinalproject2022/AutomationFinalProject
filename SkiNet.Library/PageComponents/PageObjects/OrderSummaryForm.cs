using OpenQA.Selenium;
using SkiNet.Library.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiNet.Library.PageComponents.PageObjects
{
    public abstract class OrderSummaryForm : PageObject
    {
        private IWebElement OrderSubTotalValueElement => SearchContext.FindElement(By.CssSelector(".p-4 ul li:nth-child(1) strong:nth-child(2)"));
        private IWebElement ShippingAndHandlingValueElement => SearchContext.FindElement(By.CssSelector(".p-4 ul li:nth-child(2) strong:nth-child(2)"));
        private IWebElement TotalValueElement => SearchContext.FindElement(By.CssSelector(".p-4 ul li:nth-child(3) strong:nth-child(2)"));

        public OrderSummaryForm(IWebElement webElement) : base(webElement)
        {
        }

        public string GetOrderSubTotalValue()
        {
            string subTotalValue = GetPriceValue(OrderSubTotalValueElement.Text);
            return subTotalValue;
        }

        public string GetShippingAndHandlingValue()
        {
            string shippingValue = GetPriceValue(ShippingAndHandlingValueElement.Text);
            return shippingValue;
        }

        public string GetTotalValue()
        {
            string totalValue = GetPriceValue(TotalValueElement.Text);
            return totalValue;
        }

        public char GetTotalPriceCurrency()
        {
            string totalValueString = TotalValueElement.Text;

            if (totalValueString.Length > 0)
            {
                return totalValueString[0];
            }
            else
            {
                throw new Exception("No currency symbol is found!");
            }
        }

        private string GetPriceValue(string priceString)
        {
            string value = priceString.Substring(1, priceString.Length - 1);
            return value;
        }
    }
}
