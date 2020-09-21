using System;
using System.Collections.Generic;
using Newtonsoft.Json;


namespace ImsGlobal.Caliper.Entities
{
    /// <summary>
    /// A Caliper Forum represents a channel or virtual space in which group discussions take place. A Forum typically comprises 
    /// one or more threaded conversations to which members can subscribe, post messages and reply to other messages.
    /// </summary>
    public class Forum : DigitalResourceCollection
    {
        /// <summary>
        /// An ordered collection of Thread entities. Each array item MUST be expressed either as an object or as a string 
        /// corresponding to the item’s IRI.
        /// </summary>
        [JsonProperty("items", Order = 10)]
        public new IList<Thread> Items { get; set; }


        /// <summary>
        /// Parameterless constructor for JSON Deserialization
        /// </summary>
        public Forum() { }

        public Forum(Uri id) : base(id) { }


        protected override EntityType GetEntityType() => EntityType.Forum;
    }
}
