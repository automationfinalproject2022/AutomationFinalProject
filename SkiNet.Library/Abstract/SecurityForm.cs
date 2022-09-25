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
    public abstract class SecurityForm : PageObject
    {
        private IWebElement TitleElement => SearchContext.FindElement(By.CssSelector("[class*='h3']"));
        //private IWebElement InputControlContainer => SearchContext.FindElement(By.TagName("app-text-input"));
        private IWebElement EmailElement => SearchContext.FindElement(By.CssSelector("app-text-input[formcontrolname='email']"));
        private IWebElement PasswordElement => SearchContext.FindElement(By.CssSelector("app-text-input[formcontrolname='password']"));
        
        protected IWebElement ButtonElement => SearchContext.FindElement(By.CssSelector("button[type='submit']")); 

        protected SecurityForm(IWebElement webElement) : base(webElement)
        {

        }

        public string Title => TitleElement.Text;
        public TextInputControl EmailAddress => new TextInputControl(EmailElement);
        public TextInputControl Password => new TextInputControl(PasswordElement);        
    }
}
