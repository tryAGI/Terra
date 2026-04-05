
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class METData
    {
        /// <summary>
        /// An array of Metabolic Equivalent Time samples, as calculated by the user's wearable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("MET_samples")]
        public global::System.Collections.Generic.IList<global::Terra.METSample>? MetSamples { get; set; }

        /// <summary>
        /// The average MET level of the activity.<br/>
        /// Example: 3.8
        /// </summary>
        /// <example>3.8</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg_level")]
        public double? AvgLevel { get; set; }

        /// <summary>
        /// Number of minutes spent in High Intensity during the workout - based off MET scale.<br/>
        /// Example: 10
        /// </summary>
        /// <example>10</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_high_intensity_minutes")]
        public double? NumHighIntensityMinutes { get; set; }

        /// <summary>
        /// Number of minutes spent in state of Inactivity during the workout - based off MET scale.<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_inactive_minutes")]
        public double? NumInactiveMinutes { get; set; }

        /// <summary>
        /// Number of minutes spent in Low Intensity during the workout - based off MET scale.<br/>
        /// Example: 15
        /// </summary>
        /// <example>15</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_low_intensity_minutes")]
        public double? NumLowIntensityMinutes { get; set; }

        /// <summary>
        /// Number of minutes spent in Moderate Intensity during the workout - based off MET scale.<br/>
        /// Example: 25
        /// </summary>
        /// <example>25</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_moderate_intensity_minutes")]
        public double? NumModerateIntensityMinutes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="METData" /> class.
        /// </summary>
        /// <param name="metSamples">
        /// An array of Metabolic Equivalent Time samples, as calculated by the user's wearable.
        /// </param>
        /// <param name="avgLevel">
        /// The average MET level of the activity.<br/>
        /// Example: 3.8
        /// </param>
        /// <param name="numHighIntensityMinutes">
        /// Number of minutes spent in High Intensity during the workout - based off MET scale.<br/>
        /// Example: 10
        /// </param>
        /// <param name="numInactiveMinutes">
        /// Number of minutes spent in state of Inactivity during the workout - based off MET scale.<br/>
        /// Example: 5
        /// </param>
        /// <param name="numLowIntensityMinutes">
        /// Number of minutes spent in Low Intensity during the workout - based off MET scale.<br/>
        /// Example: 15
        /// </param>
        /// <param name="numModerateIntensityMinutes">
        /// Number of minutes spent in Moderate Intensity during the workout - based off MET scale.<br/>
        /// Example: 25
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public METData(
            global::System.Collections.Generic.IList<global::Terra.METSample>? metSamples,
            double? avgLevel,
            double? numHighIntensityMinutes,
            double? numInactiveMinutes,
            double? numLowIntensityMinutes,
            double? numModerateIntensityMinutes)
        {
            this.MetSamples = metSamples;
            this.AvgLevel = avgLevel;
            this.NumHighIntensityMinutes = numHighIntensityMinutes;
            this.NumInactiveMinutes = numInactiveMinutes;
            this.NumLowIntensityMinutes = numLowIntensityMinutes;
            this.NumModerateIntensityMinutes = numModerateIntensityMinutes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="METData" /> class.
        /// </summary>
        public METData()
        {
        }
    }
}