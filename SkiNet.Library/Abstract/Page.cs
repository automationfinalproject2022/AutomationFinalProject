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
    public abstract class Page
    {
        private IWebElement PageTitle => Body.FindElement(By.CssSelector("div[class='col-9']"));

        protected IWebDriver WrappedDriver { get; private set; }
        protected IWebElement Body => WrappedDriver.FindElement(By.TagName("body"));

        public Page(IWebDriver webDriver)
        {
            WrappedDriver = webDriver;
        }

        protected WebDriverWait Wait(int timeOutInSeconds) => new WebDriverWait(WrappedDriver, TimeSpan.FromSeconds(timeOutInSeconds));

        protected void WaitLoadingIndicatorToDissappear()
        {
            IWebElement loading = Wait(7).Until(ExpectedConditions.ElementExists(By.PartialLinkText("Loading...")));
            Wait(7).Until(ExpectedConditions.StalenessOf(loading));
        }

        protected void Redirect(IWebElement redirect)
        {
            string newUrl = redirect.GetAttribute("href");
            redirect.Click();
            Wait(10).Until(ExpectedConditions.UrlToBe(newUrl));
        }

        public string Title => PageTitle.Text;
    }
}
