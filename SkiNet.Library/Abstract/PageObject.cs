using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiNet.Library.Abstract
{
    public abstract class PageObject
    {
        protected IWebDriver WrappedDriver { get; set; }
        protected IWebElement SearchContext { get; private set; }

        public PageObject(IWebElement webElement)
        {
            SearchContext = webElement;
            WrappedDriver = ((WebElement)SearchContext).WrappedDriver;
        }

        protected WebDriverWait Wait(int timeOutInSeconds) => new WebDriverWait(WrappedDriver, TimeSpan.FromSeconds(timeOutInSeconds));

        protected void Redirect(IWebElement redirect)
        {
            string newUrl = redirect.GetAttribute("href");
            redirect.Click();
            Wait(10).Until(ExpectedConditions.UrlToBe(newUrl));
        }
    }
}
