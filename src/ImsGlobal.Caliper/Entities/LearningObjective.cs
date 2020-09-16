using System;

namespace ImsGlobal.Caliper.Entities
{
    /// <summary>
    /// A Caliper LearningObjective represents a brief statement of what a learner should know or be able to perform after 
    /// completing a unit of instruction or a period of learning.
    /// </summary>
    public class LearningObjective : Entity
    {
        /// <summary>
        /// Parameterless constructor for JSON Deserialization
        /// </summary>
        public LearningObjective()
        {
            Type = EntityType.LearningObjective;
        }

        public LearningObjective(Uri id) : base(id)
        {
            Type = EntityType.LearningObjective;
        }
    }
}
