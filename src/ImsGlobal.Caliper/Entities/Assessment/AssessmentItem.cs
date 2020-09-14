using ImsGlobal.Caliper.Entities.Assignable;
using ImsGlobal.Caliper.Entities.Qti;
using Newtonsoft.Json;


namespace ImsGlobal.Caliper.Entities.Assessment
{
    public class AssessmentItem : AssignableDigitalResource, IAssessmentItem
    {
        public AssessmentItem(string id) : base(id)
        {
            this.Type = EntityType.AssessmentItem;
        }

        [JsonProperty("isTimeDependent", Order = 31)]
        public bool? IsTimeDependent { get; set; }
    }
}
