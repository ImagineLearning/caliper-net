using ImsGlobal.Caliper.Entities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using NetCore = System.Text.Json.Serialization;


namespace ImsGlobal.Caliper.Events
{
    /// <summary>
    /// <para>Base class for all Caliper Events</para>
    /// <para>
    /// A <see href="https://www.imsglobal.org/sites/default/files/caliper/v1p1/caliper-spec-v1p1/caliper-spec-v1p1.html#event">
    /// Caliper Event</see> is a generic type that describes the relationship established between an actor and an object, formed as 
    /// a result of a purposeful action undertaken by the actor at a particular moment in time and within a given learning context. 
    /// The Event properties actor, action and object form a compact data structure that resembles an RDF triple linking a subject 
    /// to an object via a predicate. A learner starting an assessment, annotating a reading, pausing a video, or posting a message 
    /// to a forum, are examples of learning activities that Caliper models as events.
    /// </para>
    /// <para>
    /// The information model also seeks to describe the learning environment or context in which a learning activity is situated. 
    /// Group affiliation, membership roles and status, recent navigation history, supporting technology and session information 
    /// can all be optionally represented. An Entity generated as a result of the interaction between an actor and an object can 
    /// also be described; annotating a piece of digital content and producing an Annotation is one such example. An extensions 
    /// property is also provided so that implementers can add custom attributes not described by the model.
    /// </para>
    /// </summary>
    public class Event
    {
        CaliperAction action;
        Agent actor;
        Entity eventObject;
        Entity target;
        Entity generatedObject;


        /// <summary>
        /// parameterless constructor required for JSON Deserialization
        /// </summary>
        public Event() { }

        public Event(Guid id) : this(id.ToCaliperUUID()) { }

        public Event(string id)
        {
            Id = id;
        }

        /// <summary>
        /// JSON-LD documents require inclusion of a context, denoted by the <b>@context</b> keyword, a property employed 
        /// to map document Terms to IRIs. JSON-LD contexts can be embedded inline or referenced externally in a document. 
        /// Inclusion of a JSON-LD context provides an economical way for Caliper to communicate document semantics to 
        /// services interested in consuming Caliper event data.
        /// </summary>
		[Required]
        [JsonProperty("@context", Order = 1)]
        [NetCore.JsonPropertyName("@context")]
        public CaliperContext Context { get; } = CaliperContext.Default;

        /// <summary>
        /// <b>REQUIRED:</b> The emitting application MUST provision the Event with a UUID. A version 4 UUID SHOULD be generated. 
        /// The UUID MUST be expressed as a URN using the form <b>urn:uuid:(UUID)</b> per RFC 4122.
        /// </summary>
        [Required]
        [JsonProperty("id", Order = 2)]
        public string Id { get; set; }

        /// <summary>
        /// <b>REQUIRED:</b> A string value corresponding to the Term defined for the Event in the external IMS Caliper JSON-LD 
        /// context document. For a generic Event set the type to the string value Event. If a subtype of Entity is created, set 
        /// the type to the Term corresponding to the subtype utilized, (e.g., NavigationEvent).
        /// </summary>
        [Required]
        [JsonProperty("type", Order = 3)]
        [JsonConverter(typeof(StringEnumConverter))]
        [NetCore.JsonConverter(typeof(NetCore.JsonStringEnumConverter))]
        public virtual EventType Type => GetEventType();

        /// <summary>
        /// <b>REQUIRED:</b> The Agent who initiated the Event, typically though not always a Person. The actor value MUST be 
        /// expressed either as an object or as a string corresponding to the actor’s IRI.
        /// </summary>
        [Required]
        [JsonProperty("actor", Order = 4)]
        public Agent Actor
        {
            get => actor;
            set
            {
                CheckSupport(GetSupportedActors(), value.Type);
                actor = value;
            }
        }

        /// <summary>
        /// <b>REQUIRED:</b> The action or predicate that binds the actor or subject to the object. The action range is limited 
        /// to the set of actions described in this specification and may be further constrained by the chosen Event type. Only 
        /// one action Term may be specified per Event.
        /// </summary>
        [Required]
        [JsonProperty("action", Order = 5)]
        [JsonConverter(typeof(StringEnumConverter))]
        [NetCore.JsonConverter(typeof(NetCore.JsonStringEnumConverter))]
        public CaliperAction Action
        {
            get => action;
            set
            {
                CheckSupport(GetSupportedActions(), value);
                action = value;
            }
        }

        /// <summary>
        /// <b>REQUIRED:</b> The Entity that comprises the object of the interaction. The object value MUST be expressed either 
        /// as an object or as a string corresponding to the object’s IRI.
        /// </summary>
        [Required]
        [JsonProperty("object", Order = 6)]
        public Entity Object
        {
            get => eventObject;
            set
            {
                CheckSupport(GetSupportedObjects(), value.Type);
                eventObject = value;
            }
        }

        /// <summary>
        /// An Entity that represents a particular segment or location within the object. The target value MUST be expressed 
        /// either as an object or as a string corresponding to the target entity’s IRI.
        /// </summary>
        [JsonProperty("target", Order = 7)]
        public Entity Target
        {
            get => target;
            set
            {
                CheckSupport(GetSupportedTargets(), value.Type);
                target = value;
            }
        }

        /// <summary>
        /// An Entity created or generated as a result of the interaction. The generated value MUST be expressed either as an 
        /// object or as a string corresponding to the generated entity’s IRI.
        /// </summary>
        [JsonProperty("generated", Order = 8)]
        public virtual Entity Generated
        {
            get => generatedObject;
            set
            {
                CheckSupport(GetSupportedGeneratedEntities(), value.Type);
                generatedObject = value;
            }
        }

        /// <summary>
		/// <para>
        /// <b>REQUIRED:</b> An ISO 8601 date and time value expressed with millisecond precision that indicates when the Event 
        /// occurred. The value MUST be expressed using the format YYYY-MM-DDTHH:mm:ss.SSSZ set to UTC with no offset specified.
        /// </para>
        /// <para>
        /// <b>NOTE: Defaults to the UTC time when the event is instantiated</b>
        /// </para>
		/// </summary>
        [Required]
        [JsonProperty("eventTime", Order = 9)]
        public DateTime EventTime { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// A SoftwareApplication that constitutes the application context. The edApp value MUST be expressed either as an object 
        /// or as a string corresponding to the edApp’s IRI.
        /// </summary>
        [JsonProperty("edApp", Order = 10)]
        public SoftwareApplication EdApp { get; set; }

        /// <summary>
        /// An Organization that represents the group context. The group value MUST be expressed either as an object or as a 
        /// string corresponding to the group’s IRI.
        /// </summary>
        [JsonProperty("group", Order = 11)]
        public Organization Group { get; set; }

        /// <summary>
        /// The relationship between the actor and the group in terms of roles assigned and current status. The membership value 
        /// MUST be expressed either as an object or as a string corresponding to the membership entity’s IRI.
        /// </summary>
        [JsonProperty("membership", Order = 12)]
        public Membership Membership { get; set; }

        /// <summary>
        /// If the Event occurs within the context of an LTI tool launch, the actor’s tool consumer LtiSession MAY be referenced. 
        /// The federatedSession value MUST be expressed either as an object or as a string corresponding to the 
        /// federatedSession’s IRI.
        /// </summary>
        [JsonProperty("federatedSession", Order = 13)]
        public LtiSession FederatedSession { get; set; }

        /// <summary>
		/// The current user Session. The session value MUST be expressed either as an object or as a string corresponding to 
        /// the session’s IRI.
		/// </summary>
		[JsonProperty("session", Order = 14)]
        public Session Session { get; set; }

        /// <summary>
        /// A map of additional attributes not defined by the model MAY be specified for a more concise representation of the Event.
        /// </summary>
        [JsonProperty("extensions", Order = 15)]
        public object Extensions { get; set; }

        /// <summary>
        /// An Entity that represents the referring context. A SoftwareApplication or DigitalResource will typically constitute 
        /// the referring context. The referrer value MUST be expressed either as an object or as a string corresponding to the 
        /// referrer’s IRI.
        /// </summary>
        [JsonProperty("referrer", Order = 16)]
        public Entity Referrer { get; set; }


        protected virtual EventType GetEventType() => EventType.Event;

        protected virtual IEnumerable<CaliperAction> GetSupportedActions() => null;

        protected virtual IEnumerable<EntityType> GetSupportedActors() => null;

        protected virtual IEnumerable<EntityType> GetSupportedObjects() => null;

        protected virtual IEnumerable<EntityType> GetSupportedTargets() => null;

        protected virtual IEnumerable<EntityType> GetSupportedGeneratedEntities() => null;

        private void CheckSupport<T>(IEnumerable<T> supportedValues, T value)
        {
            if (supportedValues == null || supportedValues.Contains(value))
                return;

            //throw new ArgumentOutOfRangeException(
            //    $"{value} is not a supported {typeof(T).Name}. " +
            //    $"{Type} only supports {string.Join(", ", supportedValues)}"
            //);
        }
    }
}
