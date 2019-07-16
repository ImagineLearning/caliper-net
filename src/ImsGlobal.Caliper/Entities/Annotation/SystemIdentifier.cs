
using ImsGlobal.Caliper.Entities.Agent;
using Newtonsoft.Json;

namespace ImsGlobal.Caliper.Entities.Annotation
{

	public class SystemIdentifier : Entity {

		public SystemIdentifier(ICaliperContext caliperContext = null)
			: base(id: null, context: caliperContext) {
			this.Type = EntityType.SystemIdentifier;
		}

		[JsonProperty("identifier", Order = 11 )]
		public string Identifier { get; set; }

        [JsonProperty("identifierType", Order = 12)]
        public string IdentifierType { get; set; }

        [JsonProperty("source", Order = 13)]
        public SoftwareApplication Source { get; set; }
    }

}
