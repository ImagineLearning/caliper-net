using ImsGlobal.Caliper.Entities;
using ImsGlobal.Caliper.Events;
using ImsGlobal.Caliper.Protocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImsGlobal.Caliper
{
    /// <summary>
    /// A Caliper sensor for sending events and entities to Caliper endpoints.
    /// </summary>
    public class CaliperSensor
    {
        private readonly string sensorId;
        private readonly Dictionary<string, CaliperClient> clients = new Dictionary<string, CaliperClient>();

        /// <summary>
        /// Constructs a new CaliperSensor instance.
        /// </summary>
        /// <param name="sensorId">A sensor identifier to uniquely identify the source of events.</param>
        public CaliperSensor(string sensorId)
        {
            this.sensorId = sensorId;
        }

        /// <summary>
        /// Registers a new Caliper endpoint with the sensor.
        /// </summary>
        /// <param name="options">The Caliper endpoint options.</param>
        /// <returns>A unique identifier for the endpoint.</returns>
        public string RegisterEndpoint(CaliperEndpointOptions options)
        {
            if (options == null)
                throw new ArgumentNullException("options");

            string endpointId = "caliper-endpoint_" + Guid.NewGuid().ToString("N");
            clients.Add(endpointId, new CaliperClient(options, sensorId));
            return endpointId;
        }

        /// <summary>
        /// Sends a sequence of events to the all configured Caliper endpoints.
        /// </summary>
        /// <param name="events">The event sequence to be sent.</param>
        public async Task<bool> SendAsync(IEnumerable<Event> events)
        {
            var tasks = clients.Values.Select(client => client.Send(events));
            var results = await Task.WhenAll(tasks);
            return results.All(result => result);
        }

        /// <summary>
        /// Sends an event to the all configured Caliper endpoints.
        /// </summary>
        /// <param name="event">The event to be sent.</param>
        public async Task<bool> SendAsync(Event @event)
        {
            return await SendAsync(new[] { @event });
        }

        /// <summary>
        /// Sends a sequence of events to a specific Caliper endpoint.
        /// </summary>
        /// <param name="events">The events to be sent.</param>
        /// <param name="endpointId">The Caliper endpoint identifier.</param>
        public async Task<bool> SendAsync(IEnumerable<Event> events, string endpointId)
        {
            CaliperClient client;
            if (!clients.TryGetValue(endpointId, out client))
                return false;

            return await client.Send(events);
        }

        /// <summary>
        /// Sends an event to a specific Caliper endpoint.
        /// </summary>
        /// <param name="event">The event to be sent.</param>
        /// <param name="endpointId">The Caliper endpoint identifier.</param>
        public async Task<bool> SendAsync(Event @event, string endpointId)
        {
            return await SendAsync(new[] { @event }, endpointId);
        }

        /// <summary>
        /// Sends a sequence of entities to all configured Caliper endpoints.
        /// </summary>
        /// <param name="entities">The entities to be sent.</param>
        public async Task<bool> DescribeAsync(IEnumerable<Entity> entities)
        {
            var tasks = clients.Values.Select(client => client.Describe(entities));
            var results = await Task.WhenAll(tasks);
            return results.All(result => result);
        }

        /// <summary>
        /// Sends an entity to the configured Caliper endpoint.
        /// </summary>
        /// <param name="entity">The entity to be sent.</param>
        public async Task<bool> DescribeAsync(Entity entity)
        {
            return await DescribeAsync(new[] { entity });
        }

        /// <summary>
        /// Sends a sequence of entities to a specific Caliper endpoint.
        /// </summary>
        /// <param name="entities">The entities to be sent.</param>
        /// <param name="endpointId">The Caliper endpoint identifier.</param>
        public async Task<bool> DescribeAsync(IEnumerable<Entity> entities, string endpointId)
        {
            CaliperClient client;
            if (!clients.TryGetValue(endpointId, out client))
                return false;

            return await client.Describe(entities);
        }

        /// <summary>
        /// Sends an entity to a specific Caliper endpoint.
        /// </summary>
        /// <param name="entity">The entity to be sent.</param>
        /// <param name="endpointId">The Caliper endpoint identifier.</param>
        public async Task<bool> DescribeAsync(Entity entity, string endpointId)
        {
            return await DescribeAsync(new[] { entity }, endpointId);
        }
    }
}
