using System;

namespace ImsGlobal.Caliper.Entities
{
    /// <summary>
    /// A Caliper WebPage represents a document containing markup that is suitable for display in a web browser.
    /// </summary>
    public class WebPage : DigitalResource
    {
        /// <summary>
        /// Parameterless constructor for JSON Deserialization
        /// </summary>
        public WebPage()
        {
            Type = EntityType.WebPage;
        }

        public WebPage(Uri id) : base(id)
        {
            this.Type = EntityType.WebPage;
        }
    }
}
