using Newtonsoft.Json;
using System;


namespace ImsGlobal.Caliper.Entities
{
    /// <summary>
    /// <para>
    /// A Caliper CourseOffering represents the occurrence of a course or a type during a specified time period. 
    /// CourseOffering is composed of a subset of properties specified in the IMS LTI 2.1 specification, which in turn, draws 
    /// inspiration from the IMS LIS 1.0 specification.
    /// </para>
    /// </summary>
    public class CourseOffering : Organization
    {
        /// <summary>
        /// A string value that constitutes a human-readable identifier for the CourseOffering.
        /// </summary>
        [JsonProperty("courseNumber", Order = 21)]
        public string CourseNumber { get; set; }

        /// <summary>
        /// A string value that constitutes a human-readable identifier of the designated period in which this CourseOffering occurs
        /// </summary>
        [JsonProperty("academicSession", Order = 22)]
        public string AcademicSession { get; set; }


        /// <summary>
        /// Parameterless constructor for JSON Deserialization
        /// </summary>
        public CourseOffering() { }

        public CourseOffering(Uri id) : base(id) { }


        protected override EntityType GetEntityType() => EntityType.CourseOffering;
    }
}
