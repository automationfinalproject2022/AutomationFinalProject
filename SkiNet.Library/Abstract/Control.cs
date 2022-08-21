using OpenQA.Selenium;
using SkiNet.Library.Abstract.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiNet.Library.Abstract
{
    public abstract class Control : PageObject, ISetData, IGetData
    {
        protected Control(IWebElement webElement) : base(webElement)
        {
        }

        public abstract dynamic ActualData { get; }

        public abstract void SetData(dynamic data);
    }
}
