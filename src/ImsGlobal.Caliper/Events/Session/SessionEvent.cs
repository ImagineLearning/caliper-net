using System;

namespace ImsGlobal.Caliper.Events.Session
{

    public class SessionEvent : Event
    {
        /// <summary>
        /// parameterless constructor required for JSON Deserialization
        /// </summary>
        public SessionEvent() { }

        public SessionEvent(Guid id, Action action) : this(id.ToCaliperUUID(), action) { }

        public SessionEvent(string id, Action action) : base(id)
        {
            Type = EventType.Session;
            Action = action;
        }

    }

}
