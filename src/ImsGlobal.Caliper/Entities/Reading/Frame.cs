
using Newtonsoft.Json;
using System;

namespace ImsGlobal.Caliper.Entities.Reading
{
    /// <summary>
    /// A Caliper Frame represents a part, portion or segment of a DigitalResource.
    /// </summary>
    public class Frame : DigitalResource
    {
        /// <summary>
        /// Parameterless constructor for JSON Deserialization
        /// </summary>
        public Frame()
        {
            Type = EntityType.Frame;
        }

        public Frame(Uri id) : base(id)
        {
            Type = EntityType.Frame;
        }


        /// <summary>
        /// A non-negative integer that represents the position of the Frame.
        /// </summary>
        [JsonProperty("index", Order = 21)]
        public int Index { get; set; }
    }
}
