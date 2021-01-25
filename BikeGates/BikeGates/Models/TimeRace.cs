using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BikeGates.Models
{
    public class TimeRace
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }


        [JsonProperty(PropertyName = "time")]
        public int Points { get; set; }
    }
}
