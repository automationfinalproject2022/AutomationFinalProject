using OpenQA.Selenium;
using SkiNet.Library.PageComponents.PageObjects;
using SkiNet.Library.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiNet.Library.PageComponents
{
    public class App
    {
        private IWebDriver Driver { get; init; }

        public App(IWebDriver driver)
        {
            Driver = driver;
            HomePage = new(Driver);
            ShopPage = new(Driver);
            ErrorsPage = new(Driver);
            LoginPage = new(Driver);
            SignUpPage = new(Driver);
        }

        public HomePage HomePage { get; init; }

        public ShopPage ShopPage { get; init; }

        public ErrorsPage ErrorsPage { get; init; }

        public LoginPage LoginPage { get; init; }

        public SignUpPage SignUpPage { get; init; }

        public Navigation Navigation => new(Driver.FindElement(By.ClassName("flex-column")));
    }
}