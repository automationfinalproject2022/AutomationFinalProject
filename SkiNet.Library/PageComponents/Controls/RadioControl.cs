using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkiNet.Library.Abstract;

namespace SkiNet.Library.PageComponents.Controls
{
    public class RadioControl : PageObject
    {
        //private IWebElement RadioElement => SearchContext.FindElement(By.CssSelector("input[type='radio']"));
        private IWebElement RadioElement => SearchContext.FindElement(By.ClassName("label-description"));

        public RadioControl(IWebElement webElement) : base(webElement)
        {
        }

        public void Tick()
        {
            RadioElement.Click();
        }
    }
}
