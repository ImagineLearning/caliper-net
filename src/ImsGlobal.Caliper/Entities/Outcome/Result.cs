using ImsGlobal.Caliper.Entities.Assignable;
using Newtonsoft.Json;
using System;

namespace ImsGlobal.Caliper.Entities.Outcome
{
    /// <summary>
    /// A Caliper Result represents the current score or grade as recorded in a gradebook. The Result score value may represent 
    /// an adjusted or scaled value and is considered mutable.
    /// </summary>
    public class Result : Entity
    {
        /// <summary>
        /// Parameterless constructor for JSON Deserialization
        /// </summary>
        public Result()
        {
            Type = EntityType.Result;
        }

        public Result(Uri id) : base(id)
        {
            Type = EntityType.Result;
        }


        /// <summary>
        /// The associated Attempt. The attempt value MUST be expressed either as an object or as a string corresponding to the 
        /// attempt’s IRI. If an object representation is provided, the Attempt SHOULD reference both the Person who generated 
        /// the Attempt and the assigned DigitalResource.
        /// </summary>
        [JsonProperty("attempt", Order = 11)]
        public Attempt Attempt { get; set; }

        /// <summary>
        /// A number with a fractional part denoted by a decimal separator that designates the maximum result score permitted.
        /// </summary>
        [JsonProperty("maxResultScore", Order = 12)]
        public double? MaxResultScore { get; set; }

        /// <summary>
        /// A number with a fractional part denoted by a decimal separator that designates the actual result score awarded.
        /// </summary>
        [JsonProperty("resultScore", Order = 13)]
        public double ResultScore { get; set; }

        /// <summary>
        /// Plain text feedback provided by the scorer.
        /// </summary>
        [JsonProperty("comment", Order = 18)]
        public string Comment { get; set; }

        /// <summary>
        /// The Agent who scored or graded the Attempt. The scoredBy value MUST be expressed either as an object or as a string 
        /// corresponding to the scorer’s IRI.
        /// </summary>
        [JsonProperty("scoredBy", Order = 19)]
        public Agent.Agent ScoredBy { get; set; }

    }

}
