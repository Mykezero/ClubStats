using System.Text.Json.Serialization;

namespace ClubStats.API.JSON
{
    public class TimeAgo
    {
        [JsonPropertyName("number")]
        public int Number { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }
}