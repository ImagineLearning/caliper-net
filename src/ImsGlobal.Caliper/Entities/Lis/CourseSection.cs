using Newtonsoft.Json;
using System;

namespace ImsGlobal.Caliper.Entities
{
    /// <summary>
    /// <para>
    /// A Caliper CourseSection represents a specific instance of a CourseOffering occurring during a specific semester, term or 
    /// period. CourseSection is composed of a subset of properties specified in the IMS LTI 2.1 specification, which in turn, 
    /// draws inspiration from the IMS LIS 1.0 specification.
    /// </para>
    /// <para>
    /// A CourseSection is a way to represent a group of people associated with a course or class. These groups may include 
    /// everyone in the class or course, or may be subsets of that whole group.
    /// </para>
    /// <para>
    /// CourseSections may have sub-sections (these are created as separate Group objects linked using the relationship). 
    /// Examples of a CourseSection are Lecture, Laboratory, Studio, Seminar, etc. There may be several instances of a type of 
    /// CourseSection e.g.,  multiple lectures.
    /// </para>
    /// </summary>
    public class CourseSection : CourseOffering
    {
        /// <summary>
        /// A string value that characterizes the purpose of the section such as “lecture”, “lab” or “seminar”.
        /// </summary>
        [JsonProperty("category", Order = 20)]
        public string Category { get; set; }


        /// <summary>
        /// Parameterless constructor for JSON Deserialization
        /// </summary>
        public CourseSection() { }

        public CourseSection(Uri id) : base(id) { }


        protected override EntityType GetEntityType() => EntityType.CourseSection;
    }
}
