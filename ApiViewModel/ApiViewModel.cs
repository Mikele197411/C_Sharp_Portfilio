using ApiViewModel.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ApiViewModel
{
    public class ApiViewModel
    {
        public string BaseUrl = @"https://booking-test.dev-dch.com/";

        public List<Locations> GetLocations()
        {
            HttpWebRequest getRequest = (HttpWebRequest)WebRequest.Create(BaseUrl+ "api/v1/Locations/Locations");
            getRequest.Method = "GET";

            var getResponse = (HttpWebResponse)getRequest.GetResponse();
            Stream newStream = getResponse.GetResponseStream();
            StreamReader sr = new StreamReader(newStream);
            var json = sr.ReadToEnd();
            var result = JsonConvert.DeserializeObject<List<Locations>>(json);
            return result;
        }
        public List<Offers> GetOffers(int Locationid)
        {
            var result = new List<Offers>();
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(BaseUrl+ "api/v1/Availability/GetOffers");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = "{\"locationId\":\"" + Locationid.ToString() +"\"}";

                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var responseString = streamReader.ReadToEnd();
                result = JsonConvert.DeserializeObject<List<Offers>>(responseString);
            }


            
            return result;
        }
        public string CreateReservation(Reservations reservation)
        {
            var result = string.Empty;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(BaseUrl + "api/v1/Reservations/CreateReservation");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = JsonConvert.SerializeObject(reservation);

                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var responseString = streamReader.ReadToEnd();
                var token = JsonConvert.DeserializeObject<JToken>(responseString)["confirmationNumber"].ToString();
                result = token; //contains 5
            }



            return result;
        }
    }
}
