using Newtonsoft.Json;
using System;
using System.Text.Json;
using System.Xml;


namespace ImsGlobal.Caliper.Util
{
    public class CaliperDurationConverter : System.Text.Json.Serialization.JsonConverter<TimeSpan?>
    {
        public override TimeSpan? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            try { return XmlConvert.ToTimeSpan(reader.GetString()); }
            catch { return null; }
        }

        public override void Write(Utf8JsonWriter writer, TimeSpan? value, JsonSerializerOptions options)
        {
            if (value.HasValue)
                writer.WriteStringValue(XmlConvert.ToString(value.Value));
            else
                writer.WriteNullValue();
        }
    }

    public class CaliperDurationNewtonsoftConverter : Newtonsoft.Json.JsonConverter<TimeSpan?>
    {
        public override TimeSpan? ReadJson(JsonReader reader, Type objectType, TimeSpan? existingValue, bool hasExistingValue, Newtonsoft.Json.JsonSerializer serializer)
        {
            try { return XmlConvert.ToTimeSpan(reader.ReadAsString()); }
            catch { return null; }
        }

        public override void WriteJson(JsonWriter writer, TimeSpan? value, Newtonsoft.Json.JsonSerializer serializer)
        {
            if (value.HasValue)
                writer.WriteValue(XmlConvert.ToString(value.Value));
            else
                writer.WriteNull();
        }
    }
}
