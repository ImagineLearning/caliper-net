using Newtonsoft.Json;
using System;


namespace ImsGlobal.Caliper.Entities
{
    /// <summary>
    /// A Caliper Frame represents a part, portion or segment of a DigitalResource.
    /// </summary>
    public class Frame : DigitalResource
    {
        /// <summary>
        /// A non-negative integer that represents the position of the Frame.
        /// </summary>
        [JsonProperty("index", Order = 21)]
        public int Index { get; set; }


        /// <summary>
        /// Parameterless constructor for JSON Deserialization
        /// </summary>
        public Frame() { }

        public Frame(Uri id) : base(id) { }


        protected override EntityType GetEntityType() => EntityType.Frame;
    }
}
