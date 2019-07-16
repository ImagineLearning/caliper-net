
using ImsGlobal.Caliper.Entities.Feedback;
using Newtonsoft.Json;
using NodaTime;

namespace ImsGlobal.Caliper.Entities.Survey
{

	public class DateTimeQuestion : Question {

		public DateTimeQuestion(string id, ICaliperContext caliperContext = null)
			: base(id, caliperContext) {
			this.Type = EntityType.DateTimeQuestion;
		}

		[JsonProperty( "minDateTime", Order = 13 )]
		public Instant? MinDateTime { get; set; }

        [JsonProperty("minLabel", Order = 14)]
        public string MinLabel { get; set; }

        [JsonProperty("maxDateTime", Order = 15)]
        public Instant? MaxDateTime { get; set; }

        [JsonProperty("maxLabel", Order = 16)]
        public string MaxLabel { get; set; }
    }

}
