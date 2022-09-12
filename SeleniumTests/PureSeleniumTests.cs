using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using SkiNet.Library.PageComponents;
using SkiNet.Library.PageComponents.Controls;
using SkiNet.Library.PageComponents.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTests
{
    public class PureSeleniumTests : BaseTests
    {
        protected override string Url => @"https://skinet.herokuapp.com/";

        [Test]
        public void SignUpUser()
        {
            
            IWebElement signUpButton = Driver.FindElement(By.CssSelector("a[href*='/account/register']"));
            signUpButton.Click();

            WebDriverWait webDriverWait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            IWebElement registerLabel = webDriverWait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("col-9")));
            Assert.IsTrue(registerLabel.Displayed);

            IWebElement displayName = Driver.FindElement(By.Id("Display Name"));
            displayName.SendKeys("Niki");

            IWebElement email = Driver.FindElement(By.Id("Email Address"));
            email.SendKeys("niki@ggg.com");

            IWebElement password = Driver.FindElement(By.Id("Password"));
            password.SendKeys("!Q2w3e4r");

            IWebElement registerButton = Driver.FindElement(By.CssSelector("button[type='submit']"));
            registerButton.Click();
        }

        [Test]
        public void Navigate()
        {
            App app = new App(Driver);

            app.Navigation.OpenLoginPage();

            //Thread.Sleep(1000);

            app.Navigation.OpenShopPage(); 

            //Thread.Sleep(1000);

            app.Navigation.OpenErrorsPage();

            //Thread.Sleep(1000);

            app.Navigation.OpenHomePage();

            Thread.Sleep(1000);

            app.Navigation.OpenSignUpPage();

            Thread.Sleep(4000);

        }

        [Test]
        public void Login()
        {
            App app = new App(Driver);

            app.Navigation.OpenLoginPage();
            Thread.Sleep(1000);

            //IWebElement email = Driver.FindElement(By.Id("Email Address"));
            app.LoginPage.LoginForm.EmailAddress.SetData("test");
            


            IWebElement password = Driver.FindElement(By.Id("Password"));
            password.SendKeys("!Q2w3e4r");

            app.LoginPage.LoginForm.SignIn();





            //app.LoginPage.LoginForm.ClickForgotPassword();

            Thread.Sleep(2000);

            /*
            string plc = app.LoginPage.LoginForm.EmailAddress.Placeholder;
            app.LoginPage.LoginForm.EmailAddress.SetData("a@a.com");
            app.LoginPage.LoginForm.Password.SetData("!Q2w3e4r");
            app.LoginPage.LoginForm.Action();

            Thread.Sleep(5000);
            */
        }


        [Test]
        public void Login2()
        {
            App app = new App(Driver);

            app.Navigation.OpenLoginPage();

            app.LoginPage.LoginForm.EmailAddress.SetData("a@a.com");
            app.LoginPage.LoginForm.Password.SetData("!Q2w3e4r");

            app.LoginPage.LoginForm.SignIn();
        }

        }
}
