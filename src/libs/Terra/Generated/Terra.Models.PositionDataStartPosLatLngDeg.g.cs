
#nullable enable

namespace Terra
{
    /// <summary>
    /// Position of the user at the start of the workout, represented by a 2-value array of latitude, longitude, wherein each of the two numbers can be nullable.<br/>
    /// Example: [80.2394, 102.931]
    /// </summary>
    public sealed partial class PositionDataStartPosLatLngDeg
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}