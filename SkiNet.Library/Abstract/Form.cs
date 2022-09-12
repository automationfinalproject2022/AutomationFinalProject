using OpenQA.Selenium;
using SkiNet.Library.PageComponents;
using SkiNet.Library.PageComponents.Controls;
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
        //private IWebElement _emailElement => SearchContext.FindElement(By.Id("Email Address"));
        //private IWebElement _emailElement => SearchContext.FindElement(By.ClassName("form-control"));        

        private IWebElement _emailElement => SearchContext.FindElement(By.CssSelector("input[placeholder = 'Email Address']"));
        private IWebElement _passwordElement => SearchContext.FindElement(By.Id("Password"));


        protected Form(IWebElement webElement) : base(webElement)
        {

        }

        public string Title => _titleElement.Text;
        public TextInputControl EmailAddress => new TextInputControl(_emailElement);
        public TextInputControl Password => new TextInputControl(_passwordElement);

        protected abstract IWebElement ActionElement { get; }

        public void Action()
        {
            ActionElement.Click();
        }

        

        
    }
}
