using Newtonsoft.Json;
using System;


namespace ImsGlobal.Caliper.Entities
{
    /// <summary>
    /// A Caliper AudioObject represents an audio or sound file.
    /// </summary>
    public class AudioObject : MediaObject
    {
        /// <summary>
        /// A string value indicating the minimum volume level permitted.
        /// </summary>
        [JsonProperty("volumeMin", Order = 81)]
        public string VolumeMin { get; set; }

        /// <summary>
        /// A string value indicating the maximum volume level permitted.
        /// </summary>
        [JsonProperty("volumeMax", Order = 82)]
        public string VolumeMax { get; set; }

        /// <summary>
        /// A string value indicating the current volume level.
        /// </summary>
        [JsonProperty("volumeLevel", Order = 83)]
        public string VolumeLevel { get; set; }

        /// <summary>
        /// An optional boolean value indicating whether or not the AudioObject has been muted.
        /// </summary>
        [JsonProperty("muted", Order = 84)]
        public bool? Muted { get; set; }


        /// <summary>
        /// Parameterless constructor for JSON Deserialization
        /// </summary>
        public AudioObject() { }

        public AudioObject(Uri id) : base(id) { }


        protected override EntityType GetEntityType() => EntityType.AudioObject;
    }
}
