
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PlannedWorkoutMetadata
    {
        /// <summary>
        /// Estimated energy expenditure for the workout
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("estimated_energy_kj")]
        public double? EstimatedEnergyKj { get; set; }

        /// <summary>
        /// Estimated speed for the workout
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("estimated_speed_meters_per_second")]
        public double? EstimatedSpeedMetersPerSecond { get; set; }

        /// <summary>
        /// Estimated elevation gain for the workout
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("estimated_elevation_gain_meters")]
        public double? EstimatedElevationGainMeters { get; set; }

        /// <summary>
        /// Estimated Training Stress Score for the workout
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("estimated_tss")]
        public double? EstimatedTss { get; set; }

        /// <summary>
        /// Estimated calorie burn for the workout
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("estimated_calories")]
        public int? EstimatedCalories { get; set; }

        /// <summary>
        /// The creation datetime of the associated workout, in ISO8601 format with microsecond precision. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time<br/>
        /// Example: 2022-11-23T09:00:00.000000+02:00
        /// </summary>
        /// <example>2022-11-23T09:00:00.000000+02:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_date")]
        public global::System.DateTime? CreatedDate { get; set; }

        /// <summary>
        /// The planned start datetime, in ISO8601 format with microsecond precision. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time<br/>
        /// Example: 2022-11-24T09:00:00.000000+02:00
        /// </summary>
        /// <example>2022-11-24T09:00:00.000000+02:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("planned_date")]
        public global::System.DateTime? PlannedDate { get; set; }

        /// <summary>
        /// The name - either user-entered or given by the fitness data provider - of the associated workout plan
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.PlannedWorkoutMetadataTypeJsonConverter))]
        public global::Terra.PlannedWorkoutMetadataType? Type { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Estimated workout duration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("estimated_duration_seconds")]
        public int? EstimatedDurationSeconds { get; set; }

        /// <summary>
        /// Estimated pace for the workout
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("estimated_pace_minutes_per_kilometer")]
        public double? EstimatedPaceMinutesPerKilometer { get; set; }

        /// <summary>
        /// Name of the original source of the workout plan
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string? Provider { get; set; }

        /// <summary>
        /// Estimated training stress score for the workout (normalized power-based metric)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("estimated_tscore")]
        public double? EstimatedTscore { get; set; }

        /// <summary>
        /// Description of the workout
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Name of the workout plan
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Estimated distance for the workout
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("estimated_distance_meters")]
        public int? EstimatedDistanceMeters { get; set; }

        /// <summary>
        /// Estimated Intensity Factor for the workout
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("estimated_if")]
        public double? EstimatedIf { get; set; }

        /// <summary>
        /// Pool length of the pool used for the workout - only relevant for swimming activity types
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pool_length_meters")]
        public int? PoolLengthMeters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlannedWorkoutMetadata" /> class.
        /// </summary>
        /// <param name="estimatedEnergyKj">
        /// Estimated energy expenditure for the workout
        /// </param>
        /// <param name="estimatedSpeedMetersPerSecond">
        /// Estimated speed for the workout
        /// </param>
        /// <param name="estimatedElevationGainMeters">
        /// Estimated elevation gain for the workout
        /// </param>
        /// <param name="estimatedTss">
        /// Estimated Training Stress Score for the workout
        /// </param>
        /// <param name="estimatedCalories">
        /// Estimated calorie burn for the workout
        /// </param>
        /// <param name="createdDate">
        /// The creation datetime of the associated workout, in ISO8601 format with microsecond precision. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time<br/>
        /// Example: 2022-11-23T09:00:00.000000+02:00
        /// </param>
        /// <param name="plannedDate">
        /// The planned start datetime, in ISO8601 format with microsecond precision. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time<br/>
        /// Example: 2022-11-24T09:00:00.000000+02:00
        /// </param>
        /// <param name="type">
        /// The name - either user-entered or given by the fitness data provider - of the associated workout plan
        /// </param>
        /// <param name="id">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="estimatedDurationSeconds">
        /// Estimated workout duration
        /// </param>
        /// <param name="estimatedPaceMinutesPerKilometer">
        /// Estimated pace for the workout
        /// </param>
        /// <param name="provider">
        /// Name of the original source of the workout plan
        /// </param>
        /// <param name="estimatedTscore">
        /// Estimated training stress score for the workout (normalized power-based metric)
        /// </param>
        /// <param name="description">
        /// Description of the workout
        /// </param>
        /// <param name="name">
        /// Name of the workout plan
        /// </param>
        /// <param name="estimatedDistanceMeters">
        /// Estimated distance for the workout
        /// </param>
        /// <param name="estimatedIf">
        /// Estimated Intensity Factor for the workout
        /// </param>
        /// <param name="poolLengthMeters">
        /// Pool length of the pool used for the workout - only relevant for swimming activity types
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlannedWorkoutMetadata(
            double? estimatedEnergyKj,
            double? estimatedSpeedMetersPerSecond,
            double? estimatedElevationGainMeters,
            double? estimatedTss,
            int? estimatedCalories,
            global::System.DateTime? createdDate,
            global::System.DateTime? plannedDate,
            global::Terra.PlannedWorkoutMetadataType? type,
            string? id,
            int? estimatedDurationSeconds,
            double? estimatedPaceMinutesPerKilometer,
            string? provider,
            double? estimatedTscore,
            string? description,
            string? name,
            int? estimatedDistanceMeters,
            double? estimatedIf,
            int? poolLengthMeters)
        {
            this.EstimatedEnergyKj = estimatedEnergyKj;
            this.EstimatedSpeedMetersPerSecond = estimatedSpeedMetersPerSecond;
            this.EstimatedElevationGainMeters = estimatedElevationGainMeters;
            this.EstimatedTss = estimatedTss;
            this.EstimatedCalories = estimatedCalories;
            this.CreatedDate = createdDate;
            this.PlannedDate = plannedDate;
            this.Type = type;
            this.Id = id;
            this.EstimatedDurationSeconds = estimatedDurationSeconds;
            this.EstimatedPaceMinutesPerKilometer = estimatedPaceMinutesPerKilometer;
            this.Provider = provider;
            this.EstimatedTscore = estimatedTscore;
            this.Description = description;
            this.Name = name;
            this.EstimatedDistanceMeters = estimatedDistanceMeters;
            this.EstimatedIf = estimatedIf;
            this.PoolLengthMeters = poolLengthMeters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlannedWorkoutMetadata" /> class.
        /// </summary>
        public PlannedWorkoutMetadata()
        {
        }
    }
}