using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiNet.Library.Abstract
{
    public abstract class Form : PageObject
    {
        private IWebElement _titleElement => SearchContext.FindElement(By.CssSelector("[class*='h3']"));
        private IWebElement _emailElement => SearchContext.FindElement(By.Id("Email Address"));
        private IWebElement _passwordElement => SearchContext.FindElement(By.Id("Password"));

        protected IWebElement ActionButton => SearchContext.FindElement(By.CssSelector("button[type='submit']"));


        protected Form(IWebElement webElement) : base(webElement)
        {

        }

        public string Title => _titleElement.Text;

        public string EmailAddress => _emailElement.Text;

        public string Password => _passwordElement.Text;

        protected abstract void Action(IWebElement webElement);
    }
}
