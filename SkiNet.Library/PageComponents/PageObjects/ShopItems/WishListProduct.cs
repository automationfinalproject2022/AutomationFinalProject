using OpenQA.Selenium;
using SkiNet.Library.Abstract.Interfaces;
using SkiNet.Library.Abstract.ShopItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiNet.Library.PageComponents.PageObjects.ShopItems
{
    public class WishListProduct : Item, IRemoveFromWishList, IViewDetails
    {
        private IWebElement TypeElement => SearchContext.FindElement(By.ClassName("text-muted"));
        private IWebElement RemoveButtonElement => SearchContext.FindElement(By.ClassName("fa-trash"));

        protected override IWebElement ProductNameElement => SearchContext.FindElement(By.CssSelector("a.text-dark"));
        protected override IWebElement PriceElement => SearchContext.FindElement(By.CssSelector("strong[_ngcontent-qpk-c16]"));
        //protected override IWebElement PriceCurrencyElement => throw new NotImplementedException();

        public string ProductName => ProductNameElement.Text;
        public string Price => GetPriceValue(PriceElement);
        public char PriceCurrency => GetPriceCurrency(PriceElement);
        public string Type => GetProductType(TypeElement.Text); 

        public WishListProduct(IWebElement webElement) : base(webElement)
        {
        }

        public void RemoveFromWishList()
        {
            RemoveButtonElement.Click();
        }

        public void ViewDetails()
        {
            ProductNameElement.Click();
        }

        private string GetProductType(string productTypeString)
        {
            string productType = productTypeString;
            string productTypePrefix = "Type: ";
            productType = productType.Substring(productTypePrefix.Length, productType.Length - (productTypePrefix.Length));
            return productType;
        }

        //TODO: This code below is duplicated in OrderSummaryForm - think about having it only once and reuse it !!!!

        private string GetPriceValue(IWebElement priceElement)
        {
            string priceString = priceElement.Text;
            string priceValue = priceString.Substring(1, priceString.Length - 1);
            return priceValue;
        }

        private char GetPriceCurrency(IWebElement priceElement)
        {
            string priceString = priceElement.Text;

            if (priceString.Length > 0)
            {
                return priceString[0];
            }
            else
            {
                throw new Exception("No currency symbol is found!");
            }
        }
    }
}
