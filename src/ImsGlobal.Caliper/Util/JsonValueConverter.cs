using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace ImsGlobal.Caliper.Util
{
    internal sealed class JsonValueConverter<T> : JsonConverter<T> where T : IJsonValue, new()
    {
        public override T ReadJson(JsonReader reader, Type objectType, T existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            return new T { Value = JToken.Load(reader).ToString() };
        }

        public override void WriteJson(JsonWriter writer, T value, JsonSerializer serializer)
        {
            JToken.FromObject(value.Value).WriteTo(writer);
        }
    }
}
