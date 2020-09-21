using Newtonsoft.Json;
using System;


namespace ImsGlobal.Caliper.Entities
{
    /// <summary>
    /// A Caliper AssessmentItem represents a single test question.
    /// </summary>
    public class AssessmentItem : AssignableDigitalResource
    {
        /// <summary>
        /// A boolean value indicating whether or not interacting with the item is time dependent.
        /// </summary>
        [JsonProperty("isTimeDependent", Order = 31)]
        public bool? IsTimeDependent { get; set; }


        /// <summary>
        /// Parameterless constructor for JSON Deserialization
        /// </summary>
        public AssessmentItem() { }

        public AssessmentItem(Uri id) : base(id) { }


        protected override EntityType GetEntityType() => EntityType.AssessmentItem;
    }
}
