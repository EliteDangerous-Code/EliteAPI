using EliteAPI.Event.Helper;
using EliteAPI.Event.Models.Abstractions;
using Newtonsoft.Json;

namespace EliteAPI.Event.Models.Startup
{
    /// <summary>
    /// This event is written when the game has started.
    /// </summary>
    /// <seealso cref="ProgressInfo"/>
    public class RankEvent : EventBase
    {
        internal RankEvent() { }

        public static RankEvent FromJson(string json)
        {
            return JsonConvert.DeserializeObject<RankEvent>(json);
        }



        /// <summary>
        /// The rank within Combat the commander has.
        /// Returns a scale from 0-8.
        /// </summary>
        [JsonProperty("Combat")]
        public short Combat { get; internal set; }

        /// <summary>
        /// The rank within Combat the commander has.
        /// Returns the localised title.
        /// </summary>
        public string CombatLocalised => RankHelper.Combat(Combat);

        /// <summary>
        /// The rank within Trade the commander has.
        /// Returns a scale from 0-8.
        /// </summary>
        [JsonProperty("Trade")]
        public short Trade { get; internal set; }

        /// <summary>
        /// The rank within Trade the commander has.
        /// Returns the localised title.
        /// </summary>
        public string TradeLocalised => RankHelper.Trade(Trade);

        /// <summary>
        /// The rank within Exploration the commander has.
        /// Returns a scale from 0-8.
        /// </summary>
        [JsonProperty("Explore")]
        public short Exploration { get; internal set; }

        /// <summary>
        /// The rank within Explore the commander has.
        /// Returns the localised title.
        /// </summary>
        public string ExplorationLocalised => RankHelper.Exploration(Exploration);

        /// <summary>
        /// The rank within the Empire the commander has.
        /// Returns a scale from 0-14.
        /// </summary>
        [JsonProperty("Empire")]
        public short Empire { get; internal set; }

        /// <summary>
        /// The rank within the Empire the commander has.
        /// Returns the localised title.
        /// </summary>
        public string EmpireLocalised => RankHelper.Empire(Empire);

        /// <summary>
        /// The rank within the Federation the commander has.
        /// Returns a scale from 0-14.
        /// </summary>
        [JsonProperty("Federation")]
        public short Federation { get; internal set; }

        /// <summary>
        /// The rank within the Federation the commander has.
        /// Returns the localised title.
        /// </summary>
        public string FederationLocalised => RankHelper.Federation(Federation);

        /// <summary>
        /// The rank within the Federation the commander has.
        /// Returns a scale from 0-8.
        /// </summary>
        [JsonProperty("CQC")]
        public short Cqc { get; internal set; }
    }
}