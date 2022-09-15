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
    public class SignUpForm : Form
    {
        private IWebElement DisplayNameElement => SearchContext.FindElement(By.CssSelector("app-text-input[formcontrolname='displayName']"));

        public SignUpForm(IWebElement webElement) : base(webElement)
        {
        }

        public TextInputControl DisplayName => new TextInputControl(DisplayNameElement);

        public void SignUp()
        {
            ButtonElement.Click();
        }
    }
}
