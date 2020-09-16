using System;


namespace ImsGlobal.Caliper.Entities.Agent
{
    /// <summary>
    /// A Caliper Agent is a generic type that represents an Entity that can initiate or perform an action.
    /// Utilize Agent only if no suitable subtype exists to represent the actor being described.
    /// <list type="bullet">
    /// <item><b>Type</b> value MUST be set to the Term <b>Agent</b></item>
    /// </list>
    /// </summary>
    public class Agent : Entity
    {
        /// <summary>
        /// Parameterless constructor for JSON Deserialization
        /// </summary>
        public Agent()
        {
            Type = EntityType.Agent;
        }

        public Agent(Uri id) : base(id)
        {
            Type = EntityType.Agent;
        }
    }
}