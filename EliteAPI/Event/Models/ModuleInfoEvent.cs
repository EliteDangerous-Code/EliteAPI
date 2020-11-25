
namespace EliteAPI.Event.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Abstractions;


    public partial class ModuleInfoEvent : EventBase
    {
        internal ModuleInfoEvent() { }

        [JsonProperty("event")]
        public string Event { get; private set; }
    }

    public partial class ModuleInfoEvent
    {
        public static ModuleInfoEvent FromJson(string json) => JsonConvert.DeserializeObject<ModuleInfoEvent>(json);
    }

    
}

namespace EliteAPI.Event.Handler
{
    using System;
    using Models;

    public partial class EventHandler
    {
        public event EventHandler<ModuleInfoEvent> ModuleInfoEvent;
        internal void InvokeModuleInfoEvent(ModuleInfoEvent arg) => ModuleInfoEvent?.Invoke(this, arg);
    }
}
