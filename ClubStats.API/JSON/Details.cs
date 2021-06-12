using System.Text.Json.Serialization;

namespace ClubStats.API.JSON
{
    public class Details
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("clubId")]
        public int ClubId { get; set; }

        [JsonPropertyName("regionId")]
        public int RegionId { get; set; }

        [JsonPropertyName("teamId")]
        public int TeamId { get; set; }

        [JsonPropertyName("customKit")]
        public CustomKit CustomKit { get; set; }
    }
}