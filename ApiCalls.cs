using System.Net;
using Newtonsoft.Json.Linq;
using System.IO;
using Newtonsoft.Json;

namespace TwistcliBuildTask
{
    public static class ApiCalls
    {
        public static string getToken(string accessKeyId, string secretKey)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://us-west1.cloud.twistlock.com/us-3-159212111/api/v1/authenticate");
            httpWebRequest.ContentType = "application/json;";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = "{\"username\":\"" + accessKeyId + "\",\"password\":\"" + secretKey + "\"}";
                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();

                var bd = JObject.Parse(result);
                var token = bd["token"].ToString();
                return token;
            }
        }

        public static RootObject[] apiReq(string token, string imageID)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://us-west1.cloud.twistlock.com/us-3-159212111/api/v1/scans?imageID=" + imageID);
            httpWebRequest.ContentType = "application/json;";
            httpWebRequest.Method = "GET";
            httpWebRequest.Headers.Add("Authorization", "Bearer " + token);
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                var resultString = result.ToString();
                RootObject[] vulns = JsonConvert.DeserializeObject<RootObject[]>(result);
                return vulns;
            }
        }
    }
}
