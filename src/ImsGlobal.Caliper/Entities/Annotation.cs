using Newtonsoft.Json;
using System;


namespace ImsGlobal.Caliper.Entities
{
    /// <summary>
    /// <para>
    /// A Caliper Annotation is a generic type that represents a comment, explanation, highlight, mark, note, question or tag 
    /// linked to a DigitalResource. The act of sharing a DigitalResource with others is also considered a form of annotation.
    /// </para>
    /// <b>NOTE: Utilize Annotation only if no suitable subtype exists to represent the annotation being described.</b>
    /// </summary>
    public class Annotation : Entity
    {
        /// <summary>
        /// The Person who created the Annotation. The annotator value MUST be expressed either as an object or as a string 
        /// corresponding to the annotator’s IRI.
        /// </summary>
        [JsonProperty("annotator", Order = 20)]
        public Person Annotator { get; set; }

        /// <summary>
        /// The DigitalResource that was annotated by the annotator. The annotated value MUST be expressed either as an object 
        /// or as a string corresponding to the annotated resource’s IRI.
        /// </summary>
        [JsonProperty("annotated", Order = 21)]
        public DigitalResource Annotated { get; set; }


        /// <summary>
        /// Parameterless constructor for JSON Deserialization
        /// </summary>
        public Annotation() { }

        public Annotation(Uri id) : base(id) { }


        protected override EntityType GetEntityType() => EntityType.Annotation;
    }
}
