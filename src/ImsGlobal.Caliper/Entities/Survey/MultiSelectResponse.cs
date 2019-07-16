
using Newtonsoft.Json;
using NodaTime;

namespace ImsGlobal.Caliper.Entities.Survey
{

	public class MultiSelectResponse : Entity {

		public MultiSelectResponse(string id, ICaliperContext caliperContext = null)
			: base(id, caliperContext) {
			this.Type = EntityType.MultiSelectResponse;
		}

		[JsonProperty("selections", Order = 11 )]
		public string[] Selections { get; set; }

        [JsonProperty("startedAtTime", Order = 12)]
        public Instant? StartedAtTime { get; set; }

        [JsonProperty("endedAtTime", Order = 13)]
        public Instant? EndedAtTime { get; set; }

        [JsonProperty("duration", Order = 14)]
        public Period Duration { get; set; }
    }

}
