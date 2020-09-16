using System;

namespace ImsGlobal.Caliper.Entities.Agent
{
    /// <summary>
    /// <para>A Caliper Person represents a human being, alive or deceased, real or imaginary.</para>
    /// Person inherits all the properties and requirements defined for its supertype Agent. 
    /// Additional requirements are described below:
    /// <list type="bullet">
    /// <item><b>Type</b> - The string value MUST be set to the Term <b>Person</b></item>
    /// <item><b>Name</b> - A string value comprising a word or phrase by which the Person is known</item>
    /// </list>
    /// </summary>
    public class Person : Agent
    {
        public Person(Uri id) : base(id)
        {
            Type = EntityType.Person;
        }
    }
}
