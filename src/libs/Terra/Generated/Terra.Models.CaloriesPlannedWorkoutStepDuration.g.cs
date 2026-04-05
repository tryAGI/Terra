
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CaloriesPlannedWorkoutStepDuration
    {
        /// <summary>
        /// Calorie burn target for the workout step - once the user reaches the target, the step will be completed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("calories")]
        public int? Calories { get; set; }

        /// <summary>
        /// Type of condition that must be fulfilled to consider the workout step complete
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.CaloriesPlannedWorkoutStepDurationDurationTypeJsonConverter))]
        public global::Terra.CaloriesPlannedWorkoutStepDurationDurationType? DurationType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CaloriesPlannedWorkoutStepDuration" /> class.
        /// </summary>
        /// <param name="calories">
        /// Calorie burn target for the workout step - once the user reaches the target, the step will be completed
        /// </param>
        /// <param name="durationType">
        /// Type of condition that must be fulfilled to consider the workout step complete
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CaloriesPlannedWorkoutStepDuration(
            int? calories,
            global::Terra.CaloriesPlannedWorkoutStepDurationDurationType? durationType)
        {
            this.Calories = calories;
            this.DurationType = durationType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CaloriesPlannedWorkoutStepDuration" /> class.
        /// </summary>
        public CaloriesPlannedWorkoutStepDuration()
        {
        }
    }
}