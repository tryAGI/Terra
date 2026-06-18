
#nullable enable

namespace Terra
{
    /// <summary>
    /// The end time of the recording of snoring data, in ISO8601 format with microsecond precision. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time.<br/>
    /// Example: 2022-11-24T08:00:00.000000+01:00
    /// </summary>
    public sealed partial class SnoringDataEndTime
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}