using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using ClubStats.JSON;
using CsvSerializer;
using Newtonsoft.Json;
using Prism.Commands;
using Prism.Mvvm;
using RestSharp;

namespace ClubStats
{
    public class MainWindowViewModel : BindableBase
    {
        private string _teams;

        public string Teams
        {
            get => _teams;
            set => SetProperty(ref _teams, value);
        }
        
        public DelegateCommand DownloadCommand { get; set; }

        private string _statusBar;
        
        public string StatusBar
        {
            get => _statusBar;
            set => SetProperty(ref _statusBar, value);
        }

        public MainWindowViewModel()
        {
            DownloadCommand = new DelegateCommand(Download);
        }

        public class API
        {
            private readonly RestClient _client;

            public API()
            {
                this._client = CreateClient();
            }
            
            private static RestClient CreateClient()
            {
                RestClient client = new RestClient("https://proclubs.ea.com/api/nhl");
                client.AddDefaultHeaders(new Dictionary<string, string>()
                {
                    {"accept", "application/json"},
                    {"Referer", "https://www.ea.com/"}
                });
                return client;
            }

            /// <summary>
            /// Search club names and returns the corresponding club ids
            /// </summary>
            /// <param name="clubNames"></param>
            /// <returns></returns>
            public IDictionary<string, string> SearchClubs(List<string> clubNames)
            {
                Dictionary<string, string> results = new Dictionary<string, string>();
                
                foreach (string clubName in clubNames)
                {
                    IRestResponse response = _client.Execute(new RestRequest($"/clubs/search?platform=xboxone&clubName={System.Web.HttpUtility.UrlEncode(clubName)}"));
                    string? clubId = JsonConvert.DeserializeObject<Dictionary<string, object>>(response.Content)?.Keys.FirstOrDefault();
                    if (!string.IsNullOrEmpty(clubId))
                    {
                        results.Add(clubId, clubName);
                    }
                }
                
                return results;
            }

            public List<ClubMatches> GetClubMatches(KeyValuePair<string,string> club)
            {
                RestRequest request = new RestRequest($"/clubs/matches?matchType=club_private&platform={"xboxone"}&clubIds={club.Key}", Method.GET, DataFormat.Json);
                IRestResponse response = _client.Execute(request);
                return JsonConvert.DeserializeObject<List<ClubMatches>>(response.Content);
            }
        }

        private void Download()
        {
            API api = new API();
            List<string> clubNames = _teams.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToList();
            IDictionary<string, string> clubs = api.SearchClubs(clubNames);

            IDictionary<string, IList<ClubMatches>> clubMatches = new Dictionary<string, IList<ClubMatches>>();

            foreach (KeyValuePair<string,string> club in clubs)
            {
                clubMatches.Add(club.Key, api.GetClubMatches(club));
            }

            StringBuilder sb = new StringBuilder();

            List<PlayerStats> playerStats = new List<PlayerStats>();
            
            foreach (KeyValuePair<string,IList<ClubMatches>> clubMatch in clubMatches)
            {
                string? clubName = clubMatch.Value.Take(1).Select(x => x.Clubs[clubMatch.Key].Details.Name).FirstOrDefault() ?? "Unknown";

                foreach (var game in clubMatch.Value)
                {
                    foreach (KeyValuePair<string, IDictionary<string, Player>> club in game.Players)
                    {
                        foreach (var player in club.Value.Select(x => x.Value))
                        {
                            PlayerStats data = new PlayerStats
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
                                Date = FromUnixTime(game.Timestamp),	
                                GameID = string.Join(" vs ", game.Clubs.Select(x => x.Value.Details.Name)),
                            };
                        
                            playerStats.Add(data);
                        }
                    }
                }

                using FileStream fileStream = File.Create("stats.csv");
                Serializer serializer = new CsvSerializer.Serializer();
                serializer.Serialize(fileStream, playerStats, false);
            }
            

            // IRestResponse response = client.Execute(request);
        }
        
        private static readonly DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public static DateTime FromUnixTime(long unixTime)
        {
            return epoch.AddSeconds(unixTime);
        }

    }

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