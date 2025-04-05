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
            testData = File.ReadAllText("C:\\Users\\Reshma\\source\\repos\\C# Nunit Project\\C# Nunit Project\\Resources\\appsettings.json");
            config = JsonConvert.DeserializeObject<ConfigData>(testData);
        }

        public ConfigData GetConfig()
        {
            return config;
        }
    }
}

