using System;
using ImsGlobal.Caliper.Entities.Assignable;
using Newtonsoft.Json;

namespace ImsGlobal.Caliper.Entities.Outcome
{
    /// <summary>
    /// A Caliper Score represents a “raw” or unadjusted numeric score or grade awarded for a given assignment submission. 
    /// A gradebook SHOULD treat the scoreGiven value as read-only and preserve it.
    /// </summary>
    public class Score : Entity
    {
        /// <summary>
        /// Parameterless constructor for JSON Deserialization
        /// </summary>
        public Score()
        {
            Type = EntityType.Score;
        }

        public Score(Uri id) : base(id)
        {
            Type = EntityType.Score;
        }


        /// <summary>
        /// he associated Attempt. The attempt value MUST be expressed either as an object or as a string corresponding to the 
        /// attempt’s IRI. If an object representation is provided, the Attempt SHOULD reference both the Person who generated 
        /// the Attempt and the assigned DigitalResource.
        /// </summary>
        [JsonProperty("attempt", Order = 11)]
        public Attempt Attempt { get; set; }

        /// <summary>
        /// A number with a fractional part denoted by a decimal separator that designates the maximum score permitted.
        /// </summary>
        [JsonProperty("maxScore", Order = 12)]
        public double MaxScore { get; set; }

        /// <summary>
        /// A number with a fractional part denoted by a decimal separator that designates the actual score awarded.
        /// </summary>
        [JsonProperty("scoreGiven", Order = 13)]
        public double ScoreGiven { get; set; }

        /// <summary>
        /// Plain text feedback provided by the scorer.
        /// </summary>
        [JsonProperty("comment", Order = 14)]
        public string Comment { get; set; }

        /// <summary>
        /// The Agent who scored or graded the Attempt. The scoredBy value MUST be expressed either as an object or as a 
        /// string corresponding to the scorer’s IRI.
        /// </summary>
        [JsonProperty("scoredBy", Order = 15)]
        public Agent.Agent ScoredBy { get; set; }
    }
}
