
using Newtonsoft.Json;

namespace ImsGlobal.Caliper.Entities.Survey
{

	public class Survey : Entity {

		public Survey(string id, ICaliperContext caliperContext = null)
			: base(id, caliperContext) {
			this.Type = EntityType.Survey;
		}

		[JsonProperty( "items", Order = 11 )]
		public Questionnaire[] Items { get; set; }
	}

}
