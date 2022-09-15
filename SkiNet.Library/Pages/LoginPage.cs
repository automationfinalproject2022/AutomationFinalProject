using OpenQA.Selenium;
using SkiNet.Library.Abstract;
using SkiNet.Library.PageComponents.Controls;
using SkiNet.Library.PageComponents.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiNet.Library.Pages
{
    public class LoginPage : Page
    {
        private IWebElement LoginFormElement => Body.FindElement(By.CssSelector("app-login"));

        public LoginPage(IWebDriver webDriver) : base(webDriver)
        {
        }

        public LoginForm LoginForm => new LoginForm(LoginFormElement);         
    }
}
