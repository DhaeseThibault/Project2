using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BikeGates.Models
{
    public class Parkour
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }


        [JsonProperty(PropertyName = "points")]
        public int Points { get; set; }
    }
}
