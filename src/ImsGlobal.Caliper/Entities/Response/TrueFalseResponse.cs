using ImsGlobal.Caliper.Util;
using Newtonsoft.Json;
using System;

using NetCore = System.Text.Json.Serialization;


namespace ImsGlobal.Caliper.Entities
{
    /// <summary>
    /// A Caliper TrueFalseResponse represents a type of Response to an AssessmentItem in which only two possible options are 
    /// provided (e.g., true/false, yes/no).
    /// </summary>
    public class TrueFalseResponse : Response
    {
        /// <summary>
        /// A string value that provides the true/false, yes/no binary selection SHOULD be provided.
        /// </summary>
        [JsonProperty("value", Order = 31)]
        [JsonConverter(typeof(CaliperBooleanNewtonsoftConverter))]
        [NetCore.JsonConverter(typeof(CaliperBooleanConverter))]
        public bool Value { get; set; }


        /// <summary>
        /// Parameterless constructor for JSON Deserialization
        /// </summary>
        public TrueFalseResponse() { }

        public TrueFalseResponse(Uri id) : base(id) { }


        protected override EntityType GetEntityType() => EntityType.TrueFalseResponse;
    }
}