using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace ImsGlobal.Caliper.Entities.Annotation
{
    /// <summary>
    /// A Caliper TagAnnotation represents the act of tagging a DigitalResource with tags or labels.
    /// </summary>
    public class TagAnnotation : Annotation
    {
        /// <summary>
        /// Parameterless constructor for JSON Deserialization
        /// </summary>
        public TagAnnotation()
        {
            Type = EntityType.Tag;
        }

        public TagAnnotation(Uri id) : base(id)
        {
            Type = EntityType.Tag;
        }


        /// <summary>
        /// An ordered collection of one or more string values that represent the tags associated with the annotated DigitalResource.
        /// </summary>
        [JsonProperty("tags", Order = 31)]
        public List<string> Tags { get; set; } = new List<string>();
    }
}
