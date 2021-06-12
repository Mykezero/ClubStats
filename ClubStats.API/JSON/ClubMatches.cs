using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ClubStats.API.JSON
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    // Source: https://json2csharp.com/
    public class ClubMatches
    {
        [JsonPropertyName("matchId")]
        public string MatchId { get; set; }

        [JsonPropertyName("timestamp")]
        public int Timestamp { get; set; }

        [JsonPropertyName("timeAgo")]
        public TimeAgo TimeAgo { get; set; }

        [JsonPropertyName("clubs")]
        public IDictionary<string, Club> Clubs { get; set; } = new Dictionary<string, Club>();

        [JsonPropertyName("players")]
        public IDictionary<string, IDictionary<string, Player>> Players { get; set; } = new Dictionary<string, IDictionary<string, Player>>();

        [JsonPropertyName("aggregate")]
        public IDictionary<string, Club> Aggregate { get; set; } = new Dictionary<string, Club>();
    }
}