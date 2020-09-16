using System;

namespace ImsGlobal.Caliper.Entities.Reading
{
    /// <summary>
    /// A Caliper Document represents textual content.
    /// </summary>
    public class Document : DigitalResource
    {
        /// <summary>
        /// Parameterless constructor for JSON Deserialization
        /// </summary>
        public Document()
        {
            Type = EntityType.Document;
        }

        public Document(Uri id) : base(id)
        {
            Type = EntityType.Document;
        }
    }
}