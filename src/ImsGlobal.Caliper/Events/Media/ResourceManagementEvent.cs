namespace ImsGlobal.Caliper.Events.Media {

	/// <summary>
	/// Event raised when an actor manages a digital resource.
	/// </summary>
	public class ResourceManagementEvent : Event {

		public ResourceManagementEvent( string id, Action action ) 
			:base( id ) {
			this.Type = EventType.ResourceManagement;
			this.Action = action;
		}

	}

}
