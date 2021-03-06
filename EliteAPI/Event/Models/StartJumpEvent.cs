using EliteAPI.Event.Models.Abstractions;
using Newtonsoft.Json;

namespace EliteAPI.Event.Models
{
    public class StartJumpEvent : EventBase
    {
        internal StartJumpEvent() { }

        public static StartJumpEvent FromJson(string json) => JsonConvert.DeserializeObject<StartJumpEvent>(json);


        [JsonProperty("JumpType")]
        public string JumpType { get; internal set; }

        [JsonProperty("StarSystem")]
        public string StarSystem { get; internal set; }

        [JsonProperty("SystemAddress")]
        public string SystemAddress { get; internal set; }

        [JsonProperty("StarClass")]
        public string StarClass { get; internal set; }

        
    }
}