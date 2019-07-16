
using ImsGlobal.Caliper.Entities.Feedback;

namespace ImsGlobal.Caliper.Entities.Survey
{

	public class OpenEndedQuestion : Question {

		public OpenEndedQuestion(string id, ICaliperContext caliperContext = null)
			: base(id, caliperContext) {
			this.Type = EntityType.OpenEndedQuestion;
		}
    }

}
