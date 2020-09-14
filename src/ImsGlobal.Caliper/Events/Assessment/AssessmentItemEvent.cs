using System;

namespace ImsGlobal.Caliper.Events.Assessment
{
    /// <summary>
    /// Event raised when an actor interacts with an assessment item resource.
    /// </summary>
    public class AssessmentItemEvent : Event
    {
        /// <summary>
        /// parameterless constructor required for JSON Deserialization
        /// </summary>
        public AssessmentItemEvent() { }

        public AssessmentItemEvent(Guid id, Action action) : this(id.ToCaliperUUID(), action) { }

        public AssessmentItemEvent(string id, Action action) : base(id)
        {
            Type = EventType.AssessmentItem;
            Action = action;
        }
    }
}
