using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiNet.Library.Abstract.ShopItems
{
    public abstract class Item : PageObject
    {
        protected abstract IWebElement ProductNameElement { get; }
        protected abstract IWebElement PriceElement { get; }
        //protected abstract IWebElement PriceCurrencyElement { get; }

        protected Item(IWebElement webElement) : base(webElement)
        {
        }
    }
}
