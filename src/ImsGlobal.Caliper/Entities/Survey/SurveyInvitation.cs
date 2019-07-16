
using ImsGlobal.Caliper.Entities.Agent;
using Newtonsoft.Json;
using NodaTime;

namespace ImsGlobal.Caliper.Entities.Survey {

	public class SurveyInvitation : Entity {

		public SurveyInvitation(string id, ICaliperContext caliperContext = null)
			: base(id, caliperContext) {
			this.Type = EntityType.SurveyInvitation;
		}

        [JsonProperty("sentCount", Order = 11)]
        public int SentCount { get; set; }

        [JsonProperty("dateSent", Order = 12)]
        public Instant? DateSent { get; set; }

        [JsonProperty("rater", Order = 13)]
		public Person Rater { get; set; }

        [JsonProperty("survey", Order = 14)]
        public Survey Survey { get; set; }
    }

}
