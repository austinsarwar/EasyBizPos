using Newtonsoft.Json;
using System.IO;

namespace EasyBizPos.Models
{
    internal class ConfigManager
    {
        private static readonly string ConfigFilePath = "config.json";
        private static ConfigManager instance;
        private ConfigData configData;

        private ConfigManager()
        {
            LoadConfig();
        }

        public static ConfigManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ConfigManager();
                }
                return instance;
            }
        }

        private void LoadConfig()
        {
            if (File.Exists(ConfigFilePath))
            {
                string json = File.ReadAllText(ConfigFilePath);
                configData = JsonConvert.DeserializeObject<ConfigData>(json);
            }
            else
            {
                configData = new ConfigData { SalesTaxRate = 0.08 };
                SaveConfig();
            }
        }

        public void SaveConfig()
        {
            string json = JsonConvert.SerializeObject(configData);
            File.WriteAllText(ConfigFilePath, json);
        }

        public double GetSalesTaxRate()
        {
            return configData.SalesTaxRate;
        }

        public void SetSalesTaxRate(double rate)
        {
            configData.SalesTaxRate = rate;
            SaveConfig();
        }

        private class ConfigData
        {
            public double SalesTaxRate { get; set; }
        }
    }
}
