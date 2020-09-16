using System;

namespace ImsGlobal.Caliper.Entities.Reading
{
    /// <summary>
    /// A Caliper Page represents an item of paginated content.
    /// </summary>
    public class Page : DigitalResource
    {
        /// <summary>
        /// Parameterless constructor for JSON Deserialization
        /// </summary>
        public Page()
        {
            Type = EntityType.Page;
        }

        public Page(Uri id) : base(id)
        {
            Type = EntityType.Page;
        }
    }
}
