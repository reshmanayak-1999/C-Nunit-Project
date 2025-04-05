using Newtonsoft.Json;
using System;
using System.IO;  // Missing namespace
using System.Collections.Generic;

namespace C__Nunit_Project.Utils
{
    public class ConfigData
    {
        public string Baseurl { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        // Add other properties matching your JSON structure
    }

    public class ConfigReader
    {
        private string testData;
        private ConfigData config;

        public ConfigReader()
        {
            string projectRoot = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;
            string filePath = Path.Combine(projectRoot, "Resources", "appsettings.json");

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"Could not find appsettings.json at {filePath}");
            }

            testData = File.ReadAllText(filePath);
            config = JsonConvert.DeserializeObject<ConfigData>(testData);
        }

        public ConfigData GetConfig()
        {
            return config;
        }
    }
}

