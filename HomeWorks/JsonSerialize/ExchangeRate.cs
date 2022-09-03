using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace ExchangeRates
{


  //  [Serializable]
    public class ExchangeRate
    {
        public bool success { get; set; }
        public long timestamp { get; set; }
        [JsonPropertyName("base")]
        public string Base { get; set; }
        public DateTime date { get; set; }
        public Dictionary<string,double> rates { get; set; }


    }

}
