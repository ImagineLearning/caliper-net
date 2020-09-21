using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace ImsGlobal.Caliper.Entities
{
    /// <summary>
    /// A Caliper MultipleResponseResponse represents a form of response in which a respondent is asked to select more than one 
    /// correct answer from a list of choices.
    /// </summary>
    public class MultipleResponseResponse : Response
    {
        /// <summary>
        /// An ordered collection of one or more selected options MAY be specified
        /// </summary>
        [JsonProperty("values", Order = 31)]
        public List<string> Values { get; set; }


        /// <summary>
        /// Parameterless constructor for JSON Deserialization
        /// </summary>
        public MultipleResponseResponse() { }

        public MultipleResponseResponse(Uri id) : base(id) { }


        protected override EntityType GetEntityType() => EntityType.MultipleResponseResponse;
    }
}