using BikeGates.Models;
using Microsoft.Azure.Cosmos.Table;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BikeGates.Repositories
{
    public class BikeGatesRepository
    {
        private const string _BASEURL = "https://bikegatestrigger.azurewebsites.net/api";
        private const string _PARKOUR = "LeaderboardParkour";
        private const string _TIMERACE = "LeaderboardTimeRace";
        private const string _SURVIVAL = "LeaderboardSurvival";
        private static HttpClient GetHttpClient()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("accept", "application/json");
            return client;
        }

        public static async Task<List<Parkour>> GetParkour()
        {
            string url = $"{_BASEURL}/{_PARKOUR}";
            using (HttpClient client = GetHttpClient())
            {
                try
                {
                    string json = await client.GetStringAsync(url);
                    List<Parkour> list = JsonConvert.DeserializeObject<List<Parkour>>(json);

                    return list;
                }
                catch (Exception ex)
                {

                    throw ex; // hier altijd een breakpoint zetten
                    // je applicatie gaat niet stoppen op je foutmelding in xamarin
                }
            }
        }
    }
}
