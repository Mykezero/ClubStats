using System.Text.Json.Serialization;

namespace ClubStats.API.JSON
{
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