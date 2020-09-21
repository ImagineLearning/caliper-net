using System;


namespace ImsGlobal.Caliper.Entities
{
    /// <summary>
    /// A Caliper ImageObject represents an image file.
    /// </summary>
    public class ImageObject : MediaObject
    {
        /// <summary>
        /// Parameterless constructor for JSON Deserialization
        /// </summary>
        public ImageObject() { }

        public ImageObject(Uri id) : base(id) { }


        protected override EntityType GetEntityType() => EntityType.ImageObject;
    }
}
