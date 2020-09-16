using Newtonsoft.Json;
using System;
using System.Collections.Generic;


namespace ImsGlobal.Caliper.Entities.Annotation
{
    /// <summary>
    /// A Caliper SharedAnnotation represents the act of sharing a reference to a DigitalResource with other agents.
    /// </summary>
    public class SharedAnnotation : Annotation
    {
        /// <summary>
        /// Parameterless constructor for JSON Deserialization
        /// </summary>
        public SharedAnnotation()
        {
            Type = EntityType.Share;
        }

        public SharedAnnotation(Uri id) : base(id)
        {
            Type = EntityType.Share;
        }


        /// <summary>
        /// An ordered collection of one or more Agent entities, typically of type Person, with whom the annotated DigitalResource 
        /// has been shared. Each array item MUST be expressed either as an object or as a string corresponding to the item’s IRI.
        /// </summary>
        [JsonProperty("withAgents", Order = 31)]
        public List<Agent.Agent> WithAgents { get; set; } = new List<Agent.Agent>();
    }
}
