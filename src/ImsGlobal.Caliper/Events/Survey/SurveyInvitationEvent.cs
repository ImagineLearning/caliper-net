namespace ImsGlobal.Caliper.Events.Survey {

	public class SurveyInvitationEvent : Event {

		public SurveyInvitationEvent(string id, Action action, ICaliperContext caliperContext = null) 
			:base (id, caliperContext) {
			this.Type = EventType.SurveyInvitation;
			this.Action = action;
		}

	}

}
