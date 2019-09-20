﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static MealPlannerDesktop.MapResultDataWrapper;

namespace MealPlannerDesktop
{
    class MapsAPI
    {
        private string url = String.Format("https://maps.googleapis.com/maps/api/place/nearbysearch/json?");

        private const string _PrivateKey = "AIzaSyCxTWHUpzXjM1twanD2-wMkYCBRnx7v7DE";

        public async Task PopulateMaps(ObservableCollection<Result> stores, 
                            double lat, double lon, string shopName)
        {
            stores.Clear();
            var mapResults = await GetMapResiltDataWrapperAsync(url, lat, lon, shopName);

            var storesList = mapResults.results;

            foreach (var store in storesList)
            {
                stores.Add(store);
            }
        }

        public async static Task<string> CallGoogleMapAPIAsync(string url, double lat, double lon, string shopName)
        {
            string completeUrl = String.Format("{0}location={1},{2}&name={3}&rankby={4}&type={5}&key={6}", url, 
                lat.ToString(CultureInfo.InvariantCulture), lon.ToString(CultureInfo.InvariantCulture), shopName,
                "distance", "supermarket", _PrivateKey);
            // Call out to Marvel
            HttpClient http = new HttpClient();
            var response = await http.GetAsync(completeUrl);
            return await response.Content.ReadAsStringAsync();
        }

        private static async Task<RootObject> GetMapResiltDataWrapperAsync(string url, double lat, double lon, string shopName)
        {
            var jsonMessage = await CallGoogleMapAPIAsync(url, lat, lon, shopName);

            // Response -> string / json -> deserialize
            var serializer = new DataContractJsonSerializer(typeof(RootObject));
            var ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonMessage));

            var result = (RootObject)serializer.ReadObject(ms);
            return result;
        }
    }
}
