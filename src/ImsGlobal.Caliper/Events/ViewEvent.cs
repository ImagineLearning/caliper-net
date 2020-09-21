using ImsGlobal.Caliper.Entities;
using System;
using System.Collections.Generic;

namespace ImsGlobal.Caliper.Events
{
    /// <summary>
    /// A Caliper ViewEvent describes an actor’s examination of digital content whenever the activity emphasizes thoughtful 
    /// observation or study as opposed to the mere retrieval of a resource.
    /// </summary>
    public class ViewEvent : Event
    {
        /// <summary>
        /// parameterless constructor required for JSON Deserialization
        /// </summary>
        public ViewEvent() { }

        public ViewEvent(Guid id) : this(id.ToCaliperUUID()) { }

        public ViewEvent(string id) : base(id)
        {
            Action = CaliperAction.Viewed;
        }


        protected override EventType GetEventType() => EventType.ViewEvent;

        protected override IEnumerable<EntityType> GetSupportedActors() => new[]
        {
            EntityType.Person
        };

        protected override IEnumerable<CaliperAction> GetSupportedActions() => new[]
        {
            CaliperAction.Viewed
        };

        protected override IEnumerable<EntityType> GetSupportedObjects() => new[]
        {
            EntityType.DigitalResource
        };

        protected override IEnumerable<EntityType> GetSupportedTargets() => new[]
        {
            EntityType.Frame
        };
    }
}
