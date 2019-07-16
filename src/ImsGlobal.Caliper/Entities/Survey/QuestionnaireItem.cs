
using Newtonsoft.Json;

namespace ImsGlobal.Caliper.Entities.Survey
{
    using ImsGlobal.Caliper.Entities.Feedback;

    public class QuestionnaireItem : Entity {

		public QuestionnaireItem(string id, ICaliperContext caliperContext = null)
			: base(id, caliperContext) {
			this.Type = EntityType.QuestionnaireItem;
		}

		[JsonProperty( "question", Order = 11 )]
		public Question Question { get; set; }

        [JsonProperty("categories", Order = 12)]
        public string[] Categories { get; set; }

        [JsonProperty( "weight", Order = 13 )]
		public double Weight { get; set; }
	}

}
