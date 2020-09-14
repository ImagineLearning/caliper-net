using System;

namespace ImsGlobal.Caliper.Events.Outcome
{
    /// <summary>
    /// Event raised when actions related to an outcome are performed.
    /// </summary>
    public class GradeEvent : Event
    {
        /// <summary>
        /// parameterless constructor required for JSON Deserialization
        /// </summary>
        public GradeEvent() { }

        public GradeEvent(Guid id, Action action) : this(id.ToCaliperUUID(), action) { }

        public GradeEvent(string id, Action action) : base(id)
        {
            Type = EventType.Outcome;
            Action = action;
        }
    }
}
