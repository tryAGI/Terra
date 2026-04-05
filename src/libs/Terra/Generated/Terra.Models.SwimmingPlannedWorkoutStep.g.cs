
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SwimmingPlannedWorkoutStep
    {
        /// <summary>
        /// List of targets for the workout
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targets")]
        public global::System.Collections.Generic.IList<global::Terra.PlannedWorkoutStepTarget>? Targets { get; set; }

        /// <summary>
        /// Type of workout step - either repeat or one-off
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.SwimmingPlannedWorkoutStepTypeJsonConverter))]
        public global::Terra.SwimmingPlannedWorkoutStepType? Type { get; set; }

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
        /// Workout equipment to be used during the workout step
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("equipment_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.SwimmingPlannedWorkoutStepEquipmentTypeJsonConverter))]
        public global::Terra.SwimmingPlannedWorkoutStepEquipmentType? EquipmentType { get; set; }

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
        /// Name of workout step
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Stroke type used for the workout step (e.g. breaststroke)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stroke_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.SwimmingPlannedWorkoutStepStrokeTypeJsonConverter))]
        public global::Terra.SwimmingPlannedWorkoutStepStrokeType? StrokeType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SwimmingPlannedWorkoutStep" /> class.
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
        /// <param name="equipmentType">
        /// Workout equipment to be used during the workout step
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
        /// <param name="strokeType">
        /// Stroke type used for the workout step (e.g. breaststroke)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SwimmingPlannedWorkoutStep(
            global::System.Collections.Generic.IList<global::Terra.PlannedWorkoutStepTarget>? targets,
            global::Terra.SwimmingPlannedWorkoutStepType? type,
            int? intensity,
            int? order,
            global::Terra.SwimmingPlannedWorkoutStepEquipmentType? equipmentType,
            string? description,
            global::System.Collections.Generic.IList<global::Terra.PlannedWorkoutStepDuration>? durations,
            string? name,
            global::Terra.SwimmingPlannedWorkoutStepStrokeType? strokeType)
        {
            this.Targets = targets;
            this.Type = type;
            this.Intensity = intensity;
            this.Order = order;
            this.EquipmentType = equipmentType;
            this.Description = description;
            this.Durations = durations;
            this.Name = name;
            this.StrokeType = strokeType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SwimmingPlannedWorkoutStep" /> class.
        /// </summary>
        public SwimmingPlannedWorkoutStep()
        {
        }
    }
}