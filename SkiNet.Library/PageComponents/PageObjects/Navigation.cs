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
            Navigate(@"HOME");
            return new HomePage(WrappedDriver);
        }

        public ShopPage OpenShopPage()
        {
            Navigate(@"SHOP");
            return new ShopPage(WrappedDriver);
        }

        public ErrorsPage OpenErrorsPage()
        {
            Navigate(@"ERRORS");
            return new ErrorsPage(WrappedDriver);
        }

        
        public LoginPage OpenLoginPage()
        {
            Navigate(@"Login");
            return new LoginPage(WrappedDriver);
        }

        public SignUpPage OpenSignUpPage()
        {
            Navigate(@"Sign up");
            return new SignUpPage(WrappedDriver);
        }
       

        private void Navigate(string locatorSuffix)
        {
            IWebElement webElement = SearchContext.FindElement(By.PartialLinkText(locatorSuffix));
            Redirect(webElement);
        }
    }
}
