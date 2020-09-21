using ImsGlobal.Caliper.Entities.SchemaDotOrg;
using ImsGlobal.Caliper.Util;
using Newtonsoft.Json;
using System;

using NetCore = System.Text.Json.Serialization;


namespace ImsGlobal.Caliper.Entities
{
    /// <summary>
    /// <para>A Caliper MediaObject represents a generic piece of media content</para>
    /// <b>NOTE: Utilize MediaObject only if no suitable subtype exists to represent the resource being described.</b>
    /// </summary>
    public class MediaObject : DigitalResource, IMediaObject
    {
        /// <summary>
        /// An optional time interval that represents the total time required to view and/or listen to the MediaObject at 
        /// normal speed. If a duration is specified the value MUST conform to the ISO 8601 duration format.
        /// </summary>
        [JsonProperty("duration", Order = 71)]
        [JsonConverter(typeof(CaliperDurationNewtonsoftConverter))]
        [NetCore.JsonConverter(typeof(CaliperDurationConverter))]
        public TimeSpan? Duration { get; set; }


        /// <summary>
        /// Parameterless constructor for JSON Deserialization
        /// </summary>
        public MediaObject() { }

        public MediaObject(Uri id) : base(id) { }


        protected override EntityType GetEntityType() => EntityType.MediaObject;
    }
}
