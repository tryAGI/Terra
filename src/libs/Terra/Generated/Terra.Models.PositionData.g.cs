
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PositionData
    {
        /// <summary>
        /// Position of the user at the midway point of the workout, represented by a 2-value array of latitude, longitude, wherein each of the two numbers can be nullable.<br/>
        /// Example: [-18.4911, 130.9123]
        /// </summary>
        /// <example>[-18.4911, 130.9123]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("center_pos_lat_lng_deg")]
        public global::System.Collections.Generic.IList<double>? CenterPosLatLngDeg { get; set; }

        /// <summary>
        /// Position of the user at the end of the workout, represented by a 2-value array of latitude, longitude, wherein each of the two numbers can be nullable.<br/>
        /// Example: [-84.4911, -150.9123]
        /// </summary>
        /// <example>[-84.4911, -150.9123]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_pos_lat_lng_deg")]
        public global::System.Collections.Generic.IList<double>? EndPosLatLngDeg { get; set; }

        /// <summary>
        /// Array of datapoints of the position of the user, sampled throughout the workout.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position_samples")]
        public global::System.Collections.Generic.IList<global::Terra.PositionSample>? PositionSamples { get; set; }

        /// <summary>
        /// Position of the user at the start of the workout, represented by a 2-value array of latitude, longitude, wherein each of the two numbers can be nullable.<br/>
        /// Example: [80.2394, 102.931]
        /// </summary>
        /// <example>[80.2394, 102.931]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_pos_lat_lng_deg")]
        public global::System.Collections.Generic.IList<double>? StartPosLatLngDeg { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PositionData" /> class.
        /// </summary>
        /// <param name="centerPosLatLngDeg">
        /// Position of the user at the midway point of the workout, represented by a 2-value array of latitude, longitude, wherein each of the two numbers can be nullable.<br/>
        /// Example: [-18.4911, 130.9123]
        /// </param>
        /// <param name="endPosLatLngDeg">
        /// Position of the user at the end of the workout, represented by a 2-value array of latitude, longitude, wherein each of the two numbers can be nullable.<br/>
        /// Example: [-84.4911, -150.9123]
        /// </param>
        /// <param name="positionSamples">
        /// Array of datapoints of the position of the user, sampled throughout the workout.
        /// </param>
        /// <param name="startPosLatLngDeg">
        /// Position of the user at the start of the workout, represented by a 2-value array of latitude, longitude, wherein each of the two numbers can be nullable.<br/>
        /// Example: [80.2394, 102.931]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PositionData(
            global::System.Collections.Generic.IList<double>? centerPosLatLngDeg,
            global::System.Collections.Generic.IList<double>? endPosLatLngDeg,
            global::System.Collections.Generic.IList<global::Terra.PositionSample>? positionSamples,
            global::System.Collections.Generic.IList<double>? startPosLatLngDeg)
        {
            this.CenterPosLatLngDeg = centerPosLatLngDeg;
            this.EndPosLatLngDeg = endPosLatLngDeg;
            this.PositionSamples = positionSamples;
            this.StartPosLatLngDeg = startPosLatLngDeg;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PositionData" /> class.
        /// </summary>
        public PositionData()
        {
        }
    }
}