using System;

namespace ImsGlobal.Caliper.Events.Media
{
    /// <summary>
    /// Event raised when an actor interacts with a media resource.
    /// </summary>
    public class MediaEvent : Event
    {
        /// <summary>
        /// parameterless constructor required for JSON Deserialization
        /// </summary>
        public MediaEvent() { }

        public MediaEvent(Guid id, Action action) : this(id.ToCaliperUUID(), action) { }

        public MediaEvent(string id, Action action) : base(id)
        {
            Type = EventType.Media;
            Action = action;
        }
    }
}
