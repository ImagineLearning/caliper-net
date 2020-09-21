using ImsGlobal.Caliper.Util;
using Newtonsoft.Json;


namespace ImsGlobal.Caliper.Entities
{
    [JsonConverter(typeof(JsonValueConverter<Status>))]
    public sealed class Status : IType, IJsonValue
    {
        public static Status Active { get; } = new Status("Active");

        public static Status Inactive { get; } = new Status("Inactive");


        public Status() { }

        public Status(string value)
        {
            Value = value;
        }

        public string Value { get; set; }
    }

}
