using System;

namespace ImsGlobal.Caliper.Util
{
    public interface IJsonId
    {
        /// <summary>
        /// <b>REQUIRED:</b> The IRI MUST be unique and persistent. The IRI SHOULD also be dereferenceable, i.e., capable of 
        /// returning a representation of the resource. A URI employing the URN scheme MAY be provided in cases where a Linked Data 
        /// friendly HTTP URI is either unavailable or inappropriate.
        /// </summary>
        Uri Id { get; }
    }
}