using System;


namespace ImsGlobal.Caliper.Entities
{
    /// <summary>
    /// A Caliper Document represents textual content.
    /// </summary>
    public class Document : DigitalResource
    {
        /// <summary>
        /// Parameterless constructor for JSON Deserialization
        /// </summary>
        public Document() { }

        public Document(Uri id) : base(id) { }


        protected override EntityType GetEntityType() => EntityType.Document;
    }
}