using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Drawing.Printing;
using Microsoft.Extensions.Options;
using System.Configuration;

namespace ConfigEditorApi.src
{
    public class AppSettings
    {
        public static IConfiguration AppSetting { get; }
        static AppSettings()
        {
            AppSetting = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.Development.json")
                    .Build();
        }
    }
    public class Functions
    {
        public string[] GetAllFileName()
        {
            string[] Files = Directory.GetFiles(AppSettings.AppSetting["Configs.Dir"]);
            string[] FileNames = new string[Files.Length];

            for (int i = 0; i < Files.Length; i++)
                FileNames[i] = Path.GetFileNameWithoutExtension(Files[i]);
            return FileNames;
        }

        public string GetConfigText(string configName)
        {
            string dir = AppSettings.AppSetting["Configs.Dir"];
            string ConfigText;
            if (File.Exists(dir + configName))
                ConfigText = File.ReadAllText(dir + configName + ".json");
            else
                ConfigText = "File not found.";
            return ConfigText;


        }
    }
}
