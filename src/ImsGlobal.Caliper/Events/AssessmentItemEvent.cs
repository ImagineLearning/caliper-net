using ImsGlobal.Caliper.Entities;
using System;
using System.Collections.Generic;

namespace ImsGlobal.Caliper.Events
{
    /// <summary>
    /// A Caliper AssessmentItemEvent models a learner’s interaction with an individual AssessmentItem.
    /// </summary>
    public class AssessmentItemEvent : Event
    {
        /// <summary>
        /// parameterless constructor required for JSON Deserialization
        /// </summary>
        public AssessmentItemEvent() { }

        public AssessmentItemEvent(Guid id, CaliperAction action) : this(id.ToCaliperUUID(), action) { }

        public AssessmentItemEvent(string id, CaliperAction action) : base(id)
        {
            Action = action;
        }


        protected override EventType GetEventType() => EventType.AssessmentItemEvent;

        protected override IEnumerable<EntityType> GetSupportedActors() => new[]
        {
            EntityType.Person
        };

        protected override IEnumerable<CaliperAction> GetSupportedActions() => new[]
        {
            CaliperAction.Started,
            CaliperAction.Skipped,
            CaliperAction.Completed
        };

        protected override IEnumerable<EntityType> GetSupportedObjects() => new[]
        {
            EntityType.AssessmentItem
        };

        protected override IEnumerable<EntityType> GetSupportedGeneratedEntities() => new[]
        {
            EntityType.Response,
            EntityType.FillinBlankResponse,
            EntityType.MultipleChoiceResponse,
            EntityType.MultipleResponseResponse,
            EntityType.SelectTextResponse,
            EntityType.TrueFalseResponse
        };
    }
}
