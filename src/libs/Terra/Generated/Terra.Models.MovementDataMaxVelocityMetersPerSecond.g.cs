
#nullable enable

namespace Terra
{
    /// <summary>
    /// Maximum velocity of the user during the workout - only calculated by certain providers, representing a separate quantity from speed.<br/>
    /// Example: 4.5
    /// </summary>
    public sealed partial class MovementDataMaxVelocityMetersPerSecond
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}