using OpenQA.Selenium;
using SkiNet.Library.Abstract;
using SkiNet.Library.PageComponents.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiNet.Library.PageComponents.PageObjects
{
    public class LoginForm : Form
    {             
        private IWebElement _forgotPasswordLink => SearchContext.FindElement(By.LinkText("Forgot password ?"));        
        protected override IWebElement ActionElement => SearchContext.FindElement(By.CssSelector("button[type='submit']")); //TODO: Rework

        public LoginForm(IWebElement webElement) : base(webElement)
        {
        }

        public void SignIn()
        {
            ActionElement.Click();
        }
        
        public void ClickForgotPassword()
        {
            _forgotPasswordLink.Click();
        }         
    }
}
