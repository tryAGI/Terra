
#nullable enable

namespace Terra
{
    /// <summary>
    /// Average normalized speed of the user during the workout - only calculated by certain providers, representing a separate quantity from speed.<br/>
    /// Example: 3.8
    /// </summary>
    public sealed partial class MovementDataNormalizedSpeedMetersPerSecond
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}