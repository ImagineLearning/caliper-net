namespace ImsGlobal.Caliper.Events.Assessment {

    /// <summary>
    /// Models a Person managing an Entity
    /// </summary>
    public class ResourceManagementEvent : Event {

		public ResourceManagementEvent(string id,  Action action, ICaliperContext caliperContext = null) 
			: base(id, caliperContext) {
            this.Type = EventType.ResourceManagement;
			this.Action = action;
		}

	}

}
