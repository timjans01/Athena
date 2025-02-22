using Spectre.Console;
using Newtonsoft.Json;
using Athena.Managers;

namespace Athena.Models;

public class Config
{
    public static Config config = null!;

    public string athenaProfileId { get; set; } = "AthenaProfile";
    public string accessToken { get; set; } = string.Empty; // for who download the program, to avoid errors
    public string profileDirectory { get; set; } = DirectoryManager.Profiles;
    public string shopDirectory { get; set; } = DirectoryManager.Profiles;

    public static void LoadSettings()
    {
        config = new Config();

        if (!File.Exists(Path.Combine(DirectoryManager.Settings, "settings.json")))
        {
            // Save the default settings
            Save();
        }
        else
        {
            config = JsonConvert.DeserializeObject<Config>(File.ReadAllText(Path.Combine(DirectoryManager.Settings, "settings.json")))!;
        }
    }

    public static void Save()
    {
        File.WriteAllText(Path.Combine(DirectoryManager.Settings, "settings.json"), JsonConvert.SerializeObject(config, Formatting.Indented));
    }
}
