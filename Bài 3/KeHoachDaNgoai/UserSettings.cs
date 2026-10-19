using System.IO;
using System.Text.Json;

public class UserSettings
{
    public string Language { get; set; } = "vi-VN"; // "vi-VN" hoặc "en-US"

    private static string GetConfigPath()
    {
        string dir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "QL_DaNgoai");
        Directory.CreateDirectory(dir);
        return Path.Combine(dir, "usersettings.json");
    }

    public static UserSettings Load()
    {
        try
        {
            string path = GetConfigPath();
            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                return JsonSerializer.Deserialize<UserSettings>(json) ?? new UserSettings();
            }
        }
        catch { }
        return new UserSettings();
    }

    public void Save()
    {
        try
        {
            string path = GetConfigPath();
            string json = JsonSerializer.Serialize(this);
            File.WriteAllText(path, json);
        }
        catch { }
    }
}