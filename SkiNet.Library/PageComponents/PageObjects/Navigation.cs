using OpenQA.Selenium;
using SkiNet.Library.Abstract;
using SkiNet.Library.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiNet.Library.PageComponents.PageObjects
{
    public class Navigation : PageObject
    {
        public Navigation(IWebElement webElement) : base(webElement)
        {
        }

        public HomePage OpenHomePage()
        {
            //Navigate(@"HOME");
            NavigateByRouterLink("/");
            return new HomePage(WrappedDriver);
        }

        public ShopPage OpenShopPage()
        {
            //Navigate(@"SHOP");
            NavigateByRouterLink("/shop");
            return new ShopPage(WrappedDriver);
        }

        public ErrorsPage OpenErrorsPage()
        {
            //Navigate(@"ERRORS");
            NavigateByRouterLink("/test-error");
            return new ErrorsPage(WrappedDriver);
        }
                
        public LoginPage OpenLoginPage()
        {
            //Navigate(@"Login");
            NavigateByRouterLink("/account/login");
            return new LoginPage(WrappedDriver);
        }

        public SignUpPage OpenSignUpPage()
        {
            //Navigate(@"Sign up");
            NavigateByRouterLink("/account/register");
            return new SignUpPage(WrappedDriver);
        }

        public WishPage OpenWishPage()
        {            
            NavigateByRouterLink("/wish");
            return new WishPage(WrappedDriver);
        }

        public BasketPage OpenBasketPage()
        {
            NavigateByRouterLink("/basket");
            return new BasketPage(WrappedDriver);
        }

        private void NavigateByRouterLink(string locator)
        {
            IWebElement webElement = SearchContext.FindElement(By.CssSelector("[routerlink = '" + locator + "']"));  //[routerlink='/basket']
            Redirect(webElement);
        }

        private void Navigate(string locatorSuffix)
        {
            IWebElement webElement = SearchContext.FindElement(By.PartialLinkText(locatorSuffix));
            Redirect(webElement);
            WaitLoadingIndicatorToDissappear();
        }
    }
}
