using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace ExchangeRate_API
    {

    class Rates
        {
        public static bool Import()
            {
            try
                {
                String URLString = "https://v6.exchangerate-api.com/v6/af370279909b3852fbc7252f/latest/USD";
                using (var webClient = new System.Net.WebClient())
                    {
                    var json = webClient.DownloadString(URLString);
                    API_Obj Test = (API_Obj)JsonConvert.DeserializeObject(json);
                    return true;
                    }
                }
            catch (Exception)
                {
                return false;
                }
            }
        }

        public class API_Obj
        {
            public string result { get; set; }
            public string documentation { get; set; }
            public string terms_of_use { get; set; }
            public string time_zone { get; set; }
            public string time_last_update { get; set; }
            public string time_next_update { get; set; }
            public ConversionRate conversion_rates { get; set; }
        }

        public class ConversionRate
        {
            // British Pound
            public decimal GBP { get; set; }
            // Canadian Dollar
            public decimal CAD { get; set; }
        }
    }
    