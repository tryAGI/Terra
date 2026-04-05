
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StrengthPlannedWorkoutStep
    {
        /// <summary>
        /// Weight to be lifted for the exercise
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weight_kg")]
        public double? WeightKg { get; set; }

        /// <summary>
        /// List of targets for the workout
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targets")]
        public global::System.Collections.Generic.IList<global::Terra.PlannedWorkoutStepTarget>? Targets { get; set; }

        /// <summary>
        /// Type of workout step - either repeat or one-off
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.StrengthPlannedWorkoutStepTypeJsonConverter))]
        public global::Terra.StrengthPlannedWorkoutStepType? Type { get; set; }

        /// <summary>
        /// Planned intensity for the workout step
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("intensity")]
        public int? Intensity { get; set; }

        /// <summary>
        /// Position of the workout step in the overall workout
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("order")]
        public int? Order { get; set; }

        /// <summary>
        /// Name of strength exercise to be performed for the workout step
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exercise_name")]
        public string? ExerciseName { get; set; }

        /// <summary>
        /// Description of workout step
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// List of conditions to be fulfilled for the workout step to be completed - all of the conditions must be completed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("durations")]
        public global::System.Collections.Generic.IList<global::Terra.PlannedWorkoutStepDuration>? Durations { get; set; }

        /// <summary>
        /// Type of strength exercise to be performed for the workout step
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exercise_category")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.StrengthPlannedWorkoutStepExerciseCategoryJsonConverter))]
        public global::Terra.StrengthPlannedWorkoutStepExerciseCategory? ExerciseCategory { get; set; }

        /// <summary>
        /// Name of workout step
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StrengthPlannedWorkoutStep" /> class.
        /// </summary>
        /// <param name="weightKg">
        /// Weight to be lifted for the exercise
        /// </param>
        /// <param name="targets">
        /// List of targets for the workout
        /// </param>
        /// <param name="type">
        /// Type of workout step - either repeat or one-off
        /// </param>
        /// <param name="intensity">
        /// Planned intensity for the workout step
        /// </param>
        /// <param name="order">
        /// Position of the workout step in the overall workout
        /// </param>
        /// <param name="exerciseName">
        /// Name of strength exercise to be performed for the workout step
        /// </param>
        /// <param name="description">
        /// Description of workout step
        /// </param>
        /// <param name="durations">
        /// List of conditions to be fulfilled for the workout step to be completed - all of the conditions must be completed
        /// </param>
        /// <param name="exerciseCategory">
        /// Type of strength exercise to be performed for the workout step
        /// </param>
        /// <param name="name">
        /// Name of workout step
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StrengthPlannedWorkoutStep(
            double? weightKg,
            global::System.Collections.Generic.IList<global::Terra.PlannedWorkoutStepTarget>? targets,
            global::Terra.StrengthPlannedWorkoutStepType? type,
            int? intensity,
            int? order,
            string? exerciseName,
            string? description,
            global::System.Collections.Generic.IList<global::Terra.PlannedWorkoutStepDuration>? durations,
            global::Terra.StrengthPlannedWorkoutStepExerciseCategory? exerciseCategory,
            string? name)
        {
            this.WeightKg = weightKg;
            this.Targets = targets;
            this.Type = type;
            this.Intensity = intensity;
            this.Order = order;
            this.ExerciseName = exerciseName;
            this.Description = description;
            this.Durations = durations;
            this.ExerciseCategory = exerciseCategory;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StrengthPlannedWorkoutStep" /> class.
        /// </summary>
        public StrengthPlannedWorkoutStep()
        {
        }
    }
}