using System;

namespace ImsGlobal.Caliper.Events.Reading
{
    /// <summary>
    /// Event raised when an actor views a resource.
    /// </summary>
    public class ViewEvent : Event
    {
        /// <summary>
        /// parameterless constructor required for JSON Deserialization
        /// </summary>
        public ViewEvent() { }

        public ViewEvent(Guid id) : this(id.ToCaliperUUID()) { }

        public ViewEvent(string id) : base(id)
        {
            Type = EventType.View;
            Action = Action.Viewed;
        }

    }
}
