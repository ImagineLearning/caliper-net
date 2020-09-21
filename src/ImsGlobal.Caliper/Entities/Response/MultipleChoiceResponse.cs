using Newtonsoft.Json;
using System;

namespace ImsGlobal.Caliper.Entities
{
    /// <summary>
    /// A Caliper MultipleChoiceResponse represents a type of Response in which a respondent is asked to provide the best 
    /// possible answer from a list of choices.
    /// </summary>
    public class MultipleChoiceResponse : Response
    {
        /// <summary>
        /// A string value that represents the selected option.
        /// </summary>
        [JsonProperty("value", Order = 31)]
        public string Value { get; set; }


        /// <summary>
        /// Parameterless constructor for JSON Deserialization
        /// </summary>
        public MultipleChoiceResponse() { }

        public MultipleChoiceResponse(Uri id) : base(id) { }


        protected override EntityType GetEntityType() => EntityType.MultipleChoiceResponse;
    }
}
