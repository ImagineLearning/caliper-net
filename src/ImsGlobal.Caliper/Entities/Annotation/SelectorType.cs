using ImsGlobal.Caliper.Util;
using Newtonsoft.Json;


namespace ImsGlobal.Caliper.Entities.Annotation
{
    [JsonConverter(typeof(JsonValueConverter<SelectorType>))]
    public sealed class SelectorType : IType, IJsonValue
    {
        public static SelectorType Text { get; } = new SelectorType("TextPositionSelector");

        public SelectorType() { }

        public SelectorType(string value)
        {
            Value = value;
        }

        public string Value { get; set; }
    }
}