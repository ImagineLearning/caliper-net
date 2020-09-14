using System;

namespace ImsGlobal.Caliper.Events.Reading
{
    /// <summary>
    /// Event raised when an actor navigates from one resource to another.
    /// </summary>
    public class NavigationEvent : Event
    {
        /// <summary>
        /// parameterless constructor required for JSON Deserialization
        /// </summary>
        public NavigationEvent() { }

        public NavigationEvent(Guid id) : this(id.ToCaliperUUID()) { }

        public NavigationEvent(string id) : base(id)
        {
            Type = EventType.Navigation;
            Action = Action.NavigatedTo;
        }
    }
}
