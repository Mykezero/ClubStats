using System.Collections.Generic;
using System.Linq;
using ClubStats.API.JSON;
using Newtonsoft.Json;
using RestSharp;

namespace ClubStats.API
{
    public class NhlApi
    {
        private readonly RestClient _client;

        public NhlApi()
        {
            _client = CreateClient();
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
        public IDictionary<string, string> SearchClubs(IEnumerable<string> clubNames)
        {
            Dictionary<string, string> results = new Dictionary<string, string>();
                
            foreach (string clubName in clubNames)
            {
                IRestResponse response = _client.Execute(new RestRequest($"/clubs/search?platform=xboxone&clubName={System.Web.HttpUtility.UrlEncode(clubName)}"));
                string clubId = JsonConvert.DeserializeObject<Dictionary<string, object>>(response.Content)?.Keys.FirstOrDefault();
                if (!string.IsNullOrEmpty(clubId))
                {
                    results.Add(clubId, clubName);
                }
            }
                
            return results;
        }

        public List<ClubMatches> GetClubMatches(KeyValuePair<string,string> club)
        {
            RestRequest request = new RestRequest($"/clubs/matches?matchType=gameType5&platform=xboxone&clubIds={club.Key}", Method.GET, DataFormat.Json);
            IRestResponse response = _client.Execute(request);
            return JsonConvert.DeserializeObject<List<ClubMatches>>(response.Content);
        }
    }
}