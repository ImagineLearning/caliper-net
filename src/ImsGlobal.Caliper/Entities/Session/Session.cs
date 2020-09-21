using ImsGlobal.Caliper.Util;
using Newtonsoft.Json;
using System;

using NetCore = System.Text.Json.Serialization;


namespace ImsGlobal.Caliper.Entities
{
    /// <summary>
    /// A Caliper Session represents a web application user session.
    /// </summary>
    public class Session : Entity
    {
        /// <summary>
        /// The Person who initiated the Session.
        /// </summary>
        [JsonProperty("user", Order = 11)]
        public Person User { get; set; }

        /// <summary>
        /// An ISO 8601 date and time value expressed with millisecond precision that describes when the Session was commenced. 
        /// The value MUST be expressed using the format YYYY-MM-DDTHH:mm:ss.SSSZ set to UTC with no offset specified.
        /// </summary>
        [JsonProperty("startedAtTime", Order = 12)]
        public DateTime? StartedAtTime { get; set; }

        /// <summary>
        /// An ISO 8601 date and time value expressed with millisecond precision that describes when the Session was completed 
        /// or terminated. The value MUST be expressed using the format YYYY-MM-DDTHH:mm:ss.SSSZ set to UTC with no offset specified.
        /// </summary>
        [JsonProperty("endedAtTime", Order = 13)]
        public DateTime? EndedAtTime { get; set; }

        /// <summary>
        /// A time interval that represents the time taken to complete the Session. If a duration is specified the value MUST 
        /// conform to the ISO 8601 duration format.
        /// </summary>
        [JsonProperty("duration", Order = 14)]
        [JsonConverter(typeof(CaliperDurationNewtonsoftConverter))]
        [NetCore.JsonConverter(typeof(CaliperDurationConverter))]
        public TimeSpan? Duration { get; set; }


        /// <summary>
        /// Parameterless constructor for JSON Deserialization
        /// </summary>
        public Session() { }

        public Session(Uri id) : base(id) { }


        protected override EntityType GetEntityType() => EntityType.Session;
    }
}
