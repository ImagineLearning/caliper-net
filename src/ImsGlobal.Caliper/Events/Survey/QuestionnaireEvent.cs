namespace ImsGlobal.Caliper.Events.Survey {

	public class QuestionnaireEvent : Event {

		public QuestionnaireEvent(string id, Action action, ICaliperContext caliperContext = null) 
			:base (id, caliperContext) {
			this.Type = EventType.Questionnaire;
			this.Action = action;
		}

	}

}
