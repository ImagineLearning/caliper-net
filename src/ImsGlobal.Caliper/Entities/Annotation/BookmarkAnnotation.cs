using Newtonsoft.Json;
using System;

namespace ImsGlobal.Caliper.Entities.Annotation
{
    /// <summary>
    /// A Caliper BookmarkAnnotation represents the act of marking a DigitalResource at a particular location.
    /// </summary>
    public class BookmarkAnnotation : Annotation
    {
        /// <summary>
        /// Parameterless constructor for JSON Deserialization
        /// </summary>
        public BookmarkAnnotation()
        {
            Type = EntityType.Bookmark;
        }

        public BookmarkAnnotation(Uri id) : base(id)
        {
            Type = EntityType.Bookmark;
        }


        /// <summary>
        /// A string value comprising a plain text rendering of the note that accompanies the bookmark.
        /// </summary>
        [JsonProperty("bookmarkNotes", Order = 31)]
        public string BookmarkNotes { get; set; }
    }
}
