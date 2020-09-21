using Newtonsoft.Json;
using System;

namespace ImsGlobal.Caliper.Entities
{
    /// <summary>
    /// <para>
    /// A Caliper Organization represents a formal collection of people organized for some common educational, social or 
    /// administrative purpose. An Organization can act as an Agent. It can be linked both to a parent Organization and to 
    /// its members.
    /// </para>
    /// A collection of people organized together into a community or other social, commercial or political structure. 
    /// The group has some common purpose or reason for existence which goes beyond the set of people belonging to it and can 
    /// act as an Agent. Organizations are often decomposable into hierarchical structures.
    /// </summary>
    public class Organization : Agent
    {
        /// <summary>
        /// <para>
        /// The parent Organization of this Organization. The subOrganizationOf value MUST be expressed either as an object or 
        /// as a string corresponding to the parent organization’s IRI.
        /// </para>
        /// Equivalent of W3C Organization Ontology org:subOrganizationOf property. Represents hierarchical containment of 
        /// Organizations or OrganizationalUnits; indicates an Organization which contains this Organization.
        /// </summary>
        [JsonProperty("subOrganizationOf", Order = 12)]
        public Organization SubOrganizationOf { get; set; }


        /// <summary>
        /// Parameterless constructor for JSON Deserialization
        /// </summary>
        public Organization() { }

        public Organization(Uri id) : base(id) { }


        protected override EntityType GetEntityType() => EntityType.Organization;
    }
}
