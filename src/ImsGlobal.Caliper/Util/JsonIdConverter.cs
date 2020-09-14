using System;
using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ImsGlobal.Caliper.Util
{
    internal sealed class JsonIdConverter<T> : JsonConverter<T> where T : IJsonId
    {
        public override bool CanRead => false;

        public override bool CanWrite => true;


        public override T ReadJson(JsonReader reader, Type objectType, [AllowNull] T existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override void WriteJson(JsonWriter writer, T value, JsonSerializer serializer)
        {
            JToken.FromObject(value.Id).WriteTo(writer);
        }
    }
}
