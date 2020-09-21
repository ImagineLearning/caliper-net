using ImsGlobal.Caliper.Entities;
using System;
using System.Collections.Generic;

namespace ImsGlobal.Caliper.Events
{
    /// <summary>
    /// A Caliper MediaEvent models interactions between learners and rich content such as audio, images and video.
    /// </summary>
    public class MediaEvent : Event
    {
        /// <summary>
        /// parameterless constructor required for JSON Deserialization
        /// </summary>
        public MediaEvent() { }

        public MediaEvent(Guid id, CaliperAction action) : this(id.ToCaliperUUID(), action) { }

        public MediaEvent(string id, CaliperAction action) : base(id)
        {
            Action = action;
        }


        protected override EventType GetEventType() => EventType.MediaEvent;

        protected override IEnumerable<EntityType> GetSupportedActors() => new[]
        {
            EntityType.Person
        };

        protected override IEnumerable<CaliperAction> GetSupportedActions() => new[]
        {
            CaliperAction.Started,
            CaliperAction.Ended,
            CaliperAction.Paused,
            CaliperAction.Resumed,
            CaliperAction.Restarted,
            CaliperAction.ForwardedTo,
            CaliperAction.JumpedTo,
            CaliperAction.ChangedResolution,
            CaliperAction.ChangedSize,
            CaliperAction.ChangedSpeed,
            CaliperAction.ChangedVolume,
            CaliperAction.EnabledClosedCaptioning,
            CaliperAction.DisabledClosedCaptioning,
            CaliperAction.EnteredFullScreen,
            CaliperAction.ExitedFullScreen,
            CaliperAction.Muted,
            CaliperAction.Unmuted,
            CaliperAction.OpenedPopout,
            CaliperAction.ClosedPopout
        };

        protected override IEnumerable<EntityType> GetSupportedObjects() => new[]
        {
            EntityType.AudioObject,
            EntityType.ImageObject,
            EntityType.MediaObject,
            EntityType.VideoObject
        };

        protected override IEnumerable<EntityType> GetSupportedTargets() => new[]
        {
            EntityType.MediaLocation
        };
    }
}
