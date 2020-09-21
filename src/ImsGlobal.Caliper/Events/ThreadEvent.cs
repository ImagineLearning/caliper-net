using ImsGlobal.Caliper.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;


namespace ImsGlobal.Caliper.Events
{
    /// <summary>
    /// A Caliper ThreadEvent models an actor interacting with a Forum thread or topic.
    /// </summary>
    public class ThreadEvent : Event
    {
        [JsonProperty("object", Order = 5)]
        public new Thread Object { get; set; }

        [JsonProperty("federatedSession", Order = 14)]
        public new LtiSession FederatedSession { get; set; }


        /// <summary>
        /// parameterless constructor required for JSON Deserialization
        /// </summary>
        public ThreadEvent() { }

        public ThreadEvent(Guid id, CaliperAction action) : this(id.ToCaliperUUID(), action) { }

        public ThreadEvent(string id, CaliperAction action) : base(id)
        {
            Action = action;
        }


        protected override EventType GetEventType() => EventType.ThreadEvent;

        protected override IEnumerable<EntityType> GetSupportedActors() => new[]
        {
            EntityType.Person
        };

        protected override IEnumerable<CaliperAction> GetSupportedActions() => new[]
        {
            CaliperAction.MarkedAsRead,
            CaliperAction.MarkedAsUnread
        };

        protected override IEnumerable<EntityType> GetSupportedObjects() => new[]
        {
            EntityType.Thread
        };
    }
}
