using ImsGlobal.Caliper.Util;
using Newtonsoft.Json;

namespace ImsGlobal.Caliper
{
    [JsonConverter(typeof(JsonValueConverter<CaliperContext>))]
    public sealed class CaliperContext : IJsonValue
    {
        /// <summary>
        /// If the top-level @context value is defined as a string it MUST be set to the Caliper remote context URL
        /// <b>http://purl.imsglobal.org/ctx/caliper/v1p1</b>
        /// </summary>
        public static CaliperContext Default { get; } = new CaliperContext("http://purl.imsglobal.org/ctx/caliper/v1p1");

        public CaliperContext() { }

        public CaliperContext(string value)
        {
            Value = value;
        }

        public string Value { get; set; }
    }
}