
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LapSample
    {
        /// <summary>
        /// Calories burned during the lap<br/>
        /// Example: 50
        /// </summary>
        /// <example>50</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("calories")]
        public double? Calories { get; set; }

        /// <summary>
        /// Average heart rate in bpm, for the Lap sample<br/>
        /// Example: 145
        /// </summary>
        /// <example>145</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg_hr_bpm")]
        public double? AvgHrBpm { get; set; }

        /// <summary>
        /// The start time of the associated lap, in ISO8601 format with microsecond precision. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time<br/>
        /// Example: 1999-11-23T09:00:00.000000+02:00
        /// </summary>
        /// <example>1999-11-23T09:00:00.000000+02:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public string? StartTime { get; set; }

        /// <summary>
        /// Average speed of the user during the lap<br/>
        /// Example: 3.5
        /// </summary>
        /// <example>3.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg_speed_meters_per_second")]
        public double? AvgSpeedMetersPerSecond { get; set; }

        /// <summary>
        /// Distance covered during the lap<br/>
        /// Example: 400
        /// </summary>
        /// <example>400</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("distance_meters")]
        public double? DistanceMeters { get; set; }

        /// <summary>
        /// Total strokes performed during the lap - only relevant for swimming activities<br/>
        /// Example: 20
        /// </summary>
        /// <example>20</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_strokes")]
        public int? TotalStrokes { get; set; }

        /// <summary>
        /// The end time of the associated lap, in ISO8601 format with microsecond precision. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time<br/>
        /// Example: 2022-10-28T10:00:00.000000+01:00
        /// </summary>
        /// <example>2022-10-28T10:00:00.000000+01:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public string? EndTime { get; set; }

        /// <summary>
        /// Stroke type used for the workout step (e.g. breaststroke)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stroke_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.StrokeTypeJsonConverter))]
        public global::Terra.StrokeType? StrokeType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LapSample" /> class.
        /// </summary>
        /// <param name="calories">
        /// Calories burned during the lap<br/>
        /// Example: 50
        /// </param>
        /// <param name="avgHrBpm">
        /// Average heart rate in bpm, for the Lap sample<br/>
        /// Example: 145
        /// </param>
        /// <param name="startTime">
        /// The start time of the associated lap, in ISO8601 format with microsecond precision. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time<br/>
        /// Example: 1999-11-23T09:00:00.000000+02:00
        /// </param>
        /// <param name="avgSpeedMetersPerSecond">
        /// Average speed of the user during the lap<br/>
        /// Example: 3.5
        /// </param>
        /// <param name="distanceMeters">
        /// Distance covered during the lap<br/>
        /// Example: 400
        /// </param>
        /// <param name="totalStrokes">
        /// Total strokes performed during the lap - only relevant for swimming activities<br/>
        /// Example: 20
        /// </param>
        /// <param name="endTime">
        /// The end time of the associated lap, in ISO8601 format with microsecond precision. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time<br/>
        /// Example: 2022-10-28T10:00:00.000000+01:00
        /// </param>
        /// <param name="strokeType">
        /// Stroke type used for the workout step (e.g. breaststroke)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LapSample(
            double? calories,
            double? avgHrBpm,
            string? startTime,
            double? avgSpeedMetersPerSecond,
            double? distanceMeters,
            int? totalStrokes,
            string? endTime,
            global::Terra.StrokeType? strokeType)
        {
            this.Calories = calories;
            this.AvgHrBpm = avgHrBpm;
            this.StartTime = startTime;
            this.AvgSpeedMetersPerSecond = avgSpeedMetersPerSecond;
            this.DistanceMeters = distanceMeters;
            this.TotalStrokes = totalStrokes;
            this.EndTime = endTime;
            this.StrokeType = strokeType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LapSample" /> class.
        /// </summary>
        public LapSample()
        {
        }
    }
}