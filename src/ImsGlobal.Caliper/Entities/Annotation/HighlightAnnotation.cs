using Newtonsoft.Json;
using System;


namespace ImsGlobal.Caliper.Entities
{
    /// <summary>
    /// A Caliper HighlightAnnotation represents the act of marking a particular segment of a DigitalResource between two known 
    /// coordinates.
    /// </summary>
    public class HighlightAnnotation : Annotation
    {
        /// <summary>
        /// The start and end positions of the highlighted text segment. The first character in the full text is character 
        /// position 0. If a TextPositionSelector is defined both its start and end positions MUST be specified.
        /// </summary>
        [JsonProperty("selection", Order = 31)]
        public TextPositionSelector Selection { get; set; }

        /// <summary>
        /// A string value representing a plain-text rendering of the highlighted segment of the annotated DigitalResource.
        /// </summary>
        [JsonProperty("selectionText", Order = 32)]
        public string SelectionText { get; set; }


        /// <summary>
        /// Parameterless constructor for JSON Deserialization
        /// </summary>
        public HighlightAnnotation() { }

        public HighlightAnnotation(Uri id) : base(id)
        {
            Selection = new TextPositionSelector();
        }


        protected override EntityType GetEntityType() => EntityType.HighlightAnnotation;
    }
}
