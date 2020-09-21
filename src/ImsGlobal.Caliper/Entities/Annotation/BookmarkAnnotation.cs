using Newtonsoft.Json;
using System;

namespace ImsGlobal.Caliper.Entities
{
    /// <summary>
    /// A Caliper BookmarkAnnotation represents the act of marking a DigitalResource at a particular location.
    /// </summary>
    public class BookmarkAnnotation : Annotation
    {
        /// <summary>
        /// A string value comprising a plain text rendering of the note that accompanies the bookmark.
        /// </summary>
        [JsonProperty("bookmarkNotes", Order = 31)]
        public string BookmarkNotes { get; set; }


        /// <summary>
        /// Parameterless constructor for JSON Deserialization
        /// </summary>
        public BookmarkAnnotation() { }

        public BookmarkAnnotation(Uri id) : base(id) { }


        protected override EntityType GetEntityType() => EntityType.BookmarkAnnotation;
    }
}
