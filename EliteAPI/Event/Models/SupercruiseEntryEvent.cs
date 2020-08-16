using Newtonsoft.Json;

namespace EliteAPI.Event.Models
{
    public class SupercruiseEntryEvent : EventBase
    {
        internal SupercruiseEntryEvent() { }

        public static SupercruiseEntryEvent FromJson(string json) => JsonConvert.DeserializeObject<SupercruiseEntryEvent>(json);


        [JsonProperty("StarSystem")]
        public string StarSystem { get; internal set; }

        [JsonProperty("SystemAddress")]
        public long SystemAddress { get; internal set; }

        
    }
}