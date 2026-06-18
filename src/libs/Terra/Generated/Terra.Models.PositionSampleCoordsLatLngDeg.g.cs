
#nullable enable

namespace Terra
{
    /// <summary>
    /// Position of the user a given point in time, represented by a 2-value array of latitude, longitude, wherein each of the two numbers can be nullable<br/>
    /// Example: [-18.4911, 130.9123]
    /// </summary>
    public sealed partial class PositionSampleCoordsLatLngDeg
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}