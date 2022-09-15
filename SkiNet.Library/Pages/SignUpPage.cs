using OpenQA.Selenium;
using SkiNet.Library.Abstract;
using SkiNet.Library.PageComponents.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiNet.Library.Pages
{
    public class SignUpPage : Page
    {
        private IWebElement SignUpFormElement => Body.FindElement(By.CssSelector("app-register"));

        public SignUpPage(IWebDriver webDriver) : base(webDriver)
        {
        }

        public SignUpForm SignUpForm => new SignUpForm(SignUpFormElement);
    }
}
