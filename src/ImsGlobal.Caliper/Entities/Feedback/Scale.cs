using Newtonsoft.Json;

namespace ImsGlobal.Caliper.Entities.Feedback
{
    public class Scale : Entity
    {
        public Scale(string id, ICaliperContext caliperContext = null)
            : base(id, caliperContext)
        {
            this.Type = EntityType.Scale;
        }
    }
}