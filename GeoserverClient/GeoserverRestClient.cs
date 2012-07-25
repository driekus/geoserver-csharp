using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace GeoserverClient
{
 
    public class GeoserverRestClient
    {
        private HttpWebRequest request;
        // https://github.com/restsharp/RestSharp/blob/master/RestSharp/RestClient.Async.cs
        // RAYONS
/**        public static void GetRayons(NetworkCredential networkCredential, Action<List<Rayon>> callback)
        {
            var request = new RestRequest("rayons");
            request.Credentials = networkCredential;
            Client.ExecuteAsync<List<Rayon>>(request, response => callback(response.Data));

 * private void callback(List<Rayon> rayons)
        {
            Deployment.Current.Dispatcher.BeginInvoke(() =>
                tbresult.Text = DateTime.Now.ToString() + ": " + rayons.Count().ToString()
            );
        }
        */


        // how does this work?
        public void ExecuteAsync<T>(string url, Action<T> callback)
        {
            request = (HttpWebRequest)WebRequest.Create(url);
            // request.BeginGetResponse(new AsyncCallback(callback), null);
        }

        public void GetAsyncResponse(string url)
        {
            request= (HttpWebRequest)WebRequest.Create(url);
            request.BeginGetResponse(new AsyncCallback(FinishWebRequest), null);
        }

        void FinishWebRequest(IAsyncResult result)
        {
            var webresponse=request.EndGetResponse(result);
            var stream = webresponse.GetResponseStream();

            using (var streamReader = new StreamReader(stream))
            {
                var readln=streamReader.ReadToEnd();
                var opengeocoderResult = JsonConvert.DeserializeObject<List<String>>(readln);
            }
        }
    }
}
