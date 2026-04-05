
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ElevationData
    {
        /// <summary>
        /// Average elevation of the user throughout the workout.<br/>
        /// Example: 950
        /// </summary>
        /// <example>950</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg_meters")]
        public double? AvgMeters { get; set; }

        /// <summary>
        /// Actual elevation gain of the user throughout the workout - this includes all elevation gain, and does _not_ represent net gain.<br/>
        /// Example: 550
        /// </summary>
        /// <example>550</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("gain_actual_meters")]
        public double? GainActualMeters { get; set; }

        /// <summary>
        /// Planned elevation gain for the workout.<br/>
        /// Example: 500
        /// </summary>
        /// <example>500</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("gain_planned_meters")]
        public double? GainPlannedMeters { get; set; }

        /// <summary>
        /// Elevation loss of the user throughout the workout.<br/>
        /// Example: 450
        /// </summary>
        /// <example>450</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("loss_actual_meters")]
        public double? LossActualMeters { get; set; }

        /// <summary>
        /// Maximum elevation of the user during the workout.<br/>
        /// Example: 1200
        /// </summary>
        /// <example>1200</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_meters")]
        public double? MaxMeters { get; set; }

        /// <summary>
        /// Minimum elevation of the user during the workout.<br/>
        /// Example: 800
        /// </summary>
        /// <example>800</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_meters")]
        public double? MinMeters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ElevationData" /> class.
        /// </summary>
        /// <param name="avgMeters">
        /// Average elevation of the user throughout the workout.<br/>
        /// Example: 950
        /// </param>
        /// <param name="gainActualMeters">
        /// Actual elevation gain of the user throughout the workout - this includes all elevation gain, and does _not_ represent net gain.<br/>
        /// Example: 550
        /// </param>
        /// <param name="gainPlannedMeters">
        /// Planned elevation gain for the workout.<br/>
        /// Example: 500
        /// </param>
        /// <param name="lossActualMeters">
        /// Elevation loss of the user throughout the workout.<br/>
        /// Example: 450
        /// </param>
        /// <param name="maxMeters">
        /// Maximum elevation of the user during the workout.<br/>
        /// Example: 1200
        /// </param>
        /// <param name="minMeters">
        /// Minimum elevation of the user during the workout.<br/>
        /// Example: 800
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ElevationData(
            double? avgMeters,
            double? gainActualMeters,
            double? gainPlannedMeters,
            double? lossActualMeters,
            double? maxMeters,
            double? minMeters)
        {
            this.AvgMeters = avgMeters;
            this.GainActualMeters = gainActualMeters;
            this.GainPlannedMeters = gainPlannedMeters;
            this.LossActualMeters = lossActualMeters;
            this.MaxMeters = maxMeters;
            this.MinMeters = minMeters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ElevationData" /> class.
        /// </summary>
        public ElevationData()
        {
        }
    }
}