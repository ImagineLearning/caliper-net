using Newtonsoft.Json;

namespace ImsGlobal.Caliper {
	using ImsGlobal.Caliper.Util;
    using System.Collections.Generic;

    [JsonConverter(typeof(CaliperContextJsonConverter))]
	public class CaliperContextCollection : ICaliperContextCollectionJsonValue
    {
        private readonly List<ICaliperContext> contexts;

        public CaliperContextCollection()
        {
            this.contexts = new List<ICaliperContext>();
        }

        public ICaliperContext[] Value => this.contexts.ToArray();

        public void Add(ICaliperContext context)
        {
            if (context != null)
                this.contexts.Add(context);
        }
    }

}