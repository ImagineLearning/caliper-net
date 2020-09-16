using System;
using System.Collections.Generic;
using Newtonsoft.Json;


namespace ImsGlobal.Caliper.Protocol
{
    internal class CaliperMessage<T>
    {
        internal CaliperMessage()
        {
            DataVersion = CaliperContext.Default.Value;
        }

        [JsonProperty("sensor", Order = 2)]
        public string SensorId { get; set; }

        [JsonProperty("sendTime", Order = 3)]
        public DateTime? SendTime { get; set; }

        [JsonProperty("dataVersion", Order = 4)]
        public string DataVersion { get; set; }

        [JsonProperty("data", Order = 5)]
        public IEnumerable<T> Data { get; set; }
    }
}
