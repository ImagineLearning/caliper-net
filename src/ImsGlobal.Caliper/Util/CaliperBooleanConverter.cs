using Newtonsoft.Json;
using System;
using System.Text.Json;


namespace ImsGlobal.Caliper.Util
{
    public class CaliperBooleanConverter : System.Text.Json.Serialization.JsonConverter<bool?>
    {
        public override bool? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var text = reader.GetString();
            switch (text.ToLower())
            {
                case "true":
                case "yes":
                    return true;

                case "false":
                case "no":
                    return false;

                default:
                    return null;
            }
        }

        public override void Write(Utf8JsonWriter writer, bool? value, JsonSerializerOptions options)
        {
            if (value.HasValue)
                writer.WriteStringValue(value.Value.ToString().ToLower());
            else
                writer.WriteNullValue();
        }
    }

    public class CaliperBooleanNewtonsoftConverter : Newtonsoft.Json.JsonConverter<bool?>
    {
        public override bool? ReadJson(JsonReader reader, Type objectType, bool? existingValue, bool hasExistingValue, Newtonsoft.Json.JsonSerializer serializer)
        {
            var text = reader.ReadAsString();
            switch (text.ToLower())
            {
                case "true":
                case "yes":
                    return true;

                case "false":
                case "no":
                    return false;

                default:
                    return null;
            }
        }

        public override void WriteJson(JsonWriter writer, bool? value, Newtonsoft.Json.JsonSerializer serializer)
        {
            if (value.HasValue)
                writer.WriteValue(value.Value.ToString().ToLower());
            else
                writer.WriteNull();
        }
    }
}
