using ImsGlobal.Caliper.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;


namespace ImsGlobal.Caliper.Events
{
    /// <summary>
    /// A Caliper ForumEvent models learners and others participating in online forum communities. Forums typically encompass 
    /// one or more threads or topics to which members can subscribe, post messages and reply to other messages if a threaded 
    /// discussion is permitted.
    /// </summary>
    public class ForumEvent : Event
    {
        [JsonProperty("object", Order = 5)]
        public new Forum Object { get; set; }

        [JsonProperty("federatedSession", Order = 14)]
        public new LtiSession FederatedSession { get; set; }


        /// <summary>
        /// parameterless constructor required for JSON Deserialization
        /// </summary>
        public ForumEvent() { }

        public ForumEvent(Guid id, CaliperAction action) : this(id.ToCaliperUUID(), action) { }

        public ForumEvent(string id, CaliperAction action) : base(id)
        {
            Action = action;
        }


        protected override EventType GetEventType() => EventType.ForumEvent;

        protected override IEnumerable<EntityType> GetSupportedActors() => new[]
        {
            EntityType.Person,
        };

        protected override IEnumerable<CaliperAction> GetSupportedActions() => new[]
        {
            CaliperAction.Subscribed,
            CaliperAction.Unsubscribed
        };

        protected override IEnumerable<EntityType> GetSupportedObjects() => new[]
        {
            EntityType.Forum
        };
    }
}
