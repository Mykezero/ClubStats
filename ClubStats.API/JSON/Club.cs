using System.Text.Json.Serialization;

namespace ClubStats.API.JSON
{
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
}