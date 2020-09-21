using ImsGlobal.Caliper.Entities;
using System;
using System.Collections.Generic;


namespace ImsGlobal.Caliper.Events
{
    /// <summary>
    /// A Caliper SessionEvent models the creation and subsequent termination of a user session established by a Person 
    /// interacting with a SoftwareApplication.
    /// </summary>
    public class SessionEvent : Event
    {
        /// <summary>
        /// parameterless constructor required for JSON Deserialization
        /// </summary>
        public SessionEvent() { }

        public SessionEvent(Guid id, CaliperAction action) : this(id.ToCaliperUUID(), action) { }

        public SessionEvent(string id, CaliperAction action) : base(id)
        {
            Action = action;
        }

        protected override EventType GetEventType() => EventType.SessionEvent;

        protected override IEnumerable<EntityType> GetSupportedActors() => new[]
        {
            EntityType.Person,
            EntityType.SoftwareApplication
        };

        protected override IEnumerable<CaliperAction> GetSupportedActions() => new[]
        {
            CaliperAction.LoggedIn,
            CaliperAction.LoggedOut,
            CaliperAction.TimedOut
        };

        protected override IEnumerable<EntityType> GetSupportedObjects() => new[]
        {
            EntityType.Session,
            EntityType.SoftwareApplication,
        };
    }
}
