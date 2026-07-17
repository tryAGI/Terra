
#nullable enable

namespace Terra
{
    /// <summary>
    /// When the observation ended, in ISO8601 format, for interval observations. Absent for point-in-time observations.<br/>
    /// Example: 2022-10-28T10:05:00.000000+01:00
    /// </summary>
    public sealed partial class HealthObservationMetadataEndTime
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}