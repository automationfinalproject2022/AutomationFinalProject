using SkiNet.Library;
using SkiNet.Library.PageComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiNet.Tests.Hooks
{
    [Binding]
    public class Base_Tests
    {
        protected DriverManager DriverManager { get; set; }
        protected App App { get; set; }

        [BeforeScenario]
        public void StartBrowser()
        {
            DriverManager = new DriverManager();
            DriverManager.Start();
            App = new App(DriverManager.Driver);
        }

        [AfterScenario]
        public void StopBrowser()
        {
            DriverManager.Quit();
        }
    }
}
