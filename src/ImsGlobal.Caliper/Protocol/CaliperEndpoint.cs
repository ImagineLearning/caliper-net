using Newtonsoft.Json;

namespace ImsGlobal.Caliper.Protocol {

	internal class CaliperEndpoint {

		[JsonProperty("endpoint_name", Order = 2 )]
		public string Name { get; set; }

		[JsonProperty("endpoint_version", Order = 3 )]
		public string Version { get; set; }
	}

}
