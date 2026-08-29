
#nullable enable

namespace Terra
{
    /// <summary>
    /// Strength-exercise details for a step
    /// </summary>
    public sealed partial class StrengthData
    {
        /// <summary>
        /// Display name of the exercise
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exercise_name")]
        public string? ExerciseName { get; set; }

        /// <summary>
        /// Weight to lift
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weight")]
        public double? Weight { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weight_display_unit")]
        public global::Terra.WeightUnit? WeightDisplayUnit { get; set; }

        /// <summary>
        /// Garmin Training API exerciseCategory string (e.g. BENCH_PRESS, SQUAT)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exercise_category")]
        public string? ExerciseCategory { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StrengthData" /> class.
        /// </summary>
        /// <param name="exerciseName">
        /// Display name of the exercise
        /// </param>
        /// <param name="weight">
        /// Weight to lift
        /// </param>
        /// <param name="weightDisplayUnit"></param>
        /// <param name="exerciseCategory">
        /// Garmin Training API exerciseCategory string (e.g. BENCH_PRESS, SQUAT)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StrengthData(
            string? exerciseName,
            double? weight,
            global::Terra.WeightUnit? weightDisplayUnit,
            string? exerciseCategory)
        {
            this.ExerciseName = exerciseName;
            this.Weight = weight;
            this.WeightDisplayUnit = weightDisplayUnit;
            this.ExerciseCategory = exerciseCategory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StrengthData" /> class.
        /// </summary>
        public StrengthData()
        {
        }

    }
}