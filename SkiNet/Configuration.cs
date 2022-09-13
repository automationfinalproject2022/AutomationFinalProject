using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SkiNet
{
    public static class Configuration
    {
        private static Dictionary<string, string> AppSettings { get; set; }

        static Configuration()
        {
            AppSettings = new Dictionary<string, string>();
            string? assemblyName = Assembly.GetCallingAssembly().GetName().Name;
            var config = GetAssemblyConfiguration(assemblyName);
            var appSettings = config.AppSettings.Settings;

            foreach (var setting in appSettings.AllKeys)
            {
                var value = appSettings[setting].Value;
                AppSettings.Add(setting, value);
            }

        }
        public static string Url => AppSettings[nameof(Url)];
        public static string Username => AppSettings[nameof(Username)];
        public static string Password => AppSettings[nameof(Password)];

        private static System.Configuration.Configuration GetAssemblyConfiguration(string assemblyName)
        {
            ExeConfigurationFileMap configFileMap = new ExeConfigurationFileMap();
            string filePath = string.Format("{0}\\{1}.dll.config", AppDomain.CurrentDomain.BaseDirectory, assemblyName);
            configFileMap.ExeConfigFilename = filePath;
            var config = ConfigurationManager.OpenMappedExeConfiguration(configFileMap, ConfigurationUserLevel.None);
            return config;
        }

    }
}
