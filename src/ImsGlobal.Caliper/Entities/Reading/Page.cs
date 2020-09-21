using System;

namespace ImsGlobal.Caliper.Entities
{
    /// <summary>
    /// A Caliper Page represents an item of paginated content.
    /// </summary>
    public class Page : DigitalResource
    {
        /// <summary>
        /// Parameterless constructor for JSON Deserialization
        /// </summary>
        public Page() { }

        public Page(Uri id) : base(id) { }


        protected override EntityType GetEntityType() => EntityType.Page;
    }
}
