using OpenQA.Selenium;
using SkiNet.Library.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiNet.Library.PageComponents.PageObjects
{
    public class BasketProductsForm : PageObject
    {
        private List<IWebElement> ProductItemElements => SearchContext.FindElements(By.CssSelector("tr[class]")).ToList();

        public BasketProductsForm(IWebElement webElement) : base(webElement)
        {
        }

        //TODO: Implement interactions with the product items on the Basket page
    }
}
