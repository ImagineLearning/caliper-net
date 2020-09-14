using System;

namespace ImsGlobal.Caliper.Events.Tool
{
    public class ToolUseEvent : Event
    {
        /// <summary>
        /// parameterless constructor required for JSON Deserialization
        /// </summary>
        public ToolUseEvent() { }

        public ToolUseEvent(Guid id, Action action) : this(id.ToCaliperUUID(), action) { }

        public ToolUseEvent(string id, Action action) : base(id)
        {
            Type = EventType.ToolUse;
            Action = action;
        }
    }
}
