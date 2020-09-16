using System;

namespace ImsGlobal.Caliper.Entities.Reading
{
    /// <summary>
    /// A Caliper Chapter represents a major sub-division of a piece of digital content.
    /// </summary>
    public class Chapter : DigitalResource
    {
        /// <summary>
        /// Parameterless constructor for JSON Deserialization
        /// </summary>
        public Chapter()
        {
            Type = EntityType.Chapter;
        }

        public Chapter(Uri id) : base(id)
        {
            Type = EntityType.Chapter;
        }
    }
}