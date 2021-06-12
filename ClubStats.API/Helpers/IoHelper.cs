using System.IO;
using CsvSerializer;
using Newtonsoft.Json;

namespace ClubStats.API.Helpers
{
    public static class IoHelper
    {
        public static void SaveCsv(object data, string filename)
        {
            using FileStream fileStream = File.Create(filename);
            Serializer serializer = new Serializer();
            serializer.Serialize(fileStream, data, false);
        }

        public static T LoadJson<T>(string filename)
        {
            return File.Exists(filename) && !string.IsNullOrEmpty(File.ReadAllText(filename))
                ? JsonConvert.DeserializeObject<T>(File.ReadAllText(filename))
                : default;
        }

        public static void SaveJson<T>(string filename, T value)
        {
            File.WriteAllText(filename, JsonConvert.SerializeObject(value));
        }
    }
}