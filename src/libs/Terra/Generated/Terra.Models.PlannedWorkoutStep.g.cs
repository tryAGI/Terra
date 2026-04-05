
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PlannedWorkoutStep
    {
        /// <summary>
        /// List of targets for the workout
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targets")]
        public global::System.Collections.Generic.IList<global::Terra.PlannedWorkoutStepTargets>? Targets { get; set; }

        /// <summary>
        /// Type of workout step - either repeat or one-off
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.PlannedWorkoutStepTypeJsonConverter))]
        public global::Terra.PlannedWorkoutStepType? Type { get; set; }

        /// <summary>
        /// Planned intensity for the workout step
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("intensity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.PlannedWorkoutStepIntensityJsonConverter))]
        public global::Terra.PlannedWorkoutStepIntensity? Intensity { get; set; }

        /// <summary>
        /// Position of the workout step in the overall workout
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("order")]
        public int? Order { get; set; }

        /// <summary>
        /// Description of workout step
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// List of conditions to be fulfilled for the workout step to be completed - all of the conditions must be completed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("durations")]
        public global::System.Collections.Generic.IList<global::Terra.PlannedWorkoutStepDurations>? Durations { get; set; }

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
        /// Initializes a new instance of the <see cref="PlannedWorkoutStep" /> class.
        /// </summary>
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
        /// <param name="description">
        /// Description of workout step
        /// </param>
        /// <param name="durations">
        /// List of conditions to be fulfilled for the workout step to be completed - all of the conditions must be completed
        /// </param>
        /// <param name="name">
        /// Name of workout step
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlannedWorkoutStep(
            global::System.Collections.Generic.IList<global::Terra.PlannedWorkoutStepTargets>? targets,
            global::Terra.PlannedWorkoutStepType? type,
            global::Terra.PlannedWorkoutStepIntensity? intensity,
            int? order,
            string? description,
            global::System.Collections.Generic.IList<global::Terra.PlannedWorkoutStepDurations>? durations,
            string? name)
        {
            this.Targets = targets;
            this.Type = type;
            this.Intensity = intensity;
            this.Order = order;
            this.Description = description;
            this.Durations = durations;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlannedWorkoutStep" /> class.
        /// </summary>
        public PlannedWorkoutStep()
        {
        }
    }
}