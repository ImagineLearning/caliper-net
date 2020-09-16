using ImsGlobal.Caliper.Util;
using Newtonsoft.Json;
using System.Linq;

namespace ImsGlobal.Caliper.Entities.Lis
{
    /// <summary>
    /// <para>
    /// Membership includes an optional roles property for assigning one or more roles to an Event actor described as a member 
    /// of an organization. Role values are limited to the list of Caliper role terms derived from the IMS LIS specification. 
    /// Assigning core context roles should prove sufficient in most cases. Whenever a subrole is specified, the related context 
    /// role SHOULD also be included. For example, a role of <b>Instructor#TeachingAssistant</b> SHOULD always be accompanied by the 
    /// <b>Instructor</b> role.
    /// </para>
    /// <para>
    /// Marker or tag interface that denotes a role that a Person or other Agent can take in an membership. Instances of this
    /// class describe the abstract role; to denote a specific instance of a person playing that role in a specific membership 
    /// use an instance of Membership.
    /// </para>
    /// </summary>
    [JsonConverter(typeof(JsonValueConverter<Role>))]
    public sealed class Role : IJsonValue
    {
        public static Role Learner { get; } = new Role("Learner");
        public static Role ExternalLearner { get; } = new Role("Learner#ExternalLearner");
        public static Role GuestLearner { get; } = new Role("Learner#GuestLearner");
        public static Role LearnerInstructor { get; } = new Role("Learner#Instructor");
        public static Role LearnerLearner { get; } = new Role("Learner#Learner");
        public static Role NoncreditLearner { get; } = new Role("Learner#NonCreditLearner");

        public static Role Instructor { get; } = new Role("Instructor");
        public static Role ExternalInstructor { get; } = new Role("Instructor#ExternalInstructor");
        public static Role GuestInstructor { get; } = new Role("Instructor#GuestInstructor");
        public static Role Lecturer { get; } = new Role("Instructor#Lecturer");
        public static Role PrimaryInstructor { get; } = new Role("Instructor#PrimaryInstructor");

        public static Role Administrator { get; } = new Role("Administrator");
        public static Role AdministratorAdministrator { get; } = new Role("Administrator#Administrator");
        public static Role AdministratorDeveloper { get; } = new Role("Administrator#Developer");
        public static Role AdministratorSupport { get; } = new Role("Administrator#Support");
        public static Role AdministratorSystemAdministrator { get; } = new Role("Administrator#SystemAdministrator");

        public static Role AdministratorExternalDeveloper { get; } = new Role("Administrator#ExternalSupport");
        public static Role AdministratorExternalSupport { get; } = new Role("Administrator#ExternalDeveloper");
        public static Role AdministratorExternalSystemAdministrator { get; } = new Role("Administrator#ExternalSystemAdministrator");

        public static Role ContentDeveloper { get; } = new Role("ContentDeveloper");
        public static Role ContentDeveloperContentDeveloper { get; } = new Role("ContentDeveloper#ContentDeveloper");
        public static Role ContentDeveloperLibrarian { get; } = new Role("ContentDeveloper#Librarian");
        public static Role ContentDeveloperContentExpert { get; } = new Role("ContentDeveloper#ContentExpert");
        public static Role ContentDeveloperExternalContentExpert { get; } = new Role("ContentDeveloper#ExternalContentExpert");

        public static Role Manager { get; } = new Role("Manager");
        public static Role ManagerAreaManager { get; } = new Role("Manager#AreaManager");
        public static Role ManagerCourseCoordinator { get; } = new Role("Manager#CourseCoordinator");
        public static Role ManagerObserver { get; } = new Role("Manager#Observer");
        public static Role ManagerExternalObserver { get; } = new Role("Manager#ExternalObserver");

        public static Role Member { get; } = new Role("Member");
        public static Role MemberMember { get; } = new Role("Member#Member");

        public static Role Mentor { get; } = new Role("Mentor");
        public static Role MentorMentor { get; } = new Role("Mentor#Mentor");
        public static Role MentorAdvisor { get; } = new Role("Mentor#Advisor");
        public static Role MentorAuditor { get; } = new Role("Mentor#Auditor");
        public static Role MentorReviewer { get; } = new Role("Mentor#Reviewer");
        public static Role MentorTutor { get; } = new Role("Mentor#Tutor");
        public static Role MentorLearningFacilitator { get; } = new Role("Mentor#LearningFacilitator");

        public static Role MentorExternalMentor { get; } = new Role("Mentor#ExternalMentor");
        public static Role MentorExternalAdvisor { get; } = new Role("Mentor#ExternalAdvisor");
        public static Role MentorExternalAuditor { get; } = new Role("Mentor#ExternalAuditor");
        public static Role MentorExternalReviewer { get; } = new Role("Mentor#ExternalReviewer");
        public static Role MentorExternalTutor { get; } = new Role("Mentor#ExternalTutor");
        public static Role MentorExternalLearningFacilitator { get; } = new Role("Mentor#ExternalLearningFacilitator");

        public static Role TeachingAssistant { get; } = new Role("TeachingAssistant");
        public static Role TeachingAssistantTeachingAssistant { get; } = new Role("TeachingAssistant#TeachingAssistant");
        public static Role TeachingAssistantGrader { get; } = new Role("TeachingAssistant#Grader");
        public static Role TeachingAssistantTeachingAssistantSection { get; } = new Role("TeachingAssistant#TeachingAssistantSection");
        public static Role TeachingAssistantTeachingAssistantSectionAssociation { get; } = new Role("TeachingAssistant#TeachingAssistantSectionAssociation");
        public static Role TeachingAssistantTeachingAssistantOffering { get; } = new Role("TeachingAssistant#TeachingAssistantOffering");
        public static Role TeachingAssistantTeachingAssistantTemplate { get; } = new Role("TeachingAssistant#TeachingAssistantTemplate");
        public static Role TeachingAssistantTeachingAssistantGroup { get; } = new Role("TeachingAssistant#TeachingAssistantGroup");

        public Role() { }

        public Role(string value)
        {
            Value = value;
        }

        public string Value { get; set; }

        public string Main => Value?.Split('#').FirstOrDefault();

        public string SubRole
        {
            get
            {
                string[] values = Value?.Split('#');
                return values.Length > 1 ? values[1] : null;
            }
        }
    }
}
