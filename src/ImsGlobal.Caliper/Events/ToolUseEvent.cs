using ImsGlobal.Caliper.Entities;
using System;
using System.Collections.Generic;

namespace ImsGlobal.Caliper.Events
{
    /// <summary>
    /// A Caliper ToolUseEvent models a Person using a learning tool in a way that the tool’s creators have determined is an 
    /// indication of a learning interaction.
    /// </summary>
    public class ToolUseEvent : Event
    {
        /// <summary>
        /// parameterless constructor required for JSON Deserialization
        /// </summary>
        public ToolUseEvent() { }

        public ToolUseEvent(Guid id) : this(id.ToCaliperUUID()) { }

        public ToolUseEvent(string id) : base(id)
        {
            Action = CaliperAction.Used;
        }


        protected override EventType GetEventType() => EventType.ToolUseEvent;

        protected override IEnumerable<EntityType> GetSupportedActors() => new[]
        {
            EntityType.Person
        };

        protected override IEnumerable<CaliperAction> GetSupportedActions() => new[]
        {
            CaliperAction.Used
        };

        protected override IEnumerable<EntityType> GetSupportedObjects() => new[]
        {
            EntityType.SoftwareApplication
        };
    }
}
