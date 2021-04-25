using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ClubStats.JSON
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
    
    public class TimeAgo
    {
        [JsonPropertyName("number")]
        public int Number { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }

    public class CustomKit
    {
        [JsonPropertyName("isCustomTeam")]
        public string IsCustomTeam { get; set; }

        [JsonPropertyName("crestAssetId")]
        public string CrestAssetId { get; set; }

        [JsonPropertyName("useBaseAsset")]
        public string UseBaseAsset { get; set; }
    }

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

    public class Club
    {
        [JsonPropertyName("clubDivision")]
        public string ClubDivision { get; set; }

        [JsonPropertyName("cNhlOnlineGameType")]
        public string CNhlOnlineGameType { get; set; }

        [JsonPropertyName("garaw")]
        public string Garaw { get; set; }

        [JsonPropertyName("gfraw")]
        public string Gfraw { get; set; }

        [JsonPropertyName("losses")]
        public string Losses { get; set; }

        [JsonPropertyName("memberString")]
        public string MemberString { get; set; }

        [JsonPropertyName("opponentClubId")]
        public string OpponentClubId { get; set; }

        [JsonPropertyName("opponentScore")]
        public string OpponentScore { get; set; }

        [JsonPropertyName("opponentTeamArtAbbr")]
        public string OpponentTeamArtAbbr { get; set; }

        [JsonPropertyName("passa")]
        public string Passa { get; set; }

        [JsonPropertyName("passc")]
        public string Passc { get; set; }

        [JsonPropertyName("ppg")]
        public string Ppg { get; set; }

        [JsonPropertyName("ppo")]
        public string Ppo { get; set; }

        [JsonPropertyName("result")]
        public string Result { get; set; }

        [JsonPropertyName("score")]
        public string Score { get; set; }

        [JsonPropertyName("scoreString")]
        public string ScoreString { get; set; }

        [JsonPropertyName("shots")]
        public string Shots { get; set; }

        [JsonPropertyName("teamArtAbbr")]
        public string TeamArtAbbr { get; set; }

        [JsonPropertyName("teamSide")]
        public string TeamSide { get; set; }

        [JsonPropertyName("toa")]
        public string Toa { get; set; }

        [JsonPropertyName("winnerByDnf")]
        public string WinnerByDnf { get; set; }

        [JsonPropertyName("winnerByGoalieDnf")]
        public string WinnerByGoalieDnf { get; set; }

        [JsonPropertyName("details")]
        public Details Details { get; set; }

        [JsonPropertyName("goals")]
        public string Goals { get; set; }

        [JsonPropertyName("goalsAgainst")]
        public string GoalsAgainst { get; set; }

        [JsonPropertyName("class")]
        public int Class { get; set; }

        [JsonPropertyName("glbrksavepct")]
        public double Glbrksavepct { get; set; }

        [JsonPropertyName("glbrksaves")]
        public int Glbrksaves { get; set; }

        [JsonPropertyName("glbrkshots")]
        public int Glbrkshots { get; set; }

        [JsonPropertyName("gldsaves")]
        public int Gldsaves { get; set; }

        [JsonPropertyName("glga")]
        public int Glga { get; set; }

        [JsonPropertyName("glgaa")]
        public double Glgaa { get; set; }

        [JsonPropertyName("glpensavepct")]
        public double Glpensavepct { get; set; }

        [JsonPropertyName("glpensaves")]
        public int Glpensaves { get; set; }

        [JsonPropertyName("glpenshots")]
        public int Glpenshots { get; set; }

        [JsonPropertyName("glpkclearzone")]
        public int Glpkclearzone { get; set; }

        [JsonPropertyName("glpokechecks")]
        public int Glpokechecks { get; set; }

        [JsonPropertyName("glsavepct")]
        public double Glsavepct { get; set; }

        [JsonPropertyName("glsaves")]
        public int Glsaves { get; set; }

        [JsonPropertyName("glshots")]
        public int Glshots { get; set; }

        [JsonPropertyName("glsoperiods")]
        public int Glsoperiods { get; set; }

        [JsonPropertyName("isGuest")]
        public int IsGuest { get; set; }

        [JsonPropertyName("opponentTeamId")]
        public int OpponentTeamId { get; set; }

        [JsonPropertyName("player_dnf")]
        public int PlayerDnf { get; set; }

        [JsonPropertyName("playerLevel")]
        public int PlayerLevel { get; set; }

        [JsonPropertyName("pNhlOnlineGameType")]
        public int PNhlOnlineGameType { get; set; }

        [JsonPropertyName("position")]
        public string Position { get; set; }

        [JsonPropertyName("posSorted")]
        public int PosSorted { get; set; }

        [JsonPropertyName("ratingDefense")]
        public double RatingDefense { get; set; }

        [JsonPropertyName("ratingOffense")]
        public double RatingOffense { get; set; }

        [JsonPropertyName("ratingTeamplay")]
        public double RatingTeamplay { get; set; }

        [JsonPropertyName("skassists")]
        public int Skassists { get; set; }

        [JsonPropertyName("skbs")]
        public int Skbs { get; set; }

        [JsonPropertyName("skdeflections")]
        public int Skdeflections { get; set; }

        [JsonPropertyName("skfol")]
        public int Skfol { get; set; }

        [JsonPropertyName("skfopct")]
        public double Skfopct { get; set; }

        [JsonPropertyName("skfow")]
        public int Skfow { get; set; }

        [JsonPropertyName("skgiveaways")]
        public int Skgiveaways { get; set; }

        [JsonPropertyName("skgoals")]
        public int Skgoals { get; set; }

        [JsonPropertyName("skgwg")]
        public int Skgwg { get; set; }

        [JsonPropertyName("skhits")]
        public int Skhits { get; set; }

        [JsonPropertyName("skinterceptions")]
        public int Skinterceptions { get; set; }

        [JsonPropertyName("skpassattempts")]
        public int Skpassattempts { get; set; }

        [JsonPropertyName("skpasses")]
        public int Skpasses { get; set; }

        [JsonPropertyName("skpasspct")]
        public double Skpasspct { get; set; }

        [JsonPropertyName("skpenaltiesdrawn")]
        public int Skpenaltiesdrawn { get; set; }

        [JsonPropertyName("skpim")]
        public int Skpim { get; set; }

        [JsonPropertyName("skpkclearzone")]
        public int Skpkclearzone { get; set; }

        [JsonPropertyName("skplusmin")]
        public int Skplusmin { get; set; }

        [JsonPropertyName("skpossession")]
        public int Skpossession { get; set; }

        [JsonPropertyName("skppg")]
        public int Skppg { get; set; }

        [JsonPropertyName("sksaucerpasses")]
        public int Sksaucerpasses { get; set; }

        [JsonPropertyName("skshg")]
        public int Skshg { get; set; }

        [JsonPropertyName("skshotattempts")]
        public int Skshotattempts { get; set; }

        [JsonPropertyName("skshotonnetpct")]
        public double Skshotonnetpct { get; set; }

        [JsonPropertyName("skshotpct")]
        public double Skshotpct { get; set; }

        [JsonPropertyName("skshots")]
        public int Skshots { get; set; }

        [JsonPropertyName("sktakeaways")]
        public int Sktakeaways { get; set; }

        [JsonPropertyName("teamId")]
        public int TeamId { get; set; }

        [JsonPropertyName("toi")]
        public int Toi { get; set; }

        [JsonPropertyName("toiseconds")]
        public int Toiseconds { get; set; }
    }

    public class Player
    {
        [JsonPropertyName("class")]
        public string Class { get; set; }

        [JsonPropertyName("glbrksavepct")]
        public string Glbrksavepct { get; set; }

        [JsonPropertyName("glbrksaves")]
        public string Glbrksaves { get; set; }

        [JsonPropertyName("glbrkshots")]
        public string Glbrkshots { get; set; }

        [JsonPropertyName("gldsaves")]
        public string Gldsaves { get; set; }

        [JsonPropertyName("glga")]
        public int Glga { get; set; }

        [JsonPropertyName("glgaa")]
        public string Glgaa { get; set; }

        [JsonPropertyName("glpensavepct")]
        public string Glpensavepct { get; set; }

        [JsonPropertyName("glpensaves")]
        public string Glpensaves { get; set; }

        [JsonPropertyName("glpenshots")]
        public string Glpenshots { get; set; }

        [JsonPropertyName("glpkclearzone")]
        public string Glpkclearzone { get; set; }

        [JsonPropertyName("glpokechecks")]
        public string Glpokechecks { get; set; }

        [JsonPropertyName("glsavepct")]
        public decimal Glsavepct { get; set; }

        [JsonPropertyName("glsaves")]
        public int Glsaves { get; set; }

        [JsonPropertyName("glshots")]
        public int Glshots { get; set; }

        [JsonPropertyName("glsoperiods")]
        public string Glsoperiods { get; set; }

        [JsonPropertyName("isGuest")]
        public string IsGuest { get; set; }

        [JsonPropertyName("opponentClubId")]
        public string OpponentClubId { get; set; }

        [JsonPropertyName("opponentScore")]
        public string OpponentScore { get; set; }

        [JsonPropertyName("opponentTeamId")]
        public string OpponentTeamId { get; set; }

        [JsonPropertyName("player_dnf")]
        public string PlayerDnf { get; set; }

        [JsonPropertyName("playerLevel")]
        public string PlayerLevel { get; set; }

        [JsonPropertyName("pNhlOnlineGameType")]
        public string PNhlOnlineGameType { get; set; }

        [JsonPropertyName("position")]
        public string Position { get; set; }

        [JsonPropertyName("posSorted")]
        public string PosSorted { get; set; }

        [JsonPropertyName("ratingDefense")]
        public string RatingDefense { get; set; }

        [JsonPropertyName("ratingOffense")]
        public string RatingOffense { get; set; }

        [JsonPropertyName("ratingTeamplay")]
        public string RatingTeamplay { get; set; }

        [JsonPropertyName("score")]
        public string Score { get; set; }

        [JsonPropertyName("skassists")]
        public int Skassists { get; set; }

        [JsonPropertyName("skbs")]
        public string Skbs { get; set; }

        [JsonPropertyName("skdeflections")]
        public string Skdeflections { get; set; }

        [JsonPropertyName("skfol")]
        public string Skfol { get; set; }

        [JsonPropertyName("skfopct")]
        public string Skfopct { get; set; }

        [JsonPropertyName("skfow")]
        public int Skfow { get; set; }

        [JsonPropertyName("skgiveaways")]
        public int Skgiveaways { get; set; }

        [JsonPropertyName("skgoals")]
        public int Skgoals { get; set; }

        [JsonPropertyName("skgwg")]
        public string Skgwg { get; set; }

        [JsonPropertyName("skhits")]
        public int Skhits { get; set; }

        [JsonPropertyName("skinterceptions")]
        public string Skinterceptions { get; set; }

        [JsonPropertyName("skpassattempts")]
        public string Skpassattempts { get; set; }

        [JsonPropertyName("skpasses")]
        public string Skpasses { get; set; }

        [JsonPropertyName("skpasspct")]
        public string Skpasspct { get; set; }

        [JsonPropertyName("skpenaltiesdrawn")]
        public string Skpenaltiesdrawn { get; set; }

        [JsonPropertyName("skpim")]
        public string Skpim { get; set; }

        [JsonPropertyName("skpkclearzone")]
        public string Skpkclearzone { get; set; }

        [JsonPropertyName("skplusmin")]
        public int Skplusmin { get; set; }

        [JsonPropertyName("skpossession")]
        public string Skpossession { get; set; }

        [JsonPropertyName("skppg")]
        public string Skppg { get; set; }

        [JsonPropertyName("sksaucerpasses")]
        public string Sksaucerpasses { get; set; }

        [JsonPropertyName("skshg")]
        public string Skshg { get; set; }

        [JsonPropertyName("skshotattempts")]
        public string Skshotattempts { get; set; }

        [JsonPropertyName("skshotonnetpct")]
        public string Skshotonnetpct { get; set; }

        [JsonPropertyName("skshotpct")]
        public string Skshotpct { get; set; }

        [JsonPropertyName("skshots")]
        public int Skshots { get; set; }

        [JsonPropertyName("sktakeaways")]
        public int Sktakeaways { get; set; }

        [JsonPropertyName("teamId")]
        public string TeamId { get; set; }

        [JsonPropertyName("teamSide")]
        public string TeamSide { get; set; }

        [JsonPropertyName("toi")]
        public string Toi { get; set; }

        [JsonPropertyName("toiseconds")]
        public string Toiseconds { get; set; }

        [JsonPropertyName("playername")]
        public string Playername { get; set; }
    }
}