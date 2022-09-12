using OpenQA.Selenium;
using SkiNet.Library.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiNet.Library.Pages
{
    public class HomePage : Page
    {
        public HomePage(IWebDriver webDriver) : base(webDriver)
        {
        }

        private IWebElement TitleElement => Body.FindElement(By.TagName("h1"));

        public string Title => TitleElement.Text;
    }
}
