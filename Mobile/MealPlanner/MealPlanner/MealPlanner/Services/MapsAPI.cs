using MealPlanner.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using static MealPlanner.Models.MapResultDataWrapper;

namespace MealPlanner.Services
{
    class MapsAPI
    {

        private string url = String.Format("https://maps.googleapis.com/maps/api/place/nearbysearch/json?");

        private const string _PrivateKey = "AIzaSyCxTWHUpzXjM1twanD2-wMkYCBRnx7v7DE";

        public async Task PopulateMaps(ObservableCollection<Result> stores, string lat, string lon)
        {
            var mapResults = await GetMapResiltDataWrapperAsync(url, lat, lon);

            var storesList = mapResults.results;

            foreach (var store in storesList)
            {
                stores.Add(store);
            }
        }

        public async static Task<string> CallGoogleMapAPIAsync(string url, string lat, string lon)
        {
            string completeUrl = String.Format("{0}location={1},{2}&radius={3}&type={4}&key={5}", url, lat, lon, 10000, "supermarket", _PrivateKey);

            // Call out to Marvel
            HttpClient http = new HttpClient();
            var response = await http.GetAsync(completeUrl);
            return await response.Content.ReadAsStringAsync();
        }

        private static async Task<RootObject> GetMapResiltDataWrapperAsync(string url, string lat, string lon)
        {
            var jsonMessage = await CallGoogleMapAPIAsync(url, lat, lon);

            // Response -> string / json -> deserialize
            var serializer = new DataContractJsonSerializer(typeof(RootObject));
            var ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonMessage));

            var result = (RootObject)serializer.ReadObject(ms);
            return result;
        }

    }
}
