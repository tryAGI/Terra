
#nullable enable

namespace Terra
{
    /// <summary>
    /// The start time of the associated lap, in ISO8601 format with microsecond precision. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time<br/>
    /// Example: 1999-11-23T09:00:00.000000+02:00
    /// </summary>
    public sealed partial class LapSampleStartTime
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}