using Newtonsoft.Json;
using System;
using System.Collections.Generic;


namespace ImsGlobal.Caliper.Entities.Response
{
    /// <summary>
    /// A Caliper SelectTextResponse represents a type of Response that identifies text or a mapping from a presented paragraph 
    /// or list.
    /// </summary>
    public class SelectTextResponse : Response
    {
        /// <summary>
        /// Parameterless constructor for JSON Deserialization
        /// </summary>
        public SelectTextResponse()
        {
            Type = EntityType.SelectText;
        }

        public SelectTextResponse(Uri id) : base(id)
        {
            Type = EntityType.SelectText;
        }


        /// <summary>
        /// An ordered collection of one or more selected options
        /// </summary>
        [JsonProperty("values", Order = 31)]
        public List<string> Values { get; set; }
    }
}