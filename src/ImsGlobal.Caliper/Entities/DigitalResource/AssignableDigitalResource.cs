using Newtonsoft.Json;
using System;


namespace ImsGlobal.Caliper.Entities
{
    /// <summary>
    /// <para>
    /// A Caliper AssignableDigitalResource is a generic type that represents digital content associated with a graded or 
    /// ungraded assignment.
    /// </para>
    /// <b>NOTE: Utilize AssignableDigitalResource only if no suitable subtype exists to represent the resource being described</b>
    /// </summary>
    public class AssignableDigitalResource : DigitalResource
    {
        /// <summary>
        /// An ISO 8601 date and time value expressed with millisecond precision that describes when the resource was activated. 
        /// The value MUST be expressed using the format YYYY-MM-DDTHH:mm:ss.SSSZ set to UTC with no offset specified.
        /// </summary>
        [JsonProperty("dateToActivate", Order = 24)]
        public DateTime? DateToActivate { get; set; }

        /// <summary>
        /// An ISO 8601 date and time value expressed with millisecond precision that describes when the resource should be shown 
        /// or made available to learners. The value MUST be expressed using the format YYYY-MM-DDTHH:mm:ss.SSSZ set to UTC with 
        /// no offset specified.
        /// </summary>
        [JsonProperty("dateToShow", Order = 25)]
        public DateTime? DateToShow { get; set; }

        /// <summary>
        /// An ISO 8601 date and time value expressed with millisecond precision that describes when the resource can be started. 
        /// The value MUST be expressed using the format YYYY-MM-DDTHH:mm:ss.SSSZ set to UTC with no offset specified.
        /// </summary>
        [JsonProperty("dateToStartOn", Order = 23)]
        public DateTime? DateToStartOn { get; set; }

        /// <summary>
        /// An ISO 8601 date and time value expressed with millisecond precision that describes when the resource is to be 
        /// submitted for evaluation. The value MUST be expressed using the format YYYY-MM-DDTHH:mm:ss.SSSZ set to UTC with no 
        /// offset specified.
        /// </summary>
        [JsonProperty("dateToSubmit", Order = 26)]
        public DateTime? DateToSubmit { get; set; }

        /// <summary>
        /// A non-negative integer that designates the number of permitted attempts.
        /// </summary>
        [JsonProperty("maxAttempts", Order = 27)]
        public uint? MaxAttempts { get; set; }

        /// <summary>
        /// A non-negative integer that designates the number of permitted submissions.
        /// </summary>
        [JsonProperty("maxSubmits", Order = 28)]
        public uint? MaxSubmits { get; set; }

        /// <summary>
        /// A number with a fractional part denoted by a decimal separator that designates the maximum score permitted.
        /// </summary>
        [JsonProperty("maxScore", Order = 29)]
        public double MaxScore { get; set; }


        /// <summary>
        /// Parameterless constructor for JSON Deserialization
        /// </summary>
        public AssignableDigitalResource() { }

        public AssignableDigitalResource(Uri id) : base(id) { }


        protected override EntityType GetEntityType() => EntityType.AssignableDigitalResource;
    }
}
