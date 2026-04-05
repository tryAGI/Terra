
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PositionSample
    {
        /// <summary>
        /// Time with which the record is associated, in ISO8601 format with microsecond precision. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time.<br/>
        /// Example: 2022-11-23T09:00:00.000000+02:00
        /// </summary>
        /// <example>2022-11-23T09:00:00.000000+02:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public string? Timestamp { get; set; }

        /// <summary>
        /// Position of the user a given point in time, represented by a 2-value array of latitude, longitude, wherein each of the two numbers can be nullable<br/>
        /// Example: [-18.4911, 130.9123]
        /// </summary>
        /// <example>[-18.4911, 130.9123]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("coords_lat_lng_deg")]
        public byte[]? CoordsLatLngDeg { get; set; }

        /// <summary>
        /// Time elapsed since the start of the workout, subtracting time during which the recording was paused<br/>
        /// Example: 300
        /// </summary>
        /// <example>300</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("timer_duration_seconds")]
        public double? TimerDurationSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PositionSample" /> class.
        /// </summary>
        /// <param name="timestamp">
        /// Time with which the record is associated, in ISO8601 format with microsecond precision. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time.<br/>
        /// Example: 2022-11-23T09:00:00.000000+02:00
        /// </param>
        /// <param name="coordsLatLngDeg">
        /// Position of the user a given point in time, represented by a 2-value array of latitude, longitude, wherein each of the two numbers can be nullable<br/>
        /// Example: [-18.4911, 130.9123]
        /// </param>
        /// <param name="timerDurationSeconds">
        /// Time elapsed since the start of the workout, subtracting time during which the recording was paused<br/>
        /// Example: 300
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PositionSample(
            string? timestamp,
            byte[]? coordsLatLngDeg,
            double? timerDurationSeconds)
        {
            this.Timestamp = timestamp;
            this.CoordsLatLngDeg = coordsLatLngDeg;
            this.TimerDurationSeconds = timerDurationSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PositionSample" /> class.
        /// </summary>
        public PositionSample()
        {
        }
    }
}