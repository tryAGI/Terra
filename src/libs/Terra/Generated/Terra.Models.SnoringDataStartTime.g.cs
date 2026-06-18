
#nullable enable

namespace Terra
{
    /// <summary>
    /// The start time of the recording of snoring data, in ISO8601 format with microsecond precision. Will always fall on midnight of any given day, and will always be equal to 24h before end_time. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time.<br/>
    /// Example: 1999-11-23T22:00:00.000000+02:00
    /// </summary>
    public sealed partial class SnoringDataStartTime
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}