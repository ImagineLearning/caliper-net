namespace ImsGlobal.Caliper.Events.Survey {

	public class SurveyEvent : Event {

		public SurveyEvent(string id, Action action, ICaliperContext caliperContext = null) 
			:base (id, caliperContext) {
			this.Type = EventType.Survey;
			this.Action = action;
		}

	}

}
