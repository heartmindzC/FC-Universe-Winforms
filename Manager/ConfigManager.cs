using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FC_Universe_Winforms.Manager
{
    class ConfigManager
    {
        private static readonly string configPath =System.IO.Path.Combine(Application.StartupPath,"config.json");

        public static AppConfig Config { get; private set; } = new AppConfig();

        public static void Load()
        {
            try
            {
                if (File.Exists(configPath))
                {
                    string json = File.ReadAllText(configPath);
                    Config = JsonSerializer.Deserialize<AppConfig>(json) ?? new AppConfig();
                }
                else
                {
                    Config = new AppConfig();
                }
            }
            catch
            {
                Config = new AppConfig(); // fallback nếu file hỏng
            }
        }

        public static void Save()
        {
            Directory.CreateDirectory(Path.GetDirectoryName(configPath));
            string json = JsonSerializer.Serialize(Config, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(configPath, json);
        }
    }
}
