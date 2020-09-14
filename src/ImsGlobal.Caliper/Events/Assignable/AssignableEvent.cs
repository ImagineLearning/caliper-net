using System;

namespace ImsGlobal.Caliper.Events.Assignable
{
    /// <summary>
    /// Event raised when an actor interacts with an assignable resource.
    /// </summary>
    public class AssignableEvent : Event
    {
        /// <summary>
        /// parameterless constructor required for JSON Deserialization
        /// </summary>
        public AssignableEvent() { }

        public AssignableEvent(Guid id, Action action) : this(id.ToCaliperUUID(), action) { }

        public AssignableEvent(string id, Action action) : base(id)
        {
            Type = EventType.Assignable;
            Action = action;
        }
    }
}
