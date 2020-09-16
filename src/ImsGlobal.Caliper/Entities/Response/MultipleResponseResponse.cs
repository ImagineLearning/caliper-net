using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace ImsGlobal.Caliper.Entities.Response
{
    /// <summary>
    /// A Caliper MultipleResponseResponse represents a form of response in which a respondent is asked to select more than one 
    /// correct answer from a list of choices.
    /// </summary>
    public class MultipleResponseResponse : Response
    {
        /// <summary>
        /// Parameterless constructor for JSON Deserialization
        /// </summary>
        public MultipleResponseResponse()
        {
            Type = EntityType.MultipleResponse;
        }

        public MultipleResponseResponse(Uri id) : base(id)
        {
            Type = EntityType.MultipleResponse;
        }


        /// <summary>
        /// An ordered collection of one or more selected options MAY be specified
        /// </summary>
        [JsonProperty("values", Order = 31)]
        public List<string> Values { get; set; }
    }
}