
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DailyDistanceData2
    {
        /// <summary>
        /// Object containing detailed distance information - this may include second-by-second samples.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detailed")]
        public global::Terra.DistanceDataDetailed? Detailed { get; set; }

        /// <summary>
        /// Total distance covered by the user throughout the day.<br/>
        /// Example: 8500.45
        /// </summary>
        /// <example>8500.45</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("distance_meters")]
        public double? DistanceMeters { get; set; }

        /// <summary>
        /// Object containing information on the elevation of the user throughout the day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("elevation")]
        public global::Terra.ElevationData? Elevation { get; set; }

        /// <summary>
        /// Total number of elevation gain in floors climbed equivalent throughout the day, as determined by the fitness data provider.<br/>
        /// Example: 15
        /// </summary>
        /// <example>15</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("floors_climbed")]
        public int? FloorsClimbed { get; set; }

        /// <summary>
        /// Total number of steps performed during the day.<br/>
        /// Example: 12000
        /// </summary>
        /// <example>12000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("steps")]
        public int? Steps { get; set; }

        /// <summary>
        /// Summary information of the user's swimming statistics for the day, if applicable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("swimming")]
        public global::Terra.SwimmingData? Swimming { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DailyDistanceData2" /> class.
        /// </summary>
        /// <param name="detailed">
        /// Object containing detailed distance information - this may include second-by-second samples.
        /// </param>
        /// <param name="distanceMeters">
        /// Total distance covered by the user throughout the day.<br/>
        /// Example: 8500.45
        /// </param>
        /// <param name="elevation">
        /// Object containing information on the elevation of the user throughout the day.
        /// </param>
        /// <param name="floorsClimbed">
        /// Total number of elevation gain in floors climbed equivalent throughout the day, as determined by the fitness data provider.<br/>
        /// Example: 15
        /// </param>
        /// <param name="steps">
        /// Total number of steps performed during the day.<br/>
        /// Example: 12000
        /// </param>
        /// <param name="swimming">
        /// Summary information of the user's swimming statistics for the day, if applicable.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DailyDistanceData2(
            global::Terra.DistanceDataDetailed? detailed,
            double? distanceMeters,
            global::Terra.ElevationData? elevation,
            int? floorsClimbed,
            int? steps,
            global::Terra.SwimmingData? swimming)
        {
            this.Detailed = detailed;
            this.DistanceMeters = distanceMeters;
            this.Elevation = elevation;
            this.FloorsClimbed = floorsClimbed;
            this.Steps = steps;
            this.Swimming = swimming;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DailyDistanceData2" /> class.
        /// </summary>
        public DailyDistanceData2()
        {
        }

    }
}