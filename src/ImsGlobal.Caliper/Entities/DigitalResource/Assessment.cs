using Newtonsoft.Json;
using System;
using System.Collections.Generic;


namespace ImsGlobal.Caliper.Entities
{
    /// <summary>
    /// A Caliper Assessment represents an assessment instrument such as a test or quiz.
    /// </summary>
    public class Assessment : AssignableDigitalResource
    {
        /// <summary>
        /// An ordered collection of AssessmentItem entities. Each array item MUST be expressed either as an object or as a 
        /// string corresponding to the item’s IRI.
        /// </summary>
        [JsonProperty("items", Order = 62)]
        public List<DigitalResource> Items { get; set; }


        /// <summary>
        /// Parameterless constructor for JSON Deserialization
        /// </summary>
        public Assessment() { }

        public Assessment(Uri id) : base(id) { }


        protected override EntityType GetEntityType() => EntityType.Assessment;
    }
}