using ImsGlobal.Caliper.Entities;
using ImsGlobal.Caliper.Events;
using ImsGlobal.Caliper.Util;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NodaTime;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace ImsGlobal.Caliper.Protocol
{
    internal class CaliperClient
    {
        private readonly CaliperEndpointOptions options;
        private readonly string sensorId;
        private readonly JsonSerializerSettings serializerSettings;

        public CaliperClient(CaliperEndpointOptions options, string sensorId)
        {
            this.options = options;
            this.sensorId = sensorId;
            serializerSettings = JsonSerializeUtils.SerializerSettings;
        }

        public async Task<bool> Send(IEnumerable<Event> events)
        {
            return await SendData(events);
        }

        public async Task<bool> Describe(IEnumerable<Entity> entities)
        {
            return await SendData(entities);
        }

        public async Task<bool> SendData<T>(IEnumerable<T> data)
        {
            var message = new CaliperMessage<T>
            {
                SensorId = sensorId,
                SendTime = SystemClock.Instance.GetCurrentInstant(),
                Data = data
            };
            var jsonString = JsonConvert.SerializeObject(message, serializerSettings);
            var jsonObject = JsonSerializeUtils.Clean(JObject.Parse(jsonString));
            var content = new StringContent(jsonObject.ToString(), Encoding.UTF8, "application/json");

            var client = options.CreateHttpClient();
            client.BaseAddress = options.Host;

            if (!string.IsNullOrWhiteSpace(options.ApiKey))
                client.DefaultRequestHeaders.Add("Authorization", options.ApiKey);

            try
            {
                HttpResponseMessage response = await client.PostAsync("", content);
                response.EnsureSuccessStatusCode();
            }
            catch (HttpRequestException ex)
            {
                Trace.WriteLine($"Failed to send data: {ex.Message}");
                return false;
            }

            return true;
        }
    }
}
