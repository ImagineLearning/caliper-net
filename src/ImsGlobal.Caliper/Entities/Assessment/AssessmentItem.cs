using ImsGlobal.Caliper.Entities.Assignable;
using ImsGlobal.Caliper.Entities.Qti;
using Newtonsoft.Json;
using System;

namespace ImsGlobal.Caliper.Entities.Assessment
{
    /// <summary>
    /// A Caliper AssessmentItem represents a single test question.
    /// </summary>
    public class AssessmentItem : AssignableDigitalResource, IAssessmentItem
    {
        /// <summary>
        /// Parameterless constructor for JSON Deserialization
        /// </summary>
        public AssessmentItem()
        {
            Type = EntityType.AssessmentItem;
        }

        public AssessmentItem(Uri id) : base(id)
        {
            Type = EntityType.AssessmentItem;
        }

        /// <summary>
        /// A boolean value indicating whether or not interacting with the item is time dependent.
        /// </summary>
        [JsonProperty("isTimeDependent", Order = 31)]
        public bool? IsTimeDependent { get; set; }
    }
}
