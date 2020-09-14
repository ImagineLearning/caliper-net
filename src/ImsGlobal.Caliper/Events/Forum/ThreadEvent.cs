using ImsGlobal.Caliper.Entities.Forum;
using ImsGlobal.Caliper.Entities.Session;
using Newtonsoft.Json;
using System;

namespace ImsGlobal.Caliper.Events.Forum
{
    /// <summary>
    /// Event raised when an actor interacts with a media resource.
    /// </summary>
    public class ThreadEvent : Event
    {
        /// <summary>
        /// parameterless constructor required for JSON Deserialization
        /// </summary>
        public ThreadEvent() { }

        public ThreadEvent(Guid id, Action action) : this(id.ToCaliperUUID(), action) { }

        public ThreadEvent(string id, Action action) : base(id)
        {
            Type = EventType.Thread;
            Action = action;
        }

        [JsonProperty("object", Order = 5)]
        public new Thread Object { get; set; }

        [JsonProperty("federatedSession", Order = 14)]
        public new LtiSession FederatedSession { get; set; }
    }
}
