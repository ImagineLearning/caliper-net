using System;
using System.Collections.Generic;
using Newtonsoft.Json;


namespace ImsGlobal.Caliper.Entities
{
    /// <summary>
    /// A Caliper Message is a digital form of written communication sent to a recipient. A series of messages may constitute 
    /// a Thread if they share a common subject and are connected by a reply or by date relationships.
    /// </summary>
    public class Message : DigitalResource
    {
        /// <summary>
        /// A Message that represents the post to which this Message is directed in reply. The replyTo value MUST be expressed 
        /// either as an object or as a string corresponding to the associated message’s IRI.
        /// </summary>
        [JsonProperty("replyTo", Order = 20)]
        public Message ReplyTo { get; set; }

        /// <summary>
        /// A string value comprising a plain-text rendering of the body content of the Message.
        /// </summary>
        [JsonProperty("body", Order = 21)]
        public string Body { get; set; }

        /// <summary>
        /// An ordered collection of one or more DigitalResource entities attached to this Message. Each array item MUST be 
        /// expressed either as an object or as a string corresponding to the item’s IRI.
        /// </summary>
        [JsonProperty("attachments", Order = 22)]
        public List<DigitalResource> Attachments { get; set; }


        /// <summary>
        /// Parameterless constructor for JSON Deserialization
        /// </summary>
        public Message() { }

        public Message(Uri id) : base(id) { }


        protected override EntityType GetEntityType() => EntityType.Message;
    }
}
