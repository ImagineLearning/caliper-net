using System;


namespace ImsGlobal.Caliper.Entities
{
    /// <summary>
    /// A Caliper Entity is a generic type that represents objects that participate in learning-related activities.
    /// </summary>
    public interface IEntity
    {
        /// <summary>
        /// The IRI MUST be unique and persistent. The IRI SHOULD also be dereferenceable, i.e., capable of 
        /// returning a representation of the resource. A URI employing the URN scheme MAY be provided in cases where a Linked Data 
        /// friendly HTTP URI is either unavailable or inappropriate.
        /// </summary>
        Uri Id { get; }

        /// <summary>
        /// JSON-LD documents require inclusion of a context, denoted by the <b>@context</b> keyword, a property employed 
        /// to map document Terms to IRIs. JSON-LD contexts can be embedded inline or referenced externally in a document. 
        /// Inclusion of a JSON-LD context provides an economical way for Caliper to communicate document semantics to 
        /// services interested in consuming Caliper event data.
        /// </summary>
        CaliperContext Context { get; }

        /// <summary>
        /// A string value corresponding to the Term defined for the Entity in the external IMS Caliper JSON-LD 
        /// context document. For a generic Entity set the type value to the term Entity. If a subtype of Entity is created, set 
        /// the type to the Term corresponding to the subtype utilized, e.g., Person.
        /// </summary>
        IType Type { get; }

        /// <summary>
        /// A string value comprising a word or phrase by which the Entity is known.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// A string value comprising a brief, written representation of the Entity.
        /// </summary>
        string Description { get; set; }

        /// <summary>
        /// An ISO 8601 date and time value expressed with millisecond precision that describes when the Entity was created. 
        /// The value MUST be expressed using the format <b>YYYY-MM-DDTHH:mm:ss.SSSZ</b> set to UTC with no offset specified.
        /// </summary>
        DateTime? DateCreated { get; set; }

        /// <summary>
        /// An ISO 8601 date and time value expressed with millisecond precision that describes when the Entity was last changed 
        /// or updated. The value MUST be expressed using the format YYYY-MM-DDTHH:mm:ss.SSSZ set to UTC with no offset specified.
        /// </summary>
        DateTime? DateModified { get; set; }

        /// <summary>
        /// A map of additional attributes not defined by the model MAY be specified for a more concise representation of the Entity.
        /// </summary>
        object Extensions { get; set; }
    }
}