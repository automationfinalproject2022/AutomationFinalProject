using OpenQA.Selenium;
using SkiNet.Library.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiNet.Library.PageComponents.Controls
{
    public class TextInputControl : Control
    {
        private IWebElement Input => SearchContext.FindElement(By.TagName("input"));

        public string Placeholder => Input.GetAttribute("placeholder");

        public TextInputControl(IWebElement webElement) : base(webElement)
        {
        }

        public override dynamic ActualData => Input.GetAttribute("value").ToString();

        public override void SetData(dynamic data)
        {
            Input.Clear();
            Input.SendKeys(data);
        }
    }
}
