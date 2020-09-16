using ImsGlobal.Caliper.Entities.Agent;
using ImsGlobal.Caliper.Util;
using System;
using Newtonsoft.Json;

using NetCore = System.Text.Json.Serialization;


namespace ImsGlobal.Caliper.Entities.Assignable
{
    /// <summary>
    /// A Caliper Attempt provides a count of the number of times an actor has interacted with an AssignableDigitalResource along 
    /// with start time, end time and duration information. An Attempt is generated as the result of an action such as starting 
    /// an Assessment.
    /// </summary>
    public class Attempt : Entity
    {
        /// <summary>
        /// Parameterless constructor for JSON Deserialization
        /// </summary>
        public Attempt()
        {
            Type = EntityType.Attempt;
        }

        public Attempt(Uri id) : base(id)
        {
            Type = EntityType.Attempt;
        }

        /// <summary>
        /// The DigitalResource that constitutes the object of the assignment. The assignable value MUST be expressed either 
        /// as an object or as a string corresponding to the assigned resource’s IRI.
        /// </summary>
        [JsonProperty("assignable", Order = 11)]
        public DigitalResource Assignable { get; set; }

        /// <summary>
        /// The Person who initiated the Attempt. The assignee value MUST be expressed either as an object or as a string 
        /// corresponding to the assignee’s IRI.
        /// </summary>
        [JsonProperty("assignee", Order = 12)]
        public Person Assignee { get; set; }

        /// <summary>
        /// The total number of attempts inclusive of the current attempt that have been registered against the assigned 
        /// DigitalResource.
        /// </summary>
        [JsonProperty("count", Order = 13)]
        public int? Count { get; set; }

        /// <summary>
        /// An ISO 8601 date and time value expressed with millisecond precision that describes when the Attempt was commenced. 
        /// The value MUST be expressed using the format YYYY-MM-DDTHH:mm:ss.SSSZ set to UTC with no offset specified.
        /// </summary>
        [JsonProperty("startedAtTime", Order = 14)]
        public DateTime? StartedAtTime { get; set; }

        /// <summary>
        /// An ISO 8601 date and time value expressed with millisecond precision that describes when the Attempt was completed or 
        /// terminated. The value MUST be expressed using the format YYYY-MM-DDTHH:mm:ss.SSSZ set to UTC with no offset specified.
        /// </summary>
        [JsonProperty("endedAtTime", Order = 15)]
        public DateTime? EndedAtTime { get; set; }

        /// <summary>
        /// A time interval that represents the time taken to complete the Attempt. If a duration is specified the value MUST 
        /// conform to the ISO 8601 duration format.
        /// </summary>
        [JsonProperty("duration", Order = 16)]
        [JsonConverter(typeof(CaliperDurationNewtonsoftConverter))]
        [NetCore.JsonConverter(typeof(CaliperDurationConverter))]
        public TimeSpan? Duration { get; set; }

        /// <summary>
        /// The parent Attempt, if one exists. The isPartOf value MUST be expressed either as an object or as a string 
        /// corresponding to the associated attempt’s IRI.
        /// </summary>
        [JsonProperty("isPartOf", Order = 17)]
        public Attempt IsPartOf { get; set; }
    }
}
