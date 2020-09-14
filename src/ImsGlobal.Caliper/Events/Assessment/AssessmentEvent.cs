using System;

namespace ImsGlobal.Caliper.Events.Assessment
{
    /// <summary>
    /// Event raised when an actor interacts with an assessment resource.
    /// </summary>
    public class AssessmentEvent : Event
    {
        /// <summary>
        /// parameterless constructor required for JSON Deserialization
        /// </summary>
        public AssessmentEvent() { }

        public AssessmentEvent(Guid id, Action action) : this(id.ToCaliperUUID(), action) { }

        public AssessmentEvent(string id, Action action) : base(id)
        {
            Type = EventType.Assessment;
            Action = action;
        }
    }
}
