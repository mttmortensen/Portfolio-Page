using System.Text.Json;

namespace Portfolio_Page.Services
{
    public static class JsonUtil
    {
        public static T LoadJson<T>(string relativePath, string rootPath) 
        {
            var filePath = Path.Combine(rootPath, relativePath);
            if (!File.Exists(filePath))
                throw new FileNotFoundException($"JSON File not found at {filePath}");

            var json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<T>(json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
        }
    }
}
