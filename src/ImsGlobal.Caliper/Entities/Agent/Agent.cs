using ImsGlobal.Caliper.Entities.Foaf;

namespace ImsGlobal.Caliper.Entities.Agent
{
    public class Agent : Entity, IAgent
    {
        public Agent(string id) : base(id)
        {
            Type = EntityType.Agent;
        }
    }
}