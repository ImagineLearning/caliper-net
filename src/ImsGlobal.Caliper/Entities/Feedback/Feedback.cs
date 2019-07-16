namespace ImsGlobal.Caliper.Entities.Feedback
{
    public class Feedback : Entity
    {
        public Feedback(string id, ICaliperContext caliperContext = null)
            : base(id, caliperContext)
        {
            this.Type = EntityType.Feedback;
        }
    }
}