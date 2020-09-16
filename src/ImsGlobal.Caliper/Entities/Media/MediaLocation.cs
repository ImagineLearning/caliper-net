
using ImsGlobal.Caliper.Util;
using Newtonsoft.Json;
using System;

using NetCore = System.Text.Json.Serialization;


namespace ImsGlobal.Caliper.Entities.Media
{
    /// <summary>
    /// A Caliper MediaLocation provides the current playback position in a MediaObject such as an AudioObject or VideoObject.
    /// </summary>
    public class MediaLocation : DigitalResource
    {
        /// <summary>
        /// parameterless constructor required for JSON Deserialization
        /// </summary>
        public MediaLocation()
        {
            Type = EntityType.MediaLocation;
        }

        public MediaLocation(Uri id) : base(id)
        {
            Type = EntityType.MediaLocation;
        }


        /// <summary>
        /// A time interval or duration that represents the current playback position measured from the beginning of an 
        /// AudioObject or VideoObject. If a currentTime is specified the value MUST conform to the ISO 8601 duration format.
        /// </summary>
        [JsonProperty("currentTime", Order = 71)]
        [JsonConverter(typeof(CaliperDurationNewtonsoftConverter))]
        [NetCore.JsonConverter(typeof(CaliperDurationConverter))]
        public TimeSpan? CurrentTime { get; set; }
    }
}
