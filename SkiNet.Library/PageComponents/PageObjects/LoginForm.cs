using OpenQA.Selenium;
using SkiNet.Library.Abstract;
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

        public LoginForm(IWebElement webElement) : base(webElement)
        {
        }

        protected override void Action(IWebElement webElement)
        {
            webElement.Click();
        }

        public void SignIn()
        {
            Action(ActionButton);
        }

        public void ForgotPassword()
        {
            throw new NotImplementedException();
        }

         
    }
}
