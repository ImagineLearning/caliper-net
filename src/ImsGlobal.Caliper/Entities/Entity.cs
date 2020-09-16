using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace ImsGlobal.Caliper.Entities
{
    /// <summary>
    /// <para>Default base class for Caliper entities.</para>
    /// A <see href="https://www.imsglobal.org/sites/default/files/caliper/v1p1/caliper-spec-v1p1/caliper-spec-v1p1.html#entity">
    /// Caliper Entity</see> is a generic type that represents objects that participate in learning-related activities.
    /// </summary>
    public class Entity : IEntity
    {
        /// <summary>
        /// Parameterless constructor for JSON Deserialization
        /// </summary>
        public Entity() { }

        public Entity(Uri id)
        {
            Id = id;
        }

        /// <summary>
        /// JSON-LD documents require inclusion of a context, denoted by the <b>@context</b> keyword, a property employed 
        /// to map document Terms to IRIs. JSON-LD contexts can be embedded inline or referenced externally in a document. 
        /// Inclusion of a JSON-LD context provides an economical way for Caliper to communicate document semantics to 
        /// services interested in consuming Caliper event data.
        /// </summary>
        [JsonProperty("@context", Order = 0)]
        public CaliperContext Context { get; } = CaliperContext.Default;

        /// <summary>
        /// <b>REQUIRED:</b> The IRI MUST be unique and persistent. The IRI SHOULD also be dereferenceable, i.e., capable of 
        /// returning a representation of the resource. A URI employing the URN scheme MAY be provided in cases where a Linked Data 
        /// friendly HTTP URI is either unavailable or inappropriate.
        /// </summary>
        [Required]
        [JsonProperty("id", Order = 1)]
        public Uri Id { get; set; }

        /// <summary>
        /// <b>REQUIRED:</b> A string value corresponding to the Term defined for the Entity in the external IMS Caliper JSON-LD 
        /// context document. For a generic Entity set the type value to the term Entity. If a subtype of Entity is created, set 
        /// the type to the Term corresponding to the subtype utilized, e.g., Person.
        /// </summary>
        [Required]
        [JsonProperty("type", Order = 2)]
        public IType Type { get; protected set; } = EntityType.Entity;

        /// <summary>
        /// A string value comprising a word or phrase by which the Entity is known.
        /// </summary>
        [JsonProperty("name", Order = 3)]
        public string Name { get; set; }

        /// <summary>
        /// A string value comprising a brief, written representation of the Entity.
        /// </summary>
        [JsonProperty("description", Order = 4)]
        public string Description { get; set; }

        /// <summary>
        /// An ISO 8601 date and time value expressed with millisecond precision that describes when the Entity was created. 
        /// The value MUST be expressed using the format <b>YYYY-MM-DDTHH:mm:ss.SSSZ</b> set to UTC with no offset specified.
        /// </summary>
        [JsonProperty("dateCreated", Order = 52)]
        public DateTime? DateCreated { get; set; }

        /// <summary>
        /// An ISO 8601 date and time value expressed with millisecond precision that describes when the Entity was last changed 
        /// or updated. The value MUST be expressed using the format YYYY-MM-DDTHH:mm:ss.SSSZ set to UTC with no offset specified.
        /// </summary>
        [JsonProperty("dateModified", Order = 53)]
        public DateTime? DateModified { get; set; }

        /// <summary>
        /// A map of additional attributes not defined by the model MAY be specified for a more concise representation of the Entity.
        /// </summary>
        [JsonProperty("extensions", Order = 51)]
        public object Extensions { get; set; }
    }
}
