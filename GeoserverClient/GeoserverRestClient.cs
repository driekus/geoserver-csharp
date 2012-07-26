using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using GeoserverClient.Model;
using Newtonsoft.Json;
using RestSharp;

namespace GeoserverClient
{
    public class GeoserverRestClient
    {
        private HttpWebRequest request;
        private const string BaseUrl = "http://geoserver.nl/rest/agn";
        static readonly RestClient Client = new RestClient(BaseUrl);
        
        public static void GetAdressen(string postcode6, int huisnummer, Action<List<Adres>> callback )
        {
            var request = new RestRequest("adressen");
            request.AddParameter("postcode", postcode6);
            request.AddParameter("huisnummer", huisnummer);
            Client.ExecuteAsync<List<Adres>>(request, response => callback(response.Data));
        }
    }
}
