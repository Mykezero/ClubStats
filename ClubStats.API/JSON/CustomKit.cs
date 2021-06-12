using System.Text.Json.Serialization;

namespace ClubStats.API.JSON
{
    public class CustomKit
    {
        [JsonPropertyName("isCustomTeam")]
        public string IsCustomTeam { get; set; }

        [JsonPropertyName("crestAssetId")]
        public string CrestAssetId { get; set; }

        [JsonPropertyName("useBaseAsset")]
        public string UseBaseAsset { get; set; }
    }
}