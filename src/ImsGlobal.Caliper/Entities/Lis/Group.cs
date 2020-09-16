using ImsGlobal.Caliper.Entities.Agent;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;


namespace ImsGlobal.Caliper.Entities.Lis
{
    /// <summary>
    /// A Caliper Group represents an ad-hoc, informal or short-lived collection of people organized for some common educational 
    /// or social purpose. A Group can act as an Agent. It can be linked both to a parent Organization and to its members.
    /// </summary>
    public class Group : Organization
    {
        /// <summary>
        /// Parameterless constructor for JSON Deserialization
        /// </summary>
        public Group()
        {
            Type = EntityType.Group;
        }

        public Group(Uri id) : base(id)
        {
            Type = EntityType.Group;
        }


        /// <summary>
        /// An ordered collection of Agent entities, typically of type Group and/or Person. Each array item MUST be expressed 
        /// either as an object or as a string corresponding to the item’s IRI.
        /// </summary>
        [JsonProperty("members", Order = 23)]
        public List<Agent.Agent> Members { get; set; }
    }
}
