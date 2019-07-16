namespace ImsGlobal.Caliper.Events.Survey {

	public class QuestionnaireItemEvent : Event {

		public QuestionnaireItemEvent(string id, Action action, ICaliperContext caliperContext = null) 
			:base (id, caliperContext) {
			this.Type = EventType.QuestionnaireItem;
			this.Action = action;
		}

	}

}
