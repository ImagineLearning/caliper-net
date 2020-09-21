using Newtonsoft.Json;
using System;
using System.Collections.Generic;


namespace ImsGlobal.Caliper.Entities
{
    /// <summary>
    /// A Caliper FillinBlankResponse represents a type of Response in which a respondent is asked to provide one or more words, 
    /// expressions or short phrases that correctly completes a statement.
    /// </summary>
    public class FillInBlankResponse : Response
    {
        /// <summary>
        /// An ordered collection of one or more string values representing words, expressions or short phrases that constitute 
        /// the FillinBlankResponse.
        /// </summary>
        [JsonProperty("values", Order = 31)]
        public IList<string> Values { get; set; }


        /// <summary>
        /// Parameterless constructor for JSON Deserialization
        /// </summary>
        public FillInBlankResponse() { }

        public FillInBlankResponse(Uri id) : base(id) { }


        protected override EntityType GetEntityType() => EntityType.FillinBlankResponse;
    }
}
