using ImsGlobal.Caliper.Entities.SchemaDotOrg;
using Newtonsoft.Json;
using System;

namespace ImsGlobal.Caliper.Entities
{
    /// <summary>
    /// A Caliper SoftwareApplication represents a computer program, application, module, platform or system.
    /// </summary>
    public class SoftwareApplication : Agent, ISoftwareApplication
    {
        /// <summary>
        /// An optional string value that designates the current form or version of this SoftwareApplication.
        /// </summary>
        [JsonProperty("version", Order = 60)]
        public string Version { get; set; }


        /// <summary>
        /// Parameterless constructor for JSON Deserialization
        /// </summary>
        public SoftwareApplication() { }

        public SoftwareApplication(Uri id) : base(id) { }


        protected override EntityType GetEntityType() => EntityType.SoftwareApplication;
    }
}
