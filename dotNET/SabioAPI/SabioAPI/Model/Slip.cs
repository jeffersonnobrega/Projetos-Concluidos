using Newtonsoft.Json;

namespace SabioAPI.Model
{
    public partial class Slip
    {
       
        [Newtonsoft.Json.JsonProperty("advice")]
        public string Advice { get; set; }
    }

    public class SlipContainer
    {
        [JsonProperty("slip")]
        public Slip Slip { get; set; }
    }
}


