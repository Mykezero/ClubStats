using System;

namespace ClubStats.API.Models
{
    internal class PlayerStats
    {
        public string Player { get; set; }
        public string Position { get; set; }
        public int Goals { get; set; }
        public int Assists { get; set; }
        public int Points { get; set; }
        public int PlusMinus { get; set; }
        public int Shots { get; set; }
        public string PenaltyMinutes { get; set; }
        public int Hits { get; set; }
        public int FaceoffWins { get; set; }
        public int Giveaways { get; set; }
        public int Takeaways { get; set; }
        public int Saves { get; set; }
        public int GoalieShots { get; set; }
        public int GoalsAgainst { get; set; }
        public decimal SavePercentage { get; set; }
        public string Team { get; set; }
        public DateTime Date { get; set; }
        public string GameID { get; set; }
    }
}