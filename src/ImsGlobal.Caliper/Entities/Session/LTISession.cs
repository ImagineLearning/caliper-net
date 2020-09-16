using Newtonsoft.Json;
using System;

namespace ImsGlobal.Caliper.Entities.Session
{
    /// <summary>
    /// A Caliper LtiSession represents an LTI Tool Consumer user session.
    /// </summary>
    public class LtiSession : Session
    {
        /// <summary>
        /// Parameterless constructor for JSON Deserialization
        /// </summary>
        public LtiSession()
        {
            Type = EntityType.LtiSession;
        }

        public LtiSession(Uri id) : base(id)
        {
            Type = EntityType.LtiSession;
        }

        /// <summary>
        /// A map of LTI-specified message parameters that provide Tool Consumer-related contextual information. LTI message 
        /// parameters of whatever type (i.e., required, recommended, optional, custom and extension) MAY be referenced.
        /// </summary>
        [JsonProperty("messageParameters", Order = 31)]
        public object MessageParameters { get; set; }
    }
}
