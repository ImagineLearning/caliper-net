using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using NetCore = System.Text.Json.Serialization;


namespace ImsGlobal.Caliper.Entities
{
    /// <summary>
    /// Base type for all PositionSelector types. As of Caliper 1.1, 
    /// only TextPositionSelector is defined.
    /// </summary>
    public abstract class Selector
    {
        public Selector(SelectorType type)
        {
            Type = type;
        }


        [JsonProperty("type", Order = 0)]
        [JsonConverter(typeof(StringEnumConverter))]
        [NetCore.JsonConverter(typeof(NetCore.JsonStringEnumConverter))]
        public SelectorType Type { get; }
    }
}
