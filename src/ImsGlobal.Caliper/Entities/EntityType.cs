using ImsGlobal.Caliper.Util;
using Newtonsoft.Json;

namespace ImsGlobal.Caliper.Entities
{
    /// <summary>
    /// Term for Entity.Type
    /// </summary>
    [JsonConverter(typeof(JsonValueConverter<EntityType>))]
    public class EntityType : IType, IJsonValue
    {
        public static EntityType Agent { get; } = new EntityType("Agent");

        public static EntityType Annotation { get; } = new EntityType("Annotation");

        public static EntityType Assessment { get; } = new EntityType("Assessment");

        public static EntityType AssessmentItem { get; } = new EntityType("AssessmentItem");

        public static EntityType AssignableDigitalResource { get; } = new EntityType("AssignableDigitalResource");

        public static EntityType Attempt { get; } = new EntityType("Attempt");

        public static EntityType AudioObject { get; } = new EntityType("AudioObject");

        public static EntityType Bookmark { get; } = new EntityType("BookmarkAnnotation");

        public static EntityType Chapter { get; } = new EntityType("Chapter");

        public static EntityType CourseOffering { get; } = new EntityType("CourseOffering");

        public static EntityType CourseSection { get; } = new EntityType("CourseSection");

        public static EntityType DigitalResource { get; } = new EntityType("DigitalResource");

        public static EntityType DigitalResourceCollection { get; } = new EntityType("DigitalResourceCollection");

        public static EntityType Document { get; } = new EntityType("Document");

        public static EntityType Entity { get; } = new EntityType("Entity");

        public static EntityType FillInBlank { get; } = new EntityType("FillinBlankResponse");

        public static EntityType Forum { get; } = new EntityType("Forum");

        public static EntityType Frame { get; } = new EntityType("Frame");

        public static EntityType Group { get; } = new EntityType("Group");

        public static EntityType Highlight { get; } = new EntityType("HighlightAnnotation");

        public static EntityType ImageObject { get; } = new EntityType("ImageObject");

        public static EntityType LearningObjective { get; } = new EntityType("LearningObjective");

        public static EntityType LtiSession { get; } = new EntityType("LtiSession");

        public static EntityType MediaLocation { get; } = new EntityType("MediaLocation");

        public static EntityType MediaObject { get; } = new EntityType("MediaObject");

        public static EntityType Membership { get; } = new EntityType("Membership");

        public static EntityType Message { get; } = new EntityType("Message");

        public static EntityType MultipleChoice { get; } = new EntityType("MultipleChoiceResponse");

        public static EntityType MultipleResponse { get; } = new EntityType("MultipleResponseResponse");

        public static EntityType Page { get; } = new EntityType("Page");

        public static EntityType Person { get; } = new EntityType("Person");

        public static EntityType Organization { get; } = new EntityType("Organization");

        public static EntityType Response { get; } = new EntityType("Response");

        public static EntityType Result { get; } = new EntityType("Result");

        public static EntityType Score { get; } = new EntityType("Score");

        public static EntityType Session { get; } = new EntityType("Session");

        public static EntityType Share { get; } = new EntityType("SharedAnnotation");

        public static EntityType SoftwareApplication { get; } = new EntityType("SoftwareApplication");

        public static EntityType SelectText { get; } = new EntityType("SelectTextResponse");

        public static EntityType Tag { get; } = new EntityType("TagAnnotation");

        public static EntityType Thread { get; } = new EntityType("Thread");

        public static EntityType TrueFalse { get; } = new EntityType("TrueFalseResponse");

        public static EntityType VideoObject { get; } = new EntityType("VideoObject");

        public static EntityType WebPage { get; } = new EntityType("WebPage");


        public EntityType() { }

        public EntityType(string value)
        {
            Value = value;
        }

        public string Value { get; set; }

    }

}