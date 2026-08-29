
#nullable enable

namespace Terra
{
    /// <summary>
    /// A single step within a step block
    /// </summary>
    public sealed partial class WorkoutStep
    {
        /// <summary>
        /// Condition that completes a step or repeats a step block
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_condition")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Terra.CompletionCondition CompletionCondition { get; set; }

        /// <summary>
        /// Intensity targets to hold during the step
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("intensity_targets")]
        public global::System.Collections.Generic.IList<global::Terra.IntensityTarget>? IntensityTargets { get; set; }

        /// <summary>
        /// Intensity classification of a workout step
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("intensity_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.WorkoutStepIntensityJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Terra.WorkoutStepIntensity IntensityType { get; set; }

        /// <summary>
        /// Free-text coaching notes shown to the athlete
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notes")]
        public string? Notes { get; set; }

        /// <summary>
        /// Equipment controls applied during the step
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("controls")]
        public global::System.Collections.Generic.IList<global::Terra.StepControl>? Controls { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strength")]
        public global::Terra.StrengthData? Strength { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("swimming")]
        public global::Terra.SwimStepData? Swimming { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkoutStep" /> class.
        /// </summary>
        /// <param name="completionCondition">
        /// Condition that completes a step or repeats a step block
        /// </param>
        /// <param name="intensityType">
        /// Intensity classification of a workout step
        /// </param>
        /// <param name="intensityTargets">
        /// Intensity targets to hold during the step
        /// </param>
        /// <param name="notes">
        /// Free-text coaching notes shown to the athlete
        /// </param>
        /// <param name="controls">
        /// Equipment controls applied during the step
        /// </param>
        /// <param name="strength"></param>
        /// <param name="swimming"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkoutStep(
            global::Terra.CompletionCondition completionCondition,
            global::Terra.WorkoutStepIntensity intensityType,
            global::System.Collections.Generic.IList<global::Terra.IntensityTarget>? intensityTargets,
            string? notes,
            global::System.Collections.Generic.IList<global::Terra.StepControl>? controls,
            global::Terra.StrengthData? strength,
            global::Terra.SwimStepData? swimming)
        {
            this.CompletionCondition = completionCondition ?? throw new global::System.ArgumentNullException(nameof(completionCondition));
            this.IntensityTargets = intensityTargets;
            this.IntensityType = intensityType;
            this.Notes = notes;
            this.Controls = controls;
            this.Strength = strength;
            this.Swimming = swimming;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkoutStep" /> class.
        /// </summary>
        public WorkoutStep()
        {
        }

    }
}