using Newtonsoft.Json;

namespace moduit.Model
{
    public class ResponseModelOne : AbstractModel
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? category { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string[] tags { get; set; }
    }
}
