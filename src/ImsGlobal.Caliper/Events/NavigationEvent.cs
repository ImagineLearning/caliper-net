using ImsGlobal.Caliper.Entities;
using System;
using System.Collections.Generic;

namespace ImsGlobal.Caliper.Events
{
    /// <summary>
    /// A Caliper NavigationEvent models an actor traversing a network of digital resources.
    /// </summary>
    public class NavigationEvent : Event
    {
        /// <summary>
        /// parameterless constructor required for JSON Deserialization
        /// </summary>
        public NavigationEvent() { }

        public NavigationEvent(Guid id) : this(id.ToCaliperUUID()) { }

        public NavigationEvent(string id) : base(id)
        {
            Action = CaliperAction.NavigatedTo;
        }


        protected override EventType GetEventType() => EventType.NavigationEvent;

        protected override IEnumerable<EntityType> GetSupportedActors() => new[]
        {
            EntityType.Person
        };

        protected override IEnumerable<CaliperAction> GetSupportedActions() => new[]
        {
            CaliperAction.NavigatedTo
        };

        protected override IEnumerable<EntityType> GetSupportedObjects() => new[]
        {
            EntityType.DigitalResource,
            EntityType.SoftwareApplication,
        };

        protected override IEnumerable<EntityType> GetSupportedTargets() => new[]
        {
            EntityType.Frame,
        };
    }
}
