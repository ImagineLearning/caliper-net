using ImsGlobal.Caliper.Entities.Forum;
using ImsGlobal.Caliper.Entities.Session;
using Newtonsoft.Json;
using System;

namespace ImsGlobal.Caliper.Events.Forum
{
    /// <summary>
    /// Event raised when an actor interacts with a media resource.
    /// </summary>
    public class MessageEvent : Event
    {
        /// <summary>
        /// parameterless constructor required for JSON Deserialization
        /// </summary>
        public MessageEvent() { }

        public MessageEvent(Guid id, Action action) : this(id.ToCaliperUUID(), action) { }

        public MessageEvent(string id, Action action) : base(id)
        {
            Type = EventType.Message;
            Action = action;
        }

        [JsonProperty("object", Order = 5)]
        public new Message Object { get; set; }

        [JsonProperty("federatedSession", Order = 14)]
        public new LtiSession FederatedSession { get; set; }
    }
}
