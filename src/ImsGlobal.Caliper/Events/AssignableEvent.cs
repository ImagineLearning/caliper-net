using ImsGlobal.Caliper.Entities;
using System;
using System.Collections.Generic;


namespace ImsGlobal.Caliper.Events
{
    /// <summary>
    /// A Caliper AssignableEvent models activities associated with the assignment of digital content assigned to a learner 
    /// for completion.
    /// </summary>
    public class AssignableEvent : Event
    {
        /// <summary>
        /// parameterless constructor required for JSON Deserialization
        /// </summary>
        public AssignableEvent() { }

        public AssignableEvent(Guid id, CaliperAction action) : this(id.ToCaliperUUID(), action) { }

        public AssignableEvent(string id, CaliperAction action) : base(id)
        {
            Action = action;
        }


        protected override EventType GetEventType() => EventType.AssignableEvent;

        protected override IEnumerable<EntityType> GetSupportedActors() => new[]
        {
            EntityType.Person
        };

        protected override IEnumerable<CaliperAction> GetSupportedActions() => new[]
        {
            CaliperAction.Activated,
            CaliperAction.Deactivated,
            CaliperAction.Started,
            CaliperAction.Completed,
            CaliperAction.Submitted,
            CaliperAction.Reviewed
        };

        protected override IEnumerable<EntityType> GetSupportedObjects() => new[]
        {
            EntityType.AssignableDigitalResource
        };

        protected override IEnumerable<EntityType> GetSupportedGeneratedEntities() => new[]
        {
            EntityType.Attempt
        };
    }
}
