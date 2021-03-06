using System.Collections.Generic;
using EliteAPI.Event.Models.Abstractions;
using Newtonsoft.Json;

namespace EliteAPI.Event.Models
{
    public class TechnologyBrokerEvent : EventBase
    {
        internal TechnologyBrokerEvent() { }

        public static TechnologyBrokerEvent FromJson(string json) => JsonConvert.DeserializeObject<TechnologyBrokerEvent>(json);


        [JsonProperty("BrokerType")]
        public string BrokerType { get; internal set; }

        [JsonProperty("MarketID")]
        public long MarketId { get; internal set; }

        [JsonProperty("ItemsUnlocked")]
        public List<ItemsUnlocked> ItemsUnlocked { get; internal set; }

        [JsonProperty("Commodities")]
        public List<Commodity> Commodities { get; internal set; }

        [JsonProperty("Materials")]
        public List<Commodity> Materials { get; internal set; }

        
    }
}