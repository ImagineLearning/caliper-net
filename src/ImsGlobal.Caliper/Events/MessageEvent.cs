using ImsGlobal.Caliper.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;


namespace ImsGlobal.Caliper.Events
{
    /// <summary>
    /// A Caliper MessageEvent describes a Person posting a Message or marking a post as either read or unread.
    /// </summary>
    public class MessageEvent : Event
    {
        [JsonProperty("object", Order = 5)]
        public new Message Object { get; set; }

        [JsonProperty("federatedSession", Order = 14)]
        public new LtiSession FederatedSession { get; set; }


        /// <summary>
        /// parameterless constructor required for JSON Deserialization
        /// </summary>
        public MessageEvent() { }

        public MessageEvent(Guid id, CaliperAction action) : this(id.ToCaliperUUID(), action) { }

        public MessageEvent(string id, CaliperAction action) : base(id)
        {
            Action = action;
        }


        protected override EventType GetEventType() => EventType.MessageEvent;

        protected override IEnumerable<EntityType> GetSupportedActors() => new[]
        {
            EntityType.Person
        };

        protected override IEnumerable<CaliperAction> GetSupportedActions() => new[]
        {
            CaliperAction.MarkedAsRead,
            CaliperAction.MarkedAsUnread,
            CaliperAction.Posted
        };

        protected override IEnumerable<EntityType> GetSupportedObjects() => new[]
        {
            EntityType.Message
        };
    }
}
