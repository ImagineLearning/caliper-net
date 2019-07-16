
using Newtonsoft.Json;

namespace ImsGlobal.Caliper.Entities.Survey
{

	public class Questionnaire : Entity {

		public Questionnaire(string id, ICaliperContext caliperContext = null)
			: base(id, caliperContext) {
			this.Type = EntityType.Questionnaire;
		}

		[JsonProperty( "items", Order = 11 )]
		public QuestionnaireItem[] Items { get; set; }
	}

}
