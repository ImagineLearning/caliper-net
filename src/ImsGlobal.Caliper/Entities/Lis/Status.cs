using ImsGlobal.Caliper.Util;
using Newtonsoft.Json;


namespace ImsGlobal.Caliper.Entities.Lis
{
    [JsonConverter(typeof(JsonValueConverter<Status>))]
    public sealed class Status : IType, IJsonValue
    {

        public static readonly Status Active = new Status("Active");
        public static readonly Status Inactive = new Status("Inactive");

        public Status() { }

        public Status(string value)
        {
            Value = value;
        }

        public string Value { get; set; }
    }

}
