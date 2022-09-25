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
    public class LoginForm : SecurityForm
    {             
        private IWebElement ForgotPasswordLink => SearchContext.FindElement(By.LinkText("Forgot password ?")); 
        
        public LoginForm(IWebElement webElement) : base(webElement)
        {
        }

        public void SignIn()
        {
            ButtonElement.Click();
        }
        
        public void ClickForgotPassword()
        {
            ForgotPasswordLink.Click();
        }         
    }
}
