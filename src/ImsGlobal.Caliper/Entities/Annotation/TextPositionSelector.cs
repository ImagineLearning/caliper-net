using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;


namespace ImsGlobal.Caliper.Entities
{
    /// <summary>
    /// A Caliper TextPositionSelector represents a fragment or selection of textual content, the starting and ending positions 
    /// of which are determined by the distance in characters from the initial character (position 0) of the enclosing full text.
    /// </summary>
    public class TextPositionSelector : Selector
    {
        /// <summary>
        /// <b>REQUIRED:</b> The starting position of the selected text MUST be specified. The first character in the full text 
        /// is character position 0.
        /// </summary>
        [Required]
        [JsonProperty("start", Order = 1)]
        public int Start { get; set; }

        /// <summary>
        /// <b>REQUIRED:</b> The end position of the selected text MUST be specified.
        /// </summary>
        [Required]
        [JsonProperty("end", Order = 2)]
        public int End { get; set; }


        /// <summary>
        /// Parameterless constructor for JSON Deserialization
        /// </summary>
        public TextPositionSelector() : base(SelectorType.TextPositionSelector) { }

        public TextPositionSelector(int start, int end) : base(SelectorType.TextPositionSelector)
        {
            Start = start;
            End = end;
        }
    }

}
