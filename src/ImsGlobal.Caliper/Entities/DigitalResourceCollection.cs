using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ImsGlobal.Caliper.Entities
{
    /// <summary>
    /// A Caliper DigitalResourceCollection represents an ordered collection of DigitalResource entities.
    /// </summary>
    public class DigitalResourceCollection : DigitalResource
    {
        /// <summary>
        /// An ordered collection of DigitalResource entities. Each array item MUST be expressed either as an object or as 
        /// a string corresponding to the item’s IRI.
        /// </summary>
        [JsonProperty("items", Order = 62)]
        public List<DigitalResource> Items { get; set; }


        /// <summary>
        /// Parameterless constructor for JSON Deserialization
        /// </summary>
        public DigitalResourceCollection() { }

        public DigitalResourceCollection(Uri id) : base(id) { }


        protected override EntityType GetEntityType() => EntityType.DigitalResourceCollection;
    }
}
