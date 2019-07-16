
using ImsGlobal.Caliper.Entities.Feedback;
using Newtonsoft.Json;

namespace ImsGlobal.Caliper.Entities.Survey
{

	public class MultiSelectQuestion : Question {

		public MultiSelectQuestion(string id, ICaliperContext caliperContext = null)
			: base(id, caliperContext) {
			this.Type = EntityType.MultiSelectQuestion;
		}

		[JsonProperty("points", Order = 13 )]
		public int Points { get; set; }

        [JsonProperty("itemLabels", Order = 14)]
        public string[] ItemLabels { get; set; }

        [JsonProperty("itemValues", Order = 15)]
        public string[] ItemValues { get; set; }
    }

}
