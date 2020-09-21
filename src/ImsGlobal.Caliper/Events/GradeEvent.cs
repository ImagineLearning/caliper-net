using ImsGlobal.Caliper.Entities;
using System;
using System.Collections.Generic;

namespace ImsGlobal.Caliper.Events
{
    /// <summary>
    /// A Caliper GradeEvent models scoring or grading activities performed by an Agent, typically a Person or a SoftwareApplication.
    /// </summary>
    public class GradeEvent : Event
    {
        /// <summary>
        /// parameterless constructor required for JSON Deserialization
        /// </summary>
        public GradeEvent() { }

        public GradeEvent(Guid id, CaliperAction action) : this(id.ToCaliperUUID(), action) { }

        public GradeEvent(string id, CaliperAction action) : base(id)
        {
            Action = action;
        }


        protected override EventType GetEventType() => EventType.GradeEvent;

        protected override IEnumerable<EntityType> GetSupportedActors() => new[]
        {
            EntityType.Agent
        };

        protected override IEnumerable<CaliperAction> GetSupportedActions() => new[]
        {
            CaliperAction.Graded
        };

        protected override IEnumerable<EntityType> GetSupportedObjects() => new[]
        {
            EntityType.Attempt
        };

        protected override IEnumerable<EntityType> GetSupportedGeneratedEntities() => new[]
        {
            EntityType.Score
        };
    }
}
