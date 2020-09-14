using System;
using System.Collections.Generic;
using System.Text;

namespace ImsGlobal.Caliper
{
    public static class __GuidExtensions
    {
        /// <summary>
        /// Formats a Guid according to the Caliper UUID data type (e.g. <b>urn:uuid:[UUID]</b>)
        /// </summary>
        /// <param name="guid"></param>
        /// <returns></returns>
        public static string ToCaliperUUID(this Guid guid) => $"urn:uuid:{guid}";
    }
}
