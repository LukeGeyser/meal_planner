using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MealPlanner.Services
{
    class MapsAPI
    {

        string url = String.Format("https://maps.googleapis.com/maps/api/place/nearbysearch/json?");

        private const string _PrivateKey = "AIzaSyCxTWHUpzXjM1twanD2-wMkYCBRnx7v7DE";

        public async static Task<string> CallGoogleMapAPIAsync(string url, string lat, string lon)
        {
            string completeUrl = String.Format("{0}location={1},{2}&radius={3}&type={4}&key={5}", url, lat, lon, 10000, "supermarket", _PrivateKey);

            // Call out to Marvel
            HttpClient http = new HttpClient();
            var response = await http.GetAsync(completeUrl);
            return await response.Content.ReadAsStringAsync();
        }
    }
}
