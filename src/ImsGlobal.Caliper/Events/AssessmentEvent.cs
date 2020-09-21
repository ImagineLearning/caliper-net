using ImsGlobal.Caliper.Entities;
using System;
using System.Collections.Generic;

namespace ImsGlobal.Caliper.Events
{
    /// <summary>
    /// <para>
    /// A Caliper AssessmentEvent models learner interactions with assessments instruments such as online tests or quizzes.
    /// </para>
    /// </summary>
    public class AssessmentEvent : Event
    {
        /// <summary>
        /// parameterless constructor required for JSON Deserialization
        /// </summary>
        public AssessmentEvent() { }

        public AssessmentEvent(Guid id, CaliperAction action) : this(id.ToCaliperUUID(), action) { }

        public AssessmentEvent(string id, CaliperAction action) : base(id)
        {
            Action = action;
        }


        protected override EventType GetEventType() => EventType.AssessmentEvent;

        protected override IEnumerable<EntityType> GetSupportedActors() => new[]
        {
            EntityType.Person
        };

        protected override IEnumerable<CaliperAction> GetSupportedActions() => new[]
        {
            CaliperAction.Started,
            CaliperAction.Paused,
            CaliperAction.Resumed,
            CaliperAction.Restarted,
            CaliperAction.Reset,
            CaliperAction.Submitted
        };

        protected override IEnumerable<EntityType> GetSupportedObjects() => new[]
        {
            EntityType.Assessment
        };

        protected override IEnumerable<EntityType> GetSupportedGeneratedEntities() => new[]
        {
            EntityType.Attempt
        };
    }
}
