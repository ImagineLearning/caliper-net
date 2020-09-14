using ImsGlobal.Caliper.Entities.Session;
using Newtonsoft.Json;
using System;

namespace ImsGlobal.Caliper.Events.Forum
{
    /// <summary>
    /// Event raised when an actor interacts with a media resource.
    /// </summary>
    public class ForumEvent : Event
    {
        /// <summary>
        /// parameterless constructor required for JSON Deserialization
        /// </summary>
        public ForumEvent() { }

        public ForumEvent(Guid id, Action action) : this(id.ToCaliperUUID(), action) { }

        public ForumEvent(string id, Action action) : base(id)
        {
            Type = EventType.Forum;
            Action = action;
        }

        [JsonProperty("object", Order = 5)]
        public new Entities.Forum.Forum Object { get; set; }

        [JsonProperty("federatedSession", Order = 14)]
        public new LtiSession FederatedSession { get; set; }
    }
}
