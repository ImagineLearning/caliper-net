using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ImsGlobal.Caliper.Entities.Forum
{
    /// <summary>
    /// A Caliper Thread represents a series of one or more messages that share a common subject and are connected by a reply 
    /// or by date relationships.
    /// </summary>
    public class Thread : DigitalResourceCollection
    {
        /// <summary>
        /// Parameterless constructor for JSON Deserialization
        /// </summary>
        public Thread()
        {
            Type = EntityType.Thread;
        }

        public Thread(Uri id) : base(id)
        {
            Type = EntityType.Thread;
        }


        /// <summary>
        /// An ordered collection of Message entities. Each array item MUST be expressed either as an object or as a string 
        /// corresponding to the item’s IRI.
        /// </summary>
        [JsonProperty("items", Order = 10)]
        public new IList<Message> Items { get; set; }
    }
}
