using System.Collections.Generic;
using ImsGlobal.Caliper.Entities.SchemaDotOrg;
using Newtonsoft.Json;
using System;


namespace ImsGlobal.Caliper.Entities
{
    /// <summary>
    /// <para>A Caliper DigitalResource is a generic type that represents digital content</para>
    /// <para>Caliper representation of a <see href="https://schema.org/CreativeWork">CreativeWork</see></para>
    /// <b>NOTE: Utilize DigitalResource only if no suitable subtype exists to represent the resource being described.</b>
    /// </summary>
    public class DigitalResource : Entity, IResource, ICreativeWork
    {
        /// <summary>
        /// Parameterless constructor for JSON Deserialization
        /// </summary>
        public DigitalResource()
        {
            Type = EntityType.DigitalResource;
        }

        public DigitalResource(Uri id) : base(id)
        {
            Type = EntityType.DigitalResource;
        }

        /// <summary>
        /// An ordered collection of one or more LearningObjective entities that describe what a learner is expected to 
        /// comprehend or accomplish after engaging with the resource. Each array item MUST be expressed either as an object 
        /// or as a string corresponding to the item’s IRI.
        /// </summary>
        [JsonProperty("learningObjectives", Order = 12)]
        public List<LearningObjective> LearningObjectives { get; set; } = new List<LearningObjective>();

        /// <summary>
        /// An ordered collection of one or more string values that represent tags or labels used to identify the resource.
        /// </summary>
        [JsonProperty("keywords", Order = 13)]
        public List<string> Keywords { get; set; } = new List<string>();

        /// <summary>
		/// An ordered collection of Agent entities, typically of type Person, that are responsible for bringing resource into 
        /// being. Each array item MUST be expressed either as an object or as a string corresponding to the item’s IRI.
		/// </summary>
		[JsonProperty("creators", Order = 14)]
        public List<Agent.Agent> Creators { get; set; } = new List<Agent.Agent>();

        /// <summary>
		/// A string value drawn from the list of <see href="https://www.iana.org/assignments/media-types/media-types.xhtml">
        /// IANA approved media types and subtypes</see> that identifies the file format of the 
        /// resource  .
		/// </summary>
		[JsonProperty("mediaType", Order = 15)]
        public string MediaType { get; set; }

        /// <summary>
        /// A related Entity that includes or incorporates the resource as a part of its whole. The isPartOf value MUST be 
        /// expressed either as an object or as a string corresponding to the associated entity’s IRI.
        /// </summary>
        [JsonProperty("isPartOf", Order = 61)]
        public Entity IsPartOf { get; set; }

        /// <summary>
        /// An ISO 8601 date and time value expressed with millisecond precision that provides the publication date of the resource. 
        /// The value MUST be expressed using the format YYYY-MM-DDTHH:mm:ss.SSSZ set to UTC with no offset specified.
        /// </summary>
        [JsonProperty("datePublished", Order = 62)]
        public DateTime? DatePublished { get; set; }

        /// <summary>
        /// A string value that designates the current form or version of the resource.
        /// </summary>
        [JsonProperty("version", Order = 63)]
        public string Version { get; set; }

    }
}
