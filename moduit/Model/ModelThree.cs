using Newtonsoft.Json;
using System;

namespace moduit.Model
{
    public class ModelThree
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int Id { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int Category { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public ItemsModel[] items { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string[] Tags { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime createdAt { get; set; }   
    }

    public class ItemsModel
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string description { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string footer { get; set; }
    }
}
