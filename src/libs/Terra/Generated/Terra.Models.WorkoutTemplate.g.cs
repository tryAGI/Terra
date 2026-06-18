
#nullable enable

namespace Terra
{
    /// <summary>
    /// A reusable workout template, created once and planned onto user calendars
    /// </summary>
    public sealed partial class WorkoutTemplate
    {
        /// <summary>
        /// Name of the workout
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Description of the workout
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Sport a workout template targets. Indoor/outdoor is expressed separately via environment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sport")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.WorkoutSportJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Terra.WorkoutSport Sport { get; set; }

        /// <summary>
        /// Environment a workout takes place in
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.EnvironmentTypeJsonConverter))]
        public global::Terra.EnvironmentType? Environment { get; set; }

        /// <summary>
        /// Pool length in meters, for swim workouts
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pool_length_meters")]
        public double? PoolLengthMeters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("step_blocks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Terra.StepBlock> StepBlocks { get; set; }

        /// <summary>
        /// Estimated total duration in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("estimated_duration_seconds")]
        public double? EstimatedDurationSeconds { get; set; }

        /// <summary>
        /// Estimated total distance in meters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("estimated_distance_meters")]
        public double? EstimatedDistanceMeters { get; set; }

        /// <summary>
        /// Estimated calories burned
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("estimated_calories")]
        public double? EstimatedCalories { get; set; }

        /// <summary>
        /// Terra identifier of the stored template. Set by Terra in responses; ignored on create.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workout_id")]
        public string? WorkoutId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkoutTemplate" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the workout
        /// </param>
        /// <param name="sport">
        /// Sport a workout template targets. Indoor/outdoor is expressed separately via environment.
        /// </param>
        /// <param name="stepBlocks"></param>
        /// <param name="description">
        /// Description of the workout
        /// </param>
        /// <param name="environment">
        /// Environment a workout takes place in
        /// </param>
        /// <param name="poolLengthMeters">
        /// Pool length in meters, for swim workouts
        /// </param>
        /// <param name="estimatedDurationSeconds">
        /// Estimated total duration in seconds
        /// </param>
        /// <param name="estimatedDistanceMeters">
        /// Estimated total distance in meters
        /// </param>
        /// <param name="estimatedCalories">
        /// Estimated calories burned
        /// </param>
        /// <param name="workoutId">
        /// Terra identifier of the stored template. Set by Terra in responses; ignored on create.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkoutTemplate(
            string name,
            global::Terra.WorkoutSport sport,
            global::System.Collections.Generic.IList<global::Terra.StepBlock> stepBlocks,
            string? description,
            global::Terra.EnvironmentType? environment,
            double? poolLengthMeters,
            double? estimatedDurationSeconds,
            double? estimatedDistanceMeters,
            double? estimatedCalories,
            string? workoutId)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Sport = sport;
            this.Environment = environment;
            this.PoolLengthMeters = poolLengthMeters;
            this.StepBlocks = stepBlocks ?? throw new global::System.ArgumentNullException(nameof(stepBlocks));
            this.EstimatedDurationSeconds = estimatedDurationSeconds;
            this.EstimatedDistanceMeters = estimatedDistanceMeters;
            this.EstimatedCalories = estimatedCalories;
            this.WorkoutId = workoutId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkoutTemplate" /> class.
        /// </summary>
        public WorkoutTemplate()
        {
        }

    }
}