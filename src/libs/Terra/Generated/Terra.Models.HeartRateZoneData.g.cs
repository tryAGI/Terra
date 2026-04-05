
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HeartRateZoneData
    {
        /// <summary>
        /// Represents the heart rate zone the user is currently in during a workout or activity
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("zone")]
        public double? Zone { get; set; }

        /// <summary>
        /// Start percentage (based off user's max HR) of the HR zone<br/>
        /// Example: 60
        /// </summary>
        /// <example>60</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_percentage")]
        public double? StartPercentage { get; set; }

        /// <summary>
        /// End percentage (based off user's max HR) of the HR zone<br/>
        /// Example: 70
        /// </summary>
        /// <example>70</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_percentage")]
        public double? EndPercentage { get; set; }

        /// <summary>
        /// Name of the associated heart rate zone<br/>
        /// Example: Aerobic
        /// </summary>
        /// <example>Aerobic</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Duration spent in the heart rate zone<br/>
        /// Example: 300
        /// </summary>
        /// <example>300</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_seconds")]
        public double? DurationSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HeartRateZoneData" /> class.
        /// </summary>
        /// <param name="zone">
        /// Represents the heart rate zone the user is currently in during a workout or activity
        /// </param>
        /// <param name="startPercentage">
        /// Start percentage (based off user's max HR) of the HR zone<br/>
        /// Example: 60
        /// </param>
        /// <param name="endPercentage">
        /// End percentage (based off user's max HR) of the HR zone<br/>
        /// Example: 70
        /// </param>
        /// <param name="name">
        /// Name of the associated heart rate zone<br/>
        /// Example: Aerobic
        /// </param>
        /// <param name="durationSeconds">
        /// Duration spent in the heart rate zone<br/>
        /// Example: 300
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HeartRateZoneData(
            double? zone,
            double? startPercentage,
            double? endPercentage,
            string? name,
            double? durationSeconds)
        {
            this.Zone = zone;
            this.StartPercentage = startPercentage;
            this.EndPercentage = endPercentage;
            this.Name = name;
            this.DurationSeconds = durationSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HeartRateZoneData" /> class.
        /// </summary>
        public HeartRateZoneData()
        {
        }
    }
}