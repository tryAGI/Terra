
#nullable enable

namespace Terra
{
    /// <summary>
    /// A step of a provider-side planned workout
    /// </summary>
    public sealed partial class PlannedWorkoutDetailsStep
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("order")]
        public int? Order { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Numeric step intensity class
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("intensity")]
        public int? Intensity { get; set; }

        /// <summary>
        /// 0 = step, 1 = repetition block
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public int? Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("durations")]
        public global::System.Collections.Generic.IList<global::Terra.PlannedWorkoutDetailsStepDuration>? Durations { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targets")]
        public global::System.Collections.Generic.IList<global::Terra.PlannedWorkoutDetailsStepTarget>? Targets { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stroke_type")]
        public int? StrokeType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("equipment_type")]
        public global::System.Collections.Generic.IList<int>? EquipmentType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exercise_name")]
        public string? ExerciseName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exercise_category")]
        public int? ExerciseCategory { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weight_kg")]
        public double? WeightKg { get; set; }

        /// <summary>
        /// Child steps of a repetition block
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("steps")]
        public global::System.Collections.Generic.IList<global::Terra.PlannedWorkoutDetailsStep>? Steps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlannedWorkoutDetailsStep" /> class.
        /// </summary>
        /// <param name="order"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="intensity">
        /// Numeric step intensity class
        /// </param>
        /// <param name="type">
        /// 0 = step, 1 = repetition block
        /// </param>
        /// <param name="durations"></param>
        /// <param name="targets"></param>
        /// <param name="strokeType"></param>
        /// <param name="equipmentType"></param>
        /// <param name="exerciseName"></param>
        /// <param name="exerciseCategory"></param>
        /// <param name="weightKg"></param>
        /// <param name="steps">
        /// Child steps of a repetition block
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlannedWorkoutDetailsStep(
            int? order,
            string? name,
            string? description,
            int? intensity,
            int? type,
            global::System.Collections.Generic.IList<global::Terra.PlannedWorkoutDetailsStepDuration>? durations,
            global::System.Collections.Generic.IList<global::Terra.PlannedWorkoutDetailsStepTarget>? targets,
            int? strokeType,
            global::System.Collections.Generic.IList<int>? equipmentType,
            string? exerciseName,
            int? exerciseCategory,
            double? weightKg,
            global::System.Collections.Generic.IList<global::Terra.PlannedWorkoutDetailsStep>? steps)
        {
            this.Order = order;
            this.Name = name;
            this.Description = description;
            this.Intensity = intensity;
            this.Type = type;
            this.Durations = durations;
            this.Targets = targets;
            this.StrokeType = strokeType;
            this.EquipmentType = equipmentType;
            this.ExerciseName = exerciseName;
            this.ExerciseCategory = exerciseCategory;
            this.WeightKg = weightKg;
            this.Steps = steps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlannedWorkoutDetailsStep" /> class.
        /// </summary>
        public PlannedWorkoutDetailsStep()
        {
        }

    }
}