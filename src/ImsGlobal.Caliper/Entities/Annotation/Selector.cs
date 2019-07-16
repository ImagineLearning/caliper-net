using Newtonsoft.Json;

namespace ImsGlobal.Caliper.Entities.Annotation {

	/// <summary>
	/// Base type for all PositionSelector types. As of Caliper 1.1, 
	/// only TextPositionSelector is defined.
	/// </summary>
	public abstract class Selector : Entity
    {
		public Selector(SelectorType type, ICaliperContext caliperContext = null) : base(id: null, context: caliperContext) {
			this.Type = type;
		}

	}
}
