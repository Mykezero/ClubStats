using System.Collections.Generic;
using System.Linq;
using ClubStats.API.Helpers;
using ClubStats.API.Models;

namespace ClubStats.API
{
    public class NhlService
    {
        private readonly NhlApi _api;

        public NhlService(NhlApi api)
        {
            _api = api;
        }
        
        public void DownloadStats(IEnumerable<string> clubNames, string filename)
        {
            List<PlayerStats> playerStats = GetPlayerStats(clubNames);
            IoHelper.SaveCsv(playerStats, filename);
        }

        private List<PlayerStats> GetPlayerStats(IEnumerable<string> clubNames)
        {
            IDictionary<string, string> clubs = _api.SearchClubs(clubNames);

            IDictionary<string, IList<JSON.ClubMatches>> clubMatches = new Dictionary<string, IList<JSON.ClubMatches>>();

            foreach (KeyValuePair<string, string> club in clubs)
            {
                clubMatches.Add(club.Key, _api.GetClubMatches(club));
            }

            return (from clubMatch in clubMatches
                from game in clubMatch.Value
                from club in game.Players
                from player in club.Value.Select(x => x.Value)
                select new PlayerStats
                {
                    Player = player.Playername,
                    Position = player.Position,
                    Goals = player.Skgoals,
                    Assists = player.Skassists,
                    Points = player.Skgoals + player.Skassists,
                    PlusMinus = player.Skplusmin,
                    PenaltyMinutes = player.Skpim,
                    Shots = player.Skshots,
                    Hits = player.Skhits,
                    FaceoffWins = player.Skfow,
                    Giveaways = player.Skgiveaways,
                    Takeaways = player.Sktakeaways,
                    Saves = player.Glsaves,
                    GoalieShots = player.Glshots,
                    GoalsAgainst = player.Glga,
                    SavePercentage = player.Glsavepct,
                    Team = game.Clubs[club.Key].Details.Name,
                    Date = TimeHelper.FromUnixTime(game.Timestamp),
                    GameID = string.Join(" vs ", game.Clubs.Select(x => x.Value.Details.Name)),
                }).ToList();
        }
    }
}