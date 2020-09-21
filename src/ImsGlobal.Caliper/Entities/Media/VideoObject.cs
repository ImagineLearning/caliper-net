using System;

namespace ImsGlobal.Caliper.Entities
{
    /// <summary>
    /// A Caliper VideoObject represents a visual recording stored in digital form.
    /// </summary>
    public class VideoObject : MediaObject
    {
        /// <summary>
        /// Parameterless constructor for JSON Deserialization
        /// </summary>
        public VideoObject() { }

        public VideoObject(Uri id) : base(id) { }


        protected override EntityType GetEntityType() => EntityType.VideoObject;
    }
}
