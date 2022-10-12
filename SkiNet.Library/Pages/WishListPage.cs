using OpenQA.Selenium;
using SkiNet.Library.Abstract;
using SkiNet.Library.PageComponents.PageObjects.ShopItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiNet.Library.Pages
{
    public class WishListPage : Page
    {
        private List<IWebElement> WishListElements => Body.FindElements(By.CssSelector("tr.ng-star-inserted")).ToList();

        public WishListPage(IWebDriver webDriver) : base(webDriver)
        {
        }

        public List<WishListProduct> WishListProducts => WishListElements.Select(item => new WishListProduct(item)).ToList();

        public WishListProduct GetWishListProduct(string name) => WishListProducts.Where(item => item.ProductName == name).Single();
    }
}
