﻿using System.Collections.Generic;
using System.Linq;
using System.Text;
using EliteAPI.Event.Models.Abstractions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace EliteAPI.Status.Models
{
    public class ShipStatus : EventBase
    {
        [JsonProperty("Flags")]
        public ShipStatusFlags Flags { get; private set; }
        public bool Docked => GetFlag(0);
        public bool Landed => GetFlag(1);
        public bool Gear => GetFlag(2);
        public bool Shields => GetFlag(3);
        public bool Supercruise => GetFlag(4);
        public bool FlightAssist => !GetFlag(5);
        public bool Hardpoints => GetFlag(6);
        public bool Winging => GetFlag(7);
        public bool Lights => GetFlag(8);
        public bool CargoScoop => GetFlag(9);
        public bool SilentRunning => GetFlag(10);
        public bool Scooping => GetFlag(11);
        public bool SrvHandbreak => GetFlag(12);
        public bool SrvTurrent => GetFlag(13);
        public bool SrvNearShip => GetFlag(14);
        public bool SrvDriveAssist => GetFlag(15);
        public bool MassLocked => GetFlag(16);
        public bool FsdCharging => GetFlag(17);
        public bool FsdCooldown => GetFlag(18);
        public bool LowFuel => GetFlag(19);
        public bool Overheating => GetFlag(20);
        public bool HasLatlong => GetFlag(21);
        public bool InDanger => GetFlag(22);
        public bool InInterdiction => GetFlag(23);
        public bool InMothership => GetFlag(24);
        public bool InFighter => GetFlag(25);
        public bool InSRV => GetFlag(26);
        public bool AnalysisMode => GetFlag(27);
        public bool NightVision => GetFlag(28);
        private bool GetFlag(int bit)
        {
            return Flags.HasFlag((ShipStatusFlags)(1 << bit));
        }

        [JsonProperty("Pips")]
        private int[] _pips { get; }

        [JsonIgnore]
        public ShipPips Pips => new ShipPips(_pips);

        [JsonProperty("FireGroup")]
        public int FireGroup { get; }

        [JsonProperty("GuiFocus")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ShipGuiFocus GuiFocus { get; private set; }

        [JsonProperty("Fuel")]
        public ShipFuel Fuel { get; private set; }

        [JsonProperty("Cargo")]
        public float Cargo { get; private set; }

        [JsonProperty("LegalState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ShipLegalState LegalState { get; private set; }

        [JsonProperty("Latitude")]
        public float Latitude { get; private set; }

        [JsonProperty("Altitude")]
        public float Altitude { get; private set; }

        [JsonProperty("Longitude")]
        public float Longitude { get; private set; }

        [JsonProperty("Heading")]
        public float Heading { get; private set; }

        [JsonProperty("BodyName")]
        public string Body { get; private set; }

        [JsonProperty("PlanetRadius")]
        public float BodyRadius { get; private set; }
    }
}
