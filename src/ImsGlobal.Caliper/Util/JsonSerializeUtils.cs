using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NodaTime;
using NodaTime.Serialization.JsonNet;

namespace ImsGlobal.Caliper.Util
{
    internal static class JsonSerializeUtils
    {
        public static JsonSerializerSettings SerializerSettings { get; }

        static JsonSerializeUtils()
        {
            SerializerSettings = new JsonSerializerSettings();
            SerializerSettings.ConfigureForNodaTime(DateTimeZoneProviders.Tzdb);
            SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
            SerializerSettings.DefaultValueHandling = DefaultValueHandling.Ignore;
        }

        /// <summary>
        /// Convert an object to a JObject via a string roundtrip using default serializer settings
        /// </summary>
        public static JObject ToJObject(object obj)
        {
            var str = JsonConvert.SerializeObject(obj, SerializerSettings);
            return JObject.Parse(str);
        }

        /// <summary>
        /// Remove empty elements and multiple occurrences of the default context. 
        /// </summary>
        public static JObject Clean(JObject json)
        {
            //remove empty elements
            IEnumerable<JToken> tokens = json.SelectTokens("..*").ToList();
            foreach (JToken tok in tokens)
            {
                if (IsNullOrEmpty(tok))
                {
                    tok.Parent.Remove();
                }
            }
            //remove dupe default contexts
            IEnumerable<JToken> contexts = json.SelectTokens("..@context").ToList();

            int seen = 0;
            foreach (JToken tok in contexts)
            {
                if (IsCaliperDefaultContext(tok))
                {
                    if (seen > 0)
                    {
                        tok.Parent.Remove();
                    }
                    seen++;
                }
            }

            return json;
        }

        private static bool IsNullOrEmpty(this JToken token)
        {
            if (token == null)
                return true;

            switch (token.Type)
            {
                case JTokenType.Array:
                    return !token.HasValues;

                case JTokenType.Object:
                    return !token.HasValues;

                case JTokenType.String:
                    return string.IsNullOrEmpty(token.ToString());

                case JTokenType.Null:
                    return true;
            }

            return false;
        }

        private static bool IsCaliperDefaultContext(this JToken token)
        {
            return token.ToString().Equals(CaliperContext.Context.Value);
        }
    }
}