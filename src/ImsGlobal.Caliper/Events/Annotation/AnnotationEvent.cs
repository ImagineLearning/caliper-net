using ImsGlobal.Caliper.Entities;
using System;
using System.Collections.Generic;


namespace ImsGlobal.Caliper.Events.Annotation
{
    using Annotation = Entities.Annotation.Annotation;

    /// <summary>
    /// Event raised when an actor annotates a resource.
    /// </summary>
    public class AnnotationEvent : Event
    {
        static IReadOnlyDictionary<string, Action> EntityTypeToAction { get; }
            = new Dictionary<string, Action>
            {
                { EntityType.Bookmark.Value, Action.Bookmarked },
                { EntityType.Highlight.Value, Action.Highlighted },
                { EntityType.Share.Value, Action.Shared },
                { EntityType.Tag.Value, Action.Tagged }
            };

        static Action MapAnnotationEntityToAction(Annotation annotation)
        {
            Action action;
            EntityTypeToAction.TryGetValue(annotation.Type.Value, out action);
            return action;
        }

        /// <summary>
        /// parameterless constructor required for JSON Deserialization
        /// </summary>
        public AnnotationEvent() { }

        public AnnotationEvent(Guid id, Annotation annotation) : this(id.ToCaliperUUID(), annotation) { }

        public AnnotationEvent(string id, Annotation annotation) : base(id)
        {
            Type = EventType.Annotation;
            Action = MapAnnotationEntityToAction(annotation);
            Generated = annotation;
        }
    }
}
