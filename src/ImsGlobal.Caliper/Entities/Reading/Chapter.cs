using System;


namespace ImsGlobal.Caliper.Entities
{
    /// <summary>
    /// A Caliper Chapter represents a major sub-division of a piece of digital content.
    /// </summary>
    public class Chapter : DigitalResource
    {
        /// <summary>
        /// Parameterless constructor for JSON Deserialization
        /// </summary>
        public Chapter() { }

        public Chapter(Uri id) : base(id) { }


        protected override EntityType GetEntityType() => EntityType.Chapter;
    }
}