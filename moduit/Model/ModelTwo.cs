using Newtonsoft.Json;

namespace moduit.Model
{
    public class ModelTwo : AbstractModel
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? category { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string[] tags { get; set; }
    }
}
