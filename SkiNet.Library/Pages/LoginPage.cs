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
         private IWebElement _loginForm => Body.FindElement(By.CssSelector("form[class*='valid']"));

        public LoginPage(IWebDriver webDriver) : base(webDriver)
        {
        }

        public LoginForm LoginForm => new LoginForm(_loginForm);         
    }
}
