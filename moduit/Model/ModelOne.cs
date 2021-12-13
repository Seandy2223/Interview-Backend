using Newtonsoft.Json;
using System;

namespace moduit.Model
{
    public class ModelOne : AbstractModel
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? category { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string[] tags { get; set; }
    }
}
