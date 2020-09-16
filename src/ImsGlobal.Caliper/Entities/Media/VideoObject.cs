using ImsGlobal.Caliper.Entities.SchemaDotOrg;
using System;

namespace ImsGlobal.Caliper.Entities.Media
{
    /// <summary>
    /// A Caliper VideoObject represents a visual recording stored in digital form.
    /// </summary>
    public class VideoObject : MediaObject, IVideoObject
    {
        /// <summary>
        /// Parameterless constructor for JSON Deserialization
        /// </summary>
        public VideoObject()
        {
            Type = EntityType.VideoObject;
        }

        public VideoObject(Uri id) : base(id, EntityType.VideoObject)
        {
        }
    }
}
