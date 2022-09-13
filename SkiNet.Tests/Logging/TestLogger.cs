using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SkiNet.Logging;

namespace SkiNet.Tests.Logging
{
    public class TestLogger : ILogger
    {
        private void  Log(string prefix, string message) => TestContext.WriteLine(prefix + ": " + message);

        public void Error(string message) => Log(nameof(Error), message);

        public void Info(string message) => Log(nameof(Info), message);

        public void Warning(string message) => Log(nameof(Warning), message);

    }
}
