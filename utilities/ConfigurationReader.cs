using System;
using System.Configuration;

namespace csharp_cucumber_selenium_framework.utilities
{
    public static class ConfigurationReader
    {
        public static string GetProperty(string keyword)
        {
            try
            {
                return ConfigurationManager.AppSettings[keyword];
            }
            catch (ConfigurationErrorsException ex)
            {
                Console.WriteLine($"Error reading app settings: {ex.Message}");
                return null;
            }
        }
    }
}