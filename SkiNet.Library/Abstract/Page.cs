using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiNet.Library.Abstract
{
    public abstract class Page
    {
        protected IWebDriver Driver { get; private set; }

        public Page(IWebDriver webDriver)
        {
            Driver = webDriver;
        }
    }
}
