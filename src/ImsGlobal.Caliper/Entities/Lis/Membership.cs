using Newtonsoft.Json;
using System;
using System.Collections.Generic;


namespace ImsGlobal.Caliper.Entities
{
    /// <summary>
    /// <para>
    /// A Caliper Membership describes the relationship between an Organization and an Agent, typically a Person 
    /// (i.e., a member) in terms of the roles assigned and current status.
    /// </para>
    /// <para>
    /// A Caliper Membership is used to define the relationship between objects that can have members and objects that can 
    /// be members. Objects recognized as having members are CourseOffering, CourseSection and Group, all of which implement 
    /// the IOrganization marker interface. Any Agent entity can be a member.
    /// </para>
    /// <para>
    /// Indicates the nature of an Agent's membership in an organization. A W3C Membership represents an n-ary relationship 
    /// between an Agent, an Organization and a Role. A Caliper Membership varies from the W3C Membership class definition by 
    /// allowing users to specify a set of roles associated with an Agent's membership in an organization.
    /// See http://www.w3.org/TR/vocab-org/#org:Membership
    /// </para>
    /// </summary>
    public class Membership : Entity
    {
        /// <summary>
        /// The Person associated with this Membership. The member value MUST be expressed either as an object or as a 
        /// string corresponding to the member’s IRI.
        /// </summary>
        [JsonProperty("member", Order = 21)]
        public Person Member { get; set; }

        /// <summary>
        /// The Organization associated with the Membership. The organization value MUST be expressed either as an object or 
        /// as a string corresponding to the organization’s IRI.
        /// </summary>
        [JsonProperty("organization", Order = 22)]
        public Organization Organization { get; set; }

        /// <summary>
        /// An ordered collection of organizational roles assigned to the member. Role values are limited to the list of Caliper 
        /// defined roles terms. Whenever a subrole is specified, the core context role SHOULD also be included; for example, a 
        /// role of Instructor#TeachingAssistant should always be accompanied by the Instructor role.
        /// </summary>
        [JsonProperty("roles", Order = 23)]
        public List<Role> Roles { get; set; } = new List<Role>();

        /// <summary>
        /// A string value that indicates the current standing of the member. If a status is specified, the value be chosen 
        /// from the list of Caliper defined statuses.
        /// </summary>
        [JsonProperty("status", Order = 24)]
        public Status Status { get; set; }


        /// <summary>
        /// Parameterless constructor for JSON Deserialization
        /// </summary>
        public Membership() { }

        public Membership(Uri id) : base(id) { }


        protected override EntityType GetEntityType() => EntityType.Membership;
    }
}
