using ImsGlobal.Caliper.Entities.SchemaDotOrg;
using Newtonsoft.Json;
using System;

namespace ImsGlobal.Caliper.Entities.Agent
{
    /// <summary>
    /// A Caliper SoftwareApplication represents a computer program, application, module, platform or system.
    /// </summary>
    public class SoftwareApplication : Agent, ISoftwareApplication
    {
        /// <summary>
        /// Parameterless constructor for JSON Deserialization
        /// </summary>
        public SoftwareApplication()
        {
            Type = EntityType.SoftwareApplication;
        }

        public SoftwareApplication(Uri id) : base(id)
        {
            Type = EntityType.SoftwareApplication;
        }

        /// <summary>
        /// An optional string value that designates the current form or version of this SoftwareApplication.
        /// </summary>
        [JsonProperty("version", Order = 60)]
        public string Version { get; set; }

    }

}
