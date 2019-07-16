using Newtonsoft.Json;

namespace ImsGlobal.Caliper.Protocol {

	internal class CaliperEndpointConfigPayload {

		[JsonProperty("caliper_maximum_payload_size", Order = 2 )]
		public int MaxPayloadSize { get; set; }

		[JsonProperty("caliper_supported_extensions", Order = 3 )]
		public CaliperEndpoint SupportedExtensions { get; set; }

		[JsonProperty("caliper_supported_versions", Order = 4)]
		public CaliperContextCollection SupportedVersions { get; set; }
	}
}
