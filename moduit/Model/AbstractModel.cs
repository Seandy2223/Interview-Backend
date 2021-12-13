using Newtonsoft.Json;
using System;

namespace moduit.Model
{
    public abstract class AbstractModel
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? id { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string title { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string description { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string footer { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime createdAt{ get; set; }
    }
}
