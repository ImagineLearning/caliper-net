using System;
using System.Net.Http;

namespace ImsGlobal.Caliper
{
    /// <summary>
    /// Options for registering a Caliper endpoint with the Caliper sensor.
    /// </summary>
    public class CaliperEndpointOptions
    {
        const int DEFAULT_TIMEOUT = 10000;

        static HttpClient CreateDefaultHttpClient() => new HttpClient();


        public CaliperEndpointOptions(Uri host, string apiKey = null, int timeout = DEFAULT_TIMEOUT)
        {
            if (host == null)
                throw new ArgumentNullException(nameof(host));

            if (timeout < 1000)
                throw new ArgumentOutOfRangeException(nameof(timeout), "timeout must be at least 1000 milliseconds.");

            Host = host;
            ApiKey = apiKey;
            Timeout = timeout;
        }

        /// <summary>
        /// The Caliper web API endpoint.
        /// </summary>
        public Uri Host { get; set; }

        /// <summary>
        /// The Caliper web API key.
        /// </summary>
        public string ApiKey { get; set; }

        /// <summary>
        /// Connection timeout in milliseconds.
        /// </summary>
        public int Timeout { get; set; }

        /// <summary>
        /// Method used to construct HttpClient. Intended for CreateClient call from IHttpClientFactory
        /// </summary>
        public Func<HttpClient> CreateHttpClient { get; set; } = CreateDefaultHttpClient;
    }
}
