using ImsGlobal.Caliper.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;


namespace ImsGlobal.Caliper.Events
{
    /// <summary>
    /// A Caliper AnnotationEvent models the annotating of digital content. The resulting Annotation is also described and is 
    /// subtyped for greater type specificity.
    /// </summary>
    public class AnnotationEvent : Event
    {
        /// <summary>
        /// Supported Actions according to caliper v1.1
        /// </summary>
        static IReadOnlyDictionary<EntityType, CaliperAction> EntityTypeToAction { get; }
            = new Dictionary<EntityType, CaliperAction>
            {
                { EntityType.BookmarkAnnotation, CaliperAction.Bookmarked },
                { EntityType.HighlightAnnotation, CaliperAction.Highlighted },
                { EntityType.SharedAnnotation, CaliperAction.Shared },
                { EntityType.TagAnnotation, CaliperAction.Tagged }
            };

        static CaliperAction MapAnnotationEntityToAction(Annotation annotation)
        {
            CaliperAction action;
            EntityTypeToAction.TryGetValue(annotation.Type, out action);
            return action;
        }

        [JsonProperty("generated", Order = 8)]
        public override Entity Generated
        {
            get => base.Generated;
            set
            {
                base.Generated = value;
                Action = MapAnnotationEntityToAction(value as Annotation);
            }
        }


        /// <summary>
        /// parameterless constructor required for JSON Deserialization
        /// </summary>
        public AnnotationEvent() { }

        public AnnotationEvent(Guid id, Annotation annotation) : this(id.ToCaliperUUID(), annotation) { }

        public AnnotationEvent(string id, Annotation annotation) : base(id)
        {
            Generated = annotation;
        }


        protected override EventType GetEventType() => EventType.AnnotationEvent;

        protected override IEnumerable<EntityType> GetSupportedActors() => new[]
        {
            EntityType.Person
        };

        protected override IEnumerable<CaliperAction> GetSupportedActions() => new[]
        {
            CaliperAction.Bookmarked,
            CaliperAction.Highlighted,
            CaliperAction.Shared,
            CaliperAction.Tagged
        };

        protected override IEnumerable<EntityType> GetSupportedObjects() => new[]
        {
            EntityType.DigitalResource
        };

        protected override IEnumerable<EntityType> GetSupportedGeneratedEntities() => new[]
        {
            EntityType.Annotation,
            EntityType.BookmarkAnnotation,
            EntityType.HighlightAnnotation,
            EntityType.SharedAnnotation,
            EntityType.TagAnnotation
        };
    }
}
