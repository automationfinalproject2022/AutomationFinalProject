using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SkiNet.Logging;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiNet.Library
{
    public class DriverManager
    {
        private static IWebDriver _driver;
        public IWebDriver Driver => _driver;

        public void Start()
        {
            if (_driver == null)
            {
                LogContext.Logger.Info("Starting the browser");
                _driver = new ChromeDriver();
                LoadUrl();
            }
        }

        private void LoadUrl(string url = null)
        {
            if (url == null)
            {
                url = Configuration.Url;
            }
            LogContext.Logger.Info("Loading the URL" + url);
            Driver.Url = url;
            Driver.Manage().Window.Maximize();
        }

        public void Quit() => Driver.Quit();
    }
}